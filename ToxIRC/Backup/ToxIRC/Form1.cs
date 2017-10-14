using System;
using System.Data;
using System.Text;
using System.Drawing;
using System.Net.Sockets;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections.Generic;

namespace ToxIRC
{
    public partial class Form1 : Form
    {
        Socket Sck = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        public static AsyncCallback sckRecvCB;                string Nick, Chan, Pre, sLogAppend;
        string LearnDB = "\r\n" +
            "toxirc == Simple definitions database by Praetox.\r\n" +
            "url == http://www.praetox.com/\r\n" +
            "forum == http://tib.110mb.com/\r\n" + 
            "<END_OF_PREDEFINED_LIST>\r\n\r\n";

        public Form1()
        {
            InitializeComponent();
        }
        #region Standard Praetox Functions
        ///<summary>
        /// Splits msg by delim, returns bit part
        ///</summary>
        public static string Split(string msg, string delim, int part)
        {
            for (int a = 0; a < part; a++)
            {
                msg = msg.Substring(msg.IndexOf(delim) + delim.Length);
            }
            if (msg.IndexOf(delim) == -1) return msg;
            return msg.Substring(0, msg.IndexOf(delim));
        }
        ///<summary>
        /// Splits msg by delim, returns string array
        ///</summary>
        public static string[] aSplit(string msg, string delim)
        {
            int spt = 0; string[] ret = new string[Countword(msg, delim) + 1];
            while (msg.Contains(delim))
            {
                ret[spt] = msg.Substring(0, msg.IndexOf(delim)); spt++;
                msg = msg.Substring(msg.IndexOf(delim) + delim.Length);
            }
            ret[spt] = msg;
            return ret;
        }
        ///<summary>
        /// Counts occurrences of delim within msg
        ///</summary>
        public static int Countword(string msg, string delim)
        {
            int ret = 0;
            while (msg.Contains(delim))
            {
                msg = msg.Substring(msg.IndexOf(delim) + delim.Length); ret++;
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
        ///<summary>
        /// Returns system clock in seconds
        ///</summary>
        public int tck()
        {
            return (System.DateTime.Now.Hour * 60 * 60) +
                   (System.DateTime.Now.Minute * 60) +
                   (System.DateTime.Now.Second);
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
        public string FileRead(string sFile)
        {
            try
            {
                string ret = "";
                System.IO.FileStream fs = new System.IO.FileStream(sFile, System.IO.FileMode.Open);
                for (int a = 0; a < fs.Length; a++)
                {
                    ret += (char)fs.ReadByte();
                }
                fs.Close(); fs.Dispose();
                while ((ret.Substring(ret.Length - 1) == "\r") || (ret.Substring(ret.Length - 1) == "\n"))
                    ret = ret.Substring(0, ret.Length - 1);
                return ret;
            }
            catch { return ""; }
        }
        public void FileWrite(string sFile, string sVal)
        {
            System.IO.FileStream fs = new System.IO.FileStream(sFile, System.IO.FileMode.Create);
            for (int a = 0; a < sVal.Length; a++)
            {
                fs.WriteByte((byte)sVal[a]);
            }
            fs.Close(); fs.Dispose();
        }
        #endregion
        #region Conversions
        public byte[] Int2Byte(int Value)
        {
            byte[] rawbuf = BitConverter.GetBytes(Value);
            int a = 0; for (a = rawbuf.Length; a > 0; a--) if (rawbuf[a - 1] != 0) break;
            byte[] buf = new byte[a]; for (a = 0; a < buf.Length; a++) buf[a] = rawbuf[a];
            return buf;
        }
        public String Byte2Str(byte[] Value)
        {
            int len = 0; for (len = Value.Length; len > 0; len--) if (Value[len - 1] != 0) break;
            string ret = ""; for (int a = 0; a < len; a++) ret += (char)Value[a];
            //byte[] buf = new byte[a]; for (a = 0; a < buf.Length; a++) buf[a] = Value[a];
            return ret; //System.Text.Encoding.ASCII.GetString(buf);
        }
        public byte[] Str2Byte(string Value)
        {
            byte[] ret = new byte[Value.Length];
            for (int a = 0; a < Value.Length; a++) ret[a] = (byte)Value[a];
            return ret;
        }
        #endregion
        #region User-defined types
        public class sckPacket
        {
            // Constructor that takes a Socket and a client number
            public sckPacket(System.Net.Sockets.Socket socket)
            {
                m_currentSocket = socket;
            }
            public System.Net.Sockets.Socket m_currentSocket;
            // Buffer to store the data sent by the client
            public byte[] buf = new byte[16384];
        }
        #endregion

        private void Log(string vl)
        {
            if (vl.Substring(vl.Length - 1) != "\n") vl += "\r\n";
            //txtLog.Text += System.DateTime.Now.ToLongTimeString() + " " + vl;
            sLogAppend = System.DateTime.Now.ToLongTimeString() + " " + vl + sLogAppend;
        }

        private void cmdGo_Click(object sender, EventArgs e)
        {
            if (Sck.Connected) Sck.Disconnect(true);
            Nick = txtNick.Text;
            Chan = txtChan.Text;
            Pre = "PRIVMSG #" + Chan + " :";
            Sck.Connect(txtServ.Text, 6667);
            Log("Connected!");
            SckSend("USER Ptx 0 * Ptx" + "\n" +
                    "NICK " + Nick + "\n");
        }

        private void SckSend(string vl)
        {
            if (vl.Substring(vl.Length - 1) != "\n") vl += "\r\n";
            //MessageBox.Show("Sending the following message:\r\n\r\n->" + vl + "<-");
            byte[] bData = Str2Byte(vl); //System.Text.Encoding.ASCII.GetBytes(vl);
            Sck.Send(bData);
        }
        private void tReadSock_Tick(object sender, EventArgs e)
        {
            if (Sck.Connected == false) return;
            if (sckRecvCB != null) return;
            sckPacket pck = new sckPacket(Sck);
            sckRecvCB = new AsyncCallback(sckRecv);
            Sck.BeginReceive(pck.buf, 0, pck.buf.Length, SocketFlags.None, sckRecvCB, pck);
        }
        private void sckRecv(IAsyncResult prm)
        {
            sckPacket pck = (sckPacket)prm.AsyncState; sckRecvCB = null;
            string l = Byte2Str(pck.buf); //Log(l);

            for (int a = 0; a < 6; a++)
            {
                if (l.Substring(l.Length - 1) == "\r") l = l.Substring(0, l.Length - 1);
                if (l.Substring(l.Length - 1) == "\n") l = l.Substring(0, l.Length - 1);
            }
            if (l.IndexOf("PING :") != -1)
            {
                string tmp = Split(Split(l, "PING :", 1), "\r\n", 0);
                SckSend("PONG " + tmp);
                Log("Ping (" + tmp + ")");
            }
            if (l.IndexOf(" MODE " + Nick + " ") != -1)
            {
                SckSend("JOIN #" + txtChan.Text);
                Log("Joining #" + txtChan.Text + "...");
            }
            if (l.IndexOf(Nick + " #" + Chan + " :End of /NAMES list.")!=-1) Log("Connection established.");
            if (l.IndexOf(" JOIN #" + Chan) != -1)
            {
                string sNick = l.Substring(1);
                sNick = sNick.Substring(0, sNick.IndexOf("!~"));
                SckSend(Pre + "Good evening, " + sNick + ".");
            }
            if (l.IndexOf(Pre) != -1)
            {
                l = Split(l, Pre, 1);
                string ll = l.ToLower();
                if (ll.Length>=7) if (ll.Substring(0, 7) == "!learn ")
                {
                    l = l.Substring(7);
                    if (l.IndexOf(" == ") != -1)
                    {
                        string LearnCall = Split(l, " == ", 0).ToLower();
                        string LearnVal = Split(l, " == ", 1);
                        if ((LearnCall == "toxirc") || (LearnCall == "url") || 
                            (LearnCall == "forum"))
                        {
                            SckSend(Pre + "Not permitted.");
                            Log("Illegal definition attempt");
                        }
                        else
                        {
                            if (LearnDB.IndexOf("\r\n" + LearnCall + " == ") != -1)
                            {
                                string LearnDB1 = Split(LearnDB, "\r\n" + LearnCall + " == ", 0);
                                string LearnDB2 = Split(LearnDB, "\r\n" + LearnCall + " == ", 1);
                                LearnDB2 = LearnDB2.Substring(LearnDB2.IndexOf("\r\n"));
                                LearnDB = LearnDB1 + LearnDB2;
                            }
                            LearnDB += LearnCall + " == " + LearnVal + "\r\n";
                            //SckSend(Pre + "Action completed.");
                            FileWrite("learndb.txt", LearnDB);
                            Log("Defined " + LearnCall);
                        }
                    }
                    else
                    {
                        SckSend(Pre + "Parameter missing!");
                        Log("Definition failed.");
                    }
                }
                if (ll.Length>=1) if (ll.Substring(0, 1) == "?")
                {
                    string FetchCall = l.Substring(1).ToLower(), FetchVal;
                    if (LearnDB.IndexOf("\r\n" + FetchCall + " == ") != -1)
                    {
                        FetchVal = Split(Split(LearnDB, "\r\n" + FetchCall + " == ", 1), "\r\n", 0);
                        SckSend(Pre + FetchCall + " >> " + FetchVal);
                        Log("  Read " + FetchCall);
                    }
                    else
                    {
                        SckSend(Pre + "I have no definition for <" + FetchCall + ">");
                        Log("-Read " + FetchCall);
                    }
                }
            }
        }

        private void tMain_Tick(object sender, EventArgs e)
        {
            if (sLogAppend != "")
            {
                txtLog.Text = sLogAppend + txtLog.Text;
                sLogAppend = "";
            }
            if (txtLearnDB.Text != LearnDB) txtLearnDB.Text = LearnDB;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string StoredDB = FileRead("learndb.txt");
            if (StoredDB != "")
                LearnDB += Split(StoredDB, "<END_OF_PREDEFINED_LIST>\r\n\r\n", 1) + "\r\n";
        }
    }
}