using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace PPS
{
    public partial class frmMain : Form
    {
        private string Playlist = "";
        private int Playfile = -1;
        private int defFadeInterval = 1000;

        [DllImport("winmm.dll")]
        private static extern long mciSendString(string strCommand, StringBuilder strReturn, int iReturnLength, IntPtr hwndCallback);
        [DllImport("user32", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        public static extern IntPtr GetForegroundWindow();

        public frmMain()
        {
            InitializeComponent();
        }
        private string FileRead(string file)
        {
            try
            {
                TextReader tr = new StreamReader(file);
                string ret = tr.ReadToEnd();
                tr.Close(); return ret;
            }
            catch
            {
                return "";
            }
        }
        public static string Split(string msg, string delim, int part)
        {
            for (int a = 0; a < part; a++)
            {
                msg = msg.Substring(msg.IndexOf(delim) + delim.Length);
            }
            if (msg.IndexOf(delim) == -1) return msg;
            return msg.Substring(0, msg.IndexOf(delim));
        }
        public static int Countword(string msg, string delim)
        {
            int ret = 0;
            while (msg.Contains(delim))
            {
                msg = msg.Substring(msg.IndexOf(delim) + delim.Length); ret++;
            }
            return ret;
        }
        
        private void MCI(string vl)
        {
            mciSendString(vl, null, 0, IntPtr.Zero);
        }
        private void mLoad(string vl)
        {
            //System.Threading.Thread.Sleep(20000);
            MCI("stop pMov");
            MCI("close pMov");
            String mTyp = vl.Substring(vl.LastIndexOf(".") + 1);
            if ((mTyp == "avi") || (mTyp == "mpg") || (mTyp == "mpeg") || (mTyp == "wmv") || (mTyp == "asf") ||
                (mTyp == "mp3") || (mTyp == "wma"))
            {
                MCI("open \"" + vl + "\" type mpegvideo alias pMov " +
                    //"parent " + dsp.Handle + " style " + 0x40000000);
                    "parent " + GetForegroundWindow() + " style " + 0x40000000);
                dsp.BackgroundImage = cmdClose.BackgroundImage;
            }
            if ((mTyp == "jpg") || (mTyp == "jpeg") || (mTyp == "bmp") || (mTyp == "gif") || (mTyp == "png"))
            {
                dsp.BackgroundImage = new Bitmap(vl) as Image;
                dsp.BackgroundImageLayout = ImageLayout.Zoom;
            }
        }
        private void mPlay()
        {
            MCI("play pMov");
            MCI("Put pMov window at 0 0 " + dsp.Width + " " + dsp.Height);
        }
        private void mStop()
        {
            MCI("stop pMov");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
            this.Width = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width;
            this.Height = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height;
            Status.Location = this.Location;
            Status.Width = this.Width;
            Status.Height = this.Height;
            dsp.Width = this.Width - 12;
            dsp.Height = this.Height - 25;

            Playlist = FileRead("Playlist.txt");
            if (Playlist == "") MessageBox.Show("Please compose the Playlist.txt file prior to the launch of PPS.");
            Log("Praetox Presentation System - " + (Countword(Playlist, "\r\n") + 1) + " files loaded.");
            lFilelist.Text = "Loaded files:\r\n¯¯¯¯¯¯¯¯¯¯\r\n" + Playlist;

            Logo.Left = (dsp.Width / 2) - (Logo.Width / 2);
            Logo.Top = (dsp.Height / 2) - (Logo.Height / 2);
            this.Show(); Application.DoEvents();
            tFade.Interval = defFadeInterval; tFade.Start();
            this.TopMost = true; this.Focus();
            Cursor.Position = new Point(Screen.PrimaryScreen.Bounds.Width,
                                        Screen.PrimaryScreen.Bounds.Height);
        }
        private void tFade_Tick(object sender, EventArgs e)
        {
            tFade.Stop(); Application.DoEvents();
            if (tFade.Interval == defFadeInterval)
            {
                Logo.Visible = true; lFilelist.Visible = true;
                for (int a = 0; a <= 100; a++)
                {
                    // 135 206 250
                    Logo.ForeColor = Color.FromArgb(135 / 100 * a, 206 / 100 * a, 250 / 100 * a);
                    lFilelist.ForeColor = Logo.ForeColor;
                    Application.DoEvents(); System.Threading.Thread.Sleep(2);
                }
                tFade.Interval = 1;
            }
            else
            {
                for (int a = 100; a >= 0; a--)
                {
                    // 135 206 250
                    Logo.ForeColor = Color.FromArgb(135 / 100 * a, 206 / 100 * a, 250 / 100 * a);
                    lFilelist.ForeColor = Logo.ForeColor;
                    Application.DoEvents(); System.Threading.Thread.Sleep(2);
                }
                Logo.Visible = false; lFilelist.Visible = false;
            }
        }
        private void Log(string vl)
        {
            Status.Text = vl;
        }
        
        private void cmdClose_KeyDown(object sender, KeyEventArgs e)
        {
            //Log(Convert.ToString(e.KeyCode));
            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.ControlKey)
            {
                tFade.Start();
            }
            if (e.KeyCode == Keys.Apps || e.KeyCode == Keys.I)
            {
                tFade.Interval = defFadeInterval; tFade_Tick(new object(), new EventArgs());
            }
            if (e.KeyCode == Keys.MediaNextTrack || e.KeyCode == Keys.Escape)
            {
                if (MessageBox.Show("Do you really want to exit?", "Confirmation", MessageBoxButtons.YesNo)
                    == DialogResult.Yes) Application.Exit();
            }
            if (e.KeyCode == Keys.MediaPlayPause || e.KeyCode == Keys.A)
            {
                Log("Playback of #" + Playfile + " started.");
                mStop();
                mLoad(Split(Playlist, "\r\n", Playfile));
                mPlay();
            }
            if (e.KeyCode == Keys.MediaStop || e.KeyCode == Keys.S)
            {
                Log("Playback stopped.");
                mStop();
            }
            if (e.KeyCode == Keys.F || e.KeyCode == Keys.W)
            {
                if (Playfile >= Countword(Playlist, "\r\n"))
                {
                    if (MessageBox.Show("Skip to start?", "Confirmation", MessageBoxButtons.YesNo)
                        == DialogResult.Yes) Playfile = -1;
                    else return;
                }
                Playfile++;
                string ThisMedia = Split(Playlist, "\r\n", Playfile);
                mLoad(ThisMedia); mPlay(); mStop();
                Log("Skipped ahead to #" + Playfile + " - " + ThisMedia);
            }
            if (e.KeyCode == Keys.B || e.KeyCode == Keys.Q)
            {
                if (Playfile <= 0)
                {
                    if (MessageBox.Show("Skip to end?", "Confirmation", MessageBoxButtons.YesNo)
                        == DialogResult.Yes) Playfile = Countword(Playlist, "\r\n") + 1;
                    else return;
                }
                Playfile--;
                string ThisMedia = Split(Playlist, "\r\n", Playfile);
                mLoad(ThisMedia); mPlay(); mStop();
                Log("Skipped back to #" + Playfile + " - " + ThisMedia);
            }
        }
    }
}