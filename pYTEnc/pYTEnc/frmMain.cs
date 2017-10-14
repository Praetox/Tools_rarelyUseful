using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace pYTEnc
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        static bool bStopEncode = false;
        static Double dMaxSec = (10 * 60) + (59 * 1);
        //static string Reg_Path = "Software\\Praetox Technologies\\pYTEnc";
        static string myPath = Application.StartupPath;
        public static string AppDomain = "http://tox.awardspace.us/div/";
        public static string ToxDomain = "http://www.praetox.com/";

        #region Set window location
        [System.Runtime.InteropServices.DllImport("user32.dll", EntryPoint = "SetWindowPos")]
        public static extern bool SetWindowPos(
           IntPtr hWnd,            // Window handle
           int hWndInsertAfter,    // Placement-order handle
           int X,                  // Horizontal position
           int Y,                  // Vertical position
           int cx,                 // Width
           int cy,                 // Height
           uint uFlags);           // Window positioning flags
        public const int HWND_BOTTOM = 0x1;
        public const uint SWP_NOSIZE = 0x1;
        public const uint SWP_NOMOVE = 0x2;
        public const uint SWP_SHOWWINDOW = 0x40;
        public const uint SWP_HIDEWINDOW = 0x80;
        #endregion

        public static int sTick()
        {
            return (System.DateTime.Now.Hour * 60 * 60) +
                   (System.DateTime.Now.Minute * 60) +
                   (System.DateTime.Now.Second);
        }
        /*static bool Reg_DoesExist(string regPath)
        {
            try
            {
                Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser;
                key = key.OpenSubKey(regPath, true);
                long lol = key.SubKeyCount;
                return true;
            }
            catch
            {
                Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser;
                key.CreateSubKey(regPath);
                return false;
            }
        }
        static string regRead(string regName)
        {
            Reg_DoesExist(Reg_Path);
            Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser;
            key = key.OpenSubKey(Reg_Path, true);
            try
            {
                return key.GetValue(regName).ToString();
            }
            catch { return ""; }
        }
        static void regWrite(string regName, string Value)
        {
            Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser;
            key = key.OpenSubKey(Reg_Path, true);
            key.SetValue(regName, Value);
        }*/

        private void cmdFileSourceBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "Supported media types (*.avi)|*.avi";
            fd.ShowDialog();
            if (fd.FileName != "")
            {
                txtFileSource.Text = fd.FileName;
                txtFileSource.SelectionStart = txtFileSource.Text.Length;
                txtFileSource.ScrollToCaret();
                txtFileDestination.Text = fd.FileName.Substring(0, fd.FileName.Length - 4) + ".flv";
                txtFileDestination.SelectionStart = txtFileDestination.Text.Length;
                txtFileDestination.ScrollToCaret();
            }
        }

        private void cmdFileSourceLoad_Click(object sender, EventArgs e)
        {
            if (txtFileSource.Text == "") cmdFileSourceBrowse_Click(new object(), new EventArgs());
            if (txtFileSource.Text == "") return;
            System.Diagnostics.Process Mencoder = new System.Diagnostics.Process();
            Mencoder.StartInfo.FileName = myPath + "Tools\\MediaInfo.exe";
            Mencoder.StartInfo.Arguments = "\"" + txtFileSource.Text + "\"";
            Mencoder.StartInfo.RedirectStandardOutput = true;
            Mencoder.StartInfo.UseShellExecute = false;
            Mencoder.Start();
            //Mencoder.StandardOutput.Read();
            //SetWindowPos(Mencoder.MainWindowHandle, 0, 0, 0, 0, 0, SWP_HIDEWINDOW);
            string miTime = "", miWidth = "", miHeight = "";
            string mipTime = "PlayTime             : ";
            string mipWidth = "Width                : ";
            string mipHeight = "Height               : ";
            while (!Mencoder.HasExited)
            {
                string tmp = Mencoder.StandardOutput.ReadToEnd();
                if (tmp.Contains(mipTime))
                    miTime = tmp.Substring(tmp.IndexOf(mipTime) + mipTime.Length).Split('\r')[0];
                if (tmp.Contains(mipWidth))
                    miWidth = tmp.Substring(tmp.IndexOf(mipWidth) + mipWidth.Length).Split('\r')[0];
                if (tmp.Contains(mipHeight))
                    miHeight = tmp.Substring(tmp.IndexOf(mipHeight) + mipHeight.Length).Split('\r')[0];
            }
            if (miTime == "" || miWidth == "" || miHeight == "")
            {
                MessageBox.Show("Some information could not be read automatically.");
            }
            else { ddAspect.Text = "ignored"; }
            if (miTime != "")
            {
                miTime = miTime.Replace("mn ", "|").Replace("s", "");
                if (miTime.Contains("|"))
                {
                    txtMinutes.Text = miTime.Split('|')[0];
                    txtSeconds.Text = miTime.Split('|')[1];
                }
                else
                {
                    txtMinutes.Text = "0";
                    txtSeconds.Text = miTime.Split(' ')[0];
                }
            }
            else { txtMinutes.Text = ""; txtSeconds.Text = ""; }
            if (miWidth != "") { miWidth = miWidth.Replace(" pixels", ""); ddWidth.Text = miWidth; }
            else { ddWidth.Text = ""; }
            if (miHeight != "") { miHeight = miHeight.Replace(" pixels", ""); ddHeight.Text = miHeight; }
            else { ddHeight.Text = ""; }
            CalcBitrate();
        }

        private void cmdFileDestinationBrowse_Click(object sender, EventArgs e)
        {
            SaveFileDialog fd = new SaveFileDialog();
            fd.Filter = "YouTube-prepared media file (*.flv)|*.flv";
            fd.ShowDialog();
            if (fd.FileName != "")
            {
                txtFileDestination.Text = fd.FileName;
                txtFileDestination.SelectionStart = txtFileDestination.Text.Length;
                txtFileDestination.ScrollToCaret();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!myPath.EndsWith("\\")) myPath += "\\";
            /*ddAspect.SelectedIndex = 1;
            ddWidth.SelectedIndex = 5;
            ddHeight.SelectedIndex = 5;
            ddVideoRate.SelectedIndex = 5;
            txtMinutes.Text = "1";
            txtSeconds.Text = "0";*/
            ddResizeX.SelectedIndex = 5;
            ddResizeY.SelectedIndex = 5;
            ddAudioRate.SelectedIndex = 3;
            
            this.Text += Application.ProductVersion;
            string oldLogo = Logo.Text;
            Logo.Text = "Checking for updates...";
            this.Show(); Application.DoEvents();
            
            string lol = new System.Net.WebClient().DownloadString(
                AppDomain + "pYTEnc_version.php?cv=" + Application.ProductVersion);
            if (!lol.Contains("<VERSION>" + Application.ProductVersion + "</VERSION>"))
            {
                bool GetUpdate = (DialogResult.Yes == MessageBox.Show(
                    "There's a new version of pYTEnc available. Update?",
                    "Application updater", MessageBoxButtons.YesNo));
                if (GetUpdate)
                {
                    string UpdateLink = new System.Net.WebClient().DownloadString(
                        ToxDomain + "inf/pYTEnc_link.html").Split('%')[1];
                    System.Diagnostics.Process.Start(UpdateLink + "?cv=" + Application.ProductVersion);
                    Application.Exit();
                }
            }
            Logo.Text = oldLogo;

            /*string tmp = "";
            tmp = regRead("File source");
            if (tmp != "") txtFileSource.Text = tmp;
            tmp = regRead("File destination");
            if (tmp != "") txtFileDestination.Text = tmp;
            tmp = regRead("Aspect ratio");
            if (tmp != "") ddAspect.Text = tmp;
            tmp = regRead("Resolution X");
            if (tmp != "") ddWidth.Text = tmp;
            tmp = regRead("Resolution Y");
            if (tmp != "") ddHeight.Text = tmp;
            tmp = regRead("Bitrate video");
            if (tmp != "") ddVideoRate.Text = tmp;
            tmp = regRead("Bitrate audio");
            if (tmp != "") ddAudioRate.Text = tmp;
            tmp = regRead("Media length");
            if (tmp != "") { txtMinutes.Text = tmp.Split(':')[0]; txtSeconds.Text = tmp.Split(':')[1]; }
            tmp = regRead("Twopass");
            if (tmp != "") if (tmp == "False") chkTwopass.Checked = false;*/
        }

        private void ddAspect_SelectedIndexChanged(object sender, EventArgs e)
        {
            int sddWidth = ddWidth.SelectedIndex;
            int sddHeight = ddHeight.SelectedIndex;
            double dX = Convert.ToDouble(ddAspect.Text.Replace(" ", "").Split(':')[0].Replace(".", ","));
            double dY = Convert.ToDouble(ddAspect.Text.Replace(" ", "").Split(':')[1].Replace(".", ","));
            double dAspect = dX / dY; ddHeight.Items.Clear();
            for (int a = 0; a < ddWidth.Items.Count; a++)
            {
                double dTAsp = Convert.ToDouble(ddWidth.Items[a].ToString());
                ddHeight.Items.Add((dTAsp/dAspect).ToString());
            }
            ddWidth.SelectedIndex = 1; ddWidth.SelectedIndex = 2;
            ddHeight.SelectedIndex = 1; ddHeight.SelectedIndex = 2;
            ddWidth.SelectedIndex = sddWidth;
            ddHeight.SelectedIndex = sddWidth;
        }

        private void cmdCalcBitrate_Click(object sender, EventArgs e)
        {
            CalcBitrate();
        }
        private void CalcBitrate()
        {
            double n0 = Math.Floor((dMaxSec * 350) * 0.98);
            if (txtMinutes.Text == "") txtMinutes.Text = "1";
            if (txtSeconds.Text == "") txtSeconds.Text = "0";
            double n1 = (Convert.ToDouble(txtMinutes.Text) * 60) + Convert.ToDouble(txtSeconds.Text);
            double n2 = (Convert.ToDouble(ddAudioRate.Text) * n1);
            double n3 = (n0 - n2) / n1;
            if (n3 > 4000) n3 = 4000;
            ddVideoRate.Text = Math.Round(n3).ToString();
        }

        /*private void ddVideoRate_TextChanged(object sender, EventArgs e)
        {
            CalcMaxLen();
        }
        private void ddAudioRate_TextChanged(object sender, EventArgs e)
        {
            CalcMaxLen();
        }
        private void CalcMaxLen()
        {
            if (ddVideoRate.Text == "" || ddAudioRate.Text == "") return;
            double n0 = Math.Floor((dMaxSec * 350) * 0.98);
            double n1 = (Convert.ToDouble(ddVideoRate.Text) + Convert.ToDouble(ddAudioRate.Text));
            double dSec = Math.Floor(n0 / n1);
            double dMin = 0;
            while (dSec >= 60) { dMin += 1; dSec -= 60; }
            string sMin = Math.Floor(dMin).ToString();
            string sSec = Math.Floor(dSec).ToString();
            if (sMin.Length <= 1) sMin = "0" + sMin;
            if (sSec.Length <= 1) sSec = "0" + sSec;
            lblInfoLength.Text = sMin + ":" + sSec;
        }*/

        private void DoEnc(string cmd1, string cmd2, string sPass, string sLog)
        {
            System.Diagnostics.Process Mencoder = new System.Diagnostics.Process();
            Mencoder.StartInfo.FileName = myPath + "Tools/mencoder.exe";
            Mencoder.StartInfo.Arguments = cmd1 + sPass + cmd2;
            Clipboard.Clear(); Clipboard.SetText(Mencoder.StartInfo.Arguments);
            Mencoder.StartInfo.RedirectStandardOutput = true;
            Mencoder.StartInfo.UseShellExecute = false;
            Mencoder.Start();
            Mencoder.StandardOutput.Read();
            SetWindowPos(Mencoder.MainWindowHandle, 0, 0, 0, 0, 0, SWP_HIDEWINDOW);
            int Tick = sTick();
            while (!Mencoder.HasExited)
            {
                string tmp = Mencoder.StandardOutput.ReadLine();
                if (Tick != sTick())
                {
                    Tick = sTick();
                    if (tmp.Contains("f ("))
                    {
                        tmp = tmp.Replace("¤", "").Replace("f (", "¤").Replace(")", "¤").Split('¤')[1].Replace(" ", "");
                        lblStatus.Text = sLog.Replace("%p", tmp);
                    }
                }
                if (bStopEncode) Mencoder.Kill();
                Application.DoEvents(); System.Threading.Thread.Sleep(1);
            }
        }

        private void cmdEncStart_Click(object sender, EventArgs e)
        {
            //mencoder shana.avi -o shana.flv -af resample=44100:0:0 -sws 9 -vf expand=448:336 -of lavf -ovc lavc
            //-lavcopts vcodec=flv:vbitrate=1000:trell:v4mv:mv0:mbd=2:cbp:aic:cmp=3:subcmp=3:vpass=1
            //-oac mp3lame -lameopts abr:br=128:mode=3

            if (txtFileSource.Text == "")
            { cmdFileSourceLoad_Click(new object(), new EventArgs()); }
            if (txtFileSource.Text == "") 
            { MessageBox.Show("Please click \"Load file\" to select a video."); return; }
            if (txtFileDestination.Text == "") 
            { MessageBox.Show("Please select a destination for the encoded file."); return; }
            if (ddWidth.Text == "" || ddHeight.Text == "") 
            { MessageBox.Show("Please enter the source file's horizontal and vertical resolution."); return; }
            if (txtMinutes.Text == "" || txtSeconds.Text == "")
            { MessageBox.Show("Please enter the source file's length."); return; }
            if (ddVideoRate.Text == "" || ddAudioRate.Text == "")
            { MessageBox.Show("Please select the preferred compression levels (bitrates)."); return; }
            if (chkResize.Checked && (ddResizeX.Text == "" || ddResizeY.Text == ""))
            { MessageBox.Show("If you want to resize, please select preferred resolution."); return; }

            bStopEncode = false;
            double dX = Convert.ToDouble(ddWidth.Text);
            double dY = dX / ((double)4 / (double)3);
            string cmd1 =
                "\"" + txtFileSource.Text + "\" -o \"" + txtFileDestination.Text + "\"" +
                " -af resample=44100:0:0 -sws 9 -vf expand=" + dX + ":" + dY;
            if (chkResize.Checked) cmd1 += ",scale=" + ddResizeX.Text + ":" + ddResizeY.Text;
            cmd1 += " -of lavf -ovc lavc -lavcopts vcodec=flv:vbitrate=" + ddVideoRate.Text +
                ":trell:v4mv:mv0:mbd=2:cbp:aic:cmp=3:subcmp=3";
            string cmd2 =
                " -oac mp3lame -lameopts abr:br=" + ddAudioRate.Text + ":mode=3";
            Clipboard.Clear(); Clipboard.SetText(cmd1 + "\r\n\r\n" + cmd2); return;
            if (chkTwopass.Checked)
            {
                DoEnc(cmd1, cmd2, ":vpass=1", "Encoding 1st pass (1/2)  -  %p");
                DoEnc(cmd1, cmd2, ":vpass=2", "Encoding 2nd pass (2/2)  -  %p");
            }
            else
            {
                DoEnc(cmd1, cmd2, "", "Encoding 1st pass (1/1)  -  %p");
            }

            int Iterations = 0;
            while (true)
            {
                try
                {
                    byte[] FakeLen = new byte[] { 0x84, 0x9f, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };
                    System.IO.FileStream FStream =
                        new System.IO.FileStream(txtFileDestination.Text, System.IO.FileMode.Open);
                    System.IO.BinaryWriter BinWri = new System.IO.BinaryWriter(FStream);
                    //BinWri.Seek(0x36, System.IO.SeekOrigin.Begin); BinWri.Write(FakeLen);
                    BinWri.Flush(); BinWri.Close(); FStream.Dispose();
                    break;
                }
                catch { Iterations++; Application.DoEvents(); System.Threading.Thread.Sleep(100); }
            }

            lblStatus.Text = "Done!";
            System.Media.SystemSounds.Exclamation.Play();
            System.Threading.Thread.Sleep(1000);
            if (Iterations > 0) MessageBox.Show("DEBUG: Had to sleep " + Iterations + "x100 miliseconds.");
        }

        private void cmdEncStop_Click(object sender, EventArgs e)
        {
            bStopEncode = true;
        }

        private void ddResizeX_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddResizeY.SelectedIndex = ddResizeX.SelectedIndex;
        }

        private void ddResizeY_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddResizeX.SelectedIndex = ddResizeY.SelectedIndex;
        }

        private void acmdAbout_Click(object sender, EventArgs e)
        {
            Form frm = new frmAbout();
            frm.Show();
        }

        private void lnkTox_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(ToxDomain);
        }
    }
}
