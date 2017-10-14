using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace YouTubeRipper
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        #region Conversions
        /// <summary>
        /// Returns character from ascii
        /// </summary>
        private string Chr(int id)
        {
            return Convert.ToChar(id).ToString();
        }
        /// <summary>
        /// Returns ascii from character
        /// </summary>
        private int Asc(char id)
        {
            return Convert.ToInt16(id);
        }
        /// <summary>
        /// Converts integer to byte
        /// </summary>
        public byte[] Int2Byte(int Value)
        {
            byte[] rawbuf = BitConverter.GetBytes(Value);
            int a = 0; for (a = rawbuf.Length; a > 0; a--) if (rawbuf[a - 1] != 0) break;
            byte[] buf = new byte[a]; for (a = 0; a < buf.Length; a++) buf[a] = rawbuf[a];
            return buf;
        }
        /// <summary>
        /// Converts byte to string
        /// </summary>
        public String Byte2Str(byte[] Value)
        {
            int len = 0; for (len = Value.Length; len > 0; len--) if (Value[len - 1] != 0) break;
            string ret = ""; for (int a = 0; a < len; a++) ret += (char)Value[a];
            //byte[] buf = new byte[a]; for (a = 0; a < buf.Length; a++) buf[a] = Value[a];
            return ret; //System.Text.Encoding.ASCII.GetString(buf);
        }
        /// <summary>
        /// Converts string to byte
        /// </summary>
        public byte[] Str2Byte(string Value)
        {
            byte[] ret = new byte[Value.Length];
            for (int a = 0; a < Value.Length; a++) ret[a] = (byte)Value[a];
            return ret;
        }
        /// <summary>
        /// Converts string into unicode byte array
        /// </summary>
        private byte[] CnvToAByt(string src)
        {
            int iRet = 0;
            Encoder enc = System.Text.Encoding.UTF8.GetEncoder();
            char[] buf1 = src.ToCharArray();
            byte[] buf2 = new byte[src.Length * 4];
            enc.GetBytes(buf1, 0, buf1.Length, buf2, 0, true);
            for (iRet = 0; iRet < buf2.Length; iRet++)
            {
                if (buf2[iRet] == 0) break;
            }
            byte[] ret = new byte[iRet];
            for (int a = 0; a < ret.Length; a++)
            {
                ret[a] = buf2[a];
            }
            return ret;
        }
        /// <summary>
        /// Converts unicode byte array to string
        /// </summary>
        private string CnvToStr(byte[] src)
        {
            int buf2l = 0;
            Decoder dec = System.Text.Encoding.UTF8.GetDecoder();
            char[] buf1 = new char[src.Length];
            dec.GetChars(src, 0, src.Length, buf1, 0);
            for (buf2l = 0; buf2l < buf1.Length; buf2l++)
            {
                if (buf1[buf2l] == 0) break;
            }
            char[] buf2 = new char[buf2l];
            for (int a = 0; a < buf2.Length; a++)
            {
                buf2[a] = buf1[a];
            }
            string lol = new string(buf2);
            return lol;
        }
        #endregion
        #region "Standard" functions
        ///<summary>
        /// Splits msg by delim, returns bit part
        /// Chops returned string at next instance of delim
        ///</summary>
        public static string Split(string msg, string delim, int part)
        {
            try
            {
                string ret;
                string repd = "" + (char)2449 + (char)3983 + (char)5422 + (char)7882 + (char)9003;
                msg = msg.Replace("" + (char)9376, repd);
                ret = msg.Replace(delim, "" + (char)9376).Split((char)9376)[part];
                ret = ret.Replace(repd, "" + (char)9376);
                return ret;
            }
            catch { return ""; }
        }
        ///<summary>
        /// Splits msg by delim, returns string array of all results
        ///</summary>
        public static string[] aSplit(string msg, string delim)
        {
            try
            {
                string[] ret;
                string repd = "" + (char)2449 + (char)3983 + (char)5422 + (char)7882 + (char)9003;
                msg = msg.Replace("" + (char)9376, repd);
                ret = msg.Replace(delim, "" + (char)9376).Split((char)9376);
                for (int a = 0; a < ret.Length; a++)
                {
                    ret[a] = ret[a].Replace(repd, "" + (char)9376);
                }
                return ret;
            }
            catch { return new string[1]; }
        }
        ///<summary>
        /// Splits msg by delim, returns bit part
        /// Does not chop at next instance of delim
        ///</summary>
        public static string sSplit(string msg, string delim, int part)
        {
            try
            {
                int loc = -1;
                for (int a = 0; a < part; a++)
                {
                    loc = msg.IndexOf(delim, loc + 1);
                }
                return msg.Substring(loc + delim.Length);
            }
            catch { return ""; }
        }
        /// <summary>
        /// Returns true if str only contains chars specified in vl
        /// </summary>
        public static bool OnlyContains(string str, string vl)
        {
            for (int a = 0; a < str.Length; a++)
                if (!vl.Contains("" + str[a])) return false;
            return true;
        }
        ///<summary>
        /// Converts a number (vl) into a digit-grouped string
        ///</summary>
        public static string Decimize(string vl)
        {
            string ret = ""; int spt = 0;
            while (vl.Length != 0)
            {
                if (spt == 3)
                {
                    ret = "," + ret; spt = 0;
                }
                ret = vl.Substring(vl.Length - 1, 1) + ret;
                vl = vl.Substring(0, vl.Length - 1);
                spt++;
            }
            return ret;
        }
        ///<summary>
        /// Creates a string containing vl number of spaces
        ///</summary>
        public static string Space(int vl)
        {
            string ret = "";
            for (int a = 0; a < vl; a++)
            {
                ret += " ";
            }
            return ret;
        }
        ///<summary>
        /// Removes all spaces at start and end of vl
        ///</summary>
        public static string unSpace(string vl)
        {
            string ret = vl;
            try
            {
                while (ret.Substring(0, 1) == " ")
                {
                    ret = ret.Substring(1);
                }
                while (ret.Substring(ret.Length - 1) == " ")
                {
                    ret = ret.Substring(0, ret.Length - 1);
                }
                return ret;
            }
            catch
            {
                return "";
            }
        }
        ///<summary>
        /// Removes all newlines at start and end of vl
        /// </summary>
        public static string unNewline(string vl)
        {
            try
            {
                while ((vl.Substring(0, 1) == "\r") || (vl.Substring(0, 1) == "\n"))
                {
                    vl = vl.Substring(1);
                }
                while ((vl.Substring(vl.Length - 1) == "\r") || (vl.Substring(vl.Length - 1) == "\n"))
                {
                    vl = vl.Substring(0, vl.Length - 1);
                }
                return vl;
            }
            catch
            {
                return "";
            }
        }
        ///<summary>
        /// Returns system clock in seconds
        ///</summary>
        public int sTick()
        {
            return (System.DateTime.Now.Hour * 60 * 60) +
                   (System.DateTime.Now.Minute * 60) +
                   (System.DateTime.Now.Second);
        }
        ///<summary>
        /// Returns what sTick will be after vl seconds
        ///</summary>
        public int T2A(int vl)
        {
            int ret = sTick() + vl + t2aDelay;
            if (ret > 86400) ret -= 86400;
            return ret;
        }
        ///<summary>
        /// Returns the waiting time until sTick is vl
        ///</summary>
        public int T2B(int vl)
        {
            int ret = vl - sTick();
            if (ret < 0) ret += 86400;
            if (ret > 3600) ret = 0;
            return ret;
        }
        ///<summary>
        /// Returns how many seconds sTick has passed vl
        ///</summary>
        public int T2C(int vl)
        {
            int ret = sTick() - vl;
            if (ret < 0) ret += 86400;
            if (ret > 3600) ret = 0;
            return ret;
        }
        ///<summary>
        /// Sleeps for vl seconds
        ///</summary>
        public void iSlp(int vl)
        {
            long lol = Tick();
            while (Tick() < lol + vl)
            {
                Application.DoEvents();
                System.Threading.Thread.Sleep(1);
            }
        }
        ///<summary>
        /// Returns system clock in miliseconds
        ///</summary>
        public long Tick()
        {
            return System.DateTime.Now.Ticks / 10000;
        }
        ///<summary>
        /// Returns hh:mm:ss of vl (seconds)
        ///</summary>
        public string s2ms(int vl)
        {
            int iHour = 0; int iMins = 0; int iSecs = vl;
            while (iSecs >= 60)
            {
                iSecs -= 60; iMins++;
            }
            while (iMins >= 60)
            {
                iMins -= 60; iHour++;
            }
            string sHour = Convert.ToString(iHour); sHour = Space(2 - sHour.Length).Replace(" ", "0") + sHour;
            string sMins = Convert.ToString(iMins); sMins = Space(2 - sMins.Length).Replace(" ", "0") + sMins;
            string sSecs = Convert.ToString(iSecs); sSecs = Space(2 - sSecs.Length).Replace(" ", "0") + sSecs;
            return sHour + ":" + sMins + ":" + sSecs;
        }
        /// <summary>
        /// This function returns false and makes regkey if not exist.
        /// </summary>
        private bool Reg_DoesExist(string regPath)
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
        ///<summary>
        /// Returns current date and time
        ///</summary>
        public string TDNow()
        {
            return System.DateTime.Now.ToLongDateString() + " .::. " +
                   System.DateTime.Now.ToLongTimeString();
        }
        ///<summary>
        /// Returns MD5 of vl
        ///</summary>
        public string MD5(string vl)
        {
            System.Security.Cryptography.MD5CryptoServiceProvider x = new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] bs = System.Text.Encoding.UTF8.GetBytes(vl);
            bs = x.ComputeHash(bs);
            System.Text.StringBuilder s = new System.Text.StringBuilder();
            foreach (byte b in bs)
            {
                s.Append(b.ToString("x2").ToLower());
            }
            return s.ToString();
        }
        /// <summary>
        /// Makes sure the process ends completely
        /// </summary>
        public static void pKillMe()
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }
        #endregion
        #region File and array manipulation
        /// <summary>
        /// Reads sFile, works with norwegian letters ae oo aa
        /// </summary>
        private string FileRead(string sFile)
        {
            try
            {
                System.IO.FileStream fs = new System.IO.FileStream
                    (sFile, System.IO.FileMode.Open);
                byte[] buf = new byte[fs.Length];
                fs.Read(buf, 0, Convert.ToInt32(fs.Length));
                fs.Flush(); fs.Close(); fs.Dispose();
                return CnvToStr(buf);
            }
            catch { return ""; }
        }
        /// <summary>
        /// Writes sVal to sFile, works with norwegian letters ae oo aa
        /// </summary>
        /// <param name="sFile">Target file</param>
        /// <param name="sVal">The string to write</param>
        /// <param name="bAppend">Append instead of overwrite</param>
        private void FileWrite(string sFile, string Data, bool bAppend)
        {
            byte[] buf = CnvToAByt(Data);
            System.IO.FileMode AccessType = System.IO.FileMode.Create;
            if (bAppend) AccessType = System.IO.FileMode.Append;
            System.IO.FileStream fs = new System.IO.FileStream(sFile, AccessType);
            fs.Write(buf, 0, buf.Length);
            fs.Flush(); fs.Close(); fs.Dispose();
        }
        public void FileWrite(string sFile, string sVal)
        {
            FileWrite(sFile, sVal, false);
        }
        /// <summary>
        /// Sorts vl[] alphabetically, ignores letters other than 0-9 a-z
        /// </summary>
        public string[] SortStringArrayAlphabetically(string[] vl)
        {
            for (int a = vl.GetUpperBound(0); a >= 0; a--)
            {
                for (int b = 0; b < a; b++) //changed "b <= a" to "b < a"
                {
                    if (string.Compare(vl[b], vl[b + 1], true) > 0)
                    {
                        //Swap values
                        string tmp = vl[b].ToString();
                        vl[b] = vl[b + 1];
                        vl[b + 1] = tmp;
                    }
                }
            }
            return vl;
        }
        #endregion
        private int t2aDelay = 0;

        private void cmd_Start_Click(object sender, EventArgs e)
        {
            string delimID = "watch?v=";
            string delimName1 = "<div id=\"vidTitle\">";
            string delimName2 = "<span >";
            string delimName3 = "</span>";
            string delimDesc1 = "<div  class=\"videoDescDiv expand-content\">";
            string delimDesc2 = "<span >";
            string delimDesc3 = "</span>";
            string delimKeyw1 = "<meta name=\"keywords\" content=\"";
            string delimKeyw2 = "\">\n";
            string delimRtng1 = "floatL\">Rate:</div>";
            string delimRtng2 = "</div>";
            string identStar1 = "rating icn_star_full_19x20png";
            //string identStar2 = "rating icn_star_full_19x20png";
            string delimRats1 = "defaultRatingMessage\">\n";
            string delimRats2 = "<span class=\"smallText\">";
            string delimRats3 = "</span>";
            string delimViws1 = "\"viewCount\">";
            string delimViws2 = "</span>";
            string delimAddD1 = "\"smallLabel\">Added:</span>";
            string delimAddD2 = "=\"smallText\">";
            string delimAddD3 = "</span>";
            string delimCmts1 = "\"lightLabel\">Comments:</span>";
            string delimCmts2 = "\">";
            string delimCmts3 = "</a>";
            string delimFavs1 = "\"lightLabel\">Favorited:";
            string delimFavs2 = "</span> ";
            string delimFavs3 = " time";
            string delimHons1 = "\"lightLabel\">Honors:</span>";
            string delimHons2 = "\">";
            string delimHons3 = "</a>";
            string delimLnks1 = "\"lightLabel\">Links:</span>";
            string delimLnks2 = "\">";
            string delimLnks3 = "</a>";

            string ret = "";
            string LogFile = "ytInfo_" +
                System.DateTime.Now.ToShortDateString().Replace(".", "-").Replace(":", "-") + "_" +
                System.DateTime.Now.ToLongTimeString().Replace(".", "-").Replace(":", "-") + ".txt";
            string[] URLs = txt_URLs.Text.Replace("\r", "").Split('\n');
            for (int a = 0; a < URLs.Length; a++)
            {
                this.Text = "Doing " + (a+1) + " of " + URLs.Length + "..."; Application.DoEvents();

                string sURL = URLs[a];
                string HTML = new System.Net.WebClient().DownloadString(sURL);
                string sID = Split(sURL, delimID, 1);
                string sGotV = "Yes";
                string sName = Split(Split(Split(HTML, delimName1, 1), delimName2, 1), delimName3, 0);
                string sDesc = Split(Split(Split(HTML, delimDesc1, 1), delimDesc2, 1), delimDesc3, 0);
                string sKeyw = Split(Split(HTML, delimKeyw1, 1), delimKeyw2, 0);
                string sViws = Split(Split(HTML, delimViws1, 1), delimViws2, 0);
                string sRtng = Split(Split(HTML, delimRtng1, 1), delimRtng2, 0);
                int iRtng = aSplit(sRtng, identStar1).Length - 1;
                string sAddD = Split(Split(Split(HTML, delimAddD1, 1), delimAddD2, 1), delimAddD3, 0);
                string sRats = Split(Split(Split(HTML, delimRats1, 1), delimRats2, 1), delimRats3, 0);
                string sCmts = Split(Split(Split(HTML, delimCmts1, 1), delimCmts2, 1), delimCmts3, 0);
                string sFavs = Split(Split(Split(HTML, delimFavs1, 1), delimFavs2, 1), delimFavs3, 0);
                string sHons = Split(Split(Split(HTML, delimHons1, 1), delimHons2, 1), delimHons3, 0);
                string sLnks = Split(Split(Split(HTML, delimLnks1, 1), delimLnks2, 1), delimLnks3, 0);

                if (!System.IO.File.Exists(sID + ".flv")) sGotV = "No <--- <--- <--- <--- <---";
                if (!sRats.Contains(" rating")) sRats = "0 ratings";
                sRats = sRats.Split(' ')[0];

                ret += "<~~~~~~~~~~< " + sName + " >~~~~~~~~~~>" + "\r\n" +
                    "URL:         " + sURL + "\r\n" +
                    "Got video:   " + sGotV + "\r\n" +
                    "Description: " + sDesc + "\r\n" +
                    "Keywords:    " + sKeyw + "\r\n" +
                    "Added date:  " + sAddD + "\r\n" +
                    "Rating val:  " + iRtng + "\r\n" +
                    "Rating cnt:  " + sRats + "\r\n" +
                    "Views:       " + sViws + "\r\n" +
                    "Comments:    " + sCmts + "\r\n" +
                    "Favourites:  " + sFavs + "\r\n" +
                    "Honors:      " + sHons + "\r\n" +
                    "Links:       " + sLnks + "\r\n" +
                    "\r\n";
            }
            FileWrite(LogFile, ret);
            this.Text = "Done!";
        }
    }
}
