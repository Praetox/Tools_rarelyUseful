using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.ComponentModel;

namespace pIRCl
{
    class pIRCl
    {
        private Socket sck; private BackgroundWorker bwReader;
        public State CState = State.Idle;
        public string Serv = "", Nick = "", Chan = ""; int Port = -1;
        public enum State { Idle, Connecting, Waiting, Connected, Joining, Joined };

        public pIRCl()
        {
            bwReader = new BackgroundWorker();
            bwReader.DoWork += new DoWorkEventHandler(bwReader_DoWork);
            bwReader.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bwReader_RunWorkerCompleted);
        }

        private void sckSend(string vl)
        {
            if (vl.Substring(vl.Length - 1) != "\n") vl += "\r\n";
            sck.Send(Str2Byte(vl));
        }
        private void bwReader_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                byte[] bBuf = new Byte[65536];
                sck.Receive(bBuf); string l = Byte2Str(bBuf);
                string pre = "PRIVMSG #" + Chan + " :";

                for (int a = 0; a < 6; a++)
                {
                    if (l.Substring(l.Length - 1) == "\r") l = l.Substring(0, l.Length - 1);
                    if (l.Substring(l.Length - 1) == "\n") l = l.Substring(0, l.Length - 1);
                }
                if (l.IndexOf("PING :") != -1)
                {
                    string tmp = Split(Split(l, "PING :", 1), "\r\n", 0);
                    sckSend("PONG " + tmp);
                }
                if (l.IndexOf(" MODE " + Nick + " ") != -1)
                {
                    CState = State.Connected;
                }
                if (l.IndexOf(Nick + " #" + Chan + " :End of /NAMES list.") != -1)
                {
                    CState = State.Joined;
                }
            }
            catch
            {
                CState = State.Idle; return;
            }
        }

        void bwReader_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (CState != State.Idle) bwReader.RunWorkerAsync();
        }

        public void Connect(string sServ, int sPort, string sNick)
        {
            Serv = sServ; Port = sPort; Nick = sNick; CState = State.Connecting;
            BackgroundWorker bwConnect = new BackgroundWorker();
            bwConnect.DoWork += new DoWorkEventHandler(bwConnect_DoWork);
            bwConnect.RunWorkerAsync();
        }

        void bwConnect_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                sck = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                sck.Connect(Serv, Port);
                sckSend("USER pircl 0 * pirc" + "\n" + "NICK " + Nick + "\n");
                CState = State.Waiting; bwReader.RunWorkerAsync();
            }
            catch
            {
                Serv = ""; Port = -1; Nick = ""; CState = State.Idle;
            }
        }

        public bool Join(string sChan)
        {
            try
            {
                Chan = sChan;
                sckSend("JOIN #" + Chan);
                return true;
            }
            catch
            {
                Chan = ""; return false;
            }
        }

        public bool Part()
        {
            try
            {
                sckSend("PART #" + Chan);
                Chan = "";
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Say(string vl)
        {
            try
            {
                sckSend("PRIVMSG #" + Chan + " :" + vl);
                return true;
            }
            catch
            {
                return false;
            }
        }


        public static String Byte2Str(byte[] Value)
        {
            int len = 0; for (len = Value.Length; len > 0; len--) if (Value[len - 1] != 0) break;
            string ret = ""; for (int a = 0; a < len; a++) ret += (char)Value[a];
            return ret;
        }
        static byte[] Str2Byte(string Value)
        {
            byte[] ret = new byte[Value.Length];
            for (int a = 0; a < Value.Length; a++) ret[a] = (byte)Value[a];
            return ret;
        }
        public static string Split(string msg, string delim, int part)
        {
            if (msg == "" || msg == null || delim == "" || delim == null) return "";
            if (msg.IndexOf(delim) == -1) return msg;
            for (int a = 0; a < part; a++)
            {
                msg = msg.Substring(msg.IndexOf(delim) + delim.Length);
            }
            if (msg.IndexOf(delim) == -1) return msg;
            return msg.Substring(0, msg.IndexOf(delim));
        }
    }
}
