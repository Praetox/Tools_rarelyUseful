using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CopyTool
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        public static string sSrc = "";
        public static string sDst = "";
        public static bool bRPath = true;
        public static bool bMkDir = true;
        public static BackgroundWorker bwCopy;
        public static string bwsSrc = "";
        public static string bwsDst = "";
        public static bool bwsOK = true;
        public static long lTimeout = 10000;
        public static string sFailPre = "#cpFail-";

        private void cmdGo_Click(object sender, EventArgs e)
        {
            string[] saPaths = GetPaths(sSrc, true);


            string[] saExcl = txtExclude.Text.Split(new string[]{"; "},
                StringSplitOptions.RemoveEmptyEntries);
            int[] iExcl = new int[saExcl.Length];
            for (int a = 0; a < saExcl.Length; a++)
            {
                saExcl[a] = saExcl[a].ToLower();
                if (saExcl[a].EndsWith("*"))
                {
                    saExcl[a] = saExcl[a].Substring(0, saExcl[a].Length - 1);
                    iExcl[a] = 1;
                }
                else if (saExcl[a].StartsWith("*"))
                {
                    saExcl[a] = saExcl[a].Substring(1);
                    iExcl[a] = 3;
                }
                else iExcl[a] = 2;
            }


            int iDo = 0; bool[] bDo = new bool[saPaths.Length];
            for (int a = 0; a < saPaths.Length; a++)
            {
                bDo[a] = true;
                string sFile = saPaths[a].Substring(saPaths[a].LastIndexOf("/") + 1);
                sFile = sFile.ToLower();
                for (int b = 0; b < saExcl.Length; b++)
                {
                    if (iExcl[b] == 1)
                        if (sFile.StartsWith(saExcl[b]))
                            bDo[a] = false;
                    if (iExcl[b] == 2)
                        if (sFile.Contains(saExcl[b]))
                            bDo[a] = false;
                    if (iExcl[b] == 3)
                        if (sFile.EndsWith(saExcl[b]))
                            bDo[a] = false;
                }
                if (bDo[a]) iDo++;
            }
            pbFiles.Maximum = iDo;
            pbFiles.Value = 0;
            txtStatus.Text = saPaths.Length + " files  |  " + iDo + " added";


            int iCur = 0; int iOk = 0; int iFail = 0;
            for (int a = 0; a < saPaths.Length; a++)
            {
                if (bDo[a])
                {
                    iCur++; pbFiles.Value = iCur - 1;
                    double dPerc = (100/(double)iDo) * (double)(iCur - 1);
                    txtStatus.Text = iCur + " of " + iDo + " -- " + Math.Round(dPerc, 2) + "%";
                    Application.DoEvents();

                    string sPath = saPaths[a].Substring(0, saPaths[a].LastIndexOf("/") + 1);
                    string sFile = saPaths[a].Substring(sPath.Length);
                    string sRelP = sPath.Substring(sSrc.Length);
                    string sDestP = sDst;
                    if (bRPath) sDestP += sRelP;
                    string sDest = sDestP + sFile;
                    if (!System.IO.File.Exists(sDestP + sFile) &&
                        !System.IO.File.Exists(sDestP + sFailPre + sFile))
                    {
                        try
                        {
                            if (bMkDir) System.IO.Directory.
                                CreateDirectory(sDestP);
                            long lTick1 = DateTime.Now.Ticks / 10000000;
                            bwsDst = sDest;
                            bwsSrc = saPaths[a];
                            bwCopy.RunWorkerAsync();
                            while (bwCopy.IsBusy)
                            {
                                Application.DoEvents();
                                System.Threading.Thread.Sleep(1);
                            }
                            if (!bwsOK) throw new Exception();
                            long lTick2 = DateTime.Now.Ticks / 10000000;
                            if (lTick2 > lTick1 + lTimeout)
                            {
                                txtRisky.Text = sRelP + sFile + "\r\n" + txtRisky.Text;
                            }
                            else
                            {
                                txtCopied.Text = sRelP + sFile + "\r\n" + txtCopied.Text;
                            }
                            iOk++;
                        }
                        catch
                        {
                            txtFailed.Text = sRelP + sFile + "\r\n" + txtFailed.Text;
                            System.IO.FileStream fs = System.IO.File.Create(sDestP + sFailPre + sFile);
                            fs.Flush(); fs.Close(); fs.Dispose(); iFail++;
                        }
                    }
                }
                txtStatus.Text = iOk + " of " + iDo + " files copied (" + iFail + " failed)";
                pbFiles.Value = iDo;
            }
        }
        void bwCopy_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                System.IO.File.Copy(bwsSrc, bwsDst);
                bwsOK = true;
            }
            catch { bwsOK = false; }
        }
        public string[] GetPaths(string sRoot, bool bRecursive)
        {
            txtStatus.Text = "Parsing " + sRoot.Substring(sSrc.Length - 1);
            Application.DoEvents();
            sRoot = sRoot.Replace("\\", "/");
            if (!sRoot.EndsWith("/")) sRoot += "/";
            string[] ret = new string[0];
            string[] saFolders, saFiles;
            try
            {
                saFolders = SortStringArrayAlphabetically
                    (System.IO.Directory.GetDirectories(sRoot));
                saFiles = SortStringArrayAlphabetically
                    (System.IO.Directory.GetFiles(sRoot));
            }
            catch
            {
                saFiles = new string[] { "#ERROR#" };
                saFolders = new string[] { };
            }
            ret = saFiles;
            for (int a = 0; a < ret.Length; a++)
            {
                ret[a] = ret[a].Replace("\\", "/");
            }
            for (int a = 0; a < saFolders.Length; a++)
            {
                if (bRecursive)
                {
                    string[] saAppend = GetPaths(saFolders[a], bRecursive);
                    string[] saOldRet = ret;
                    ret = new string[saOldRet.Length + saAppend.Length];
                    saOldRet.CopyTo(ret, 0);
                    saAppend.CopyTo(ret, saOldRet.Length);
                }
            }
            return ret;
        }
        public string[] SortStringArrayAlphabetically(string[] vl)
        {
            string tmp = "";
            for (int a = vl.Length - 1; a >= 0; a--)
            {
                for (int b = 0; b < a; b++) //changed "b <= a" to "b < a"
                {
                    if (string.Compare(vl[b], vl[b + 1], true) > 0)
                    {
                        //Swap values
                        tmp = vl[b];
                        vl[b] = vl[b + 1];
                        vl[b + 1] = tmp;
                    }
                }
            }
            return vl;
        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            int iConW = this.Width - 32;
            txtStatus.Width = iConW;
            pbFiles.Width = iConW;
            txtCopied.Width = iConW;
            txtFailed.Width = iConW;
        }
        private void cmdSrc_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog(); if (fbd.SelectedPath == "") return;
            txtSrc.Text = fbd.SelectedPath;
        }
        private void cmdDst_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog(); if (fbd.SelectedPath == "") return;
            txtDst.Text = fbd.SelectedPath;
        }

        private void txtSrc_TextChanged(object sender, EventArgs e)
        {
            sSrc = txtSrc.Text;
            sSrc = sSrc.Replace("\\", "/");
            if (!sSrc.EndsWith("/")) sSrc += "/";
        }
        private void txtDst_TextChanged(object sender, EventArgs e)
        {
            sDst = txtDst.Text;
            sDst = sDst.Replace("\\", "/");
            if (!sDst.EndsWith("/")) sDst += "/";
        }
        private void chkRPath_CheckedChanged(object sender, EventArgs e)
        {
            bRPath = chkRPath.Checked;
        }
        private void chkMkDir_CheckedChanged(object sender, EventArgs e)
        {
            bMkDir = chkMkDir.Checked;
        }

        private void frmMain_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }
        private void frmMain_DragDrop(object sender, DragEventArgs e)
        {
            txtSrc.Text = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            bwCopy = new BackgroundWorker();
            bwCopy.DoWork += new DoWorkEventHandler(bwCopy_DoWork);
        }
    }
}
