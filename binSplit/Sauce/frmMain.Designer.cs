namespace binSplit {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ginb = new System.Windows.Forms.Button();
            this.gin = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gopt2v = new System.Windows.Forms.TextBox();
            this.gopt1v = new System.Windows.Forms.TextBox();
            this.gopt2 = new System.Windows.Forms.RadioButton();
            this.gopt1 = new System.Windows.Forms.RadioButton();
            this.gSTART = new System.Windows.Forms.Button();
            this.gGTFO = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gbatch = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbase = new System.Windows.Forms.TextBox();
            this.ginf = new System.Windows.Forms.Label();
            this.tGUI = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ginb);
            this.groupBox1.Controls.Add(this.gin);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 48);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input file";
            // 
            // ginb
            // 
            this.ginb.Location = new System.Drawing.Point(236, 19);
            this.ginb.Name = "ginb";
            this.ginb.Size = new System.Drawing.Size(26, 23);
            this.ginb.TabIndex = 1;
            this.ginb.Text = "...";
            this.ginb.UseVisualStyleBackColor = true;
            this.ginb.Click += new System.EventHandler(this.ginb_Click);
            // 
            // gin
            // 
            this.gin.Location = new System.Drawing.Point(6, 21);
            this.gin.Name = "gin";
            this.gin.Size = new System.Drawing.Size(224, 20);
            this.gin.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gopt2v);
            this.groupBox2.Controls.Add(this.gopt1v);
            this.groupBox2.Controls.Add(this.gopt2);
            this.groupBox2.Controls.Add(this.gopt1);
            this.groupBox2.Location = new System.Drawing.Point(12, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(268, 71);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Split options";
            // 
            // gopt2v
            // 
            this.gopt2v.Location = new System.Drawing.Point(104, 45);
            this.gopt2v.Name = "gopt2v";
            this.gopt2v.Size = new System.Drawing.Size(158, 20);
            this.gopt2v.TabIndex = 3;
            this.gopt2v.Text = "1\'073\'741\'824";
            // 
            // gopt1v
            // 
            this.gopt1v.Location = new System.Drawing.Point(104, 19);
            this.gopt1v.Name = "gopt1v";
            this.gopt1v.Size = new System.Drawing.Size(158, 20);
            this.gopt1v.TabIndex = 2;
            this.gopt1v.Text = "20";
            // 
            // gopt2
            // 
            this.gopt2.AutoSize = true;
            this.gopt2.Checked = true;
            this.gopt2.Location = new System.Drawing.Point(6, 46);
            this.gopt2.Name = "gopt2";
            this.gopt2.Size = new System.Drawing.Size(91, 17);
            this.gopt2.TabIndex = 1;
            this.gopt2.TabStop = true;
            this.gopt2.Text = "Fixed size limit";
            this.gopt2.UseVisualStyleBackColor = true;
            // 
            // gopt1
            // 
            this.gopt1.AutoSize = true;
            this.gopt1.Location = new System.Drawing.Point(6, 20);
            this.gopt1.Name = "gopt1";
            this.gopt1.Size = new System.Drawing.Size(92, 17);
            this.gopt1.TabIndex = 0;
            this.gopt1.Text = "Split to n parts";
            this.gopt1.UseVisualStyleBackColor = true;
            // 
            // gSTART
            // 
            this.gSTART.Location = new System.Drawing.Point(205, 234);
            this.gSTART.Name = "gSTART";
            this.gSTART.Size = new System.Drawing.Size(75, 23);
            this.gSTART.TabIndex = 2;
            this.gSTART.Text = "Start";
            this.gSTART.UseVisualStyleBackColor = true;
            this.gSTART.Click += new System.EventHandler(this.gSTART_Click);
            // 
            // gGTFO
            // 
            this.gGTFO.Location = new System.Drawing.Point(124, 234);
            this.gGTFO.Name = "gGTFO";
            this.gGTFO.Size = new System.Drawing.Size(75, 23);
            this.gGTFO.TabIndex = 3;
            this.gGTFO.Text = "Cancel";
            this.gGTFO.UseVisualStyleBackColor = true;
            this.gGTFO.Click += new System.EventHandler(this.gGTFO_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gbatch);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.gbase);
            this.groupBox3.Location = new System.Drawing.Point(12, 143);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(268, 70);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Output files";
            // 
            // gbatch
            // 
            this.gbatch.Checked = true;
            this.gbatch.CheckState = System.Windows.Forms.CheckState.Checked;
            this.gbatch.Location = new System.Drawing.Point(6, 47);
            this.gbatch.Name = "gbatch";
            this.gbatch.Size = new System.Drawing.Size(256, 17);
            this.gbatch.TabIndex = 6;
            this.gbatch.Text = "Create automerge batch script (merge.bat)";
            this.gbatch.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Base filename";
            // 
            // gbase
            // 
            this.gbase.Location = new System.Drawing.Point(104, 21);
            this.gbase.Name = "gbase";
            this.gbase.Size = new System.Drawing.Size(158, 20);
            this.gbase.TabIndex = 0;
            this.gbase.Text = "movie.mkv";
            // 
            // ginf
            // 
            this.ginf.AutoSize = true;
            this.ginf.Location = new System.Drawing.Point(12, 239);
            this.ginf.Name = "ginf";
            this.ginf.Size = new System.Drawing.Size(0, 13);
            this.ginf.TabIndex = 5;
            // 
            // tGUI
            // 
            this.tGUI.Tick += new System.EventHandler(this.tGUI_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 269);
            this.Controls.Add(this.ginf);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gGTFO);
            this.Controls.Add(this.gSTART);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "pSFileSplit";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ginb;
        private System.Windows.Forms.TextBox gin;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton gopt2;
        private System.Windows.Forms.RadioButton gopt1;
        private System.Windows.Forms.TextBox gopt2v;
        private System.Windows.Forms.TextBox gopt1v;
        private System.Windows.Forms.Button gSTART;
        private System.Windows.Forms.Button gGTFO;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox gbase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox gbatch;
        private System.Windows.Forms.Label ginf;
        private System.Windows.Forms.Timer tGUI;
    }
}

