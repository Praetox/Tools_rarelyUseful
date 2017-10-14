using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GendouDumper
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        public static string Template = "";
        public static string SessID = "";
        public static System.Net.WebHeaderCollection WHC;

        private void cmdPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.RootFolder = Environment.SpecialFolder.MyComputer;
            fbd.ShowDialog(); if (fbd.SelectedPath == "") return;
            string sPath = fbd.SelectedPath;
            if (!sPath.EndsWith("\\")) sPath += "\\";
            txtPath.Text = sPath;
        }

        private long Tick()
        {
            return DateTime.Now.Ticks / 10000;
        }
        private string[] Split(string s1, string s2)
        {
            return s1.Split(new string[] { s2 }, StringSplitOptions.None);
        }
        private string FileRead(string f)
        {
            string ret = "";
            try
            {
                System.IO.FileStream fs = new System.IO.FileStream(
                    f, System.IO.FileMode.Open, System.IO.FileAccess.Read);
                byte[] b = new byte[fs.Length];
                fs.Read(b, 0, (int)fs.Length);
                ret = System.Text.Encoding.UTF8.GetString(b);
                fs.Flush(); fs.Close(); fs.Dispose();
            }
            catch { }
            return ret;
        }
        private void FileWrite(string f, bool nju, string s)
        {
            System.IO.FileStream fs;
            if (nju) fs = new System.IO.FileStream(f, System.IO.FileMode.Create);
            else fs = new System.IO.FileStream(f, System.IO.FileMode.Append);
            byte[] b = System.Text.Encoding.UTF8.GetBytes(s);
            fs.Write(b, 0, b.Length);
            fs.Flush(); fs.Close(); fs.Dispose();
        }
        public string MD5File(string sFile)
        {
            System.IO.FileStream fs = new System.IO.FileStream(
                sFile, System.IO.FileMode.Open, System.IO.FileAccess.Read);
            byte[] bFile = new byte[fs.Length];
            fs.Read(bFile, 0, (int)fs.Length);
            fs.Close(); fs.Dispose();
            return MD5(bFile);
        }
        public string MD5(byte[] bData)
        {
            System.Security.Cryptography.MD5CryptoServiceProvider crypt =
                new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] bRet = crypt.ComputeHash(bData);
            string ret = "";
            for (int a = 0; a < bRet.Length; a++)
            {
                //string wat = bRet[a].ToString("x2");
                //while (wat.Length < 2) wat = "0" + wat;
                ret += bRet[a].ToString("x2"); //wat;
            }
            crypt.Clear(); return ret;
        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            WHC = new System.Net.WebHeaderCollection();
            WHC.Add("Referer", "http://gendou.com/");

            WebReq wr = new WebReq();
            wr.Request("http://gendou.com/forum/login.php", WHC,
                "name=" + txtUser.Text + "&pass=" + txtPass.Text + "&back=%2F",
                "", true);
            long ltStart = Tick();
            while (!wr.isReady)
            {
                if (ltStart + 10000 < Tick())
                {
                    lbSessID.Text = "Connection timeout";
                    return;
                }
                Application.DoEvents(); System.Threading.Thread.Sleep(10);
            }

            for (int a = 0; a < wr.Headers.Count; a++)
                if (wr.Headers.GetKey(a) == "Set-Cookie")
                {
                    string[] sVals = wr.Headers.GetValues(a);
                    for (int b = 0; b < sVals.Length; b++)
                        if (sVals[b].StartsWith("sid="))
                            SessID = sVals[b]
                                .Substring(4)
                                .Split(';')[0];
                }

            WHC.Add("Cookie", "sid=" + SessID);
            lbSessID.Text = "Session: " + SessID;
        }

        private void cmdGo_Click(object sender, EventArgs e)
        {
            int iFileSite = 0;
            int iFileLocal = 0;
            int iPage = Convert.ToInt32(txtPage.Text) - 1;
            Template = FileRead("template.html");

            while (true)
            {
                iPage++;
                lbiCurr.Text = iPage + "  -  x  -  x"; Application.DoEvents();
                WebReq wrPage = new WebReq();
                wrPage.Request("http://gendou.com/amusic/?page=" + iPage + "&rev=1&sort=0",
                    WHC, "", "", true);
                long ltPageStart = Tick();
                while (!wrPage.isReady)
                {
                    if (ltPageStart + 10000 < Tick())
                    {
                        lbsCurr.Text = "Connection timeout";
                        return;
                    }
                    Application.DoEvents(); System.Threading.Thread.Sleep(10);
                }

                string[] saTmp = Split(wrPage.Response, "<tr class=\"\">");
                for (int a = 1; a < saTmp.Length; a++)
                {
                    string sURL = Split(Split(saTmp[a], "href=\"")[1], "\">")[0]
                        .Trim(new char[] { ' ', '\t', '\r', '\n' });
                    string sTitle = Split(Split(Split(saTmp[a], "<td>")[1], "\">")[1], "</a>")[0]
                        .Trim(new char[] { ' ', '\t', '\r', '\n' });
                    string sAnime = Split(Split(Split(saTmp[a], "<td>")[2], "\">")[1], "</a>")[0]
                        .Trim(new char[] { ' ', '\t', '\r', '\n' });
                    string sArtis = Split(Split(Split(saTmp[a], "<td>")[3], "\">")[1], "</a>")[0]
                        .Trim(new char[] { ' ', '\t', '\r', '\n' });
                    string sTrTyp = Split(Split(saTmp[a], "<td>")[4], "</td>")[0]
                        .Trim(new char[] { ' ', '\t', '\r', '\n' });
                    string sTrLen = Split(Split(saTmp[a], "<td>")[5], "</td>")[0]
                        .Trim(new char[] { ' ', '\t', '\r', '\n' });
                    string sTrSiz = Split(Split(saTmp[a], "<td>")[6], "</td>")[0]
                        .Trim(new char[] { ' ', '\t', '\r', '\n' });
                    string sLyric = "";
                    if (saTmp[a].Contains("<a title=\"Romaji\""))
                        sLyric = Split(Split(Split(saTmp[a], "<td>")[7], "href=\"")[1], "\">")[0]
                         .Trim(new char[] { ' ', '\t', '\r', '\n' });

                    iFileSite++;
                    sURL = "http://gendou.com" + sURL;
                    string sExt = sURL.Split('.')[sURL.Split('.').Length - 1];
                    string sPath = sAnime
                        .Replace("\\", "[bs]").Replace("/", "[fs]").Replace(":", "[co]")
                        .Replace("|", "[pi]").Replace("*", "[as]").Replace("?", "[qm]")
                        .Replace("\"", "''").Replace("<", "[lt]").Replace(">", "[gt]");
                    sPath = txtPath.Text + sPath + "\\";
                    string sFile = (sArtis + " - " + sTitle + "." + sExt)
                        .Replace("\\", "[bs]").Replace("/", "[fs]").Replace(":", "[co]")
                        .Replace("|", "[pi]").Replace("*", "[as]").Replace("?", "[qm]")
                        .Replace("\"", "''").Replace("<", "[lt]").Replace(">", "[gt]");
                    lbsCurr.Text = sFile;
                    lbiCurr.Text = iPage + "  -  " + a + "p/" + iFileSite + "t  -  x";
                    lbiNew.Text = iFileLocal + "";
                    Application.DoEvents();

                    if (!System.IO.Directory.Exists(sPath))
                        System.IO.Directory.CreateDirectory(sPath);

                    if (!System.IO.File.Exists(sPath + sFile))
                    {
                        string[] sLyr = new string[] { "", "", "" };
                        if (sLyric != "")
                        {
                            WebReq wrLyr = new WebReq();
                            wrLyr.Request("http://gendou.com/amusic/" +
                                sLyric, WHC, "", "", true);
                            while (!wrLyr.isReady)
                            {
                                Application.DoEvents();
                                System.Threading.Thread.Sleep(10);
                            }
                            for (int iWR = 0; iWR < 3; iWR++)
                            {
                                if (wrLyr.Response.Contains("<span id=\"content_" + iWR + "\">"))
                                {
                                    sLyr[iWR] = Split(Split(wrLyr.Response,
                                        "<span id=\"content_" + iWR + "\">")[1], "</span>")[0]
                                        .Replace("\r", "").Replace("\n", "")
                                        .Replace("<br />", "<br />\r\n");
                                }
                                else
                                {
                                    sLyr[iWR] =
                                        "<span>Oh snap.</span> " +
                                        "It seems that there are no lyrics available in this language.<br><br>" +
                                        "Furthermore, it would also seem that you've lost <span>T</span>he <span>G</span>ame.";
                                }
                            }
                        }

                        iFileLocal++;
                        bool bResume = false;
                        bool bGetIt = true;
                        long wrcLength = 0;
                        long ltFileStart = 0;
                        while (bGetIt)
                        {
                            WebReq wrFile = new WebReq();
                            wrFile.Request(sURL, WHC, "", sPath + sFile, false);
                            ltFileStart = Tick();
                            while (!wrFile.isReady)
                            {
                                lbiCurr.Text = iPage + "  -  " + a + "p/" + iFileSite + "t  -  " + wrFile.Progress;
                                Application.DoEvents(); System.Threading.Thread.Sleep(500);
                            }
                            wrcLength = wrFile.cLength;
                            if (wrFile.ResponseCode == "")
                            {
                                bGetIt = false;
                                bResume = true;
                            }
                            else
                            {
                                if (wrFile.Response.Contains("#02-0004_301_<loc>") ||
                                    wrFile.Response.Contains("#02-0004_302_<loc>"))
                                {
                                    sURL = Split(Split(wrFile.Response,
                                        "<loc>")[1], "</loc>")[0];
                                    try { Uri tmpuri = new Uri(sURL); }
                                    catch { bGetIt = false; }
                                }
                                else { bGetIt = false; }
                            }
                        }

                        if (bResume)
                        {
                            string sMD5 = MD5File(sPath + sFile);
                            string sLyrPath = sPath + sFile
                                .Substring(0, sFile.Length - sExt.Length);
                            FileWrite(sLyrPath + "html", true, Template
                                .Replace("[[title]]", sTitle)
                                .Replace("[[artist]]", sArtis)
                                .Replace("[[anime]]", sAnime)
                                .Replace("[[trlen]]", sTrLen)
                                .Replace("[[trtyp]]", sTrTyp)
                                .Replace("[[fsize]]", sTrSiz + "")
                                .Replace("[[wrsize]]", wrcLength + "")
                                .Replace("[[md5sum]]", sMD5)
                                .Replace("[[lyrics1]]", sLyr[0])
                                .Replace("[[lyrics2]]", sLyr[1])
                                .Replace("[[lyrics3]]", sLyr[2]));

                            string sSep = " " + (char)990 + " ";
                            FileWrite("file_id.diz", false,
                                (sPath + sFile).Substring(txtPath.Text.Length) + "\r\n" +
                                wrcLength + sSep + sTrSiz + sSep + sTrLen + sSep + sMD5 + "\r\n\r\n");
                        }
                        else
                        {
                            FileWrite("file_er.diz", false,
                                System.DateTime.Now.ToShortDateString() + " - " +
                                System.DateTime.Now.ToLongTimeString() + " - " +
                                (sPath + sFile).Substring(txtPath.Text.Length) + "\r\n");
                        }

                        while (Tick() < ltFileStart + 11000)
                        {
                            Application.DoEvents(); System.Threading.Thread.Sleep(10);
                        }
                    }
                    if (iFileLocal >= 100) Application.Exit();
                    Application.DoEvents();
                }
            }
        }

        private void cmdGetMD5_Click(object sender, EventArgs e)
        {
            string ret = "";
            string[] wat = FileRead("file_id.diz").Replace("\r", "").Split('\n');
            for (int a = 0; a < wat.Length; a += 3)
            {
                if (wat[a] == "") break;
                string sMD5 = wat[a + 1].Substring(wat[a + 1].Length - 32);
                string sPath = wat[a]; ret += sMD5 + " *" + sPath + "\r\n";
            }
            FileWrite("sums.md5", true, ret);
        }
    }
}
