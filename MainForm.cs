using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AcordStandaloneInstaller
{
    public partial class MainForm : Form
    {
        static string appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        static string localAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        string lastGuiLang = "tr";
        public MainForm()
        {
            InitializeComponent();
            SetGuiLang("en");
        }

        private void officialDiscordLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://discord.gg/HQ57svW6as");
        }

        private void websiteLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://acord.app/");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            discordStableRadio.Enabled = Directory.Exists(Path.Combine(localAppData, "Discord"));
            discordPTBRadio.Enabled = Directory.Exists(Path.Combine(localAppData, "DiscordPTB"));
            discordCanaryRadio.Enabled = Directory.Exists(Path.Combine(localAppData, "DiscordCanary"));
            discordDevelopmentRadio.Enabled = Directory.Exists(Path.Combine(localAppData, "DiscordDevelopment"));

            if (!discordStableRadio.Enabled && !discordPTBRadio.Enabled && !discordCanaryRadio.Enabled && !discordDevelopmentRadio.Enabled)
            {
                MessageBox.Show(lastGuiLang == "en" ? "Unable find a valid version of Discord on your device. You can try installing Discord again." : "Bigisayarınızda geçerli bir Discord uygulaması bulunamadı. Yeniden Discord indirmeyi deneyebilirsiniz.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }
        }

        string GetSelectedDiscordRelease()
        {
            if (discordStableRadio.Checked) return "Discord";
            if (discordPTBRadio.Checked) return "DiscordPTB";
            if (discordCanaryRadio.Checked) return "DiscordCanary";
            if (discordDevelopmentRadio.Checked) return "DiscordDevelopment";
            return null;
        }

        void Install()
        {
            string discordRelease = GetSelectedDiscordRelease();

            if (discordRelease == null)
            {
                MessageBox.Show(lastGuiLang == "en" ? "Please select a valid version of Discord." : "Lütfen geçerli bir Discord versiyonu seçiniz.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            installButton.Text = lastGuiLang == "en" ? "Installing.." : "Yükleniyor..";
            uninstallButton.Enabled = false;
            installButton.Enabled = false;
            releaseGroupBox.Enabled = false;
            TopMost = true;


            Process[] processes = Process.GetProcessesByName(discordRelease.ToLower()).ToArray();

            string discordExePath = null;

            for (int i = 0; i < processes.Length; i++)
            {
                Process process = processes[i];

                try
                {
                    process.Kill();
                    if (discordExePath == null)
                    {
                        discordExePath = process.MainModule.FileName;
                        Thread.Sleep(100);
                    }
                }
                catch
                {

                }

            }

            string acordDataFolder = Path.Combine(appData, "Acord/data");
            Directory.CreateDirectory(acordDataFolder);

            string acordAsarPath = Path.Combine(acordDataFolder, "acord.asar");

            DownloadFile("https://api.acord.app/download/asar", acordAsarPath);

            File.WriteAllText(Path.Combine(appData, discordRelease.ToLower(), "settings.json"), @"{""openasar"":{""setup"":true},""DANGEROUS_ENABLE_DEVTOOLS_ONLY_ENABLE_IF_YOU_KNOW_WHAT_YOURE_DOING"":true}");

            string[] appPaths = Directory.GetDirectories(Path.Combine(localAppData, discordRelease)).Where(i => Path.GetFileName(i).StartsWith("app-")).ToArray();

            for (int i = 0; i < appPaths.Length; i++)
            {
                string discordAppPath = appPaths[i];

                string modulesPath = Path.Combine(discordAppPath, "modules");

                if (Directory.Exists(modulesPath))
                {
                    string[] desktopCoreModulePaths = Directory.GetDirectories(modulesPath).Where(k => Path.GetFileName(k).StartsWith("discord_desktop_core-")).ToArray();

                    for (int j = 0; j < desktopCoreModulePaths.Length; j++)
                    {
                        string modulePath = Path.Combine(desktopCoreModulePaths[j], "discord_desktop_core");

                        File.WriteAllText(Path.Combine(modulePath, "index.js"), $@"require(""{acordAsarPath.Replace("\\", "/")}"");module.exports = require(""./core.asar"");");
                        File.WriteAllText(Path.Combine(modulePath, "package.json"), "{\"name\":\"acord\",\"main\":\"index.js\",\"version\":\"0.0.0\"}");
                    }

                    Directory.CreateDirectory(Path.Combine(discordAppPath, "resources/app"));
                    DownloadFile("https://github.com/GooseMod/OpenAsar/releases/download/nightly/app.asar", Path.Combine(discordAppPath, "resources/app.asar"));
                }

            }

            if (discordExePath != null)
            {
                Thread.Sleep(100);
                Process.Start(discordExePath);
            }

            installButton.Text = lastGuiLang == "en" ? "Install" : "Yükle";
            uninstallButton.Enabled = true;
            installButton.Enabled = true;
            releaseGroupBox.Enabled = true;
            TopMost = false;

            DialogResult resp = MessageBox.Show(lastGuiLang == "en" ? "Installing process is done! Do you want to quit?" : "Acord'u indirme işlemi tamamlandı! Çıkmak ister misiniz?", this.Text, MessageBoxButtons.YesNo);
            if (resp == DialogResult.Yes) Close();
        }

        void Uninstall()
        {
            string discordRelease = GetSelectedDiscordRelease();

            if (discordRelease == null)
            {
                MessageBox.Show(lastGuiLang == "en" ? "Please select a valid version of Discord." : "Lütfen geçerli bir Discord versiyonu seçiniz.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            uninstallButton.Text = lastGuiLang == "en" ? "Uninstalling.." : "Siliniyor..";
            uninstallButton.Enabled = false;
            installButton.Enabled = false;
            releaseGroupBox.Enabled = false;
            TopMost = true;

            Process[] processes = Process.GetProcessesByName(discordRelease.ToLower()).ToArray();

            string discordExePath = null;

            for (int i = 0; i < processes.Length; i++)
            {
                Process process = processes[i];

                try
                {
                    process.Kill();
                    if (discordExePath == null)
                    {
                        discordExePath = process.MainModule.FileName;
                        Thread.Sleep(100);
                    }
                }
                catch
                {

                }

            }

            string[] appPaths = Directory.GetDirectories(Path.Combine(localAppData, discordRelease)).Where(i => Path.GetFileName(i).StartsWith("app-")).ToArray();

            for (int i = 0; i < appPaths.Length; i++)
            {
                string discordAppPath = appPaths[i];

                string modulesPath = Path.Combine(discordAppPath, "modules");

                if (Directory.Exists(modulesPath))
                {
                    string[] desktopCoreModulePaths = Directory.GetDirectories(modulesPath).Where(k => Path.GetFileName(k).StartsWith("discord_desktop_core-")).ToArray();

                    for (int j = 0; j < desktopCoreModulePaths.Length; j++)
                    {
                        string modulePath = Path.Combine(desktopCoreModulePaths[j], "discord_desktop_core");

                        File.WriteAllText(Path.Combine(modulePath, "index.js"), $@"module.exports = require(""./core.asar"");");
                        File.WriteAllText(Path.Combine(modulePath, "package.json"), "{\"name\":\"discord\",\"main\":\"index.js\",\"version\":\"0.0.0\"}");
                    }
                }

            }

            if (discordExePath != null)
            {
                Thread.Sleep(100);
                Process.Start(discordExePath);
            }

            uninstallButton.Text = lastGuiLang == "en" ? "Uninstall" : "Sil";
            uninstallButton.Enabled = true;
            installButton.Enabled = true;
            releaseGroupBox.Enabled = true;
            TopMost = false;

            DialogResult resp = MessageBox.Show(lastGuiLang == "en" ? "Uninstalling process is done. Do you want to quit?" : "Acord'u silme işlemi tamamlandı! Çıkmak ister misiniz?", this.Text, MessageBoxButtons.YesNo);
            if (resp == DialogResult.Yes) Close();
        }

        public void DownloadFile(string uri, string path)
        {
            using (var client = new WebClient())
            {
                client.DownloadFile(uri, path);
            }
        }

        private void installButton_Click(object sender, EventArgs e)
        {
            Install();
        }

        private void uninstallButton_Click(object sender, EventArgs e)
        {
            Uninstall();
        }

        private void SetGuiLang(string lang)
        {
            lastGuiLang = lang;
            switch (lang)
            {
                case "tr":
                    {
                        descLabel.Text = "Bu indirici her zaman Acord'un\nen güncel versiyonunu kurmaktadır.";
                        turkishRadio.Text = "Türkçe";
                        englishRadio.Text = "İngilizce";
                        uninstallButton.Text = "Sil";
                        installButton.Text = "Yükle";
                        discordVersionLabel.Text = "Discord Versiyonu";
                        langLabel.Text = "Yükleyici Dili";
                        this.Text = "Acord Yükleyici";
                        break;
                    }
                case "en":
                    {
                        descLabel.Text = "This downloader always installs\n the latest version of Acord.";
                        turkishRadio.Text = "Turkish";
                        englishRadio.Text = "English";
                        uninstallButton.Text = "Uninstall";
                        installButton.Text = "Install";
                        discordVersionLabel.Text = "Discord Version";
                        langLabel.Text = "Installer Language";
                        this.Text = "Acord Installer";
                        break;
                    }
            }
        }

        private void englishRadio_CheckedChanged(object sender, EventArgs e)
        {
            SetGuiLang("en");
        }

        private void turkishRadio_CheckedChanged(object sender, EventArgs e)
        {
            SetGuiLang("tr");
        }
    }
}
