namespace CopyTool
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSrc = new System.Windows.Forms.TextBox();
            this.cmdSrc = new System.Windows.Forms.Button();
            this.cmdDst = new System.Windows.Forms.Button();
            this.txtDst = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkRPath = new System.Windows.Forms.CheckBox();
            this.chkMkDir = new System.Windows.Forms.CheckBox();
            this.txtCopied = new System.Windows.Forms.TextBox();
            this.cmdGo = new System.Windows.Forms.Button();
            this.txtFailed = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtExclude = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pbFiles = new System.Windows.Forms.ProgressBar();
            this.txtRisky = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source";
            // 
            // txtSrc
            // 
            this.txtSrc.Location = new System.Drawing.Point(68, 12);
            this.txtSrc.Name = "txtSrc";
            this.txtSrc.Size = new System.Drawing.Size(282, 20);
            this.txtSrc.TabIndex = 1;
            this.txtSrc.TextChanged += new System.EventHandler(this.txtSrc_TextChanged);
            // 
            // cmdSrc
            // 
            this.cmdSrc.Location = new System.Drawing.Point(356, 10);
            this.cmdSrc.Name = "cmdSrc";
            this.cmdSrc.Size = new System.Drawing.Size(24, 23);
            this.cmdSrc.TabIndex = 4;
            this.cmdSrc.Text = "...";
            this.cmdSrc.UseVisualStyleBackColor = true;
            this.cmdSrc.Click += new System.EventHandler(this.cmdSrc_Click);
            // 
            // cmdDst
            // 
            this.cmdDst.Location = new System.Drawing.Point(356, 36);
            this.cmdDst.Name = "cmdDst";
            this.cmdDst.Size = new System.Drawing.Size(24, 23);
            this.cmdDst.TabIndex = 7;
            this.cmdDst.Text = "...";
            this.cmdDst.UseVisualStyleBackColor = true;
            this.cmdDst.Click += new System.EventHandler(this.cmdDst_Click);
            // 
            // txtDst
            // 
            this.txtDst.Location = new System.Drawing.Point(68, 38);
            this.txtDst.Name = "txtDst";
            this.txtDst.Size = new System.Drawing.Size(282, 20);
            this.txtDst.TabIndex = 6;
            this.txtDst.TextChanged += new System.EventHandler(this.txtDst_TextChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Target";
            // 
            // chkRPath
            // 
            this.chkRPath.AutoSize = true;
            this.chkRPath.Checked = true;
            this.chkRPath.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRPath.Location = new System.Drawing.Point(68, 119);
            this.chkRPath.Name = "chkRPath";
            this.chkRPath.Size = new System.Drawing.Size(112, 17);
            this.chkRPath.TabIndex = 9;
            this.chkRPath.Text = "Keep relative path";
            this.chkRPath.UseVisualStyleBackColor = true;
            this.chkRPath.CheckedChanged += new System.EventHandler(this.chkRPath_CheckedChanged);
            // 
            // chkMkDir
            // 
            this.chkMkDir.AutoSize = true;
            this.chkMkDir.Checked = true;
            this.chkMkDir.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMkDir.Location = new System.Drawing.Point(186, 119);
            this.chkMkDir.Name = "chkMkDir";
            this.chkMkDir.Size = new System.Drawing.Size(108, 17);
            this.chkMkDir.TabIndex = 10;
            this.chkMkDir.Text = "Create directories";
            this.chkMkDir.UseVisualStyleBackColor = true;
            this.chkMkDir.CheckedChanged += new System.EventHandler(this.chkMkDir_CheckedChanged);
            // 
            // txtCopied
            // 
            this.txtCopied.Location = new System.Drawing.Point(12, 197);
            this.txtCopied.Multiline = true;
            this.txtCopied.Name = "txtCopied";
            this.txtCopied.Size = new System.Drawing.Size(368, 150);
            this.txtCopied.TabIndex = 11;
            this.txtCopied.Text = ">> List of win";
            this.txtCopied.WordWrap = false;
            // 
            // cmdGo
            // 
            this.cmdGo.Location = new System.Drawing.Point(68, 90);
            this.cmdGo.Name = "cmdGo";
            this.cmdGo.Size = new System.Drawing.Size(282, 23);
            this.cmdGo.TabIndex = 12;
            this.cmdGo.Text = "LETS GET THAT SHIT GOING MAN";
            this.cmdGo.UseVisualStyleBackColor = true;
            this.cmdGo.Click += new System.EventHandler(this.cmdGo_Click);
            // 
            // txtFailed
            // 
            this.txtFailed.Location = new System.Drawing.Point(12, 509);
            this.txtFailed.Multiline = true;
            this.txtFailed.Name = "txtFailed";
            this.txtFailed.Size = new System.Drawing.Size(368, 150);
            this.txtFailed.TabIndex = 13;
            this.txtFailed.Text = ">> List of fail";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(12, 142);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(368, 20);
            this.txtStatus.TabIndex = 14;
            this.txtStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtExclude
            // 
            this.txtExclude.Location = new System.Drawing.Point(68, 64);
            this.txtExclude.Name = "txtExclude";
            this.txtExclude.Size = new System.Drawing.Size(282, 20);
            this.txtExclude.TabIndex = 16;
            this.txtExclude.Text = "*.exe; *.tmp; Thumbs.db";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Ignore";
            // 
            // pbFiles
            // 
            this.pbFiles.Location = new System.Drawing.Point(12, 168);
            this.pbFiles.Name = "pbFiles";
            this.pbFiles.Size = new System.Drawing.Size(368, 23);
            this.pbFiles.TabIndex = 17;
            // 
            // txtRisky
            // 
            this.txtRisky.Location = new System.Drawing.Point(12, 353);
            this.txtRisky.Multiline = true;
            this.txtRisky.Name = "txtRisky";
            this.txtRisky.Size = new System.Drawing.Size(368, 150);
            this.txtRisky.TabIndex = 18;
            this.txtRisky.Text = ">> List of huh";
            this.txtRisky.WordWrap = false;
            // 
            // frmMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 671);
            this.Controls.Add(this.txtRisky);
            this.Controls.Add(this.pbFiles);
            this.Controls.Add(this.txtExclude);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtFailed);
            this.Controls.Add(this.cmdGo);
            this.Controls.Add(this.txtCopied);
            this.Controls.Add(this.chkMkDir);
            this.Controls.Add(this.chkRPath);
            this.Controls.Add(this.cmdDst);
            this.Controls.Add(this.txtDst);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmdSrc);
            this.Controls.Add(this.txtSrc);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.Text = "CopyTool :: praetox.com";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.frmMain_DragDrop);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.DragOver += new System.Windows.Forms.DragEventHandler(this.frmMain_DragOver);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSrc;
        private System.Windows.Forms.Button cmdSrc;
        private System.Windows.Forms.Button cmdDst;
        private System.Windows.Forms.TextBox txtDst;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkRPath;
        private System.Windows.Forms.CheckBox chkMkDir;
        private System.Windows.Forms.TextBox txtCopied;
        private System.Windows.Forms.Button cmdGo;
        private System.Windows.Forms.TextBox txtFailed;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtExclude;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar pbFiles;
        private System.Windows.Forms.TextBox txtRisky;
    }
}

