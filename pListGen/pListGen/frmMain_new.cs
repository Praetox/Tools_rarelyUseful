using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pListGen
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private static Color colActive = Color.FromArgb(192, 255, 192);
        private static Color colInactive = Color.FromArgb(255, 192, 192);
        private static DateTime dtBase = DateTime.Now;

        private void cDayMon_Click(object sender, EventArgs e)
        {
            if (cDayMon.BackColor == colActive) cDayMon.BackColor = colInactive;
            else cDayMon.BackColor = colActive;
        }
        private void cDayTue_Click(object sender, EventArgs e)
        {
            if (cDayTue.BackColor == colActive) cDayTue.BackColor = colInactive;
            else cDayTue.BackColor = colActive;
        }
        private void cDayWed_Click(object sender, EventArgs e)
        {
            if (cDayWed.BackColor == colActive) cDayWed.BackColor = colInactive;
            else cDayWed.BackColor = colActive;
        }
        private void cDayThu_Click(object sender, EventArgs e)
        {
            if (cDayThu.BackColor == colActive) cDayThu.BackColor = colInactive;
            else cDayThu.BackColor = colActive;
        }
        private void cDayFri_Click(object sender, EventArgs e)
        {
            if (cDayFri.BackColor == colActive) cDayFri.BackColor = colInactive;
            else cDayFri.BackColor = colActive;
        }
        private void cDaySat_Click(object sender, EventArgs e)
        {
            if (cDaySat.BackColor == colActive) cDaySat.BackColor = colInactive;
            else cDaySat.BackColor = colActive;
        }
        private void cDaySun_Click(object sender, EventArgs e)
        {
            if (cDaySun.BackColor == colActive) cDaySun.BackColor = colInactive;
            else cDaySun.BackColor = colActive;
        }
        private void cDayAll_Click(object sender, EventArgs e)
        {
            Color colSet = colActive;
            if (cDayAll.BackColor == colActive) colSet = colInactive;

            for (int a = 0; a < gbDays.Controls.Count; a++)
            {
                gbDays.Controls[a].BackColor = colSet;
            }
        }

        private void DayP_Click(object sender, EventArgs e)
        {
            dtBase = dtBase.AddDays(1); ShowBase();
        }
        private void DayM_Click(object sender, EventArgs e)
        {
            dtBase = dtBase.AddDays(-1); ShowBase();
        }
        private void MonP_Click(object sender, EventArgs e)
        {
            dtBase = dtBase.AddMonths(1); ShowBase();
        }
        private void MonM_Click(object sender, EventArgs e)
        {
            dtBase = dtBase.AddMonths(-1); ShowBase();
        }
        private void YearP_Click(object sender, EventArgs e)
        {
            dtBase = dtBase.AddYears(1); ShowBase();
        }
        private void YearM_Click(object sender, EventArgs e)
        {
            dtBase = dtBase.AddYears(-1); ShowBase();
        }
        private void ShowBase()
        {
            lbBase.Text = (GetDay(dtBase, true) +
                " " + dtBase.ToLongDateString())
                .Replace(" ", "  ").Replace(".", "");
        }
        private string GetDay(DateTime dt, bool Norwegian)
        {
            string ret = dt.DayOfWeek.ToString();
            if (Norwegian)
            {
                if (ret == "Monday") ret = "Mandag";
                if (ret == "Tuesday") ret = "Tirsdag";
                if (ret == "Wednesday") ret = "Onsdag";
                if (ret == "Thursday") ret = "Torsdag";
                if (ret == "Friday") ret = "Fredag";
                if (ret == "Saturday") ret = "Lørdag";
                if (ret == "Sunday") ret = "Søndag";
            }
            return ret;
        }

        public static bool Reg_DoesExist(string regPath)
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
        public static string Reg_Access(string sKey, string sVal)
        {
            Microsoft.Win32.RegistryKey rKey = Microsoft.Win32.Registry.CurrentUser;
            Reg_DoesExist("Software\\ACorp\\pListGen");
            rKey = rKey.OpenSubKey("Software\\ACorp\\pListGen", true);
            if (sVal != "") rKey.SetValue(sKey, sVal);
            string sRet = "";
            try
            {
                sRet = rKey.GetValue(sKey).ToString();
            }
            catch { }
            rKey.Close(); return sRet;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            bool bLoadConfig = false;
            if (Reg_Access("weekdays_included", "")!="")
            {
                if (DialogResult.Yes == MessageBox.Show(
                    "Ønsker du å bruke de samme innstillingene som du brukte sist?",
                    "Autokonfigurer", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    bLoadConfig = true;
                }
            }

            this.Show(); Application.DoEvents();
            ShowBase(); Application.DoEvents();
            
            wb.Navigate("about:blank"); Application.DoEvents();
            while (wb.IsBusy) Application.DoEvents();
            wb.Navigate("about:blank"); Application.DoEvents();
            while (wb.IsBusy) Application.DoEvents();
            string sDoc =
                "<html><head><title>pListGen</title>" + "\r\n" +
                "<style type=\"text/css\">p { background: #ddd; padding: 2px 4px 2px 4px; margin: 18px 0px 0px 0px; border: 1px solid; border-color: #fff #bbb #bbb #fff; }</style>" + "\r\n" +
                "</head><body bgcolor=#eeeeee><center>" + "\r\n" +

                "<p>Hvis du ønsker å skrive ut en liste som gjelder fra og med idag, klikk på \"Lag og skriv ut\" med èn gang.</p>" + "\r\n\r\n" +
                "<p>Dersom visse ukedager skal hoppes over, klikk på disse i ruten \"Inkluder ukedager\" slik at dem blir røde.</p>" + "\r\n\r\n" +
                "<p>Om listen skal lages fra og med en annen dato enn idag, endre start-dato ved å benytte Dag +/-, Mnd +/- og År +/-.</p>" + "\r\n\r\n" +
                "<p>For å endre hvilke klokkeslett som skal inkluderes, bytt ut klokkeslettene i feltet over. Separer med komma.</p>" + "\r\n\r\n" +
                "<p>Husk at dersom du velger for mange dager per kolonne, så vil listen deles over flere ark.<br>" + 
                "Dersom listen skal gå over en lengre periode, så er det bedre å øke tallet i \"Antall lister frem i tid\".</p>" +
                "<p>Alle innstillingene vil bli lagret når programmet avsluttes.</p>" +

                "</center></body></html>";
            wb.Document.Write(sDoc);

            cDayMon.BackColor = colActive;
            cDayTue.BackColor = colActive;
            cDayWed.BackColor = colActive;
            cDayThu.BackColor = colActive;
            cDayFri.BackColor = colActive;
            cDaySat.BackColor = colActive;
            cDaySun.BackColor = colActive;

            if (bLoadConfig)
            {
                string cfgWeekdaysInc = Reg_Access("weekdays_included", "");
                string cfgDaysPerCol = Reg_Access("dayspercol", "");
                string cfgListsAhead = Reg_Access("listsahead", "");
                string cfgTimeArray = Reg_Access("timearray", "");

                if (cfgWeekdaysInc != "")
                {
                    if (cfgWeekdaysInc[0] == '0') cDayMon.BackColor = colInactive;
                    if (cfgWeekdaysInc[1] == '0') cDayTue.BackColor = colInactive;
                    if (cfgWeekdaysInc[2] == '0') cDayWed.BackColor = colInactive;
                    if (cfgWeekdaysInc[3] == '0') cDayThu.BackColor = colInactive;
                    if (cfgWeekdaysInc[4] == '0') cDayFri.BackColor = colInactive;
                    if (cfgWeekdaysInc[5] == '0') cDaySat.BackColor = colInactive;
                    if (cfgWeekdaysInc[6] == '0') cDaySun.BackColor = colInactive;
                }
                if (cfgDaysPerCol != "")
                {
                    txDaysPerCol.Text = cfgDaysPerCol;
                }
                if (cfgListsAhead != "")
                {
                    txListsAhead.Text = cfgListsAhead;
                }
                if (cfgTimeArray != "")
                {
                    txTimes.Text = cfgTimeArray;
                }
            }
        }
        private void cPrint_Click(object sender, EventArgs e)
        {
            cGen_Click(new object(), new EventArgs());
            Application.DoEvents(); wb.ShowPrintDialog();
        }
        private void cGen_Click(object sender, EventArgs e)
        {
            string sCSS =
                "<style type=\"text/css\">" + "\r\n" +
                "    table{ width: 100%; height: 100%; " +
                "           border-color: #444; border-width: 0 0 1px 1px; " + 
                "           border-style: solid; }" + "\r\n" +
                "    td{ text-align: center; margin: 0; padding: 4px; " +
                "        background-color: #FFF; border-color: #777; " +
                "        border-width: 1px 1px 0 0; border-style: solid;  }" + "\r\n" +
                "    td.lsDate{ width: 4%; }" + "\r\n" +
                "    td.lsTime{ width: 8%; }" + "\r\n" +
                "    td.lsName{ width: 36%; }" + "\r\n" +
                "</style>";
            
            int iLists = Convert.ToInt32(txListsAhead.Text);
            string sBodyTotal = "";
            for (int a = 0; a < iLists; a++)
            {
                if (a > 0) sBodyTotal += "<p style=\"page-break-before: always\"></p>" + "\r\n";
                sBodyTotal += GetBodyPage(dtBase, a + 1);
            }

            string sDoc =
                "<html><header><title>pListGen</title>" + "\r\n" + sCSS + "\r\n" + "</header>" + "\r\n" +
                "<body>" + "\r\n" + sBodyTotal + "\r\n" + "</body></html>";

            wb.Navigate("about:blank"); Application.DoEvents();
            while (wb.IsBusy) Application.DoEvents();
            wb.Document.Write(sDoc); Application.DoEvents();
            //Clipboard.Clear(); Clipboard.SetText(sDoc);
        }
        private string GetBodyPage(DateTime dtStart, int iPage)
        {
            string sGoodDays = ",";
            if (cDayMon.BackColor != colInactive) sGoodDays += "Monday,";
            if (cDayTue.BackColor != colInactive) sGoodDays += "Tuesday,";
            if (cDayWed.BackColor != colInactive) sGoodDays += "Wednesday,";
            if (cDayThu.BackColor != colInactive) sGoodDays += "Thursday,";
            if (cDayFri.BackColor != colInactive) sGoodDays += "Friday,";
            if (cDaySat.BackColor != colInactive) sGoodDays += "Saturday,";
            if (cDaySun.BackColor != colInactive) sGoodDays += "Sunday,";

            string sDayFirst = "";
            string sDayLast = "";

            DateTime dtCur = dtBase.AddDays(-1);
            int iDaysPerCol = Convert.ToInt32(txDaysPerCol.Text);
            int iDaysSkipped = 0;
            while (iDaysSkipped < iDaysPerCol * 2 * (iPage - 1))
            {
                dtCur = dtCur.AddDays(1);
                if (sGoodDays.Contains("," + dtCur.DayOfWeek.ToString() + ","))
                {
                    iDaysSkipped++;
                }
            }

            int iDaysAdded = 0;
            string sDaysAdded = "";
            while (iDaysAdded < iDaysPerCol * 2)
            {
                dtCur = dtCur.AddDays(1);
                if (sGoodDays.Contains("," + dtCur.DayOfWeek.ToString() + ","))
                {
                    if (sDayFirst == "") sDayFirst = dtCur.ToLongDateString();
                    sDayLast = dtCur.ToLongDateString();
                    iDaysAdded++; sDaysAdded +=
                        dtCur.Day + "," + GetDay(dtCur, true) +
                        ",------------------------" + "\n";
                }
            }
            sDaysAdded = sDaysAdded.Substring(0, sDaysAdded.Length - 1);

            string[] sDays = sDaysAdded.Split('\n');
            string[] sTimes = txTimes.Text.Replace(" ", "").Split(',');
            string sTData1 = "";
            string sTData2 = "";
            for (int a = 0; a < sDays.Length; a++)
            {
                string sAppend = sDays[a] + "\n";
                for (int b = 0; b < sTimes.Length; b++)
                {
                    sAppend += "&nbsp;," + sTimes[b] + ",&nbsp;" + "\n";
                }
                if (a < iDaysPerCol) sTData1 += sAppend;
                else sTData2 += sAppend;
            }

            string sBody =
                "<div style=\"height:5%; text-indent:5%; font-size:200%\"><b><i>" +
                sDayFirst + " &nbsp;til&nbsp; " + sDayLast + "</i></b></div>" + "\r\n" +
                "<div style=\"height:94%; text-align:left;\"><table>" + "\r\n";
            string sTableRow =
                "<tr>" + "\r\n" +
                "    <td class=lsDate>[[date1]]</td> <td class=lsTime>[[time1]]</td> <td class=lsName>[[name1]]</td>" + "\r\n" +
                "    <td class=lsDate>[[date2]]</td> <td class=lsTime>[[time2]]</td> <td class=lsName>[[name2]]</td>" + "\r\n" +
                "</tr>" + "\r\n";

            for (int a = 0; a < iDaysPerCol * (sTimes.Length + 1); a++)
            {
                string[] sTValue1 = sTData1.Substring(0, sTData1.IndexOf('\n')).Split(',');
                string[] sTValue2 = sTData2.Substring(0, sTData2.IndexOf('\n')).Split(',');
                sTData1 = sTData1.Substring(sTData1.IndexOf('\n') + 1);
                sTData2 = sTData2.Substring(sTData2.IndexOf('\n') + 1);
                sBody += sTableRow
                    .Replace("[[date1]]", sTValue1[0]).Replace("[[time1]]", sTValue1[1]).Replace("[[name1]]", sTValue1[2])
                    .Replace("[[date2]]", sTValue2[0]).Replace("[[time2]]", sTValue2[1]).Replace("[[name2]]", sTValue2[2]);
            }

            return sBody + "</table></div>";
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            string sWeekdaysInc = "";
            if (cDayMon.BackColor != colInactive) sWeekdaysInc += "1"; else sWeekdaysInc += "0";
            if (cDayTue.BackColor != colInactive) sWeekdaysInc += "1"; else sWeekdaysInc += "0";
            if (cDayWed.BackColor != colInactive) sWeekdaysInc += "1"; else sWeekdaysInc += "0";
            if (cDayThu.BackColor != colInactive) sWeekdaysInc += "1"; else sWeekdaysInc += "0";
            if (cDayFri.BackColor != colInactive) sWeekdaysInc += "1"; else sWeekdaysInc += "0";
            if (cDaySat.BackColor != colInactive) sWeekdaysInc += "1"; else sWeekdaysInc += "0";
            if (cDaySun.BackColor != colInactive) sWeekdaysInc += "1"; else sWeekdaysInc += "0";
            Reg_Access("weekdays_included", sWeekdaysInc);
            Reg_Access("dayspercol", txDaysPerCol.Text);
            Reg_Access("listsahead", txListsAhead.Text);
            Reg_Access("timearray", txTimes.Text);
        }
    }
}
