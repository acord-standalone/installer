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
            this.discordVersionLabel = new System.Windows.Forms.Label();
            this.discordDevelopmentRadio = new System.Windows.Forms.RadioButton();
            this.discordCanaryRadio = new System.Windows.Forms.RadioButton();
            this.discordPTBRadio = new System.Windows.Forms.RadioButton();
            this.installButton = new System.Windows.Forms.Button();
            this.descLabel = new System.Windows.Forms.Label();
            this.uninstallButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.langLabel = new System.Windows.Forms.Label();
            this.turkishRadio = new System.Windows.Forms.RadioButton();
            this.englishRadio = new System.Windows.Forms.RadioButton();
            this.releaseGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.releaseGroupBox.Controls.Add(this.discordVersionLabel);
            this.releaseGroupBox.Controls.Add(this.discordDevelopmentRadio);
            this.releaseGroupBox.Controls.Add(this.discordCanaryRadio);
            this.releaseGroupBox.Controls.Add(this.discordPTBRadio);
            this.releaseGroupBox.Controls.Add(this.discordStableRadio);
            this.releaseGroupBox.Location = new System.Drawing.Point(12, 12);
            this.releaseGroupBox.Name = "releaseGroupBox";
            this.releaseGroupBox.Size = new System.Drawing.Size(134, 111);
            this.releaseGroupBox.TabIndex = 1;
            this.releaseGroupBox.TabStop = false;
            // 
            // discordVersionLabel
            // 
            this.discordVersionLabel.AutoSize = true;
            this.discordVersionLabel.Location = new System.Drawing.Point(6, 0);
            this.discordVersionLabel.Name = "discordVersionLabel";
            this.discordVersionLabel.Size = new System.Drawing.Size(92, 13);
            this.discordVersionLabel.TabIndex = 4;
            this.discordVersionLabel.Text = "Discord Versiyonu";
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
            this.installButton.Location = new System.Drawing.Point(109, 129);
            this.installButton.Name = "installButton";
            this.installButton.Size = new System.Drawing.Size(230, 23);
            this.installButton.TabIndex = 2;
            this.installButton.Text = "Yükle";
            this.installButton.UseVisualStyleBackColor = false;
            this.installButton.Click += new System.EventHandler(this.installButton_Click);
            // 
            // descLabel
            // 
            this.descLabel.AutoSize = true;
            this.descLabel.Location = new System.Drawing.Point(153, 82);
            this.descLabel.Name = "descLabel";
            this.descLabel.Size = new System.Drawing.Size(175, 26);
            this.descLabel.TabIndex = 3;
            this.descLabel.Text = "Bu indirici her zaman Acord\'un\r\nen güncel versiyonunu kurmaktadır.";
            // 
            // uninstallButton
            // 
            this.uninstallButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(12)))), ((int)(((byte)(71)))));
            this.uninstallButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.uninstallButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.uninstallButton.ForeColor = System.Drawing.Color.White;
            this.uninstallButton.Location = new System.Drawing.Point(12, 129);
            this.uninstallButton.Name = "uninstallButton";
            this.uninstallButton.Size = new System.Drawing.Size(91, 23);
            this.uninstallButton.TabIndex = 6;
            this.uninstallButton.Text = "Sil";
            this.uninstallButton.UseVisualStyleBackColor = false;
            this.uninstallButton.Click += new System.EventHandler(this.uninstallButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.langLabel);
            this.groupBox1.Controls.Add(this.turkishRadio);
            this.groupBox1.Controls.Add(this.englishRadio);
            this.groupBox1.Location = new System.Drawing.Point(155, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(181, 65);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // langLabel
            // 
            this.langLabel.AutoSize = true;
            this.langLabel.Location = new System.Drawing.Point(6, 0);
            this.langLabel.Name = "langLabel";
            this.langLabel.Size = new System.Drawing.Size(92, 13);
            this.langLabel.TabIndex = 4;
            this.langLabel.Text = "Discord Versiyonu";
            // 
            // turkishRadio
            // 
            this.turkishRadio.AutoSize = true;
            this.turkishRadio.Location = new System.Drawing.Point(6, 42);
            this.turkishRadio.Name = "turkishRadio";
            this.turkishRadio.Size = new System.Drawing.Size(60, 17);
            this.turkishRadio.TabIndex = 1;
            this.turkishRadio.Text = "Turkish";
            this.turkishRadio.UseVisualStyleBackColor = true;
            this.turkishRadio.CheckedChanged += new System.EventHandler(this.turkishRadio_CheckedChanged);
            // 
            // englishRadio
            // 
            this.englishRadio.AutoSize = true;
            this.englishRadio.Checked = true;
            this.englishRadio.Location = new System.Drawing.Point(6, 19);
            this.englishRadio.Name = "englishRadio";
            this.englishRadio.Size = new System.Drawing.Size(59, 17);
            this.englishRadio.TabIndex = 0;
            this.englishRadio.TabStop = true;
            this.englishRadio.Text = "English";
            this.englishRadio.UseVisualStyleBackColor = true;
            this.englishRadio.CheckedChanged += new System.EventHandler(this.englishRadio_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(348, 157);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.uninstallButton);
            this.Controls.Add(this.descLabel);
            this.Controls.Add(this.installButton);
            this.Controls.Add(this.releaseGroupBox);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acord Installer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.releaseGroupBox.ResumeLayout(false);
            this.releaseGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Label descLabel;
        private System.Windows.Forms.Button uninstallButton;
        private System.Windows.Forms.Label discordVersionLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label langLabel;
        private System.Windows.Forms.RadioButton turkishRadio;
        private System.Windows.Forms.RadioButton englishRadio;
    }
}

