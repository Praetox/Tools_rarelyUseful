namespace ToxIRC
{
    partial class Form1
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
            this.txtServ = new System.Windows.Forms.TextBox();
            this.txtNick = new System.Windows.Forms.TextBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.txtChan = new System.Windows.Forms.TextBox();
            this.txtLearnDB = new System.Windows.Forms.TextBox();
            this.tReadSock = new System.Windows.Forms.Timer(this.components);
            this.cmdGo = new System.Windows.Forms.Button();
            this.tMain = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txtServ
            // 
            this.txtServ.Location = new System.Drawing.Point(12, 12);
            this.txtServ.Name = "txtServ";
            this.txtServ.Size = new System.Drawing.Size(90, 20);
            this.txtServ.TabIndex = 1;
            this.txtServ.Text = "irc.rizon.no";
            // 
            // txtNick
            // 
            this.txtNick.Location = new System.Drawing.Point(108, 12);
            this.txtNick.Name = "txtNick";
            this.txtNick.Size = new System.Drawing.Size(90, 20);
            this.txtNick.TabIndex = 2;
            this.txtNick.Text = "hivemind";
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(12, 38);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(312, 319);
            this.txtLog.TabIndex = 5;
            // 
            // txtChan
            // 
            this.txtChan.Location = new System.Drawing.Point(204, 12);
            this.txtChan.Name = "txtChan";
            this.txtChan.Size = new System.Drawing.Size(90, 20);
            this.txtChan.TabIndex = 3;
            this.txtChan.Text = "/a/";
            // 
            // txtLearnDB
            // 
            this.txtLearnDB.Location = new System.Drawing.Point(330, 12);
            this.txtLearnDB.Multiline = true;
            this.txtLearnDB.Name = "txtLearnDB";
            this.txtLearnDB.Size = new System.Drawing.Size(442, 345);
            this.txtLearnDB.TabIndex = 6;
            // 
            // tReadSock
            // 
            this.tReadSock.Enabled = true;
            this.tReadSock.Tick += new System.EventHandler(this.tReadSock_Tick);
            // 
            // cmdGo
            // 
            this.cmdGo.Location = new System.Drawing.Point(300, 12);
            this.cmdGo.Name = "cmdGo";
            this.cmdGo.Size = new System.Drawing.Size(24, 20);
            this.cmdGo.TabIndex = 4;
            this.cmdGo.Text = "|>";
            this.cmdGo.UseVisualStyleBackColor = true;
            this.cmdGo.Click += new System.EventHandler(this.cmdGo_Click);
            // 
            // tMain
            // 
            this.tMain.Enabled = true;
            this.tMain.Interval = 1000;
            this.tMain.Tick += new System.EventHandler(this.tMain_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 369);
            this.Controls.Add(this.cmdGo);
            this.Controls.Add(this.txtLearnDB);
            this.Controls.Add(this.txtChan);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.txtNick);
            this.Controls.Add(this.txtServ);
            this.Name = "Form1";
            this.Text = "ToxIRC";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtServ;
        private System.Windows.Forms.TextBox txtNick;
        private System.Windows.Forms.TextBox txtChan;
        private System.Windows.Forms.Timer tReadSock;
        private System.Windows.Forms.Button cmdGo;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.TextBox txtLearnDB;
        private System.Windows.Forms.Timer tMain;
    }
}

