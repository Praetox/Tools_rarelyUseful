namespace pListGen
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
            this.gbDate = new System.Windows.Forms.GroupBox();
            this.lbBase = new System.Windows.Forms.Label();
            this.YearM = new System.Windows.Forms.Button();
            this.MonM = new System.Windows.Forms.Button();
            this.DayM = new System.Windows.Forms.Button();
            this.YearP = new System.Windows.Forms.Button();
            this.MonP = new System.Windows.Forms.Button();
            this.DayP = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbCP = new System.Windows.Forms.GroupBox();
            this.cPrint = new System.Windows.Forms.Button();
            this.cGen = new System.Windows.Forms.Button();
            this.gbDays = new System.Windows.Forms.GroupBox();
            this.cDayAll = new System.Windows.Forms.Button();
            this.cDaySun = new System.Windows.Forms.Button();
            this.cDaySat = new System.Windows.Forms.Button();
            this.cDayMon = new System.Windows.Forms.Button();
            this.cDayThu = new System.Windows.Forms.Button();
            this.cDayWed = new System.Windows.Forms.Button();
            this.cDayTue = new System.Windows.Forms.Button();
            this.cDayFri = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.wb = new System.Windows.Forms.WebBrowser();
            this.gbTimes = new System.Windows.Forms.GroupBox();
            this.txTimes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbDaysPC = new System.Windows.Forms.GroupBox();
            this.txDaysPerCol = new System.Windows.Forms.TextBox();
            this.gbListsAhead = new System.Windows.Forms.GroupBox();
            this.txListsAhead = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbDate.SuspendLayout();
            this.gbCP.SuspendLayout();
            this.gbDays.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbTimes.SuspendLayout();
            this.gbDaysPC.SuspendLayout();
            this.gbListsAhead.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDate
            // 
            this.gbDate.Controls.Add(this.lbBase);
            this.gbDate.Controls.Add(this.YearM);
            this.gbDate.Controls.Add(this.MonM);
            this.gbDate.Controls.Add(this.DayM);
            this.gbDate.Controls.Add(this.YearP);
            this.gbDate.Controls.Add(this.MonP);
            this.gbDate.Controls.Add(this.DayP);
            this.gbDate.Location = new System.Drawing.Point(12, 12);
            this.gbDate.Name = "gbDate";
            this.gbDate.Size = new System.Drawing.Size(230, 102);
            this.gbDate.TabIndex = 0;
            this.gbDate.TabStop = false;
            this.gbDate.Text = "Lag liste fra og med";
            // 
            // lbBase
            // 
            this.lbBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBase.Location = new System.Drawing.Point(6, 74);
            this.lbBase.Name = "lbBase";
            this.lbBase.Size = new System.Drawing.Size(218, 25);
            this.lbBase.TabIndex = 9;
            this.lbBase.Text = "Torsdag 24. September 2008";
            this.lbBase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // YearM
            // 
            this.YearM.Location = new System.Drawing.Point(155, 48);
            this.YearM.Name = "YearM";
            this.YearM.Size = new System.Drawing.Size(69, 23);
            this.YearM.TabIndex = 8;
            this.YearM.TabStop = false;
            this.YearM.Text = "År -";
            this.YearM.UseVisualStyleBackColor = true;
            this.YearM.Click += new System.EventHandler(this.YearM_Click);
            // 
            // MonM
            // 
            this.MonM.Location = new System.Drawing.Point(81, 48);
            this.MonM.Name = "MonM";
            this.MonM.Size = new System.Drawing.Size(68, 23);
            this.MonM.TabIndex = 7;
            this.MonM.TabStop = false;
            this.MonM.Text = "Mnd -";
            this.MonM.UseVisualStyleBackColor = true;
            this.MonM.Click += new System.EventHandler(this.MonM_Click);
            // 
            // DayM
            // 
            this.DayM.Location = new System.Drawing.Point(6, 48);
            this.DayM.Name = "DayM";
            this.DayM.Size = new System.Drawing.Size(69, 23);
            this.DayM.TabIndex = 6;
            this.DayM.TabStop = false;
            this.DayM.Text = "Dag -";
            this.DayM.UseVisualStyleBackColor = true;
            this.DayM.Click += new System.EventHandler(this.DayM_Click);
            // 
            // YearP
            // 
            this.YearP.Location = new System.Drawing.Point(155, 19);
            this.YearP.Name = "YearP";
            this.YearP.Size = new System.Drawing.Size(69, 23);
            this.YearP.TabIndex = 4;
            this.YearP.TabStop = false;
            this.YearP.Text = "År +";
            this.YearP.UseVisualStyleBackColor = true;
            this.YearP.Click += new System.EventHandler(this.YearP_Click);
            // 
            // MonP
            // 
            this.MonP.Location = new System.Drawing.Point(81, 19);
            this.MonP.Name = "MonP";
            this.MonP.Size = new System.Drawing.Size(68, 23);
            this.MonP.TabIndex = 3;
            this.MonP.TabStop = false;
            this.MonP.Text = "Mnd +";
            this.MonP.UseVisualStyleBackColor = true;
            this.MonP.Click += new System.EventHandler(this.MonP_Click);
            // 
            // DayP
            // 
            this.DayP.Location = new System.Drawing.Point(6, 19);
            this.DayP.Name = "DayP";
            this.DayP.Size = new System.Drawing.Size(69, 23);
            this.DayP.TabIndex = 2;
            this.DayP.TabStop = false;
            this.DayP.Text = "Dag +";
            this.DayP.UseVisualStyleBackColor = true;
            this.DayP.Click += new System.EventHandler(this.DayP_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(12, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(760, 16);
            this.label2.TabIndex = 1;
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(248, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 191);
            this.label3.TabIndex = 3;
            this.label3.Visible = false;
            // 
            // gbCP
            // 
            this.gbCP.Controls.Add(this.cPrint);
            this.gbCP.Controls.Add(this.cGen);
            this.gbCP.Location = new System.Drawing.Point(542, 12);
            this.gbCP.Name = "gbCP";
            this.gbCP.Size = new System.Drawing.Size(230, 102);
            this.gbCP.TabIndex = 2;
            this.gbCP.TabStop = false;
            this.gbCP.Text = "Generer listen";
            // 
            // cPrint
            // 
            this.cPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cPrint.Location = new System.Drawing.Point(6, 60);
            this.cPrint.Name = "cPrint";
            this.cPrint.Size = new System.Drawing.Size(218, 36);
            this.cPrint.TabIndex = 2;
            this.cPrint.Text = "Lag og skriv ut";
            this.cPrint.UseVisualStyleBackColor = true;
            this.cPrint.Click += new System.EventHandler(this.cPrint_Click);
            // 
            // cGen
            // 
            this.cGen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cGen.Location = new System.Drawing.Point(6, 19);
            this.cGen.Name = "cGen";
            this.cGen.Size = new System.Drawing.Size(218, 36);
            this.cGen.TabIndex = 1;
            this.cGen.Text = "Forhåndsvisning";
            this.cGen.UseVisualStyleBackColor = true;
            this.cGen.Click += new System.EventHandler(this.cGen_Click);
            // 
            // gbDays
            // 
            this.gbDays.Controls.Add(this.cDayAll);
            this.gbDays.Controls.Add(this.cDaySun);
            this.gbDays.Controls.Add(this.cDaySat);
            this.gbDays.Controls.Add(this.cDayMon);
            this.gbDays.Controls.Add(this.cDayThu);
            this.gbDays.Controls.Add(this.cDayWed);
            this.gbDays.Controls.Add(this.cDayTue);
            this.gbDays.Controls.Add(this.cDayFri);
            this.gbDays.Location = new System.Drawing.Point(277, 12);
            this.gbDays.Name = "gbDays";
            this.gbDays.Size = new System.Drawing.Size(230, 102);
            this.gbDays.TabIndex = 1;
            this.gbDays.TabStop = false;
            this.gbDays.Text = "Inkluder ukedager";
            // 
            // cDayAll
            // 
            this.cDayAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cDayAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cDayAll.Location = new System.Drawing.Point(174, 60);
            this.cDayAll.Name = "cDayAll";
            this.cDayAll.Size = new System.Drawing.Size(50, 36);
            this.cDayAll.TabIndex = 16;
            this.cDayAll.TabStop = false;
            this.cDayAll.Text = "Alle";
            this.cDayAll.UseVisualStyleBackColor = false;
            this.cDayAll.Click += new System.EventHandler(this.cDayAll_Click);
            // 
            // cDaySun
            // 
            this.cDaySun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cDaySun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cDaySun.Location = new System.Drawing.Point(118, 60);
            this.cDaySun.Name = "cDaySun";
            this.cDaySun.Size = new System.Drawing.Size(50, 36);
            this.cDaySun.TabIndex = 15;
            this.cDaySun.TabStop = false;
            this.cDaySun.Text = "Søn";
            this.cDaySun.UseVisualStyleBackColor = false;
            this.cDaySun.Click += new System.EventHandler(this.cDaySun_Click);
            // 
            // cDaySat
            // 
            this.cDaySat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cDaySat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cDaySat.Location = new System.Drawing.Point(62, 60);
            this.cDaySat.Name = "cDaySat";
            this.cDaySat.Size = new System.Drawing.Size(50, 36);
            this.cDaySat.TabIndex = 14;
            this.cDaySat.TabStop = false;
            this.cDaySat.Text = "Lør";
            this.cDaySat.UseVisualStyleBackColor = false;
            this.cDaySat.Click += new System.EventHandler(this.cDaySat_Click);
            // 
            // cDayMon
            // 
            this.cDayMon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cDayMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cDayMon.Location = new System.Drawing.Point(6, 19);
            this.cDayMon.Name = "cDayMon";
            this.cDayMon.Size = new System.Drawing.Size(50, 36);
            this.cDayMon.TabIndex = 13;
            this.cDayMon.TabStop = false;
            this.cDayMon.Text = "Man";
            this.cDayMon.UseVisualStyleBackColor = false;
            this.cDayMon.Click += new System.EventHandler(this.cDayMon_Click);
            // 
            // cDayThu
            // 
            this.cDayThu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cDayThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cDayThu.Location = new System.Drawing.Point(174, 19);
            this.cDayThu.Name = "cDayThu";
            this.cDayThu.Size = new System.Drawing.Size(50, 36);
            this.cDayThu.TabIndex = 12;
            this.cDayThu.TabStop = false;
            this.cDayThu.Text = "Tor";
            this.cDayThu.UseVisualStyleBackColor = false;
            this.cDayThu.Click += new System.EventHandler(this.cDayThu_Click);
            // 
            // cDayWed
            // 
            this.cDayWed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cDayWed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cDayWed.Location = new System.Drawing.Point(118, 19);
            this.cDayWed.Name = "cDayWed";
            this.cDayWed.Size = new System.Drawing.Size(50, 36);
            this.cDayWed.TabIndex = 11;
            this.cDayWed.TabStop = false;
            this.cDayWed.Text = "Ons";
            this.cDayWed.UseVisualStyleBackColor = false;
            this.cDayWed.Click += new System.EventHandler(this.cDayWed_Click);
            // 
            // cDayTue
            // 
            this.cDayTue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cDayTue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cDayTue.Location = new System.Drawing.Point(62, 19);
            this.cDayTue.Name = "cDayTue";
            this.cDayTue.Size = new System.Drawing.Size(50, 36);
            this.cDayTue.TabIndex = 10;
            this.cDayTue.TabStop = false;
            this.cDayTue.Text = "Tir";
            this.cDayTue.UseVisualStyleBackColor = false;
            this.cDayTue.Click += new System.EventHandler(this.cDayTue_Click);
            // 
            // cDayFri
            // 
            this.cDayFri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cDayFri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cDayFri.Location = new System.Drawing.Point(6, 60);
            this.cDayFri.Name = "cDayFri";
            this.cDayFri.Size = new System.Drawing.Size(50, 36);
            this.cDayFri.TabIndex = 9;
            this.cDayFri.TabStop = false;
            this.cDayFri.Text = "Fre";
            this.cDayFri.UseVisualStyleBackColor = false;
            this.cDayFri.Click += new System.EventHandler(this.cDayFri_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(513, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 191);
            this.label1.TabIndex = 6;
            this.label1.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 203);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 326);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Forhåndsvisning";
            // 
            // wb
            // 
            this.wb.AllowWebBrowserDrop = false;
            this.wb.IsWebBrowserContextMenuEnabled = false;
            this.wb.Location = new System.Drawing.Point(1, 1);
            this.wb.MinimumSize = new System.Drawing.Size(20, 20);
            this.wb.Name = "wb";
            this.wb.Size = new System.Drawing.Size(746, 299);
            this.wb.TabIndex = 3;
            this.wb.TabStop = false;
            // 
            // gbTimes
            // 
            this.gbTimes.Controls.Add(this.txTimes);
            this.gbTimes.Location = new System.Drawing.Point(12, 136);
            this.gbTimes.Name = "gbTimes";
            this.gbTimes.Size = new System.Drawing.Size(230, 45);
            this.gbTimes.TabIndex = 3;
            this.gbTimes.TabStop = false;
            this.gbTimes.Text = "Klokkeslett";
            // 
            // txTimes
            // 
            this.txTimes.Location = new System.Drawing.Point(6, 19);
            this.txTimes.Name = "txTimes";
            this.txTimes.Size = new System.Drawing.Size(218, 20);
            this.txTimes.TabIndex = 0;
            this.txTimes.TabStop = false;
            this.txTimes.Text = "08-10, 10-12, 12-14, 14-16, 16-18, 18-20";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(12, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(760, 16);
            this.label4.TabIndex = 9;
            this.label4.Visible = false;
            // 
            // gbDaysPC
            // 
            this.gbDaysPC.Controls.Add(this.txDaysPerCol);
            this.gbDaysPC.Location = new System.Drawing.Point(277, 136);
            this.gbDaysPC.Name = "gbDaysPC";
            this.gbDaysPC.Size = new System.Drawing.Size(230, 45);
            this.gbDaysPC.TabIndex = 4;
            this.gbDaysPC.TabStop = false;
            this.gbDaysPC.Text = "Dager per kolonne";
            // 
            // txDaysPerCol
            // 
            this.txDaysPerCol.Location = new System.Drawing.Point(6, 19);
            this.txDaysPerCol.Name = "txDaysPerCol";
            this.txDaysPerCol.Size = new System.Drawing.Size(218, 20);
            this.txDaysPerCol.TabIndex = 1;
            this.txDaysPerCol.TabStop = false;
            this.txDaysPerCol.Text = "4";
            this.txDaysPerCol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbListsAhead
            // 
            this.gbListsAhead.Controls.Add(this.txListsAhead);
            this.gbListsAhead.Location = new System.Drawing.Point(542, 136);
            this.gbListsAhead.Name = "gbListsAhead";
            this.gbListsAhead.Size = new System.Drawing.Size(230, 45);
            this.gbListsAhead.TabIndex = 5;
            this.gbListsAhead.TabStop = false;
            this.gbListsAhead.Text = "Antall lister frem i tid";
            // 
            // txListsAhead
            // 
            this.txListsAhead.Location = new System.Drawing.Point(6, 19);
            this.txListsAhead.Name = "txListsAhead";
            this.txListsAhead.Size = new System.Drawing.Size(218, 20);
            this.txListsAhead.TabIndex = 1;
            this.txListsAhead.TabStop = false;
            this.txListsAhead.Text = "1";
            this.txListsAhead.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.wb);
            this.panel1.Location = new System.Drawing.Point(6, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(748, 301);
            this.panel1.TabIndex = 4;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(784, 541);
            this.Controls.Add(this.gbListsAhead);
            this.Controls.Add(this.gbDaysPC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gbTimes);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbDays);
            this.Controls.Add(this.gbCP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gbDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "pListGen";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.gbDate.ResumeLayout(false);
            this.gbCP.ResumeLayout(false);
            this.gbDays.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.gbTimes.ResumeLayout(false);
            this.gbTimes.PerformLayout();
            this.gbDaysPC.ResumeLayout(false);
            this.gbDaysPC.PerformLayout();
            this.gbListsAhead.ResumeLayout(false);
            this.gbListsAhead.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDate;
        private System.Windows.Forms.Button YearM;
        private System.Windows.Forms.Button MonM;
        private System.Windows.Forms.Button DayM;
        private System.Windows.Forms.Button YearP;
        private System.Windows.Forms.Button MonP;
        private System.Windows.Forms.Button DayP;
        private System.Windows.Forms.Label lbBase;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbCP;
        private System.Windows.Forms.Button cPrint;
        private System.Windows.Forms.Button cGen;
        private System.Windows.Forms.GroupBox gbDays;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cDayAll;
        private System.Windows.Forms.Button cDaySun;
        private System.Windows.Forms.Button cDaySat;
        private System.Windows.Forms.Button cDayMon;
        private System.Windows.Forms.Button cDayThu;
        private System.Windows.Forms.Button cDayWed;
        private System.Windows.Forms.Button cDayTue;
        private System.Windows.Forms.Button cDayFri;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.WebBrowser wb;
        private System.Windows.Forms.GroupBox gbTimes;
        private System.Windows.Forms.TextBox txTimes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbDaysPC;
        private System.Windows.Forms.TextBox txDaysPerCol;
        private System.Windows.Forms.GroupBox gbListsAhead;
        private System.Windows.Forms.TextBox txListsAhead;
        private System.Windows.Forms.Panel panel1;
    }
}

