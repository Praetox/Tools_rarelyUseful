namespace pIRCl
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
            this.tStates = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cDconn = new System.Windows.Forms.Button();
            this.cConn = new System.Windows.Forms.Button();
            this.tPort = new System.Windows.Forms.TextBox();
            this.tServ = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tDelay = new System.Windows.Forms.TextBox();
            this.tCount = new System.Windows.Forms.TextBox();
            this.tNick = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cPart = new System.Windows.Forms.Button();
            this.cJoin = new System.Windows.Forms.Button();
            this.tChan = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cSpam = new System.Windows.Forms.Button();
            this.tMsg = new System.Windows.Forms.TextBox();
            this.tmrStates = new System.Windows.Forms.Timer(this.components);
            this.TTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tStates
            // 
            this.tStates.Location = new System.Drawing.Point(12, 12);
            this.tStates.Multiline = true;
            this.tStates.Name = "tStates";
            this.tStates.Size = new System.Drawing.Size(120, 229);
            this.tStates.TabIndex = 0;
            this.TTip.SetToolTip(this.tStates, "Client status display.");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cDconn);
            this.groupBox1.Controls.Add(this.cConn);
            this.groupBox1.Controls.Add(this.tPort);
            this.groupBox1.Controls.Add(this.tServ);
            this.groupBox1.Location = new System.Drawing.Point(138, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 72);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Server";
            // 
            // cDconn
            // 
            this.cDconn.Location = new System.Drawing.Point(116, 43);
            this.cDconn.Name = "cDconn";
            this.cDconn.Size = new System.Drawing.Size(104, 23);
            this.cDconn.TabIndex = 3;
            this.cDconn.Text = "Disconnect";
            this.TTip.SetToolTip(this.cDconn, "Disconnect clients.");
            this.cDconn.UseVisualStyleBackColor = true;
            this.cDconn.Click += new System.EventHandler(this.cDconn_Click);
            // 
            // cConn
            // 
            this.cConn.Location = new System.Drawing.Point(6, 43);
            this.cConn.Name = "cConn";
            this.cConn.Size = new System.Drawing.Size(104, 23);
            this.cConn.TabIndex = 2;
            this.cConn.Text = "Connect";
            this.TTip.SetToolTip(this.cConn, "Connect clients.");
            this.cConn.UseVisualStyleBackColor = true;
            this.cConn.Click += new System.EventHandler(this.cConn_Click);
            // 
            // tPort
            // 
            this.tPort.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tPort.Location = new System.Drawing.Point(178, 19);
            this.tPort.Name = "tPort";
            this.tPort.Size = new System.Drawing.Size(42, 18);
            this.tPort.TabIndex = 1;
            this.tPort.Text = "6667";
            this.tPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TTip.SetToolTip(this.tPort, "The server\'s port.");
            // 
            // tServ
            // 
            this.tServ.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tServ.Location = new System.Drawing.Point(6, 19);
            this.tServ.Name = "tServ";
            this.tServ.Size = new System.Drawing.Size(166, 18);
            this.tServ.TabIndex = 0;
            this.tServ.Text = "irc.rizon.no";
            this.tServ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TTip.SetToolTip(this.tServ, "The server\'s address.");
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tDelay);
            this.groupBox2.Controls.Add(this.tCount);
            this.groupBox2.Controls.Add(this.tNick);
            this.groupBox2.Location = new System.Drawing.Point(138, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(226, 43);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "General";
            // 
            // tDelay
            // 
            this.tDelay.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tDelay.Location = new System.Drawing.Point(178, 19);
            this.tDelay.Name = "tDelay";
            this.tDelay.Size = new System.Drawing.Size(42, 18);
            this.tDelay.TabIndex = 3;
            this.tDelay.Text = "45";
            this.tDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TTip.SetToolTip(this.tDelay, "Delay (in seconds) between each connection.");
            // 
            // tCount
            // 
            this.tCount.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tCount.Location = new System.Drawing.Point(130, 19);
            this.tCount.Name = "tCount";
            this.tCount.Size = new System.Drawing.Size(42, 18);
            this.tCount.TabIndex = 2;
            this.tCount.Text = "30";
            this.tCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TTip.SetToolTip(this.tCount, "Amount of clients to connect.");
            // 
            // tNick
            // 
            this.tNick.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tNick.Location = new System.Drawing.Point(6, 19);
            this.tNick.Name = "tNick";
            this.tNick.Size = new System.Drawing.Size(118, 18);
            this.tNick.TabIndex = 1;
            this.tNick.Text = "fagno%i";
            this.tNick.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TTip.SetToolTip(this.tNick, "Nickname of connected clients. %i is the client index.");
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cPart);
            this.groupBox3.Controls.Add(this.cJoin);
            this.groupBox3.Controls.Add(this.tChan);
            this.groupBox3.Location = new System.Drawing.Point(138, 139);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(226, 48);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Channel";
            // 
            // cPart
            // 
            this.cPart.Location = new System.Drawing.Point(178, 19);
            this.cPart.Name = "cPart";
            this.cPart.Size = new System.Drawing.Size(42, 23);
            this.cPart.TabIndex = 3;
            this.cPart.Text = "Part";
            this.TTip.SetToolTip(this.cPart, "Part channel.");
            this.cPart.UseVisualStyleBackColor = true;
            this.cPart.Click += new System.EventHandler(this.cPart_Click);
            // 
            // cJoin
            // 
            this.cJoin.Location = new System.Drawing.Point(130, 19);
            this.cJoin.Name = "cJoin";
            this.cJoin.Size = new System.Drawing.Size(42, 23);
            this.cJoin.TabIndex = 2;
            this.cJoin.Text = "Join";
            this.TTip.SetToolTip(this.cJoin, "Join channel.");
            this.cJoin.UseVisualStyleBackColor = true;
            this.cJoin.Click += new System.EventHandler(this.cJoin_Click);
            // 
            // tChan
            // 
            this.tChan.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tChan.Location = new System.Drawing.Point(6, 22);
            this.tChan.Name = "tChan";
            this.tChan.Size = new System.Drawing.Size(118, 18);
            this.tChan.TabIndex = 0;
            this.tChan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TTip.SetToolTip(this.tChan, "Channel to join.");
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cSpam);
            this.groupBox4.Controls.Add(this.tMsg);
            this.groupBox4.Location = new System.Drawing.Point(138, 193);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(226, 48);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Spammer";
            // 
            // cSpam
            // 
            this.cSpam.Location = new System.Drawing.Point(130, 19);
            this.cSpam.Name = "cSpam";
            this.cSpam.Size = new System.Drawing.Size(90, 23);
            this.cSpam.TabIndex = 2;
            this.cSpam.Text = "GO GO GO !";
            this.TTip.SetToolTip(this.cSpam, "Execute spamming.");
            this.cSpam.UseVisualStyleBackColor = true;
            this.cSpam.Click += new System.EventHandler(this.cSpam_Click);
            // 
            // tMsg
            // 
            this.tMsg.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tMsg.Location = new System.Drawing.Point(6, 22);
            this.tMsg.Name = "tMsg";
            this.tMsg.Size = new System.Drawing.Size(118, 18);
            this.tMsg.TabIndex = 0;
            this.tMsg.Text = "DESU DESU DESU DESU DESU DESU DESU DESU DESU DESU DESU DESU DESU DESU DESU DESU D" +
                "ESU DESU DESU DESU DESU DESU DESU DESU DESU DESU DESU DESU DESU DESU DESU DESU D" +
                "ESU DESU DESU DESU DESU DESU DESU DESU";
            this.tMsg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TTip.SetToolTip(this.tMsg, "Message to spam.");
            // 
            // tmrStates
            // 
            this.tmrStates.Enabled = true;
            this.tmrStates.Interval = 1000;
            this.tmrStates.Tick += new System.EventHandler(this.tmrStates_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 253);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tStates);
            this.Name = "frmMain";
            this.Text = "pIRCl example";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tStates;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tPort;
        private System.Windows.Forms.TextBox tServ;
        private System.Windows.Forms.Button cDconn;
        private System.Windows.Forms.Button cConn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tCount;
        private System.Windows.Forms.TextBox tNick;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button cPart;
        private System.Windows.Forms.Button cJoin;
        private System.Windows.Forms.TextBox tChan;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button cSpam;
        private System.Windows.Forms.TextBox tMsg;
        private System.Windows.Forms.TextBox tDelay;
        private System.Windows.Forms.Timer tmrStates;
        private System.Windows.Forms.ToolTip TTip;
    }
}

