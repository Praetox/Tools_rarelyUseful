namespace GendouDumper
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbSessID = new System.Windows.Forms.Label();
            this.cmdLogin = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmdPath = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmdGo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPage = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbiNew = new System.Windows.Forms.Label();
            this.lbiCurr = new System.Windows.Forms.Label();
            this.lbsCurr = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdGetMD5 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbSessID);
            this.groupBox1.Controls.Add(this.cmdLogin);
            this.groupBox1.Controls.Add(this.txtPass);
            this.groupBox1.Controls.Add(this.txtUser);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 89);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account on Gendou.com";
            // 
            // lbSessID
            // 
            this.lbSessID.Location = new System.Drawing.Point(6, 71);
            this.lbSessID.Name = "lbSessID";
            this.lbSessID.Size = new System.Drawing.Size(256, 13);
            this.lbSessID.TabIndex = 3;
            this.lbSessID.Text = "Session: xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx";
            this.lbSessID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmdLogin
            // 
            this.cmdLogin.Location = new System.Drawing.Point(6, 45);
            this.cmdLogin.Name = "cmdLogin";
            this.cmdLogin.Size = new System.Drawing.Size(256, 23);
            this.cmdLogin.TabIndex = 2;
            this.cmdLogin.Text = "Log in";
            this.cmdLogin.UseVisualStyleBackColor = true;
            this.cmdLogin.Click += new System.EventHandler(this.cmdLogin_Click);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(137, 19);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(125, 20);
            this.txtPass.TabIndex = 1;
            this.txtPass.Text = "u8u8u8";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(6, 19);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(125, 20);
            this.txtUser.TabIndex = 0;
            this.txtUser.Text = "twinkiez";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmdPath);
            this.groupBox2.Controls.Add(this.txtPath);
            this.groupBox2.Location = new System.Drawing.Point(12, 107);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(268, 45);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Download to";
            // 
            // cmdPath
            // 
            this.cmdPath.Location = new System.Drawing.Point(238, 17);
            this.cmdPath.Name = "cmdPath";
            this.cmdPath.Size = new System.Drawing.Size(24, 23);
            this.cmdPath.TabIndex = 3;
            this.cmdPath.Text = "...";
            this.cmdPath.UseVisualStyleBackColor = true;
            this.cmdPath.Click += new System.EventHandler(this.cmdPath_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(6, 19);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(226, 20);
            this.txtPath.TabIndex = 0;
            this.txtPath.Text = "c:\\Gendou_dump\\";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmdGo);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtPage);
            this.groupBox3.Location = new System.Drawing.Point(12, 158);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(268, 74);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Let\'s get the party going";
            // 
            // cmdGo
            // 
            this.cmdGo.Location = new System.Drawing.Point(6, 45);
            this.cmdGo.Name = "cmdGo";
            this.cmdGo.Size = new System.Drawing.Size(256, 23);
            this.cmdGo.TabIndex = 5;
            this.cmdGo.Text = "PARTY HARD! PARTY HARD!";
            this.cmdGo.UseVisualStyleBackColor = true;
            this.cmdGo.Click += new System.EventHandler(this.cmdGo_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Start caching at page no. ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPage
            // 
            this.txtPage.Location = new System.Drawing.Point(173, 19);
            this.txtPage.Name = "txtPage";
            this.txtPage.Size = new System.Drawing.Size(89, 20);
            this.txtPage.TabIndex = 0;
            this.txtPage.Text = "0";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbiNew);
            this.groupBox4.Controls.Add(this.lbiCurr);
            this.groupBox4.Controls.Add(this.lbsCurr);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(12, 238);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(268, 62);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Status";
            // 
            // lbiNew
            // 
            this.lbiNew.Location = new System.Drawing.Point(45, 42);
            this.lbiNew.Name = "lbiNew";
            this.lbiNew.Size = new System.Drawing.Size(217, 13);
            this.lbiNew.TabIndex = 5;
            this.lbiNew.Text = "iNew";
            // 
            // lbiCurr
            // 
            this.lbiCurr.Location = new System.Drawing.Point(45, 29);
            this.lbiCurr.Name = "lbiCurr";
            this.lbiCurr.Size = new System.Drawing.Size(217, 13);
            this.lbiCurr.TabIndex = 4;
            this.lbiCurr.Text = "iCurr";
            // 
            // lbsCurr
            // 
            this.lbsCurr.Location = new System.Drawing.Point(45, 16);
            this.lbsCurr.Name = "lbsCurr";
            this.lbsCurr.Size = new System.Drawing.Size(217, 13);
            this.lbsCurr.TabIndex = 3;
            this.lbsCurr.Text = "sCurr";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "iNew";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "iCurr";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "sCurr";
            // 
            // cmdGetMD5
            // 
            this.cmdGetMD5.Location = new System.Drawing.Point(12, 306);
            this.cmdGetMD5.Name = "cmdGetMD5";
            this.cmdGetMD5.Size = new System.Drawing.Size(268, 23);
            this.cmdGetMD5.TabIndex = 6;
            this.cmdGetMD5.Text = "Get MD5 sums";
            this.cmdGetMD5.UseVisualStyleBackColor = true;
            this.cmdGetMD5.Click += new System.EventHandler(this.cmdGetMD5_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 341);
            this.Controls.Add(this.cmdGetMD5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbSessID;
        private System.Windows.Forms.Button cmdLogin;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button cmdPath;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button cmdGo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPage;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbiNew;
        private System.Windows.Forms.Label lbiCurr;
        private System.Windows.Forms.Label lbsCurr;
        private System.Windows.Forms.Button cmdGetMD5;
    }
}

