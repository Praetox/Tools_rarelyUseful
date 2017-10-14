namespace thlmcepTools {
    partial class frmMain {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.lnk = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Move_srcC = new System.Windows.Forms.CheckBox();
            this.Move_GO = new System.Windows.Forms.Button();
            this.Move_flt = new System.Windows.Forms.TextBox();
            this.Move_dstB = new System.Windows.Forms.Button();
            this.Move_dst = new System.Windows.Forms.TextBox();
            this.Move_srcB = new System.Windows.Forms.Button();
            this.Move_src = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Treegen_flt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Treegen_GO = new System.Windows.Forms.Button();
            this.Treegen_dstB = new System.Windows.Forms.Button();
            this.Treegen_dst = new System.Windows.Forms.TextBox();
            this.Treegen_srcB = new System.Windows.Forms.Button();
            this.Treegen_src = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.szEnc_reMov = new System.Windows.Forms.CheckBox();
            this.szEnc_GO = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.szEnc_parm = new System.Windows.Forms.TextBox();
            this.szEnc_srcB = new System.Windows.Forms.Button();
            this.szEnc_src = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.extract_dbg = new System.Windows.Forms.CheckBox();
            this.extract_subf = new System.Windows.Forms.CheckBox();
            this.extract_GO = new System.Windows.Forms.Button();
            this.extract_srcB = new System.Windows.Forms.Button();
            this.extract_src = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.adv = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.szDec_parm = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.upgrade_scr = new System.Windows.Forms.ComboBox();
            this.upgrade_GO = new System.Windows.Forms.Button();
            this.upgrade_srcB = new System.Windows.Forms.Button();
            this.upgrade_src = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.Polydir_GO = new System.Windows.Forms.Button();
            this.Polydir_flt = new System.Windows.Forms.TextBox();
            this.Polydir_srcB = new System.Windows.Forms.Button();
            this.Polydir_src = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "\"Touhou Lossy Music Collection Encoding Project\" Toolkit v1.0";
            // 
            // lnk
            // 
            this.lnk.AutoSize = true;
            this.lnk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnk.Location = new System.Drawing.Point(367, 9);
            this.lnk.Name = "lnk";
            this.lnk.Size = new System.Drawing.Size(101, 13);
            this.lnk.TabIndex = 1;
            this.lnk.Text = "http://praetox.com/";
            this.lnk.Click += new System.EventHandler(this.lnk_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Move_srcC);
            this.groupBox1.Controls.Add(this.Move_GO);
            this.groupBox1.Controls.Add(this.Move_flt);
            this.groupBox1.Controls.Add(this.Move_dstB);
            this.groupBox1.Controls.Add(this.Move_dst);
            this.groupBox1.Controls.Add(this.Move_srcB);
            this.groupBox1.Controls.Add(this.Move_src);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 331);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(456, 106);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File mover";
            // 
            // Move_srcC
            // 
            this.Move_srcC.AutoSize = true;
            this.Move_srcC.Location = new System.Drawing.Point(53, 24);
            this.Move_srcC.Name = "Move_srcC";
            this.Move_srcC.Size = new System.Drawing.Size(15, 14);
            this.Move_srcC.TabIndex = 10;
            this.Move_srcC.UseVisualStyleBackColor = true;
            // 
            // Move_GO
            // 
            this.Move_GO.Location = new System.Drawing.Point(375, 77);
            this.Move_GO.Name = "Move_GO";
            this.Move_GO.Size = new System.Drawing.Size(75, 23);
            this.Move_GO.TabIndex = 8;
            this.Move_GO.Text = "MOVE";
            this.Move_GO.UseVisualStyleBackColor = true;
            this.Move_GO.Click += new System.EventHandler(this.Move_GO_Click);
            // 
            // Move_flt
            // 
            this.Move_flt.Location = new System.Drawing.Point(53, 79);
            this.Move_flt.Name = "Move_flt";
            this.Move_flt.Size = new System.Drawing.Size(316, 20);
            this.Move_flt.TabIndex = 7;
            this.Move_flt.Text = "*.tta; *.cue";
            // 
            // Move_dstB
            // 
            this.Move_dstB.Location = new System.Drawing.Point(375, 48);
            this.Move_dstB.Name = "Move_dstB";
            this.Move_dstB.Size = new System.Drawing.Size(75, 23);
            this.Move_dstB.TabIndex = 6;
            this.Move_dstB.Text = "Browse";
            this.Move_dstB.UseVisualStyleBackColor = true;
            this.Move_dstB.Click += new System.EventHandler(this.Move_dstB_Click);
            // 
            // Move_dst
            // 
            this.Move_dst.Location = new System.Drawing.Point(53, 50);
            this.Move_dst.Name = "Move_dst";
            this.Move_dst.Size = new System.Drawing.Size(316, 20);
            this.Move_dst.TabIndex = 5;
            // 
            // Move_srcB
            // 
            this.Move_srcB.Location = new System.Drawing.Point(375, 19);
            this.Move_srcB.Name = "Move_srcB";
            this.Move_srcB.Size = new System.Drawing.Size(75, 23);
            this.Move_srcB.TabIndex = 4;
            this.Move_srcB.Text = "Browse";
            this.Move_srcB.UseVisualStyleBackColor = true;
            this.Move_srcB.Click += new System.EventHandler(this.Move_srcB_Click);
            // 
            // Move_src
            // 
            this.Move_src.Location = new System.Drawing.Point(74, 21);
            this.Move_src.Name = "Move_src";
            this.Move_src.Size = new System.Drawing.Size(295, 20);
            this.Move_src.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Filter";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Target";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Source";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Treegen_flt);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.Treegen_GO);
            this.groupBox2.Controls.Add(this.Treegen_dstB);
            this.groupBox2.Controls.Add(this.Treegen_dst);
            this.groupBox2.Controls.Add(this.Treegen_srcB);
            this.groupBox2.Controls.Add(this.Treegen_src);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(12, 452);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(456, 106);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "End-node directory tree creator";
            // 
            // Treegen_flt
            // 
            this.Treegen_flt.Location = new System.Drawing.Point(53, 79);
            this.Treegen_flt.Name = "Treegen_flt";
            this.Treegen_flt.Size = new System.Drawing.Size(316, 20);
            this.Treegen_flt.TabIndex = 10;
            this.Treegen_flt.Text = "*.mp3";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Filter";
            // 
            // Treegen_GO
            // 
            this.Treegen_GO.Location = new System.Drawing.Point(375, 77);
            this.Treegen_GO.Name = "Treegen_GO";
            this.Treegen_GO.Size = new System.Drawing.Size(75, 23);
            this.Treegen_GO.TabIndex = 8;
            this.Treegen_GO.Text = "INDEX";
            this.Treegen_GO.UseVisualStyleBackColor = true;
            this.Treegen_GO.Click += new System.EventHandler(this.Treegen_GO_Click);
            // 
            // Treegen_dstB
            // 
            this.Treegen_dstB.Enabled = false;
            this.Treegen_dstB.Location = new System.Drawing.Point(375, 48);
            this.Treegen_dstB.Name = "Treegen_dstB";
            this.Treegen_dstB.Size = new System.Drawing.Size(75, 23);
            this.Treegen_dstB.TabIndex = 6;
            this.Treegen_dstB.Text = "Browse";
            this.Treegen_dstB.UseVisualStyleBackColor = true;
            // 
            // Treegen_dst
            // 
            this.Treegen_dst.Location = new System.Drawing.Point(53, 50);
            this.Treegen_dst.Name = "Treegen_dst";
            this.Treegen_dst.Size = new System.Drawing.Size(316, 20);
            this.Treegen_dst.TabIndex = 5;
            this.Treegen_dst.Text = "tree.dc3";
            // 
            // Treegen_srcB
            // 
            this.Treegen_srcB.Location = new System.Drawing.Point(375, 19);
            this.Treegen_srcB.Name = "Treegen_srcB";
            this.Treegen_srcB.Size = new System.Drawing.Size(75, 23);
            this.Treegen_srcB.TabIndex = 4;
            this.Treegen_srcB.Text = "Browse";
            this.Treegen_srcB.UseVisualStyleBackColor = true;
            this.Treegen_srcB.Click += new System.EventHandler(this.Treegen_srcB_Click);
            // 
            // Treegen_src
            // 
            this.Treegen_src.Location = new System.Drawing.Point(53, 21);
            this.Treegen_src.Name = "Treegen_src";
            this.Treegen_src.Size = new System.Drawing.Size(316, 20);
            this.Treegen_src.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Target";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Source";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.szEnc_reMov);
            this.groupBox3.Controls.Add(this.szEnc_GO);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.szEnc_parm);
            this.groupBox3.Controls.Add(this.szEnc_srcB);
            this.groupBox3.Controls.Add(this.szEnc_src);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(12, 573);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(456, 106);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "7z archiver";
            // 
            // szEnc_reMov
            // 
            this.szEnc_reMov.AutoSize = true;
            this.szEnc_reMov.Checked = true;
            this.szEnc_reMov.CheckState = System.Windows.Forms.CheckState.Checked;
            this.szEnc_reMov.Location = new System.Drawing.Point(53, 81);
            this.szEnc_reMov.Name = "szEnc_reMov";
            this.szEnc_reMov.Size = new System.Drawing.Size(197, 17);
            this.szEnc_reMov.TabIndex = 9;
            this.szEnc_reMov.Text = "Rename \"loldongs.zip\" to ../dirname";
            this.szEnc_reMov.UseVisualStyleBackColor = true;
            // 
            // szEnc_GO
            // 
            this.szEnc_GO.Location = new System.Drawing.Point(375, 77);
            this.szEnc_GO.Name = "szEnc_GO";
            this.szEnc_GO.Size = new System.Drawing.Size(75, 23);
            this.szEnc_GO.TabIndex = 8;
            this.szEnc_GO.Text = "MAKE";
            this.szEnc_GO.UseVisualStyleBackColor = true;
            this.szEnc_GO.Click += new System.EventHandler(this.szEnc_GO_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(375, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Browse";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // szEnc_parm
            // 
            this.szEnc_parm.Location = new System.Drawing.Point(53, 50);
            this.szEnc_parm.Name = "szEnc_parm";
            this.szEnc_parm.Size = new System.Drawing.Size(316, 20);
            this.szEnc_parm.TabIndex = 5;
            this.szEnc_parm.Text = "%temp%\\7z.exe a -scsUTF-8 -tzip -mx1 loldongs *.mp3";
            // 
            // szEnc_srcB
            // 
            this.szEnc_srcB.Location = new System.Drawing.Point(375, 19);
            this.szEnc_srcB.Name = "szEnc_srcB";
            this.szEnc_srcB.Size = new System.Drawing.Size(75, 23);
            this.szEnc_srcB.TabIndex = 4;
            this.szEnc_srcB.Text = "Browse";
            this.szEnc_srcB.UseVisualStyleBackColor = true;
            this.szEnc_srcB.Click += new System.EventHandler(this.szEnc_srcB_Click);
            // 
            // szEnc_src
            // 
            this.szEnc_src.Location = new System.Drawing.Point(53, 21);
            this.szEnc_src.Name = "szEnc_src";
            this.szEnc_src.Size = new System.Drawing.Size(316, 20);
            this.szEnc_src.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Action";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Source";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.extract_dbg);
            this.groupBox4.Controls.Add(this.extract_subf);
            this.groupBox4.Controls.Add(this.extract_GO);
            this.groupBox4.Controls.Add(this.extract_srcB);
            this.groupBox4.Controls.Add(this.extract_src);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Location = new System.Drawing.Point(12, 126);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(456, 77);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Extract music from zip";
            // 
            // extract_dbg
            // 
            this.extract_dbg.AutoSize = true;
            this.extract_dbg.Location = new System.Drawing.Point(9, 53);
            this.extract_dbg.Name = "extract_dbg";
            this.extract_dbg.Size = new System.Drawing.Size(15, 14);
            this.extract_dbg.TabIndex = 7;
            this.extract_dbg.UseVisualStyleBackColor = true;
            // 
            // extract_subf
            // 
            this.extract_subf.AutoSize = true;
            this.extract_subf.Checked = true;
            this.extract_subf.CheckState = System.Windows.Forms.CheckState.Checked;
            this.extract_subf.Location = new System.Drawing.Point(53, 52);
            this.extract_subf.Name = "extract_subf";
            this.extract_subf.Size = new System.Drawing.Size(191, 17);
            this.extract_subf.TabIndex = 9;
            this.extract_subf.Text = "Create subfolder for zipfile contents";
            this.extract_subf.UseVisualStyleBackColor = true;
            // 
            // extract_GO
            // 
            this.extract_GO.Location = new System.Drawing.Point(375, 48);
            this.extract_GO.Name = "extract_GO";
            this.extract_GO.Size = new System.Drawing.Size(75, 23);
            this.extract_GO.TabIndex = 8;
            this.extract_GO.Text = "EXTRACT";
            this.extract_GO.UseVisualStyleBackColor = true;
            this.extract_GO.Click += new System.EventHandler(this.extract_GO_Click);
            // 
            // extract_srcB
            // 
            this.extract_srcB.Location = new System.Drawing.Point(375, 19);
            this.extract_srcB.Name = "extract_srcB";
            this.extract_srcB.Size = new System.Drawing.Size(75, 23);
            this.extract_srcB.TabIndex = 4;
            this.extract_srcB.Text = "Browse";
            this.extract_srcB.UseVisualStyleBackColor = true;
            this.extract_srcB.Click += new System.EventHandler(this.extract_srcB_Click);
            // 
            // extract_src
            // 
            this.extract_src.Location = new System.Drawing.Point(53, 21);
            this.extract_src.Name = "extract_src";
            this.extract_src.Size = new System.Drawing.Size(316, 20);
            this.extract_src.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Source";
            // 
            // adv
            // 
            this.adv.AutoSize = true;
            this.adv.Location = new System.Drawing.Point(412, 214);
            this.adv.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.adv.Name = "adv";
            this.adv.Size = new System.Drawing.Size(56, 13);
            this.adv.TabIndex = 6;
            this.adv.Text = "Advanced";
            this.adv.MouseDown += new System.Windows.Forms.MouseEventHandler(this.adv_MouseDown);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.szDec_parm);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Location = new System.Drawing.Point(12, 694);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(456, 48);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Extraction parameters";
            // 
            // szDec_parm
            // 
            this.szDec_parm.Location = new System.Drawing.Point(53, 21);
            this.szDec_parm.Name = "szDec_parm";
            this.szDec_parm.Size = new System.Drawing.Size(397, 20);
            this.szDec_parm.TabIndex = 3;
            this.szDec_parm.Text = "%temp%\\7z.exe e tmp_rena.zip";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "cmd";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Controls.Add(this.upgrade_scr);
            this.groupBox6.Controls.Add(this.upgrade_GO);
            this.groupBox6.Controls.Add(this.upgrade_srcB);
            this.groupBox6.Controls.Add(this.upgrade_src);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Location = new System.Drawing.Point(12, 34);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(456, 77);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Upgrade from prev. torrent";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 53);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "Script";
            // 
            // upgrade_scr
            // 
            this.upgrade_scr.FormattingEnabled = true;
            this.upgrade_scr.Location = new System.Drawing.Point(53, 50);
            this.upgrade_scr.Name = "upgrade_scr";
            this.upgrade_scr.Size = new System.Drawing.Size(316, 21);
            this.upgrade_scr.TabIndex = 9;
            // 
            // upgrade_GO
            // 
            this.upgrade_GO.Location = new System.Drawing.Point(375, 48);
            this.upgrade_GO.Name = "upgrade_GO";
            this.upgrade_GO.Size = new System.Drawing.Size(75, 23);
            this.upgrade_GO.TabIndex = 8;
            this.upgrade_GO.Text = "UPGRADE";
            this.upgrade_GO.UseVisualStyleBackColor = true;
            this.upgrade_GO.Click += new System.EventHandler(this.upgrade_GO_Click);
            // 
            // upgrade_srcB
            // 
            this.upgrade_srcB.Location = new System.Drawing.Point(375, 19);
            this.upgrade_srcB.Name = "upgrade_srcB";
            this.upgrade_srcB.Size = new System.Drawing.Size(75, 23);
            this.upgrade_srcB.TabIndex = 4;
            this.upgrade_srcB.Text = "Browse";
            this.upgrade_srcB.UseVisualStyleBackColor = true;
            this.upgrade_srcB.Click += new System.EventHandler(this.upgrade_srcB_Click);
            // 
            // upgrade_src
            // 
            this.upgrade_src.Location = new System.Drawing.Point(53, 21);
            this.upgrade_src.Name = "upgrade_src";
            this.upgrade_src.Size = new System.Drawing.Size(316, 20);
            this.upgrade_src.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Zipfiles";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.Polydir_GO);
            this.groupBox7.Controls.Add(this.Polydir_flt);
            this.groupBox7.Controls.Add(this.Polydir_srcB);
            this.groupBox7.Controls.Add(this.Polydir_src);
            this.groupBox7.Controls.Add(this.label15);
            this.groupBox7.Controls.Add(this.label17);
            this.groupBox7.Location = new System.Drawing.Point(12, 239);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(456, 77);
            this.groupBox7.TabIndex = 9;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Find multifile directories";
            // 
            // Polydir_GO
            // 
            this.Polydir_GO.Location = new System.Drawing.Point(375, 48);
            this.Polydir_GO.Name = "Polydir_GO";
            this.Polydir_GO.Size = new System.Drawing.Size(75, 23);
            this.Polydir_GO.TabIndex = 8;
            this.Polydir_GO.Text = "SEARCH";
            this.Polydir_GO.UseVisualStyleBackColor = true;
            this.Polydir_GO.Click += new System.EventHandler(this.Polydir_GO_Click);
            // 
            // Polydir_flt
            // 
            this.Polydir_flt.Location = new System.Drawing.Point(53, 50);
            this.Polydir_flt.Name = "Polydir_flt";
            this.Polydir_flt.Size = new System.Drawing.Size(316, 20);
            this.Polydir_flt.TabIndex = 7;
            this.Polydir_flt.Text = "*.tta; *.cue";
            // 
            // Polydir_srcB
            // 
            this.Polydir_srcB.Location = new System.Drawing.Point(375, 19);
            this.Polydir_srcB.Name = "Polydir_srcB";
            this.Polydir_srcB.Size = new System.Drawing.Size(75, 23);
            this.Polydir_srcB.TabIndex = 4;
            this.Polydir_srcB.Text = "Browse";
            this.Polydir_srcB.UseVisualStyleBackColor = true;
            this.Polydir_srcB.Click += new System.EventHandler(this.Polydir_srcB_Click);
            // 
            // Polydir_src
            // 
            this.Polydir_src.Location = new System.Drawing.Point(53, 21);
            this.Polydir_src.Name = "Polydir_src";
            this.Polydir_src.Size = new System.Drawing.Size(316, 20);
            this.Polydir_src.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 53);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 13);
            this.label15.TabIndex = 2;
            this.label15.Text = "Filter";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 24);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "Source";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 206);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 13);
            this.label14.TabIndex = 10;
            this.label14.Text = "486; 254";
            this.label14.Visible = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 229);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.adv);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lnk);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "thlmcepToolkit";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lnk;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Move_srcB;
        private System.Windows.Forms.TextBox Move_src;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Move_GO;
        private System.Windows.Forms.TextBox Move_flt;
        private System.Windows.Forms.Button Move_dstB;
        private System.Windows.Forms.TextBox Move_dst;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Treegen_GO;
        private System.Windows.Forms.Button Treegen_dstB;
        private System.Windows.Forms.TextBox Treegen_dst;
        private System.Windows.Forms.Button Treegen_srcB;
        private System.Windows.Forms.TextBox Treegen_src;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox szEnc_reMov;
        private System.Windows.Forms.Button szEnc_GO;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox szEnc_parm;
        private System.Windows.Forms.Button szEnc_srcB;
        private System.Windows.Forms.TextBox szEnc_src;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Treegen_flt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox extract_subf;
        private System.Windows.Forms.Button extract_GO;
        private System.Windows.Forms.Button extract_srcB;
        private System.Windows.Forms.TextBox extract_src;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label adv;
        private System.Windows.Forms.CheckBox extract_dbg;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox szDec_parm;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button upgrade_GO;
        private System.Windows.Forms.Button upgrade_srcB;
        private System.Windows.Forms.TextBox upgrade_src;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button Polydir_GO;
        private System.Windows.Forms.TextBox Polydir_flt;
        private System.Windows.Forms.Button Polydir_srcB;
        private System.Windows.Forms.TextBox Polydir_src;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox upgrade_scr;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox Move_srcC;
    }
}

