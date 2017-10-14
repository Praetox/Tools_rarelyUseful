namespace pKillPopup
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
            this.tBoot = new System.Windows.Forms.Timer(this.components);
            this.tPoll = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // tBoot
            // 
            this.tBoot.Tick += new System.EventHandler(this.tBoot_Tick);
            // 
            // tPoll
            // 
            this.tPoll.Enabled = true;
            this.tPoll.Interval = 10;
            this.tPoll.Tick += new System.EventHandler(this.tPoll_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tBoot;
        private System.Windows.Forms.Timer tPoll;
    }
}

