using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BatchRename {
    public partial class frmMain : Form {
        public frmMain() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog(); string dir = fbd.SelectedPath;
            if (dir == "") return; textBox1.Text = dir;
        }

        private void button2_Click(object sender, EventArgs e) {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Batch rename list (*.brl)|*.brl";
            sfd.InitialDirectory = textBox1.Text;
            sfd.ShowDialog(); string dir = sfd.FileName;
            if (dir == "") return; textBox2.Text = dir;
            textBox4.Text = dir;
        }

        private void button3_Click(object sender, EventArgs e) {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Batch rename list (*.brl)|*.brl";
            ofd.InitialDirectory = textBox1.Text;
            ofd.ShowDialog(); string dir = ofd.FileName;
            if (dir == "") return; textBox3.Text = dir;
        }

        private void button4_Click(object sender, EventArgs e) {
            string root = textBox1.Text;
            string[] saFiles = GetPaths(root, true);
            for (int a = 0; a < saFiles.Length; a++)
                saFiles[a] = saFiles[a]
                    .Substring(root.Length);
            int[] iNum = new int[saFiles.Length];
            for (int a = 0; a < iNum.Length; a++)
                iNum[a] = -1;

            if (textBox3.Text != "") {
                object[] vars = ParseScript(textBox3.Text);
                int[] iOF = (int[])vars[0];
                string[] saOF = (string[])vars[1];
                for (int a = 0; a < iOF.Length; a++) {
                    for (int b = 0; b < iNum.Length; b++) {
                        if (saOF[a] == saFiles[b])
                            iNum[b] = iOF[a];
                    }
                }
            }
            for (int a = 0; a < iNum.Length; a++) {
                if (iNum[a] == -1)
                    iNum[a] = GetNext(iNum);
            }
            for (int a = 0; a < iNum.Length; a++) {
                for (int b = 0; b < a; b++) {
                    if (iNum[a] == iNum[b])
                        MessageBox.Show("AW BALLS");
                }
            }
            StringBuilder sb = new StringBuilder();
            for (int a = 0; a < iNum.Length; a++)
                sb.Append(iNum[a] + " " +
                    saFiles[a] + "\r\n");
            System.IO.File.WriteAllText(
                textBox2.Text, sb.ToString());
            MessageBox.Show("Done!");
        }
        private object[] ParseScript(string path) {
            string[] saOF = System.IO.File.ReadAllText
                    (path).Replace("\r", "")
                    .Trim('\n').Split('\n');
            int[] iOF = new int[saOF.Length];
            for (int a = 0; a < iOF.Length; a++) {
                int dlm = saOF[a].IndexOf(" ");
                iOF[a] = Convert.ToInt32(saOF[a]
                    .Substring(0, dlm));
                saOF[a] = saOF[a].Substring(dlm + 1);
            }
            return new object[] { iOF, saOF };
        }
        private int GetNext(int[] iNum) {
            int iMax = 0;
            bool WholeLap = false;
            while (WholeLap == false) {
                WholeLap = true;
                for (int a = 0; a < iNum.Length; a++) {
                    if (iNum[a] == iMax) {
                        WholeLap = false;
                        iMax++;
                    }
                }
            }
            return iMax;
        }

        public static string[] GetPaths(string sRoot, bool bRecursive) {
            Application.DoEvents();
            sRoot = sRoot.Replace("\\", "/");
            if (!sRoot.EndsWith("/")) sRoot += "/";
            string[] ret = new string[0];
            string[] saFolders, saFiles;
            try {
                saFolders = System.IO.Directory.GetDirectories(sRoot);
                saFiles = System.IO.Directory.GetFiles(sRoot);
            } catch {
                saFiles = new string[] { "#ERROR#" };
                saFolders = new string[] { };
            }
            ret = saFiles;
            //for (int a = 0; a < ret.Length; a++)
            //{
            //    ret[a] = ret[a].Replace("\\", "/");
            //}
            for (int a = 0; a < saFolders.Length; a++) {
                if (bRecursive) {
                    string[] saAppend = GetPaths(saFolders[a], bRecursive);
                    string[] saOldRet = ret;
                    ret = new string[saOldRet.Length + saAppend.Length];
                    saOldRet.CopyTo(ret, 0);
                    saAppend.CopyTo(ret, saOldRet.Length);
                }
            }
            return ret;
        }

        private void button5_Click(object sender, EventArgs e) {
            string root = textBox4.Text;
            object[] vars = ParseScript(root);
            int[] iOF = (int[])vars[0];
            string[] saOF = (string[])vars[1];
            root = root.Substring(0,
                root.LastIndexOf("\\"));
            for (int a = 0; a < saOF.Length; a++) {
                string sFile = root + saOF[a];
                System.IO.File.Move(sFile,
                    root + "\\br!fn;" + iOF[a]);
            }
            MessageBox.Show("Done!");
        }

        private void button6_Click(object sender, EventArgs e) {
            string root = textBox4.Text;
            object[] vars = ParseScript(root);
            int[] iOF = (int[])vars[0];
            string[] saOF = (string[])vars[1];
            root = root.Substring(0,
                root.LastIndexOf("\\"));
            for (int a = 0; a < saOF.Length; a++) {
                string sFile = root + saOF[a];
                System.IO.File.Move(root +
                    "\\br!fn;" + iOF[a], sFile);
            }
            MessageBox.Show("Done!");
        }

        private void button7_Click(object sender, EventArgs e) {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Batch rename list (*.brl)|*.brl";
            ofd.InitialDirectory = textBox1.Text;
            ofd.ShowDialog(); string dir = ofd.FileName;
            if (dir == "") return; textBox4.Text = dir;
        }
    }
}
