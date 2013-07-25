namespace CWlauncher
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Websites = new System.Windows.Forms.Button();
            this.Seed = new System.Windows.Forms.Button();
            this.Directory = new System.Windows.Forms.Button();
            this.Launch = new System.Windows.Forms.Button();
            this.LaunchServer = new System.Windows.Forms.Button();
            this.LaunchOfficial = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Websites
            // 
            this.Websites.Location = new System.Drawing.Point(12, 319);
            this.Websites.Name = "Websites";
            this.Websites.Size = new System.Drawing.Size(167, 79);
            this.Websites.TabIndex = 0;
            this.Websites.Text = "Cube World Sites";
            this.Websites.UseVisualStyleBackColor = true;
            this.Websites.Click += new System.EventHandler(this.Websites_Click);
            // 
            // Seed
            // 
            this.Seed.Location = new System.Drawing.Point(185, 319);
            this.Seed.Name = "Seed";
            this.Seed.Size = new System.Drawing.Size(167, 79);
            this.Seed.TabIndex = 0;
            this.Seed.Text = "Settings";
            this.Seed.UseVisualStyleBackColor = true;
            this.Seed.Click += new System.EventHandler(this.Seed_Click);
            // 
            // Directory
            // 
            this.Directory.Location = new System.Drawing.Point(358, 319);
            this.Directory.Name = "Directory";
            this.Directory.Size = new System.Drawing.Size(167, 79);
            this.Directory.TabIndex = 0;
            this.Directory.Text = "Open File directory";
            this.Directory.UseVisualStyleBackColor = true;
            this.Directory.Click += new System.EventHandler(this.Directory_Click);
            // 
            // Launch
            // 
            this.Launch.Location = new System.Drawing.Point(12, 234);
            this.Launch.Name = "Launch";
            this.Launch.Size = new System.Drawing.Size(167, 79);
            this.Launch.TabIndex = 0;
            this.Launch.Text = "Launch Game";
            this.Launch.UseVisualStyleBackColor = true;
            this.Launch.Click += new System.EventHandler(this.Launch_Click);
            // 
            // LaunchServer
            // 
            this.LaunchServer.Location = new System.Drawing.Point(185, 234);
            this.LaunchServer.Name = "LaunchServer";
            this.LaunchServer.Size = new System.Drawing.Size(167, 79);
            this.LaunchServer.TabIndex = 0;
            this.LaunchServer.Text = "Launch Server";
            this.LaunchServer.UseVisualStyleBackColor = true;
            this.LaunchServer.Click += new System.EventHandler(this.LaunchServer_Click);
            // 
            // LaunchOfficial
            // 
            this.LaunchOfficial.Location = new System.Drawing.Point(358, 234);
            this.LaunchOfficial.Name = "LaunchOfficial";
            this.LaunchOfficial.Size = new System.Drawing.Size(167, 79);
            this.LaunchOfficial.TabIndex = 0;
            this.LaunchOfficial.Text = "Official Launcher";
            this.LaunchOfficial.UseVisualStyleBackColor = true;
            this.LaunchOfficial.Click += new System.EventHandler(this.LaunchOfficial_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(344, 404);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(181, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Close launcher on game launch?";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CWlauncher.Properties.Resources.header;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(513, 216);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 420);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.LaunchOfficial);
            this.Controls.Add(this.LaunchServer);
            this.Controls.Add(this.Launch);
            this.Controls.Add(this.Directory);
            this.Controls.Add(this.Seed);
            this.Controls.Add(this.Websites);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cube World Launcher";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Websites;
        private System.Windows.Forms.Button Seed;
        private System.Windows.Forms.Button Directory;
        private System.Windows.Forms.Button Launch;
        private System.Windows.Forms.Button LaunchServer;
        private System.Windows.Forms.Button LaunchOfficial;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

