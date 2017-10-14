namespace PPS
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
            this.components = new System.ComponentModel.Container();
            this.cmdClose = new System.Windows.Forms.Button();
            this.Status = new System.Windows.Forms.GroupBox();
            this.dsp = new System.Windows.Forms.Panel();
            this.lFilelist = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.Label();
            this.tFade = new System.Windows.Forms.Timer(this.components);
            this.Status.SuspendLayout();
            this.dsp.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdClose
            // 
            this.cmdClose.ForeColor = System.Drawing.Color.Black;
            this.cmdClose.Location = new System.Drawing.Point(0, 0);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(14, 21);
            this.cmdClose.TabIndex = 0;
            this.cmdClose.Text = "X";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmdClose_KeyDown);
            // 
            // Status
            // 
            this.Status.Controls.Add(this.dsp);
            this.Status.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.Status.Location = new System.Drawing.Point(12, 12);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(268, 242);
            this.Status.TabIndex = 1;
            this.Status.TabStop = false;
            this.Status.Text = "Praetox Presentation System - ready to kick some ass.";
            // 
            // dsp
            // 
            this.dsp.Controls.Add(this.lFilelist);
            this.dsp.Controls.Add(this.Logo);
            this.dsp.Location = new System.Drawing.Point(6, 19);
            this.dsp.Name = "dsp";
            this.dsp.Size = new System.Drawing.Size(256, 211);
            this.dsp.TabIndex = 0;
            // 
            // lFilelist
            // 
            this.lFilelist.AutoSize = true;
            this.lFilelist.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFilelist.ForeColor = System.Drawing.Color.Black;
            this.lFilelist.Location = new System.Drawing.Point(14, 16);
            this.lFilelist.Name = "lFilelist";
            this.lFilelist.Size = new System.Drawing.Size(69, 14);
            this.lFilelist.TabIndex = 2;
            this.lFilelist.Text = "Loaded files:";
            // 
            // Logo
            // 
            this.Logo.AutoSize = true;
            this.Logo.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logo.ForeColor = System.Drawing.Color.Black;
            this.Logo.Location = new System.Drawing.Point(24, 23);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(460, 114);
            this.Logo.TabIndex = 1;
            this.Logo.Text = "Welcome to\r\nPraetox Presentation System\r\nhttp://praetox.com";
            this.Logo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tFade
            // 
            this.tFade.Interval = 1000;
            this.tFade.Tick += new System.EventHandler(this.tFade_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.cmdClose);
            this.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.Text = "Praetox Presentation System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Status.ResumeLayout(false);
            this.dsp.ResumeLayout(false);
            this.dsp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.GroupBox Status;
        private System.Windows.Forms.Timer tFade;
        private System.Windows.Forms.Label Logo;
        private System.Windows.Forms.Panel dsp;
        private System.Windows.Forms.Label lFilelist;
    }
}

