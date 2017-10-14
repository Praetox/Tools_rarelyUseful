using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GetAllFiles {
    public partial class frmMain : Form {
        public frmMain() {
            InitializeComponent();
        }
        int filesTotal = 0;
        void killMe() {
            System.Diagnostics.Process.
                GetCurrentProcess().Kill();
        }
        string[] getFiles(string root) {
            string[] ret = new string[0];
            string[] dirs = System.IO.
                Directory.GetDirectories(root);
            for (int a = 0; a < dirs.Length; a++) {
                ret = merge(ret, getFiles(dirs[a]));
            }
            string[] files = System.IO.
                Directory.GetFiles(root);
            filesTotal += files.Length;
            label.Text = "Scanning (" +
                filesTotal + " files)";
            Application.DoEvents();
            return merge(files, ret);
        }
        string[] merge(string[] a, string[] b) {
            string[] ret = new string[a.Length + b.Length];
            a.CopyTo(ret, 0); b.CopyTo(ret, a.Length);
            return ret;
        }
        void frmMain_Load(object sender, EventArgs e) {
            this.Show(); Application.DoEvents();
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog(); string root = fbd.SelectedPath;
            if (root == "") killMe();
            
            label.Text = "Scanning";
            Application.DoEvents();
            string[] files = getFiles(root);

            label.Text = "Preparing list";
            Application.DoEvents();
            StringBuilder sb = new StringBuilder();
            progress.Maximum = files.Length;
            for (int a = 0; a < files.Length; a++) {
                if (a % 10 == 0) {
                    label.Text = "Creating list";
                    progress.Value = a;
                    Application.DoEvents();
                }
                sb.Append(files[a] + "\r\n");
            }

            progress.Value = files.Length;
            label.Text = "Writing list";
            Application.DoEvents();
            System.IO.File.WriteAllText("list.txt",
                sb.ToString(), Encoding.UTF8);
            label.Text = "Finished!";
        }
    }
}
