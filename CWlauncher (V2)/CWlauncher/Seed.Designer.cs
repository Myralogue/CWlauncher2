namespace CWlauncher
{
    partial class Settings
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbReso = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbFS = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.tbAA = new System.Windows.Forms.TrackBar();
            this.label9 = new System.Windows.Forms.Label();
            this.tbRD = new System.Windows.Forms.TrackBar();
            this.lblAA = new System.Windows.Forms.Label();
            this.lblRD = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tbSV = new System.Windows.Forms.TrackBar();
            this.label11 = new System.Windows.Forms.Label();
            this.lblSV = new System.Windows.Forms.Label();
            this.tbMV = new System.Windows.Forms.TrackBar();
            this.label13 = new System.Windows.Forms.Label();
            this.lblMV = new System.Windows.Forms.Label();
            this.tbCS = new System.Windows.Forms.TrackBar();
            this.label15 = new System.Windows.Forms.Label();
            this.lblCS = new System.Windows.Forms.Label();
            this.tbCSmooth = new System.Windows.Forms.TrackBar();
            this.label17 = new System.Windows.Forms.Label();
            this.lblCSmooth = new System.Windows.Forms.Label();
            this.tbFSP = new System.Windows.Forms.TrackBar();
            this.label19 = new System.Windows.Forms.Label();
            this.lblFPS = new System.Windows.Forms.Label();
            this.cbLanguage = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.cbInvertY = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbAA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCSmooth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFSP)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(359, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Seed:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(473, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Seed";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(364, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Change to:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(429, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(205, 20);
            this.textBox1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(363, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(271, 60);
            this.button1.TabIndex = 4;
            this.button1.Text = "Set Seed";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button2.Location = new System.Drawing.Point(438, 314);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 60);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cancel/Quit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(444, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "(keep empty to get a random seed)";
            // 
            // cbReso
            // 
            this.cbReso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbReso.FormattingEnabled = true;
            this.cbReso.Items.AddRange(new object[] {
            "1440 x 900",
            "1920 x 1080",
            "1680 x 1050",
            "1600 x 1024",
            "1600 x 900",
            "1280 x 960",
            "1280 x 720",
            "1024 x 768",
            "800 x 600"});
            this.cbReso.Location = new System.Drawing.Point(176, 43);
            this.cbReso.Name = "cbReso";
            this.cbReso.Size = new System.Drawing.Size(138, 21);
            this.cbReso.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(353, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 157);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seed";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.lblFPS);
            this.groupBox2.Controls.Add(this.lblCSmooth);
            this.groupBox2.Controls.Add(this.lblCS);
            this.groupBox2.Controls.Add(this.lblMV);
            this.groupBox2.Controls.Add(this.lblSV);
            this.groupBox2.Controls.Add(this.lblRD);
            this.groupBox2.Controls.Add(this.lblAA);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cbFS);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.tbFSP);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.tbCSmooth);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.tbCS);
            this.groupBox2.Controls.Add(this.Label7);
            this.groupBox2.Controls.Add(this.tbMV);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.cbInvertY);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cbLanguage);
            this.groupBox2.Controls.Add(this.tbSV);
            this.groupBox2.Controls.Add(this.cbReso);
            this.groupBox2.Controls.Add(this.tbRD);
            this.groupBox2.Controls.Add(this.tbAA);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(335, 368);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Settings";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Resolution:";
            // 
            // cbFS
            // 
            this.cbFS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFS.FormattingEnabled = true;
            this.cbFS.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cbFS.Location = new System.Drawing.Point(176, 19);
            this.cbFS.Name = "cbFS";
            this.cbFS.Size = new System.Drawing.Size(138, 21);
            this.cbFS.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "FullScreen:";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(6, 116);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(96, 20);
            this.Label7.TabIndex = 8;
            this.Label7.Text = "AntiAliasing:";
            // 
            // tbAA
            // 
            this.tbAA.Location = new System.Drawing.Point(176, 116);
            this.tbAA.Maximum = 2;
            this.tbAA.Name = "tbAA";
            this.tbAA.Size = new System.Drawing.Size(121, 45);
            this.tbAA.TabIndex = 9;
            this.tbAA.Scroll += new System.EventHandler(this.tbAA_Scroll);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "RenderDistance:";
            // 
            // tbRD
            // 
            this.tbRD.Location = new System.Drawing.Point(176, 141);
            this.tbRD.Maximum = 100;
            this.tbRD.Minimum = 25;
            this.tbRD.Name = "tbRD";
            this.tbRD.Size = new System.Drawing.Size(121, 45);
            this.tbRD.SmallChange = 5;
            this.tbRD.TabIndex = 9;
            this.tbRD.TickFrequency = 5;
            this.tbRD.Value = 25;
            this.tbRD.Scroll += new System.EventHandler(this.tbRD_Scroll);
            // 
            // lblAA
            // 
            this.lblAA.AutoSize = true;
            this.lblAA.Location = new System.Drawing.Point(294, 121);
            this.lblAA.Name = "lblAA";
            this.lblAA.Size = new System.Drawing.Size(0, 13);
            this.lblAA.TabIndex = 10;
            // 
            // lblRD
            // 
            this.lblRD.AutoSize = true;
            this.lblRD.Location = new System.Drawing.Point(294, 146);
            this.lblRD.Name = "lblRD";
            this.lblRD.Size = new System.Drawing.Size(0, 13);
            this.lblRD.TabIndex = 11;
            // 
            // tbSV
            // 
            this.tbSV.LargeChange = 10;
            this.tbSV.Location = new System.Drawing.Point(176, 166);
            this.tbSV.Maximum = 100;
            this.tbSV.Name = "tbSV";
            this.tbSV.Size = new System.Drawing.Size(121, 45);
            this.tbSV.SmallChange = 10;
            this.tbSV.TabIndex = 9;
            this.tbSV.TickFrequency = 10;
            this.tbSV.Scroll += new System.EventHandler(this.tbSV_Scroll);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 166);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 20);
            this.label11.TabIndex = 8;
            this.label11.Text = "SoundVolume:";
            // 
            // lblSV
            // 
            this.lblSV.AutoSize = true;
            this.lblSV.Location = new System.Drawing.Point(294, 171);
            this.lblSV.Name = "lblSV";
            this.lblSV.Size = new System.Drawing.Size(0, 13);
            this.lblSV.TabIndex = 11;
            // 
            // tbMV
            // 
            this.tbMV.LargeChange = 10;
            this.tbMV.Location = new System.Drawing.Point(176, 191);
            this.tbMV.Maximum = 100;
            this.tbMV.Name = "tbMV";
            this.tbMV.Size = new System.Drawing.Size(121, 45);
            this.tbMV.SmallChange = 10;
            this.tbMV.TabIndex = 9;
            this.tbMV.TickFrequency = 10;
            this.tbMV.Scroll += new System.EventHandler(this.tbMV_Scroll);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 191);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(108, 20);
            this.label13.TabIndex = 8;
            this.label13.Text = "MusicVolume:";
            // 
            // lblMV
            // 
            this.lblMV.AutoSize = true;
            this.lblMV.Location = new System.Drawing.Point(294, 196);
            this.lblMV.Name = "lblMV";
            this.lblMV.Size = new System.Drawing.Size(0, 13);
            this.lblMV.TabIndex = 11;
            // 
            // tbCS
            // 
            this.tbCS.Location = new System.Drawing.Point(176, 216);
            this.tbCS.Maximum = 100;
            this.tbCS.Minimum = 10;
            this.tbCS.Name = "tbCS";
            this.tbCS.Size = new System.Drawing.Size(121, 45);
            this.tbCS.SmallChange = 5;
            this.tbCS.TabIndex = 9;
            this.tbCS.TickFrequency = 5;
            this.tbCS.Value = 10;
            this.tbCS.Scroll += new System.EventHandler(this.tbCS_Scroll);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(6, 216);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(116, 20);
            this.label15.TabIndex = 8;
            this.label15.Text = "CameraSpeed:";
            // 
            // lblCS
            // 
            this.lblCS.AutoSize = true;
            this.lblCS.Location = new System.Drawing.Point(294, 221);
            this.lblCS.Name = "lblCS";
            this.lblCS.Size = new System.Drawing.Size(0, 13);
            this.lblCS.TabIndex = 11;
            // 
            // tbCSmooth
            // 
            this.tbCSmooth.Location = new System.Drawing.Point(176, 241);
            this.tbCSmooth.Maximum = 100;
            this.tbCSmooth.Name = "tbCSmooth";
            this.tbCSmooth.Size = new System.Drawing.Size(121, 45);
            this.tbCSmooth.SmallChange = 5;
            this.tbCSmooth.TabIndex = 9;
            this.tbCSmooth.TickFrequency = 5;
            this.tbCSmooth.Scroll += new System.EventHandler(this.tbCSmooth_Scroll);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(6, 241);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(159, 20);
            this.label17.TabIndex = 8;
            this.label17.Text = "CameraSmoothness:";
            // 
            // lblCSmooth
            // 
            this.lblCSmooth.AutoSize = true;
            this.lblCSmooth.Location = new System.Drawing.Point(294, 246);
            this.lblCSmooth.Name = "lblCSmooth";
            this.lblCSmooth.Size = new System.Drawing.Size(0, 13);
            this.lblCSmooth.TabIndex = 11;
            // 
            // tbFSP
            // 
            this.tbFSP.Location = new System.Drawing.Point(176, 266);
            this.tbFSP.Maximum = 7;
            this.tbFSP.Name = "tbFSP";
            this.tbFSP.Size = new System.Drawing.Size(121, 45);
            this.tbFSP.TabIndex = 9;
            this.tbFSP.Scroll += new System.EventHandler(this.tbFSP_Scroll);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(6, 266);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(73, 20);
            this.label19.TabIndex = 8;
            this.label19.Text = "MaxFPS:";
            // 
            // lblFPS
            // 
            this.lblFPS.AutoSize = true;
            this.lblFPS.Location = new System.Drawing.Point(294, 271);
            this.lblFPS.Name = "lblFPS";
            this.lblFPS.Size = new System.Drawing.Size(0, 13);
            this.lblFPS.TabIndex = 11;
            // 
            // cbLanguage
            // 
            this.cbLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLanguage.FormattingEnabled = true;
            this.cbLanguage.Items.AddRange(new object[] {
            "English"});
            this.cbLanguage.Location = new System.Drawing.Point(176, 66);
            this.cbLanguage.Name = "cbLanguage";
            this.cbLanguage.Size = new System.Drawing.Size(138, 21);
            this.cbLanguage.TabIndex = 7;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(6, 63);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(85, 20);
            this.label21.TabIndex = 8;
            this.label21.Text = "Language:";
            // 
            // cbInvertY
            // 
            this.cbInvertY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInvertY.FormattingEnabled = true;
            this.cbInvertY.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cbInvertY.Location = new System.Drawing.Point(176, 89);
            this.cbInvertY.Name = "cbInvertY";
            this.cbInvertY.Size = new System.Drawing.Size(138, 21);
            this.cbInvertY.TabIndex = 7;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(6, 86);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(64, 20);
            this.label22.TabIndex = 8;
            this.label22.Text = "InvertY:";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button3.Location = new System.Drawing.Point(6, 302);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(308, 60);
            this.button3.TabIndex = 12;
            this.button3.Text = "Save Changes";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(353, 175);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(295, 127);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 392);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Seed_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbAA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCSmooth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbReso;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbFS;
        private System.Windows.Forms.TrackBar tbAA;
        private System.Windows.Forms.Label Label7;
        private System.Windows.Forms.Label lblMV;
        private System.Windows.Forms.Label lblSV;
        private System.Windows.Forms.Label lblRD;
        private System.Windows.Forms.Label lblAA;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TrackBar tbMV;
        private System.Windows.Forms.TrackBar tbSV;
        private System.Windows.Forms.TrackBar tbRD;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblFPS;
        private System.Windows.Forms.Label lblCSmooth;
        private System.Windows.Forms.Label lblCS;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TrackBar tbFSP;
        private System.Windows.Forms.TrackBar tbCSmooth;
        private System.Windows.Forms.TrackBar tbCS;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox cbInvertY;
        private System.Windows.Forms.ComboBox cbLanguage;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}