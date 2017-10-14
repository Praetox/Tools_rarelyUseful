using System;
using System.IO;
using System.Windows.Forms;

/*  pSFSplit -- Simple File Splitter, splits binary files.
 *  Copyright (C) 2009  Praetox (http://praetox.com/)
 *
 *  This program is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation, either version 3 of the License, or
 *  (at your option) any later version.
 *
 *  This program is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU General Public License for more details.
 *
 *  You should have received a copy of the GNU General Public License
 *  along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

namespace binSplit {
    public partial class frmMain : Form {
        public frmMain() {
            InitializeComponent();
        }
        const long BF = 1024 * 1024 * 8;
        long remain; long total;

        #region GUI and helper methods
        private void ginb_Click(object sender, EventArgs e) {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog(); gin.Text = ofd.FileName;
        }
        private void gGTFO_Click(object sender, EventArgs e) {
            Application.Exit();
        }
        private void tGUI_Tick(object sender, EventArgs e) {
            if (total != 0) {
                double d = 100 /
                    (double)total;
                d *= total - remain;
                ginf.Text = Math.Round
                    (d, 1) + " %";

                if (remain == 0) {
                    ginf.Text = "Done.";
                    gGTFO.Enabled = true;
                    gSTART.Enabled = true;
                    tGUI.Stop();
                }
            }
        }
        private int parsevar(string str) {
            string[] ignore = new string[]{
                ".",",","-","'","`"," "};
            for (int a = 0; a < ignore.Length; a++)
                str = str.Replace(ignore[a], "");
            return Convert.ToInt32(str);
        }
        private void closefs(FileStream fs) {
            fs.Flush();
            fs.Close();
            fs.Dispose();
        }
        #endregion

        private void gSTART_Click(object sender, EventArgs e) {

            //Lock GUI
            gGTFO.Enabled = false;
            gSTART.Enabled = false;
            ginf.Text = "Starting";
            Application.DoEvents();

            //Read options
            SplitOptions v = new SplitOptions();
            v.infile = gin.Text;
            v.basefn = gbase.Text;
            v.batch = gbatch.Checked;
            if (gopt1.Checked) v.nparts =
                parsevar(gopt1v.Text);
            if (gopt2.Checked) v.sizelim =
                parsevar(gopt2v.Text);

            //Start in separate thread (LEAVE GUI ALONE ;_;)
            System.Threading.Thread th = new System.Threading.Thread(new
                System.Threading.ParameterizedThreadStart(split));
            th.IsBackground = true; th.Start(v); tGUI.Start();
        }
        void split(object vo) {
            
            //Fetch arguments
            SplitOptions v =
                (SplitOptions)vo;

            //Read info from GUI
            string path = v.infile.Substring(0,
                v.infile.LastIndexOf("\\") + 1);

            //Open file in read-only mode
            FileStream sin = new FileStream(
                v.infile, FileMode.Open,
                FileAccess.Read);

            //Find segment length
            total = sin.Length;
            long size = total;
            if (v.nparts >= 0) {
                double count = Convert.ToDouble(v.nparts);
                size = (long)Math.Ceiling((double)size / count);
            }
            else size = v.sizelim;

            //Here goes
            int seg = 1;
            long segpos = 0;
            FileStream fout = null;
            while (true) {

                //Determine bytes left in input file
                remain = sin.Length - sin.Position;
                if (remain <= 0) break; //gtfo my loop.

                if (fout == null) {
                    //No segment open. Let's fix that.
                    fout = new FileStream(v.basefn + "." +
                        seg.ToString("d3"), FileMode.Create);
                    segpos = 0; seg++;
                }

                //Limit chunk size to lowest value
                //between segment size limit and 8MB
                long chunk = Math.Min(size - segpos, BF);

                //Limit chunk size to remaining data
                chunk = Math.Min(remain, chunk);

                //Create buffer, copy data
                byte[] buffer = new byte[chunk];
                sin.Read(buffer, 0, buffer.Length);
                fout.Write(buffer, 0, buffer.Length);

                //Segment full yet?
                segpos += buffer.Length;
                if (segpos >= size) {

                    //Close seg
                    closefs(fout);
                    fout = null;
                }
            }
            closefs(fout);
            closefs(sin);

            //Write script?
            if (v.batch) {

                //This is where I stopped caring
                //about how my code looks. Fuck yeah.
                System.IO.File.WriteAllText("merge.bat",
                    "@echo off" + "\r\n" +
                    "echo ." + "\r\n" +
                    "echo .  Merging files, please wait." + "\r\n" +
                    "echo ." + "\r\n" +
                    "copy /B " + v.basefn + ".* " +
                    v.basefn + "" + "\r\n" +
                    "echo ." + "\r\n" +
                    "echo .  Finished!" + "\r\n" +
                    "echo ." + "\r\n" +
                    "pause");
            }
        }
    }
    class SplitOptions {
        public string infile;
        public string basefn;
        public int nparts;
        public long sizelim;
        public bool batch;
        public SplitOptions() {
            infile = "";
            basefn = "";
            nparts = -1;
            sizelim = -1;
            batch = false;
        }
    }
}
