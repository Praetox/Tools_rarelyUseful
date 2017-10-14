using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace thlmcepTools {
    partial class frmWait : Form {
        public frmWait() {
            InitializeComponent();
        }
        public string msg = "Please wait";
        private void frmWait_Load(object sender, EventArgs e) {
            this.Opacity = 0;
            this.Visible = false;
            this.TopMost = true;
            Timer t = new Timer(); t.Interval = 500;
            t.Tick += delegate(object lol, EventArgs wut) {
                a.Text = msg;
            }; t.Start();
        }
        public void vis() {
            this.Opacity = 0;
            this.Visible = true;
            for (double a = 0; a < 1; a+=0.1) {
                this.Opacity = a;
                Application.DoEvents();
                System.Threading.Thread.Sleep(10);
            }
        }
        public void invis() {
            for (double a = 0.9; a > 0; a-=0.1) {
                this.Opacity = a;
                Application.DoEvents();
                System.Threading.Thread.Sleep(10);
            }
            this.Visible = false;
        }
    }
}
