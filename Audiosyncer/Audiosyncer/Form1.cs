using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Audiosyncer
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(
            System.Windows.Forms.Keys vKey);    // The keycode to poll for
        MP3 song = new MP3();
        long LastTick = 0;
        bool Newline = false;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            song.Open("Still_Alive.mp3");
        }
        private long Tick()
        {
            return System.DateTime.Now.Ticks / 10000;
        }

        private void tMain_Tick(object sender, EventArgs e)
        {
            if (GetAsyncKeyState(Keys.F12)==-32767)
            {
                song.Play(false);
                LastTick = Tick();
            }
            if (GetAsyncKeyState(Keys.F11)==-32767)
            {
                Newline = true;
            }
            if (GetAsyncKeyState(Keys.F10) == -32767)
            {
                long TTick = Tick();
                string Append = (TTick - LastTick) + "|";
                LastTick = TTick; Application.DoEvents();

                if (Newline) Append += "\r\n"; Newline = false;
                Timestamp.Text += Append;
                Timestamp.SelectionStart = Timestamp.Text.Length-1;
                Timestamp.ScrollToCaret();
            }
        }
    }
}