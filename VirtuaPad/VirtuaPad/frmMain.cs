using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VirtuaPad
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(int vKey); //System.Windows.Forms.Keys vKey);
        #region File manipulation
        /// <summary>
        /// Reads sFile, works with norwegian letters ae oo aa
        /// </summary>
        public string FileRead(string sFile)
        {
            try
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(sFile, Encoding.GetEncoding("iso-8859-1"));
                string ret = sr.ReadToEnd();
                while ((ret.Substring(ret.Length - 1) == "\r") || (ret.Substring(ret.Length - 1) == "\n"))
                    ret = ret.Substring(0, ret.Length - 1);
                sr.Close(); sr.Dispose(); return ret;
            }
            catch { return ""; }
        }
        /// <summary>
        /// Writes sVal to sFile, works with norwegian letters ae oo aa
        /// </summary>
        /// <param name="sFile"></param>
        /// <param name="sVal"></param>
        public void FileWrite(string sFile, string sVal)
        {
            System.IO.FileStream fs = new System.IO.FileStream(sFile, System.IO.FileMode.Create);
            System.IO.StreamWriter sw = new System.IO.StreamWriter(fs, Encoding.GetEncoding("iso-8859-1"));
            sw.Write(sVal); sw.Close(); sw.Dispose();
        }
        #endregion
        LabelArray lInf; public static Label lInfClicked;       public static int lInfClickedNum;
        PBoxArray pGlow; public static PictureBox pGlowClicked; public static int pGlowClickedNum;
        PanelArray pPad; public static Panel pPadClicked;       public static int pPadClickedNum;
        char[] phKeys = { '1', '2', '3', '4', 'Q', 'W', 'E', 'R', 'A', 'S', 'D', 'F', 'Z', 'X', 'C', 'V' };
        string[] Paths; MP3[] Sfx; int[] aiFade; string Root;
        string ptAppInfo = "http://nordic.awardspace.com/VirtuaPad.php";
        
        private void frmMain_Load(object sender, EventArgs e)
        {
            #region Update checker and template downloader
            string strError = "VirtuaPad could not check for new versions!";
            try
            {
                string wcRaw = new System.Net.WebClient().DownloadString(ptAppInfo);
                if (wcRaw.IndexOf("<version>") == -1)
                {
                    MessageBox.Show(strError);
                }
                else
                {
                    if (wcRaw.IndexOf("<version>" + Application.ProductVersion + "</version>") == -1)
                    {
                        MessageBox.Show("There is a new version available on my website.\r\n" +
                                        "Please re-download VirtuaPad if you want to update.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(strError + "\r\n\r\n" + "Specific error:\r\n" + ex.Message);
            }
            #endregion
            Root = InputBox.Show("Enter the name of the samples folder you wish to use.",
                                 "Samples chooser", "Demo_03").Text + "/";
            string raw = FileRead(Root + "_config.txt").Replace("\r", "");
            if (raw == "")
            {
                MessageBox.Show("Could not find a valid _config.txt file!"); Application.Exit(); return;
            }
            this.Text = "VirtuaPad ~ v" + Application.ProductVersion + " ~ " +
                        raw.Substring(0, raw.IndexOf("\n"));
            raw = raw.Substring(raw.IndexOf("\n") + 1);
            while (raw.IndexOf("\n\n")!=-1) raw = raw.Replace("\n\n", "\n");
            while (raw.StartsWith("\n")) raw = raw.Substring(1);
            while (raw.EndsWith("\n")) raw = raw.Substring(0, raw.Length - 1);
            Paths = raw.Split('\n');

            lInf = new LabelArray(this); pGlow = new PBoxArray(this); pPad = new PanelArray(this);
            for (int y = 1; y <= 4; y++)
            {
                for (int x = 1; x <= 4; x++)
                {
                    int aThis = ControlIntFromXY(x, y);
                    pGlow.NewPBox(); pPad.NewPanel(); lInf.NewLabel();
                    pGlow[aThis].Size = new Size(124, 124);
                    pGlow[aThis].Location = new Point(((x * 130) - 130) + 12, ((y * 130) - 130) + 63);
                    pGlow[aThis].BackColor = Color.FromArgb(0, 60, 125);
                    pGlow[aThis].BackgroundImage = picGlow2.Image;
                    pGlow[aThis].Controls.Add(pPad[aThis]);
                    pPad[aThis].Size = new Size(100, 100);
                    pPad[aThis].Location = new Point(12, 12);
                    pPad[aThis].BackColor = Color.Transparent;
                    pPad[aThis].Controls.Add(lInf[aThis]);
                    lInf[aThis].AutoSize = false; lInf[aThis].Size = new Size(90, 90);
                    lInf[aThis].Location = new Point(5, 5);
                    lInf[aThis].BackColor = Color.Transparent;
                    lInf[aThis].ForeColor = Color.FromArgb(0, 0, 0);
                    lInf[aThis].Text = HotkeyFromControlInt(aThis) + "\r\n\r\n" + Paths[aThis];
                    lInf[aThis].TextAlign = ContentAlignment.MiddleCenter;
                    pGlow[aThis].BringToFront(); pPad[aThis].BringToFront(); lInf[aThis].BringToFront();
                }
            }
            aiFade = new int[Paths.GetUpperBound(0)+1];
            Sfx = new MP3[Paths.GetUpperBound(0)+1];
            for (int a = 0; a <= Sfx.GetUpperBound(0); a++)
            {
                Sfx[a] = new MP3();
                Sfx[a].Open(a, Root + Paths[a] + ".wav");
                aiFade[a] = 10 + (a * 4);
            }
            tHotkeys.Start(); tPadFader.Start();
        }

        private int ControlIntFromXY(int x, int y)
        {
            return ((y * 4) - 4) + x - 1;
        }
        private Point XYFromControlInt(int ind)
        {
            return new Point((ind / 4), ind - (ind / 4));
        }
        private int ControlIntFromHotkey(char chr)
        {
            for (int a = 0; a <= phKeys.GetUpperBound(0); a++)
            {
                if (chr == phKeys[a]) return phKeys[a];
            }
            return '-';
        }
        private char HotkeyFromControlInt(int num)
        {
            return phKeys[num];
        }

        private void tHotkeys_Tick(object sender, EventArgs e)
        {
            if (!this.Focused) return;
            for (int a = 0; a <= phKeys.GetUpperBound(0); a++)
                if (GetAsyncKeyState((int)phKeys[a]) == -32767)
                {
                    Sfx[a].Play(a, false); pGlow[a].BackgroundImage = picGlow2.Image; aiFade[a] = 10;
                }
        }

        private void tPadFader_Tick(object sender, EventArgs e)
        {
            for (int a = 0; a <= Paths.GetUpperBound(0); a++)
            {
                if (aiFade[a] > 0)
                {
                    aiFade[a]--;
                    if (aiFade[a] == 0) pGlow[a].BackgroundImage = picGlow1.Image;
                }
            }
        }
    }
}