namespace timah {
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
            this.TickList = new System.Windows.Forms.ListBox();
            this.ApplyTick = new System.Windows.Forms.Button();
            this.tReloc = new System.Windows.Forms.Timer(this.components);
            this.TickRange = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.KaraPre = new System.Windows.Forms.TextBox();
            this.KaraPost = new System.Windows.Forms.TextBox();
            this.tSkew = new System.Windows.Forms.Timer(this.components);
            this.SkewVal = new System.Windows.Forms.TextBox();
            this.SkewAll = new System.Windows.Forms.Button();
            this.KaraMake = new System.Windows.Forms.Button();
            this.TickCopy = new System.Windows.Forms.Button();
            this.TickPaste = new System.Windows.Forms.Button();
            this.AbsEnd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TickList
            // 
            this.TickList.FormattingEnabled = true;
            this.TickList.Location = new System.Drawing.Point(286, 94);
            this.TickList.Name = "TickList";
            this.TickList.Size = new System.Drawing.Size(268, 199);
            this.TickList.TabIndex = 0;
            // 
            // ApplyTick
            // 
            this.ApplyTick.Location = new System.Drawing.Point(286, 12);
            this.ApplyTick.Name = "ApplyTick";
            this.ApplyTick.Size = new System.Drawing.Size(268, 23);
            this.ApplyTick.TabIndex = 1;
            this.ApplyTick.Text = "ApplyTick();";
            this.ApplyTick.UseVisualStyleBackColor = true;
            this.ApplyTick.Click += new System.EventHandler(this.ApplyTick_Click);
            this.ApplyTick.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ApplyTick_KeyDown);
            // 
            // tReloc
            // 
            this.tReloc.Enabled = true;
            this.tReloc.Tick += new System.EventHandler(this.tReloc_Tick);
            // 
            // TickRange
            // 
            this.TickRange.FormattingEnabled = true;
            this.TickRange.Location = new System.Drawing.Point(286, 41);
            this.TickRange.Name = "TickRange";
            this.TickRange.Size = new System.Drawing.Size(268, 21);
            this.TickRange.TabIndex = 3;
            this.TickRange.SelectedIndexChanged += new System.EventHandler(this.TickRange_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(268, 204);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // KaraPre
            // 
            this.KaraPre.Location = new System.Drawing.Point(12, 222);
            this.KaraPre.Name = "KaraPre";
            this.KaraPre.Size = new System.Drawing.Size(131, 20);
            this.KaraPre.TabIndex = 5;
            this.KaraPre.Text = "{\\r\\t(";
            // 
            // KaraPost
            // 
            this.KaraPost.Location = new System.Drawing.Point(12, 248);
            this.KaraPost.Name = "KaraPost";
            this.KaraPost.Size = new System.Drawing.Size(268, 20);
            this.KaraPost.TabIndex = 6;
            this.KaraPost.Text = ",\\1c&HFFFFFF&\\3c&H9c8e63&)}";
            // 
            // tSkew
            // 
            this.tSkew.Enabled = true;
            this.tSkew.Interval = 1;
            this.tSkew.Tick += new System.EventHandler(this.tSkew_Tick);
            // 
            // SkewVal
            // 
            this.SkewVal.Location = new System.Drawing.Point(12, 274);
            this.SkewVal.Name = "SkewVal";
            this.SkewVal.Size = new System.Drawing.Size(131, 20);
            this.SkewVal.TabIndex = 7;
            this.SkewVal.Text = "+200";
            // 
            // SkewAll
            // 
            this.SkewAll.Location = new System.Drawing.Point(149, 274);
            this.SkewAll.Name = "SkewAll";
            this.SkewAll.Size = new System.Drawing.Size(62, 20);
            this.SkewAll.TabIndex = 9;
            this.SkewAll.Text = "Skew all";
            this.SkewAll.UseVisualStyleBackColor = true;
            this.SkewAll.Click += new System.EventHandler(this.SkewAll_Click);
            // 
            // KaraMake
            // 
            this.KaraMake.Location = new System.Drawing.Point(149, 222);
            this.KaraMake.Name = "KaraMake";
            this.KaraMake.Size = new System.Drawing.Size(131, 20);
            this.KaraMake.TabIndex = 10;
            this.KaraMake.Text = "It needs moar kara";
            this.KaraMake.UseVisualStyleBackColor = true;
            this.KaraMake.Click += new System.EventHandler(this.KaraMake_Click);
            // 
            // TickCopy
            // 
            this.TickCopy.Location = new System.Drawing.Point(286, 68);
            this.TickCopy.Name = "TickCopy";
            this.TickCopy.Size = new System.Drawing.Size(131, 20);
            this.TickCopy.TabIndex = 11;
            this.TickCopy.Text = "COPY";
            this.TickCopy.UseVisualStyleBackColor = true;
            this.TickCopy.Click += new System.EventHandler(this.TickCopy_Click);
            // 
            // TickPaste
            // 
            this.TickPaste.Location = new System.Drawing.Point(423, 68);
            this.TickPaste.Name = "TickPaste";
            this.TickPaste.Size = new System.Drawing.Size(131, 20);
            this.TickPaste.TabIndex = 12;
            this.TickPaste.Text = "PASTE";
            this.TickPaste.UseVisualStyleBackColor = true;
            this.TickPaste.Click += new System.EventHandler(this.TickPaste_Click);
            // 
            // AbsEnd
            // 
            this.AbsEnd.Location = new System.Drawing.Point(218, 273);
            this.AbsEnd.Name = "AbsEnd";
            this.AbsEnd.Size = new System.Drawing.Size(62, 20);
            this.AbsEnd.TabIndex = 13;
            this.AbsEnd.Text = "Abs end";
            this.AbsEnd.UseVisualStyleBackColor = true;
            this.AbsEnd.Click += new System.EventHandler(this.AbsEnd_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(566, 306);
            this.Controls.Add(this.AbsEnd);
            this.Controls.Add(this.TickPaste);
            this.Controls.Add(this.TickCopy);
            this.Controls.Add(this.KaraMake);
            this.Controls.Add(this.SkewAll);
            this.Controls.Add(this.SkewVal);
            this.Controls.Add(this.KaraPost);
            this.Controls.Add(this.KaraPre);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TickRange);
            this.Controls.Add(this.ApplyTick);
            this.Controls.Add(this.TickList);
            this.Name = "frmMain";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox TickList;
        private System.Windows.Forms.Button ApplyTick;
        private System.Windows.Forms.Timer tReloc;
        private System.Windows.Forms.ComboBox TickRange;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox KaraPre;
        private System.Windows.Forms.TextBox KaraPost;
        private System.Windows.Forms.Timer tSkew;
        private System.Windows.Forms.TextBox SkewVal;
        private System.Windows.Forms.Button SkewAll;
        private System.Windows.Forms.Button KaraMake;
        private System.Windows.Forms.Button TickCopy;
        private System.Windows.Forms.Button TickPaste;
        private System.Windows.Forms.Button AbsEnd;
    }
}

