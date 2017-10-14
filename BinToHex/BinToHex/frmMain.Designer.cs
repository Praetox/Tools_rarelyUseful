namespace BinToHex
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
            this.txtPath = new System.Windows.Forms.TextBox();
            this.cmdBinToHex = new System.Windows.Forms.Button();
            this.cmdHexToBin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPath
            // 
            this.txtPath.AllowDrop = true;
            this.txtPath.Location = new System.Drawing.Point(12, 12);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(268, 20);
            this.txtPath.TabIndex = 0;
            // 
            // cmdBinToHex
            // 
            this.cmdBinToHex.Location = new System.Drawing.Point(12, 38);
            this.cmdBinToHex.Name = "cmdBinToHex";
            this.cmdBinToHex.Size = new System.Drawing.Size(268, 23);
            this.cmdBinToHex.TabIndex = 1;
            this.cmdBinToHex.Text = "Bin -> Hex";
            this.cmdBinToHex.UseVisualStyleBackColor = true;
            this.cmdBinToHex.Click += new System.EventHandler(this.cmdBinToHex_Click);
            // 
            // cmdHexToBin
            // 
            this.cmdHexToBin.Location = new System.Drawing.Point(12, 67);
            this.cmdHexToBin.Name = "cmdHexToBin";
            this.cmdHexToBin.Size = new System.Drawing.Size(268, 23);
            this.cmdHexToBin.TabIndex = 2;
            this.cmdHexToBin.Text = "Hex -> Bin";
            this.cmdHexToBin.UseVisualStyleBackColor = true;
            this.cmdHexToBin.Click += new System.EventHandler(this.cmdHexToBin_Click);
            // 
            // frmMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 269);
            this.Controls.Add(this.cmdHexToBin);
            this.Controls.Add(this.cmdBinToHex);
            this.Controls.Add(this.txtPath);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.frmMain_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.frmMain_DragEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button cmdBinToHex;
        private System.Windows.Forms.Button cmdHexToBin;
    }
}

