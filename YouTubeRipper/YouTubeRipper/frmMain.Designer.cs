namespace YouTubeRipper
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmd_Start = new System.Windows.Forms.Button();
            this.txt_URLs = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_URLs);
            this.groupBox1.Controls.Add(this.cmd_Start);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(499, 504);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "rip";
            // 
            // cmd_Start
            // 
            this.cmd_Start.Location = new System.Drawing.Point(6, 19);
            this.cmd_Start.Name = "cmd_Start";
            this.cmd_Start.Size = new System.Drawing.Size(487, 23);
            this.cmd_Start.TabIndex = 0;
            this.cmd_Start.Text = "go";
            this.cmd_Start.UseVisualStyleBackColor = true;
            this.cmd_Start.Click += new System.EventHandler(this.cmd_Start_Click);
            // 
            // txt_URLs
            // 
            this.txt_URLs.Location = new System.Drawing.Point(6, 48);
            this.txt_URLs.Multiline = true;
            this.txt_URLs.Name = "txt_URLs";
            this.txt_URLs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_URLs.Size = new System.Drawing.Size(487, 450);
            this.txt_URLs.TabIndex = 1;
            this.txt_URLs.Text = resources.GetString("txt_URLs.Text");
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 528);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_URLs;
        private System.Windows.Forms.Button cmd_Start;
    }
}

