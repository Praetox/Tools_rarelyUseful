namespace pYTEnc
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.Logo = new System.Windows.Forms.Label();
            this.cmdFileDestination = new System.Windows.Forms.Button();
            this.txtFileDestination = new System.Windows.Forms.TextBox();
            this.cmdFileSourceBrowse = new System.Windows.Forms.Button();
            this.txtFileSource = new System.Windows.Forms.TextBox();
            this.cmdEncStart = new System.Windows.Forms.Button();
            this.chkTwopass = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmdCalcBitrate = new System.Windows.Forms.Button();
            this.txtSeconds = new System.Windows.Forms.TextBox();
            this.txtMinutes = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.ddAspect = new System.Windows.Forms.ComboBox();
            this.ddHeight = new System.Windows.Forms.ComboBox();
            this.ddWidth = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cmdFileSourceLoad = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.cmdEncStop = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.ddAudioRate = new System.Windows.Forms.ComboBox();
            this.ddVideoRate = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.chkResize = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.ddResizeY = new System.Windows.Forms.ComboBox();
            this.ddResizeX = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.acmdAbout = new System.Windows.Forms.Button();
            this.lnkTox = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // Logo
            // 
            this.Logo.Cursor = System.Windows.Forms.Cursors.Default;
            this.Logo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logo.Location = new System.Drawing.Point(12, 9);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(760, 40);
            this.Logo.TabIndex = 0;
            this.Logo.Text = "Praetox YouTube Encoder";
            this.Logo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmdFileDestination
            // 
            this.cmdFileDestination.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.cmdFileDestination.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdFileDestination.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdFileDestination.Location = new System.Drawing.Point(308, 19);
            this.cmdFileDestination.Name = "cmdFileDestination";
            this.cmdFileDestination.Size = new System.Drawing.Size(52, 20);
            this.cmdFileDestination.TabIndex = 1;
            this.cmdFileDestination.TabStop = false;
            this.cmdFileDestination.Text = "Browse...";
            this.cmdFileDestination.UseVisualStyleBackColor = false;
            this.cmdFileDestination.Click += new System.EventHandler(this.cmdFileDestinationBrowse_Click);
            // 
            // txtFileDestination
            // 
            this.txtFileDestination.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFileDestination.ForeColor = System.Drawing.Color.White;
            this.txtFileDestination.Location = new System.Drawing.Point(6, 19);
            this.txtFileDestination.Name = "txtFileDestination";
            this.txtFileDestination.Size = new System.Drawing.Size(296, 20);
            this.txtFileDestination.TabIndex = 0;
            this.txtFileDestination.TabStop = false;
            // 
            // cmdFileSourceBrowse
            // 
            this.cmdFileSourceBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.cmdFileSourceBrowse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdFileSourceBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdFileSourceBrowse.Location = new System.Drawing.Point(308, 19);
            this.cmdFileSourceBrowse.Name = "cmdFileSourceBrowse";
            this.cmdFileSourceBrowse.Size = new System.Drawing.Size(52, 20);
            this.cmdFileSourceBrowse.TabIndex = 1;
            this.cmdFileSourceBrowse.TabStop = false;
            this.cmdFileSourceBrowse.Text = "Browse";
            this.cmdFileSourceBrowse.UseVisualStyleBackColor = false;
            this.cmdFileSourceBrowse.Click += new System.EventHandler(this.cmdFileSourceBrowse_Click);
            // 
            // txtFileSource
            // 
            this.txtFileSource.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFileSource.ForeColor = System.Drawing.Color.White;
            this.txtFileSource.Location = new System.Drawing.Point(7, 19);
            this.txtFileSource.Name = "txtFileSource";
            this.txtFileSource.Size = new System.Drawing.Size(295, 20);
            this.txtFileSource.TabIndex = 0;
            this.txtFileSource.TabStop = false;
            // 
            // cmdEncStart
            // 
            this.cmdEncStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(24)))));
            this.cmdEncStart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdEncStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdEncStart.Location = new System.Drawing.Point(186, 45);
            this.cmdEncStart.Name = "cmdEncStart";
            this.cmdEncStart.Size = new System.Drawing.Size(174, 20);
            this.cmdEncStart.TabIndex = 2;
            this.cmdEncStart.Text = "S T A R T";
            this.cmdEncStart.UseVisualStyleBackColor = false;
            this.cmdEncStart.Click += new System.EventHandler(this.cmdEncStart_Click);
            // 
            // chkTwopass
            // 
            this.chkTwopass.AutoSize = true;
            this.chkTwopass.Checked = true;
            this.chkTwopass.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTwopass.Location = new System.Drawing.Point(246, 35);
            this.chkTwopass.Name = "chkTwopass";
            this.chkTwopass.Size = new System.Drawing.Size(116, 17);
            this.chkTwopass.TabIndex = 2;
            this.chkTwopass.TabStop = false;
            this.chkTwopass.Text = "Twopass encoding";
            this.chkTwopass.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cmdCalcBitrate);
            this.groupBox1.Controls.Add(this.txtSeconds);
            this.groupBox1.Controls.Add(this.txtMinutes);
            this.groupBox1.ForeColor = System.Drawing.Color.LightBlue;
            this.groupBox1.Location = new System.Drawing.Point(12, 242);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 44);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Step 3. Verify media length";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(118, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Sec";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(6, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Min";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmdCalcBitrate
            // 
            this.cmdCalcBitrate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.cmdCalcBitrate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdCalcBitrate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdCalcBitrate.Location = new System.Drawing.Point(214, 19);
            this.cmdCalcBitrate.Name = "cmdCalcBitrate";
            this.cmdCalcBitrate.Size = new System.Drawing.Size(146, 20);
            this.cmdCalcBitrate.TabIndex = 2;
            this.cmdCalcBitrate.TabStop = false;
            this.cmdCalcBitrate.Text = "Re-calculate bitrate";
            this.cmdCalcBitrate.UseVisualStyleBackColor = false;
            this.cmdCalcBitrate.Click += new System.EventHandler(this.cmdCalcBitrate_Click);
            // 
            // txtSeconds
            // 
            this.txtSeconds.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSeconds.ForeColor = System.Drawing.Color.White;
            this.txtSeconds.Location = new System.Drawing.Point(82, 19);
            this.txtSeconds.Name = "txtSeconds";
            this.txtSeconds.Size = new System.Drawing.Size(30, 20);
            this.txtSeconds.TabIndex = 1;
            this.txtSeconds.TabStop = false;
            // 
            // txtMinutes
            // 
            this.txtMinutes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMinutes.ForeColor = System.Drawing.Color.White;
            this.txtMinutes.Location = new System.Drawing.Point(46, 19);
            this.txtMinutes.Name = "txtMinutes";
            this.txtMinutes.Size = new System.Drawing.Size(30, 20);
            this.txtMinutes.TabIndex = 0;
            this.txtMinutes.TabStop = false;
            this.txtMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.ddAspect);
            this.groupBox3.Controls.Add(this.ddHeight);
            this.groupBox3.Controls.Add(this.ddWidth);
            this.groupBox3.ForeColor = System.Drawing.Color.LightBlue;
            this.groupBox3.Location = new System.Drawing.Point(12, 161);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(366, 59);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Step 2. Verify resolution and aspect ratio";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(246, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Vertical res";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(126, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Horizontal res";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(6, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Aspect Ratio";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ddAspect
            // 
            this.ddAspect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ddAspect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ddAspect.ForeColor = System.Drawing.Color.White;
            this.ddAspect.FormattingEnabled = true;
            this.ddAspect.Items.AddRange(new object[] {
            "4:3",
            "16:9",
            "16:10"});
            this.ddAspect.Location = new System.Drawing.Point(6, 32);
            this.ddAspect.Name = "ddAspect";
            this.ddAspect.Size = new System.Drawing.Size(114, 21);
            this.ddAspect.TabIndex = 0;
            this.ddAspect.TabStop = false;
            this.ddAspect.SelectedIndexChanged += new System.EventHandler(this.ddAspect_SelectedIndexChanged);
            // 
            // ddHeight
            // 
            this.ddHeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ddHeight.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ddHeight.ForeColor = System.Drawing.Color.White;
            this.ddHeight.FormattingEnabled = true;
            this.ddHeight.Items.AddRange(new object[] {
            "144",
            "240",
            "264",
            "288",
            "360",
            "480",
            "540",
            "720",
            "768",
            "960"});
            this.ddHeight.Location = new System.Drawing.Point(246, 32);
            this.ddHeight.Name = "ddHeight";
            this.ddHeight.Size = new System.Drawing.Size(114, 21);
            this.ddHeight.TabIndex = 2;
            this.ddHeight.TabStop = false;
            // 
            // ddWidth
            // 
            this.ddWidth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ddWidth.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ddWidth.ForeColor = System.Drawing.Color.White;
            this.ddWidth.FormattingEnabled = true;
            this.ddWidth.Items.AddRange(new object[] {
            "192",
            "320",
            "352",
            "384",
            "480",
            "640",
            "720",
            "960",
            "1024",
            "1280"});
            this.ddWidth.Location = new System.Drawing.Point(126, 32);
            this.ddWidth.Name = "ddWidth";
            this.ddWidth.Size = new System.Drawing.Size(114, 21);
            this.ddWidth.TabIndex = 1;
            this.ddWidth.TabStop = false;
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(6, 68);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(354, 13);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Encoding not started yet";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cmdFileSourceLoad);
            this.groupBox5.Controls.Add(this.cmdFileSourceBrowse);
            this.groupBox5.Controls.Add(this.txtFileSource);
            this.groupBox5.ForeColor = System.Drawing.Color.LightBlue;
            this.groupBox5.Location = new System.Drawing.Point(12, 68);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(366, 71);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Step 1. Select file to encode";
            // 
            // cmdFileSourceLoad
            // 
            this.cmdFileSourceLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(24)))));
            this.cmdFileSourceLoad.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdFileSourceLoad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdFileSourceLoad.Location = new System.Drawing.Point(6, 45);
            this.cmdFileSourceLoad.Name = "cmdFileSourceLoad";
            this.cmdFileSourceLoad.Size = new System.Drawing.Size(354, 20);
            this.cmdFileSourceLoad.TabIndex = 2;
            this.cmdFileSourceLoad.Text = "L o a d    f i l e";
            this.cmdFileSourceLoad.UseVisualStyleBackColor = false;
            this.cmdFileSourceLoad.Click += new System.EventHandler(this.cmdFileSourceLoad_Click);
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(12, 142);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(16, 16);
            this.label14.TabIndex = 14;
            // 
            // cmdEncStop
            // 
            this.cmdEncStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.cmdEncStop.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdEncStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdEncStop.Location = new System.Drawing.Point(6, 45);
            this.cmdEncStop.Name = "cmdEncStop";
            this.cmdEncStop.Size = new System.Drawing.Size(174, 20);
            this.cmdEncStop.TabIndex = 3;
            this.cmdEncStop.Text = "S T O P";
            this.cmdEncStop.UseVisualStyleBackColor = false;
            this.cmdEncStop.Click += new System.EventHandler(this.cmdEncStop_Click);
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(12, 223);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 16);
            this.label10.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(12, 289);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 16);
            this.label11.TabIndex = 17;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.chkTwopass);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Controls.Add(this.ddAudioRate);
            this.groupBox6.Controls.Add(this.ddVideoRate);
            this.groupBox6.ForeColor = System.Drawing.Color.LightBlue;
            this.groupBox6.Location = new System.Drawing.Point(12, 308);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(366, 59);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Step 4. Verify resolution and aspect ratio";
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(246, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(114, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "Higher quality";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(126, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(114, 13);
            this.label15.TabIndex = 15;
            this.label15.Text = "Audio bitrate";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(6, 16);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(114, 13);
            this.label16.TabIndex = 14;
            this.label16.Text = "Video bitrate";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ddAudioRate
            // 
            this.ddAudioRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ddAudioRate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ddAudioRate.ForeColor = System.Drawing.Color.White;
            this.ddAudioRate.FormattingEnabled = true;
            this.ddAudioRate.Items.AddRange(new object[] {
            "32",
            "56",
            "64",
            "96",
            "128",
            "160",
            "192",
            "224",
            "320"});
            this.ddAudioRate.Location = new System.Drawing.Point(126, 32);
            this.ddAudioRate.Name = "ddAudioRate";
            this.ddAudioRate.Size = new System.Drawing.Size(114, 21);
            this.ddAudioRate.TabIndex = 1;
            this.ddAudioRate.TabStop = false;
            // 
            // ddVideoRate
            // 
            this.ddVideoRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ddVideoRate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ddVideoRate.ForeColor = System.Drawing.Color.White;
            this.ddVideoRate.FormattingEnabled = true;
            this.ddVideoRate.Items.AddRange(new object[] {
            "100",
            "175",
            "300",
            "500",
            "750",
            "1000",
            "1500",
            "2000",
            "4000",
            "8000"});
            this.ddVideoRate.Location = new System.Drawing.Point(6, 32);
            this.ddVideoRate.Name = "ddVideoRate";
            this.ddVideoRate.Size = new System.Drawing.Size(114, 21);
            this.ddVideoRate.TabIndex = 0;
            this.ddVideoRate.TabStop = false;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 370);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 16);
            this.label4.TabIndex = 19;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblStatus);
            this.groupBox2.Controls.Add(this.cmdEncStart);
            this.groupBox2.Controls.Add(this.cmdEncStop);
            this.groupBox2.Controls.Add(this.txtFileDestination);
            this.groupBox2.Controls.Add(this.cmdFileDestination);
            this.groupBox2.ForeColor = System.Drawing.Color.LightBlue;
            this.groupBox2.Location = new System.Drawing.Point(12, 389);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(366, 85);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Step 5. Encode!";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 16);
            this.label3.TabIndex = 21;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox7);
            this.groupBox4.ForeColor = System.Drawing.Color.LightBlue;
            this.groupBox4.Location = new System.Drawing.Point(406, 68);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(366, 406);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Advanced configuration";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.chkResize);
            this.groupBox7.Controls.Add(this.label6);
            this.groupBox7.Controls.Add(this.label17);
            this.groupBox7.Controls.Add(this.ddResizeY);
            this.groupBox7.Controls.Add(this.ddResizeX);
            this.groupBox7.ForeColor = System.Drawing.Color.LightBlue;
            this.groupBox7.Location = new System.Drawing.Point(60, 64);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(246, 82);
            this.groupBox7.TabIndex = 5;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Resize";
            // 
            // chkResize
            // 
            this.chkResize.AutoSize = true;
            this.chkResize.Location = new System.Drawing.Point(6, 19);
            this.chkResize.Name = "chkResize";
            this.chkResize.Size = new System.Drawing.Size(107, 17);
            this.chkResize.TabIndex = 0;
            this.chkResize.Text = "Resizing enabled";
            this.chkResize.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(126, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Vertical res";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(6, 66);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(114, 13);
            this.label17.TabIndex = 19;
            this.label17.Text = "Horizontal res";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ddResizeY
            // 
            this.ddResizeY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ddResizeY.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ddResizeY.ForeColor = System.Drawing.Color.White;
            this.ddResizeY.FormattingEnabled = true;
            this.ddResizeY.Items.AddRange(new object[] {
            "144",
            "240",
            "264",
            "288",
            "360",
            "480",
            "540",
            "720",
            "768",
            "960"});
            this.ddResizeY.Location = new System.Drawing.Point(126, 42);
            this.ddResizeY.Name = "ddResizeY";
            this.ddResizeY.Size = new System.Drawing.Size(114, 21);
            this.ddResizeY.TabIndex = 2;
            this.ddResizeY.TabStop = false;
            this.ddResizeY.SelectedIndexChanged += new System.EventHandler(this.ddResizeY_SelectedIndexChanged);
            // 
            // ddResizeX
            // 
            this.ddResizeX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ddResizeX.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ddResizeX.ForeColor = System.Drawing.Color.White;
            this.ddResizeX.FormattingEnabled = true;
            this.ddResizeX.Items.AddRange(new object[] {
            "192",
            "320",
            "352",
            "384",
            "480",
            "640",
            "720",
            "960",
            "1024",
            "1280"});
            this.ddResizeX.Location = new System.Drawing.Point(6, 42);
            this.ddResizeX.Name = "ddResizeX";
            this.ddResizeX.Size = new System.Drawing.Size(114, 21);
            this.ddResizeX.TabIndex = 1;
            this.ddResizeX.TabStop = false;
            this.ddResizeX.SelectedIndexChanged += new System.EventHandler(this.ddResizeX_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(384, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 16);
            this.label5.TabIndex = 22;
            // 
            // acmdAbout
            // 
            this.acmdAbout.ForeColor = System.Drawing.Color.Black;
            this.acmdAbout.Location = new System.Drawing.Point(704, 12);
            this.acmdAbout.Name = "acmdAbout";
            this.acmdAbout.Size = new System.Drawing.Size(68, 37);
            this.acmdAbout.TabIndex = 26;
            this.acmdAbout.Text = "About...";
            this.acmdAbout.UseVisualStyleBackColor = true;
            this.acmdAbout.Click += new System.EventHandler(this.acmdAbout_Click);
            // 
            // lnkTox
            // 
            this.lnkTox.AutoSize = true;
            this.lnkTox.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.lnkTox.Location = new System.Drawing.Point(12, 9);
            this.lnkTox.Name = "lnkTox";
            this.lnkTox.Size = new System.Drawing.Size(93, 13);
            this.lnkTox.TabIndex = 27;
            this.lnkTox.TabStop = true;
            this.lnkTox.Text = "www.Praetox.com";
            this.lnkTox.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(128)))));
            this.lnkTox.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkTox_LinkClicked);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(784, 486);
            this.Controls.Add(this.lnkTox);
            this.Controls.Add(this.acmdAbout);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Logo);
            this.ForeColor = System.Drawing.Color.LightBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "pYTEnc v";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Logo;
        private System.Windows.Forms.Button cmdFileDestination;
        private System.Windows.Forms.TextBox txtFileDestination;
        private System.Windows.Forms.Button cmdFileSourceBrowse;
        private System.Windows.Forms.TextBox txtFileSource;
        private System.Windows.Forms.Button cmdEncStart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMinutes;
        private System.Windows.Forms.TextBox txtSeconds;
        private System.Windows.Forms.Button cmdCalcBitrate;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox ddHeight;
        private System.Windows.Forms.ComboBox ddWidth;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chkTwopass;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox ddAspect;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button cmdEncStop;
        private System.Windows.Forms.Button cmdFileSourceLoad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox ddAudioRate;
        private System.Windows.Forms.ComboBox ddVideoRate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.CheckBox chkResize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox ddResizeY;
        private System.Windows.Forms.ComboBox ddResizeX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button acmdAbout;
        private System.Windows.Forms.LinkLabel lnkTox;
    }
}

