using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace thlmcepTools {
    public partial class frmMain : Form {
        public frmMain() {
            InitializeComponent();
        }
        const string defExtract = "(just ignore this field for now)";
        const string defUpgrade = "(directory containing all the files from the old torrent)";

        //Helper methods
        private frmWait frmw = new frmWait();
        private void lockMe() {
            frmw.vis(); this.Enabled = false;
            Application.DoEvents();
        }
        private void unlockMe() {
            frmw.invis(); this.Enabled = true;
            Application.DoEvents(); this.Focus();
        }
        private void frmMain_Load(object sender, EventArgs e) {
            //lockMe(); unlockMe();
            if (!System.IO.File.Exists("7z.exe")) {
                MessageBox.Show("Please extract the tools archive first!");
                System.Diagnostics.Process.GetCurrentProcess().Kill();
            }
            extract_src.Text = defExtract;
            upgrade_src.Text = defUpgrade;
            string[] scr = System.IO.Directory.GetFiles(".", "*.usc");
            Array.Sort(scr); Array.Reverse(scr);
            for (int a = 0; a < scr.Length; a++) {
                scr[a] = scr[a].Substring(2);
                scr[a] = scr[a].Substring(0,
                    scr[a].LastIndexOf(".usc"));
                upgrade_scr.Items.Add(scr[a]);
            }
            if (upgrade_scr.Items.Count > 0)
                upgrade_scr.SelectedIndex = 0;
        }
        private string guiPath(string root) {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (root == "") root = Application.StartupPath;
            fbd.SelectedPath = root; fbd.ShowDialog();
            return fbd.SelectedPath;
        }
        private string guiMkFile(string root) {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Directory trees (*.dc3)|*.dc3";
            if (root == "") root = Application.StartupPath;
            sfd.InitialDirectory = root; sfd.ShowDialog();
            sfd.OverwritePrompt = true;
            return sfd.FileName;
        }
        private string guiOpFile(string root) {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Directory trees (*.dc3)|*.dc3";
            if (root == "") root = Application.StartupPath;
            ofd.InitialDirectory = root; ofd.ShowDialog();
            return ofd.FileName;
        }

        //Multi-album directories
        private void Polydir_srcB_Click(object sender, EventArgs e) {
            string path = guiPath(Move_src.Text);
            if (path == "") return;
            Polydir_src.Text = path;
            Move_src.Text = path;
            Treegen_src.Text = path;
            szEnc_src.Text = path + "\\" + Treegen_dst.Text;
        }
        private void Polydir_GO_Click(object sender, EventArgs e) {
            lockMe(); Recurser rc = new Recurser();
            string src = Polydir_src.Text.Trim('\\', '/');
            string[] mask = Polydir_flt.Text.Split(';');
            for (int a = 0; a < mask.Length; a++)
                mask[a] = mask[a].Trim();
            rc.parse(src, mask);
            //string[] files = rc.getFiles();
            string ret = "\n";
            string[] dirs = rc.getFiles();

            StringBuilder sb = new StringBuilder();
            for (int a = 0; a < dirs.Length; a++)
                sb.Append(dirs[a] + "\r\n");
            System.IO.File.WriteAllText("flist.txt",
                sb.ToString(), Encoding.UTF8);

            if (dirs.Length > 1 || dirs[0] != "") {
                for (int a = 0; a < dirs.Length; a++)
                    dirs[a] = dirs[a].Substring(0,
                        dirs[a].LastIndexOf("\\"));
                for (int a = 0; a < dirs.Length; a++) {
                    for (int b = 0; b < a; b++) {
                        if (dirs[a] == dirs[b] &&
                            !ret.Contains("\n" +
                            dirs[a] + "\n")) {
                            ret += dirs[a] + "\n";
                        }
                    }
                }
                ListBox lb = new ListBox();
                string[] itens = ret.Trim('\n').Split('\n');
                for (int a = 0; a < itens.Length; a++)
                    lb.Items.Add(itens[a]);
                lb.MouseDoubleClick += delegate(object lol, MouseEventArgs wut) {
                    int i = lb.IndexFromPoint(wut.Location);
                    System.Diagnostics.Process.Start("explorer",
                        "\"" + Polydir_src.Text + "\\" +
                        lb.Items[i].ToString() + "\"");
                };
                lb.Dock = DockStyle.Fill;
                Form frm = new Form();
                frm.Size = new Size(640, 480);
                frm.StartPosition =
                    FormStartPosition
                    .CenterScreen;
                frm.Controls.Add(lb);
                frm.Show();
            }
            unlockMe();
        }

        //File moving
        private void Move_srcB_Click(object sender, EventArgs e) {
            string path = guiPath(Move_src.Text);
            if (path == "") return;
            Move_src.Text = path;
            Treegen_src.Text = path;
            szEnc_src.Text = path + "\\" + Treegen_dst.Text;
        }
        private void Move_dstB_Click(object sender, EventArgs e) {
            string sOld = Move_dst.Text;
            if (sOld == "") sOld = Move_src.Text;
            string path = guiPath(sOld);
            if (path == "") return;
            Move_dst.Text = path;
        }
        private void Move_GO_Click(object sender, EventArgs e) {
            lockMe();
            string root = Move_src.Text.Trim('\\','/');
            string target = Move_dst.Text.Trim('\\','/');
            string[] mask = Move_flt.Text.Split(';');
            for (int a = 0; a < mask.Length; a++)
                mask[a] = mask[a].Trim();
            string[] files = null;
            if (Move_srcC.Checked) {
                files = System.IO.File.ReadAllText("flist.txt",
                    Encoding.UTF8).Replace("\r", "").Trim('\n')
                    .Split('\n');
            }
            else {
                Recurser rc = new Recurser();
                rc.parse(root, mask);
                files = rc.getFiles();
            }
            for (int a = 0; a < files.Length; a++) {
                MoveRel(root, files[a], target);
            }
            unlockMe();
        }
        private bool MoveRel(string root, string relFrom, string target) {
            relFrom = "\\" + relFrom;
            string reldir = relFrom.Substring
                (0, relFrom.LastIndexOf("\\"));
            System.IO.Directory.CreateDirectory(target + reldir);
            try { System.IO.File.Move(root + relFrom, target + relFrom); return true; }
            catch { MessageBox.Show("File not found:\r\n" + relFrom); }
            return false;
        }
        private bool MoveLoc(string root, string relFrom, string relTo) {
            relTo = "\\" + relTo;
            relFrom = "\\" + relFrom;
            string reldir = relTo.Substring
                (0, relTo.LastIndexOf("\\"));
            System.IO.Directory.CreateDirectory(root + reldir);
            if (System.IO.File.Exists(root + relTo))
                System.IO.File.Delete(root + relTo);
            try {
                if (System.IO.File.Exists(root + relFrom)) {
                    System.IO.File.Move(root + relFrom,
                        root + relTo); return true;
                }
                if (System.IO.Directory.Exists(root + relFrom)) {
                    System.IO.Directory.Move(root + relFrom,
                        root + relTo); return true;
                }
            }
            catch { }
            MessageBox.Show("File not found:\r\n" +
                relFrom); return false;
        }

        //Tree generation
        private void Treegen_srcB_Click(object sender, EventArgs e) {
            string path = guiPath(Treegen_src.Text);
            if (path == "") return;
            Treegen_src.Text = path;
            szEnc_src.Text = path + "\\" + Treegen_dst.Text;
        }
        private void Treegen_GO_Click(object sender, EventArgs e) {
            lockMe(); Recurser rc = new Recurser();
            string src = Treegen_src.Text.Trim('\\', '/');
            string dst = Treegen_dst.Text.Trim('\\','/');
            string[] mask = Treegen_flt.Text.Split(';');
            for (int a = 0; a < mask.Length; a++)
                mask[a] = mask[a].Trim();
            rc.parse(src, mask);
            string dirs = rc.getPaths();
            System.IO.File.WriteAllText(src +
                "\\" + dst, dirs, Encoding.UTF8);
            unlockMe();
        }

        //Compress to zip
        private void szEnc_srcB_Click(object sender, EventArgs e) {
            string path = guiOpFile(szEnc_src.Text);
            if (path == "") return;
            szEnc_src.Text = path;
        }
        private void szEnc_GO_Click(object sender, EventArgs e) {
            lockMe();
            string sevZ = Environment.GetEnvironmentVariable("temp") + "\\7z.exe";
            System.IO.File.Copy(Application.StartupPath + "\\7z.exe", sevZ, true);
            string root = szEnc_src.Text;
            string[] dirs = System.IO.File.ReadAllText(root)
                .Replace("\r", "").Trim('\n').Split('\n');
            root = root.Substring(0, root.LastIndexOf("\\"));
            for (int a = 0; a < dirs.Length; a++) {
                frmw.msg = "Archiving" + "\r\n" +
                    "------------" + "\r\n" +
                    (a+1) + " of " + dirs.Length;

                dirs[a] = root + "\\" + dirs[a];
                string batch = dirs[a] + "\\ignoreme.bat";
                System.IO.File.WriteAllText(batch,
                    szEnc_parm.Text + "\r\n" +
                    "del ignoreme.bat");
                System.Diagnostics.Process prc =
                    new System.Diagnostics.Process();
                prc.StartInfo.FileName = batch;
                prc.StartInfo.WorkingDirectory = dirs[a];
                prc.StartInfo.UseShellExecute = true;
                prc.Start();
                while (System.IO.File.Exists(batch)) {
                    System.Threading.Thread.Sleep(200);
                    Application.DoEvents();
                }
                if (szEnc_reMov.Checked) {
                    //System.Threading.Thread.Sleep(500);
                    string zName = dirs[a].Substring
                        (dirs[a].LastIndexOf("\\")+1);
                    string zPath = dirs[a].Substring
                        (0, dirs[a].LastIndexOf("\\"));
                    System.IO.File.Move(dirs[a] + "\\loldongs.zip",
                        zPath + "\\" + zName + ".zip");
                }
            }
            unlockMe();
        }

        //Extract from zip
        private void extract_srcB_Click(object sender, EventArgs e) {
            string path = guiPath(Move_src.Text);
            if (path == "") return;
            extract_src.Text = path;
        }
        private void extract_GO_Click(object sender, EventArgs e) {
            lockMe();
            string sevZ = Environment.GetEnvironmentVariable("temp") + "\\7z.exe";
            System.IO.File.Copy(Application.StartupPath + "\\7z.exe", sevZ, true);
            string root = extract_src.Text;
            if (root == defExtract) root =
                Application.StartupPath;
            Recurser rc = new Recurser();
            rc.parse(root, new string[]{"*.zip"});
            string[] zips = rc.getFiles();

            for (int a = 0; a < zips.Length; a++) {
                frmw.msg = "Extracting" + "\r\n" +
                    "------------" + "\r\n" +
                    (a + 1) + " of " + zips.Length;

                zips[a] = root + "\\" + zips[a];
                string dir = zips[a].Substring(0, zips[a].Length - 4);
                System.IO.Directory.CreateDirectory(dir);
                System.IO.File.Move(zips[a], dir + "\\tmp_rena.zip");

                string batch = dir + "\\ignoreme.bat";
                System.IO.File.WriteAllText(batch,
                    szDec_parm.Text + "\r\n" +
                    "del ignoreme.bat");
                System.Diagnostics.Process prc =
                    new System.Diagnostics.Process();
                prc.StartInfo.FileName = batch;
                prc.StartInfo.WorkingDirectory = dir;
                prc.StartInfo.UseShellExecute = true;
                if (!extract_dbg.Checked)
                    prc.StartInfo.WindowStyle = System.
                        Diagnostics.ProcessWindowStyle.Hidden;
                prc.Start();

                while (System.IO.File.Exists(batch)) {
                    System.Threading.Thread.Sleep(200);
                    Application.DoEvents();
                }
                System.IO.File.Move(dir +
                    "\\tmp_rena.zip", zips[a]);
            }
            unlockMe();
        }

        //Upgrade from prev. cottont
        private void upgrade_srcB_Click(object sender, EventArgs e) {
            string sel = upgrade_src.Text;
            if (sel == defUpgrade) sel = "";
            string path = guiPath(sel);
            if (path == "") return;
            upgrade_src.Text = path;
        }
        private void upgrade_GO_Click(object sender, EventArgs e) {
            lockMe();
            string root = upgrade_src.Text;
            if (root == defUpgrade) root =
                Application.StartupPath;
            string sscr = System.IO.File.ReadAllText(upgrade_scr.Text +
                ".usc", Encoding.UTF8).Replace("\r", "").Trim('\n');
            Filemod[] fm = new Filemod[z.Split(sscr, "\n:").Length];
            string[] scr = sscr.Split('\n'); int ifm = 0;
            int usci = 0; try {
                for (usci = 0; usci < scr.Length; usci++) {
                    if (scr[usci] == "") continue;
                    if (scr[usci].StartsWith(":ren")) {
                        fm[ifm] = new Filemod(Filemod.Action.ren);
                        fm[ifm].f = scr[usci + 1];
                        fm[ifm].t = scr[usci + 2];
                        if (!fm[ifm].isValid()) throw new Exception
                            ("Bad arguments for ''rename''");
                        usci += 2; ifm++;
                    }
                    else if (scr[usci].StartsWith(":rm")) {
                        fm[ifm] = new Filemod(Filemod.Action.rm);
                        fm[ifm].f = scr[usci + 1];
                        if (!fm[ifm].isValid()) throw new Exception
                            ("Bad arguments for ''remove''");
                        usci += 1; ifm++;
                    }
                    else if (scr[usci].StartsWith(":del")) {
                        fm[ifm] = new Filemod(Filemod.Action.del);
                        fm[ifm].f = scr[usci + 1];
                        if (!fm[ifm].isValid()) throw new Exception
                            ("Bad arguments for ''delete''");
                        usci += 1; ifm++;
                    }
                    else throw new Exception("Bad action");
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Script error at line " +
                    (usci + 1) + ":\r\n\r\n" + ex.Message,
                    "Praetox fucked up", MessageBoxButtons.OK,
                    MessageBoxIcon.Error); unlockMe(); return;
            }
            try {
                for (usci = 0; usci < fm.Length; usci++) {
                    //if (fm[usci].a == Filemod.Action.rm) break;
                    string pth = root + "\\" + fm[usci].f;
                    if (!System.IO.File.Exists(pth) &&
                        !System.IO.Directory.Exists(pth)) {
                        throw new Exception(fm[usci].f);
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Version control error! " +
                    "File not found:\r\n\r\n" + ex.Message + "\r\n\r\n" +
                    "- Did you remember to Browse for the torrent directory?" + "\r\n" +
                    "- Did you remember to select the correct upgrade script?",
                    "Version mismatch?", MessageBoxButtons.OK,
                    MessageBoxIcon.Error); unlockMe(); return;
            }
            MessageBox.Show("Script seems to be valid!" +
                "\r\n\r\n" + "Executing script now.",
                "Here goes...", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            bool gtfo = false;
            for (int a = 0; a < fm.Length; a++) {
                string pth = root + "\\" + fm[a].f;
                if (fm[a].a == Filemod.Action.ren) {
                    MoveLoc(root, fm[a].f, fm[a].t);
                }
                if (fm[a].a == Filemod.Action.del) {
                    if (System.IO.File.Exists(pth))
                        System.IO.File.Delete(pth);
                    else MessageBox.Show("Couldn't remove file:" + "\r\n\r\n" +
                        fm[a].f + "\r\n\r\n" + "As this isn't a critical error, " +
                        "I'll just continue.", "Non-critical error",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (fm[a].a == Filemod.Action.rm) {
                    bool ignore = false;
                    if (!System.IO.Directory.Exists(pth)) {
                        ignore = true;
                        MessageBox.Show("Couldn't remove empty directory:" + "\r\n\r\n" +
                            fm[a].f + "\r\n\r\n" + "As this isn't a critical error, " +
                            "I'll just continue.", "Non-critical error",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    while (!ignore && !gtfo) {
                        string[] files = System.IO.Directory.GetFiles(pth);
                        string[] dirs = System.IO.Directory.GetDirectories(pth);
                        if (files.Length == 0 && dirs.Length == 0) break;

                        System.Diagnostics.Process.Start("explorer", "\"" + pth + "\"");
                        DialogResult dr = MessageBox.Show(
                            "This directory needs to be empty." + "\r\n\r\n" +
                            "It isn't." + "\r\n\r\n" + "Please deal with it.",
                            "Unexpected shit", MessageBoxButtons.AbortRetryIgnore,
                            MessageBoxIcon.Exclamation);

                        if (dr == DialogResult.Ignore) ignore = true;
                        if (dr == DialogResult.Abort) gtfo = true;
                    }
                    if (!ignore && !gtfo)
                        System.IO.Directory.Delete(pth);
                }
                if (gtfo) break;
            }

            MessageBox.Show("Torrent successfully upgraded!",
                "Fuck yeah", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        //Gui bullshit
        private bool badv = false;
        private void adv_MouseDown(object sender, MouseEventArgs e) {
            int hDiff = 525; badv = !badv;
            if (!badv) hDiff = 0 - hDiff;
            this.Height += hDiff;
        }
        private void lnk_Click(object sender, EventArgs e) {
            System.Diagnostics.Process.Start("http://praetox.com/");
        }
    }
    public class Recurser {
        private string root;
        private StringBuilder retFiles;
        private StringBuilder retPaths;
        public Recurser() {
            retFiles = new StringBuilder();
            retPaths = new StringBuilder();
        }
        public void parse(string path, string[] mask) {
            if (!path.EndsWith("\\")) path += "\\";
            this.root = path; getDirs(path, mask);
        }
        public string[] getFiles() {
            return retFiles.ToString()
                .Trim('\n').Split('\n');
        }
        public string getPaths() {
            return retPaths.ToString().Trim('\n');
        }
        private void getDirs(string path, string[] mask) {
            path = path.Trim('/', '\\');
            bool bAppendPath = false;
            for (int a = 0; a < mask.Length; a++) {
                string[] files = System.IO.Directory.GetFiles(path, mask[a]);
                if (files.Length > 0) bAppendPath = true;
                for (int b = 0; b < files.Length; b++)
                    retFiles.Append(files[b].Substring
                        (root.Length) + "\n");
            }
            if (bAppendPath) retPaths.Append(path.Substring(root.Length) + "\n");
            string[] dirs = System.IO.Directory.GetDirectories(path);
            for (int a = 0; a < dirs.Length; a++) getDirs(dirs[a], mask);
        }
    }
    public class Filemod {
        public enum Action { nul, rm, del, ren };
        public Action a = Action.nul;
        public string f = null, t = null;
        public Filemod(Action act, string from, string to) {
            a = act; f = from; t = to;
        }
        public Filemod(Action act) {
            a = act; f = null; t = null;
        }
        public bool isValid() {
            if (a == Action.nul) return false;
            if (string.IsNullOrEmpty(f)) return false;
            if (a == Action.ren &&
                string.IsNullOrEmpty(t)) return false;
            return true;
        }
    }
    public class z {
        public static string[] Split(string a, string b) {
            return a.Split(new string[] { b },
                StringSplitOptions.None);
        }
    }
}
