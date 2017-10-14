using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PBPMeasure
{
    public partial class Form1 : Form
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(
            System.Windows.Forms.Keys vKey);    // The keycode to poll for
        //double LastTick, BeatsTotal, DistLast, DistTotal, DistAverage, BpmLast, BpmAverage;
        double FirstTick, LastTick, BeatsTotal, DistLast, DistTotal, DistAverage, BpmLast, BpmAverage;

        public Form1()
        {
            InitializeComponent();
        }
        private long Tick()
        {
            return System.DateTime.Now.Ticks / 10000;
        }

        private void cBeat_KeyDown(object sender, KeyEventArgs e)
        {
            if (FirstTick == 0)
            {
                FirstTick = Tick(); LastTick = FirstTick;
                BeatsTotal = 1; lBeatsTotal.Text = "1"; return;
            }
            
            //BeatsTotal++; DistLast = Tick() - LastTick; LastTick = Tick();
            //DistTotal += DistLast; DistAverage = DistTotal / (BeatsTotal - (double)1);
            //BpmLast = (double)60000 / DistLast; BpmAverage = (double)60000 / DistAverage;
            double dTick = Tick(); BeatsTotal++;
            DistLast = dTick - LastTick; LastTick = Tick();
            DistTotal = (dTick - FirstTick);
            DistAverage = DistTotal / (BeatsTotal - 1);
            BpmLast = (double)60000 / DistLast;
            BpmAverage = (double)60000 / DistAverage;

            lBeatsTotal.Text = Convert.ToString(Math.Round(BeatsTotal, 3));
            lDistLast.Text = Convert.ToString(Math.Round(DistLast, 3));
            lDistTotal.Text = Convert.ToString(Math.Round(DistTotal, 3));
            lDistAverage.Text = Convert.ToString(Math.Round(DistAverage, 3));
            lBpmLast.Text = Convert.ToString(Math.Round(BpmLast, 3));
            lBpmAverage.Text = Convert.ToString(Math.Round(BpmAverage, 3));
        }

        private void cClear_Click(object sender, EventArgs e)
        {
            FirstTick = 0; LastTick = 0;
            BeatsTotal = 0; DistLast = 0; DistTotal = 0;
            DistAverage = 0; BpmLast = 0; BpmAverage = 0;
            lBeatsTotal.Text = "0"; lDistLast.Text = "0"; lDistTotal.Text = "0";
            lDistAverage.Text = "0"; lBpmLast.Text = "0"; lBpmAverage.Text = "0";
        }
    }
}