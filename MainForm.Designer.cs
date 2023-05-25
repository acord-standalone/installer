namespace AcordStandaloneInstaller
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.discordStableRadio = new System.Windows.Forms.RadioButton();
            this.releaseGroupBox = new System.Windows.Forms.GroupBox();
            this.discordDevelopmentRadio = new System.Windows.Forms.RadioButton();
            this.discordCanaryRadio = new System.Windows.Forms.RadioButton();
            this.discordPTBRadio = new System.Windows.Forms.RadioButton();
            this.installButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.officialDiscordLink = new System.Windows.Forms.LinkLabel();
            this.websiteLink = new System.Windows.Forms.LinkLabel();
            this.uninstallButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.releaseGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // discordStableRadio
            // 
            this.discordStableRadio.AutoSize = true;
            this.discordStableRadio.Location = new System.Drawing.Point(6, 19);
            this.discordStableRadio.Name = "discordStableRadio";
            this.discordStableRadio.Size = new System.Drawing.Size(61, 17);
            this.discordStableRadio.TabIndex = 0;
            this.discordStableRadio.TabStop = true;
            this.discordStableRadio.Text = "Discord";
            this.discordStableRadio.UseVisualStyleBackColor = true;
            // 
            // releaseGroupBox
            // 
            this.releaseGroupBox.Controls.Add(this.label2);
            this.releaseGroupBox.Controls.Add(this.discordDevelopmentRadio);
            this.releaseGroupBox.Controls.Add(this.discordCanaryRadio);
            this.releaseGroupBox.Controls.Add(this.discordPTBRadio);
            this.releaseGroupBox.Controls.Add(this.discordStableRadio);
            this.releaseGroupBox.Location = new System.Drawing.Point(12, 12);
            this.releaseGroupBox.Name = "releaseGroupBox";
            this.releaseGroupBox.Size = new System.Drawing.Size(134, 112);
            this.releaseGroupBox.TabIndex = 1;
            this.releaseGroupBox.TabStop = false;
            // 
            // discordDevelopmentRadio
            // 
            this.discordDevelopmentRadio.AutoSize = true;
            this.discordDevelopmentRadio.Location = new System.Drawing.Point(6, 88);
            this.discordDevelopmentRadio.Name = "discordDevelopmentRadio";
            this.discordDevelopmentRadio.Size = new System.Drawing.Size(127, 17);
            this.discordDevelopmentRadio.TabIndex = 3;
            this.discordDevelopmentRadio.TabStop = true;
            this.discordDevelopmentRadio.Text = "Discord Development";
            this.discordDevelopmentRadio.UseVisualStyleBackColor = true;
            // 
            // discordCanaryRadio
            // 
            this.discordCanaryRadio.AutoSize = true;
            this.discordCanaryRadio.Location = new System.Drawing.Point(6, 65);
            this.discordCanaryRadio.Name = "discordCanaryRadio";
            this.discordCanaryRadio.Size = new System.Drawing.Size(97, 17);
            this.discordCanaryRadio.TabIndex = 2;
            this.discordCanaryRadio.TabStop = true;
            this.discordCanaryRadio.Text = "Discord Canary";
            this.discordCanaryRadio.UseVisualStyleBackColor = true;
            // 
            // discordPTBRadio
            // 
            this.discordPTBRadio.AutoSize = true;
            this.discordPTBRadio.Location = new System.Drawing.Point(6, 42);
            this.discordPTBRadio.Name = "discordPTBRadio";
            this.discordPTBRadio.Size = new System.Drawing.Size(85, 17);
            this.discordPTBRadio.TabIndex = 1;
            this.discordPTBRadio.TabStop = true;
            this.discordPTBRadio.Text = "Discord PTB";
            this.discordPTBRadio.UseVisualStyleBackColor = true;
            // 
            // installButton
            // 
            this.installButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(12)))), ((int)(((byte)(71)))));
            this.installButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.installButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.installButton.ForeColor = System.Drawing.Color.White;
            this.installButton.Location = new System.Drawing.Point(155, 100);
            this.installButton.Name = "installButton";
            this.installButton.Size = new System.Drawing.Size(181, 23);
            this.installButton.TabIndex = 2;
            this.installButton.Text = "Yükle / Güncelle";
            this.installButton.UseVisualStyleBackColor = false;
            this.installButton.Click += new System.EventHandler(this.installButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bu indirici her zaman Acord\'un\r\nen güncel versiyonunu kurmaktadır.";
            // 
            // officialDiscordLink
            // 
            this.officialDiscordLink.AutoSize = true;
            this.officialDiscordLink.ForeColor = System.Drawing.Color.White;
            this.officialDiscordLink.LinkColor = System.Drawing.Color.Black;
            this.officialDiscordLink.Location = new System.Drawing.Point(261, 54);
            this.officialDiscordLink.Name = "officialDiscordLink";
            this.officialDiscordLink.Size = new System.Drawing.Size(75, 13);
            this.officialDiscordLink.TabIndex = 4;
            this.officialDiscordLink.TabStop = true;
            this.officialDiscordLink.Text = "Resmi Discord";
            this.officialDiscordLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.officialDiscordLink_LinkClicked);
            // 
            // websiteLink
            // 
            this.websiteLink.AutoSize = true;
            this.websiteLink.ForeColor = System.Drawing.Color.White;
            this.websiteLink.LinkColor = System.Drawing.Color.Black;
            this.websiteLink.Location = new System.Drawing.Point(152, 54);
            this.websiteLink.Name = "websiteLink";
            this.websiteLink.Size = new System.Drawing.Size(53, 13);
            this.websiteLink.TabIndex = 5;
            this.websiteLink.TabStop = true;
            this.websiteLink.Text = "Websitesi";
            this.websiteLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.websiteLink_LinkClicked);
            // 
            // uninstallButton
            // 
            this.uninstallButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(12)))), ((int)(((byte)(71)))));
            this.uninstallButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.uninstallButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.uninstallButton.ForeColor = System.Drawing.Color.White;
            this.uninstallButton.Location = new System.Drawing.Point(155, 71);
            this.uninstallButton.Name = "uninstallButton";
            this.uninstallButton.Size = new System.Drawing.Size(181, 23);
            this.uninstallButton.TabIndex = 6;
            this.uninstallButton.Text = "Sil";
            this.uninstallButton.UseVisualStyleBackColor = false;
            this.uninstallButton.Click += new System.EventHandler(this.uninstallButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Discord Versiyonu";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(348, 137);
            this.Controls.Add(this.uninstallButton);
            this.Controls.Add(this.websiteLink);
            this.Controls.Add(this.officialDiscordLink);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.installButton);
            this.Controls.Add(this.releaseGroupBox);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acord Standalone Yükleyici";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.releaseGroupBox.ResumeLayout(false);
            this.releaseGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton discordStableRadio;
        private System.Windows.Forms.GroupBox releaseGroupBox;
        private System.Windows.Forms.RadioButton discordDevelopmentRadio;
        private System.Windows.Forms.RadioButton discordCanaryRadio;
        private System.Windows.Forms.RadioButton discordPTBRadio;
        private System.Windows.Forms.Button installButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel officialDiscordLink;
        private System.Windows.Forms.LinkLabel websiteLink;
        private System.Windows.Forms.Button uninstallButton;
        private System.Windows.Forms.Label label2;
    }
}

