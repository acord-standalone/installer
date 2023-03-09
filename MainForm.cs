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

        public MainForm()
        {
            InitializeComponent();
        }

        private void officialDiscordLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://discord.gg/rrtKWh48v9");
        }

        private void websiteLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://armagan.rest/");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            discordStableRadio.Enabled = Directory.Exists(Path.Combine(localAppData, "Discord"));
            discordPTBRadio.Enabled = Directory.Exists(Path.Combine(localAppData, "DiscordPTB"));
            discordCanaryRadio.Enabled = Directory.Exists(Path.Combine(localAppData, "DiscordCanary"));
            discordDevelopmentRadio.Enabled = Directory.Exists(Path.Combine(localAppData, "DiscordDevelopment"));
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

            installButton.Text = "Installing..";
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

            DownloadFile("https://github.com/acord-standalone/standalone/raw/main/dist/acord.asar", acordAsarPath);

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

            installButton.Text = "Install Acord";
            uninstallButton.Enabled = true;
            installButton.Enabled = true;
            releaseGroupBox.Enabled = true;
            TopMost = false;

            DialogResult resp = MessageBox.Show($"Installation done for {discordRelease}! Do you want to exit installer?", "Acord Standalone Installer", MessageBoxButtons.YesNo);
            if (resp == DialogResult.Yes) Close();
        }

        void Uninstall()
        {
            string discordRelease = GetSelectedDiscordRelease();

            uninstallButton.Text = "Uninstalling..";
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

            uninstallButton.Text = "Uninstall Acord";
            uninstallButton.Enabled = true;
            installButton.Enabled = true;
            releaseGroupBox.Enabled = true;
            TopMost = false;

            DialogResult resp = MessageBox.Show($"Uninstallation done for {discordRelease}! Do you want to exit installer?", "Acord Standalone Installer", MessageBoxButtons.YesNo);
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
    }
}
