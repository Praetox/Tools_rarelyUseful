using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace pIRCl
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        pIRCl[] IRC;

        private void cConn_Click(object sender, EventArgs e)
        {
            IRC = new pIRCl[Convert.ToInt32(tCount.Text)];
            for (int a = 0; a <= IRC.GetUpperBound(0); a++)
            {
                IRC[a] = new pIRCl();
                IRC[a].Connect(tServ.Text, Convert.ToInt32(tPort.Text), tNick.Text.Replace("%i", "" + a));
                int iDelay = Convert.ToInt32(tDelay.Text);
                long is1 = sec();
                while (is1+iDelay>sec())
                {
                    System.Threading.Thread.Sleep(1); Application.DoEvents();
                }
            }
            while (true)
            {
                bool AllDone = true; string sStates = "";
                for (int a = 0; a <= IRC.GetUpperBound(0); a++)
                {
                    sStates += a + ": " + IRC[a].CState + "\r\n";
                    if (IRC[a].CState != pIRCl.State.Connected &&
                        IRC[a].CState != pIRCl.State.Idle)
                        AllDone = false;
                }
                tStates.Text = sStates; if (AllDone) break;
                Application.DoEvents(); System.Threading.Thread.Sleep(1);
            }
        }

        private void cDconn_Click(object sender, EventArgs e)
        {
            IRC = null;
        }

        private void cJoin_Click(object sender, EventArgs e)
        {
            for (int a = 0; a <= IRC.GetUpperBound(0); a++)
            {
                IRC[a].Join(tChan.Text);
            }
        }

        private void cSpam_Click(object sender, EventArgs e)
        {
            for (int a = 0; a <= IRC.GetUpperBound(0); a++)
            {
                IRC[a].Say(tMsg.Text);
            }
        }

        private void cPart_Click(object sender, EventArgs e)
        {
            for (int a = 0; a <= IRC.GetUpperBound(0); a++)
            {
                IRC[a].Part();
            }
        }

        private long sec()
        {
            return System.DateTime.Now.Ticks / 10000000;
        }

        private void tmrStates_Tick(object sender, EventArgs e)
        {
            if (IRC != null)
            {
                string sStates = "";
                for (int a = 0; a <= IRC.GetUpperBound(0); a++)
                {
                    if (IRC[a] != null)
                    {
                        sStates += a + ": " + IRC[a].CState + "\r\n";
                    }
                }
                tStates.Text = sStates;
            }
            else
            {
                tStates.Text = "";
            }
        }
    }
}
