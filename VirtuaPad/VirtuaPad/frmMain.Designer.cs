namespace VirtuaPad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.picGlow2 = new System.Windows.Forms.PictureBox();
            this.picGlow1 = new System.Windows.Forms.PictureBox();
            this.tHotkeys = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tPadFader = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picGlow2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGlow1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // picGlow2
            // 
            this.picGlow2.Image = ((System.Drawing.Image)(resources.GetObject("picGlow2.Image")));
            this.picGlow2.Location = new System.Drawing.Point(142, 55);
            this.picGlow2.Name = "picGlow2";
            this.picGlow2.Size = new System.Drawing.Size(124, 124);
            this.picGlow2.TabIndex = 0;
            this.picGlow2.TabStop = false;
            this.picGlow2.Visible = false;
            // 
            // picGlow1
            // 
            this.picGlow1.Image = ((System.Drawing.Image)(resources.GetObject("picGlow1.Image")));
            this.picGlow1.Location = new System.Drawing.Point(12, 55);
            this.picGlow1.Name = "picGlow1";
            this.picGlow1.Size = new System.Drawing.Size(124, 124);
            this.picGlow1.TabIndex = 1;
            this.picGlow1.TabStop = false;
            this.picGlow1.Visible = false;
            // 
            // tHotkeys
            // 
            this.tHotkeys.Interval = 1;
            this.tHotkeys.Tick += new System.EventHandler(this.tHotkeys_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VirtuaPad.Properties.Resources.Banner;
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(536, 48);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // tPadFader
            // 
            this.tPadFader.Interval = 10;
            this.tPadFader.Tick += new System.EventHandler(this.tPadFader_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(538, 589);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picGlow1);
            this.Controls.Add(this.picGlow2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMain";
            this.Text = "Praetox VirtuaPad - ";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picGlow2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGlow1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picGlow2;
        private System.Windows.Forms.PictureBox picGlow1;
        private System.Windows.Forms.Timer tHotkeys;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer tPadFader;

    }
}

