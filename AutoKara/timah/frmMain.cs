using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace timah {
    public partial class frmMain : Form {
        public frmMain() {
            InitializeComponent();
        }
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(System.Windows.Forms.Keys vKey);

        tmr sync = new tmr();
        ArrayList al = new ArrayList();
        private void ApplyTick_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Space) return;
            sync.Add(); int[] meh = sync.Get();
            TickList.Items.Add(meh[meh.Length-1]);
        }

        tmr t = new tmr(); private int lastclip = -1;
        private void tReloc_Tick(object sender, EventArgs e) {
            int lol = 0;
            if (SkewVal.Text != "") return;
            string str = Clipboard.GetText();
            if (int.TryParse(str, out lol)) {
                if (lol == lastclip) return; lol += 200;
                Clipboard.Clear(); Clipboard.SetText("" + lol);
                lastclip = lol;
            }
        }

        private void ApplyTick_Click(object sender, EventArgs e) {
            int[] wut = sync.Get();
            if (wut.Length > 0) {
                al.Add(wut);
                TickRange.Items.Add(
                    TickRange.Items.Count + 1);
            }
            TickList.Items.Clear();
            TickList.Items.Add("0");
            sync = new tmr();
            sync.Start();
        }

        private void TickRange_SelectedIndexChanged(object sender, EventArgs e) {
            TickList.Items.Clear(); TickList.Items.Add("0");
            int[] meh = (int[])al[TickRange.SelectedIndex];
            for (int a = 0; a < meh.Length; a++) {
                TickList.Items.Add(meh[a]);
            }
        }

        private void tSkew_Tick(object sender, EventArgs e) {
            if (GetAsyncKeyState(Keys.RMenu) == -32767) {
                while (GetAsyncKeyState(Keys.RMenu) != 0)
                    Application.DoEvents();
                int inc = Convert.ToInt32(SkewVal.Text);
                SendKeys.SendWait("^x"); Application.DoEvents();
                System.Threading.Thread.Sleep(100);
                int v = Convert.ToInt32(Clipboard.GetText());
                SendKeys.SendWait("" + (v + inc));
            }
        }

        private void SkewAll_Click(object sender, EventArgs e) {
            int skew = Convert.ToInt32(SkewVal.Text);
            string[] derp = Clipboard.GetText().Split(new
                string[] { KaraPre.Text }, StringSplitOptions.None);
            for (int a = 1; a < derp.Length; a++) {
                string tmp = "";
                tmp = derp[a].Substring(0, derp[a].IndexOf(","));
                derp[a] = derp[a].Substring(tmp.Length + 1);
                int v1 = Convert.ToInt32(tmp) + skew;
                tmp = derp[a].Substring(0, derp[a].IndexOf(","));
                derp[a] = derp[a].Substring(tmp.Length + 1);
                int v2 = Convert.ToInt32(tmp) + skew;
                derp[a] = KaraPre.Text + v1 +
                    "," + v2 + "," + derp[a];
            }
            string ret = "";
            for (int a = 0; a < derp.Length; a++)
                ret += derp[a]; Clipboard.Clear();
            Clipboard.SetText(ret);
        }

        private void AbsEnd_Click(object sender, EventArgs e) {
            int skew = Convert.ToInt32(SkewVal.Text);
            string[] derp = Clipboard.GetText().Split(new
                string[] { KaraPre.Text }, StringSplitOptions.None);
            for (int a = 1; a < derp.Length; a++) {
                string tmp = "";
                tmp = derp[a].Substring(0, derp[a].IndexOf(","));
                derp[a] = derp[a].Substring(tmp.Length + 1);
                int v1 = Convert.ToInt32(tmp);
                tmp = derp[a].Substring(0, derp[a].IndexOf(","));
                derp[a] = derp[a].Substring(tmp.Length + 1);
                int v2 = v1 + skew;
                derp[a] = KaraPre.Text + v1 +
                    "," + v2 + "," + derp[a];
            }
            string ret = "";
            for (int a = 0; a < derp.Length; a++)
                ret += derp[a]; Clipboard.Clear();
            Clipboard.SetText(ret);
        }

        private void KaraMake_Click(object sender, EventArgs e) {
            string ret = "";
            for (int a = 0; a < 10; a++) {
                TickList.Items.Add(9001);
            }
            int ofs = Convert.ToInt32(SkewVal.Text);
            string[] var = Clipboard.GetText().Split('|');
            long[] tck = new long[TickList.Items.Count];
            for (int a = 0; a < tck.Length; a++)
                tck[a] = Convert.ToInt32(
                    TickList.Items[a].ToString());
            for (int a = 0; a < var.Length; a++)
                ret += KaraPre.Text + (tck[a] + ofs) + "," +
                    (tck[a] + 200 + ofs) + KaraPost.Text + var[a];
            Clipboard.Clear(); Clipboard.SetText(ret);
        }

        private void TickCopy_Click(object sender, EventArgs e) {
            string ret = "";
            for (int a = 0; a < TickList.Items.Count; a++)
                ret += TickList.Items[a].ToString() + " ";
            Clipboard.Clear(); Clipboard.SetText(ret);
        }

        private void TickPaste_Click(object sender, EventArgs e) {
            TickList.Items.Clear();
            string[] vars = Clipboard.GetText().Split(' ');
            for (int a = 0; a < vars.Length; a++)
                TickList.Items.Add(vars[a]);
        }
    }
    public class tmr {
        [System.Runtime.InteropServices.DllImport("Kernel32.dll")]
        private static extern bool QueryPerformanceCounter(out double lpPerformanceCount);
        [System.Runtime.InteropServices.DllImport("Kernel32.dll")]
        private static extern bool QueryPerformanceFrequency(out double lpFrequency);
        private double l1, l2, lf; private ArrayList al = new ArrayList();

        public tmr() {
            if (QueryPerformanceFrequency(out lf) == false)
                throw new Win32Exception(); al.Clear();
        }
        public void Start() { l1 = 0; l2 = 0; QueryPerformanceCounter(out l1); }
        public double Stop() { QueryPerformanceCounter(out l2); return (l2 - l1) / lf; }
        public void Add() { al.Add(Stop()*1000); }
        public int[] Get() {
            int[] ret = new int[al.Count];
            for (int a = 0; a < ret.Length; a++)
                ret[a] = (int)Math.Round((double)al[a]);
            return ret;
        }
    }
}
