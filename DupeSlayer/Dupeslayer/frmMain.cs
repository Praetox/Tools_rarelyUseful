using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Dupeslayer
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void cmdBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fd = new FolderBrowserDialog();
            fd.ShowDialog(); string sPath = fd.SelectedPath;
            if (sPath == "") return; sPath = sPath.Replace("\\", "/");
            if (!sPath.EndsWith("/")) sPath += "/";
            txtPath.Text = sPath;
        }

        public string[] GetFiles(string sRoot, bool bRecursive, int iDepth)
        {
            if (iDepth < 3) lbFileNow.Text = sRoot;
            Application.DoEvents();
            sRoot = sRoot.Replace("\\", "/");
            if (!sRoot.EndsWith("/")) sRoot += "/";
            string[] ret = new string[0];
            string[] saFolders, saFiles;
            try
            {
                saFolders = System.IO.Directory.GetDirectories(sRoot);
                saFiles = System.IO.Directory.GetFiles(sRoot);
            }
            catch
            {
                saFiles = new string[] { "#ERROR#" };
                saFolders = new string[] { };
            }
            ret = saFiles;
            //for (int a = 0; a < ret.Length; a++)
            //{
            //    ret[a] = ret[a].Replace("\\", "/");
            //}
            for (int a = 0; a < saFolders.Length; a++)
            {
                if (bRecursive)
                {
                    string[] saAppend = GetFiles(saFolders[a], bRecursive, iDepth + 1);
                    string[] saOldRet = ret;
                    ret = new string[saOldRet.Length + saAppend.Length];
                    saOldRet.CopyTo(ret, 0);
                    saAppend.CopyTo(ret, saOldRet.Length);
                }
            }
            return ret;
        }

        private void cmdStart_Click(object sender, EventArgs e)
        {
            string[] saFile; //, hash;
            string sRoot = txtPath.Text;
            ArrayList dupes = new ArrayList();

            //////// Get all files ////////
            lbFileCount.Text = "Scanning..."; Application.DoEvents();
            saFile = GetFiles(sRoot, chkRecursive.Checked, 0);
            if (saFile[0].Length < 3) throw new Exception("No files to check!");
            for (int a = 0; a < saFile.Length; a++)
                saFile[a] = saFile[a].Substring(sRoot.Length);
            FileData[] fd = new FileData[saFile.Length];
            for (int a = 0; a < fd.Length; a++)
            {
                fd[a] = new FileData();
                //fd[a].dupe = bDupes[a];
                //fd[a].orig = saOrig[a];
                fd[a].file = saFile[a];
                //fd[a].hash = hash[a];
                //fd[a].i = a;
            }
            //Array.Sort(hash, fd);

            //////// Read stored hashes ////////
            lbFileCount.Text = "Repository (init)...";
            Application.DoEvents();
            string sRepos = sRoot + "_repository.md5";
            lbFileCount.Text = fd.Length + " / ?";
            if (System.IO.File.Exists(sRepos))
            {
                string[] saRepository = System.IO.File.ReadAllText
                    (sRepos).Replace("\r", "").Trim('\n').Split('\n');
                for (int a = 0; a < saRepository.Length; a++)
                {
                    if (a % 100 == 0)
                    {
                        lbFileNow.Text = "Repository (" + a + ")...";
                        Application.DoEvents();
                    }
                    string thFile = saRepository[a].Substring(33);
                    string thHash = saRepository[a].Substring(0, 32);
                    for (int b = 0; b < fd.Length; b++)
                        if (fd[b].file == thFile)
                            fd[b].hash = thHash;
                }
            }

            //////// Construct hashing list ////////
            int iHash = 0; //Files-to-hash count
            bool[] bHash = new bool[fd.Length];
            for (int a = 0; a < bHash.Length; a++)
                if (fd[a].hash == null ||
                    fd[a].hash.Length != 32)
                {
                    bHash[a] = true; iHash++;
                }
            lbFileCount.Text = fd.Length + " / " +
                iHash; Application.DoEvents();

            //////// Read MD5 sums ////////
            int iCur = 0; //Current file count
            for (int a = 0; a < bHash.Length; a++)
            {
                if (bHash[a])
                {
                    lbFileNow.Text = iCur + ": " + fd[a].file;
                    Application.DoEvents(); iCur++;
                    fd[a].hash = MD5File(sRoot + fd[a].file);
                }
            }

            //////// Sorting ////////
            lbFileNow.Text = "Sorting (init)...";
            Application.DoEvents();
            string[] hash = new string[fd.Length];
            for (int a = 0; a < hash.Length; a++)
                hash[a] = fd[a].hash;
            Array.Sort(hash, fd);

            //////// Find dupes ////////
            lbFileNow.Text = "Comparing (init)...";
            int iDupes = 0; Application.DoEvents();
            for (int a = 0; a < fd.Length; a++)
            {
                if (fd[a].dupe) continue;
                if (a % 100 == 0)
                {
                    lbFileNow.Text = "Comparing (" + a + ")...";
                    Application.DoEvents();
                }
                for (int b = a + 1; b < fd.Length; b++)
                {
                    if (fd[b].hash == fd[a].hash)
                    {
                        fd[b].orig = fd[a].file;
                        fd[b].dupe = true;
                        iDupes++;
                    }
                }
            }
            lbVerifiedDupes.Text = iDupes + " files";

            //////// Sorting, exporting ////////
            lbFileNow.Text = "Exporting (init)...";
            Application.DoEvents();
            StringBuilder sb = new StringBuilder();
            string sPreOrig = "."; iCur = 0;
            for (int a = 0; a < fd.Length; a++)
            {
                if (!fd[a].dupe) continue;
                if (a % 100 == 0)
                {
                    lbFileNow.Text = "Exporting (" + iCur + ")...";
                    Application.DoEvents(); iCur++;
                }
                if (fd[a].orig != sPreOrig)
                {
                    sPreOrig = fd[a].orig;
                    sb.Append("\r\necho ... " + sPreOrig + "\r\n");
                }
                sb.Append("del \"" + fd[a].file.Replace("/", "\\") + "\"\r\n");
            }
            System.IO.File.WriteAllText(sRoot +
                "_dupeslayer.bat", sb.ToString());
            
            //////// Store new repository ////////
            StringBuilder sbRepos = new StringBuilder();
            for (int a = 0; a < fd.Length; a++)
                sbRepos.Append(
                    fd[a].hash + " " +
                    fd[a].file + "\r\n");
            System.IO.File.WriteAllText
                (sRepos, sbRepos.ToString());

            lbFileNow.Text = "All done!";
        }
        public static string MD5File(string sFile)
        {
            System.IO.FileStream fs = new System.IO.FileStream(
                sFile, System.IO.FileMode.Open, System.IO.FileAccess.Read);
            byte[] bFile = new byte[fs.Length];
            fs.Read(bFile, 0, (int)fs.Length);
            fs.Close(); fs.Dispose();
            return MD5(bFile);
        }
        public static string MD5(byte[] bData)
        {
            System.Security.Cryptography.MD5CryptoServiceProvider crypt =
                new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] bRet = crypt.ComputeHash(bData);
            string ret = "";
            for (int a = 0; a < bRet.Length; a++)
                ret += bRet[a].ToString("x2");
            crypt.Clear(); return ret;
        }
    }
    class FileData
    {
        //public int i;
        public string file;
        public string hash;
        public string orig;
        public bool dupe;
    }
    public class tmr
    {
        [System.Runtime.InteropServices.DllImport("Kernel32.dll")]
        private static extern bool QueryPerformanceCounter(out long lpPerformanceCount);
        [System.Runtime.InteropServices.DllImport("Kernel32.dll")]
        private static extern bool QueryPerformanceFrequency(out long lpFrequency);
        private long l1, l2, lf;

        public tmr()
        {
            l1 = 0; l2 = 0;
            if (QueryPerformanceFrequency(out lf) == false)
                throw new Win32Exception();
        }
        public void Start()
        {
            QueryPerformanceCounter(out l1);
        }
        public void Stop()
        {
            QueryPerformanceCounter(out l2);
        }
        public double Ret
        {
            get { return (double)(l2 - l1) / (double)lf; }
        }
    }
}
