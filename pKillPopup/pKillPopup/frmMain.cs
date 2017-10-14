using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pKillPopup
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern int GetForegroundWindow();
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern int GetWindowText(int hWnd, StringBuilder text, int count);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern short GetAsyncKeyState(System.Windows.Forms.Keys vKey);
        static int handle = 0;

        private void frmMain_Load(object sender, EventArgs e)
        {
            tBoot.Start();
        }
        private void tBoot_Tick(object sender, EventArgs e)
        {
            this.Visible = false;
        }
        private void tPoll_Tick(object sender, EventArgs e)
        {
            if (GetAsyncKeyState(Keys.LButton) != 0) return;
            if (GetAsyncKeyState(Keys.MButton) != 0) return;
            int hnd = GetForegroundWindow();
            if (handle != hnd)
            {
                handle = hnd;
                StringBuilder sb = new StringBuilder(256);
                if (GetWindowText(handle, sb, 256) > 0)
                {
                    string str = sb.ToString();
                    if (str == "Please purchase WinRAR license")
                        SendKeys.Send("{esc}");
                }
            }
        }
    }
}
