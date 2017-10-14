using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VGADithr
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        string[] sFiles = new string[0];
        bool bDither = false;

        public Bitmap ResizeBitmap(Bitmap bPic, int iX, int iY, bool bKeepAspect, int iScaleMode)
        {
            /*if (iX > bPic.Width) iX = bPic.Width;
            if (iY > bPic.Height) iY = bPic.Height;*/
            double dRaX = (double)bPic.Width / (double)iX;
            double dRaY = (double)bPic.Height / (double)iY;
            if (bKeepAspect)
            {
                if (dRaX > dRaY) iY = (int)Math.Round((double)iX / ((double)bPic.Width / (double)bPic.Height));
                if (dRaY > dRaX) iX = (int)Math.Round((double)iY * ((double)bPic.Width / (double)bPic.Height));
            }
            Bitmap bOut = new Bitmap(iX, iY);
            using (Graphics gOut = Graphics.FromImage((Image)bOut))
            {
                gOut.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
                if (iScaleMode == 2) gOut.InterpolationMode =
                      System.Drawing.Drawing2D.InterpolationMode.High;
                if (iScaleMode == 3) gOut.InterpolationMode =
                      System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
                gOut.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
                gOut.DrawImage(bPic, 0, 0, iX, iY);
            }
            return bOut;
        }

        private void frmMain_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void frmMain_DragDrop(object sender, DragEventArgs e)
        {
            sFiles = (string[])e.Data.GetData(DataFormats.FileDrop);
            try
            {
                sFiles = System.IO.Directory.GetFiles(sFiles[0]);
            }
            catch { }
            bDither = true;
        }

        void tDither_Tick(object sender, EventArgs e)
        {
            if (!bDither) return;
            bDither = false;
            int iDResX = Convert.ToInt32(tDResX.Text);
            int iDResY = Convert.ToInt32(tDResY.Text);
            int iIResX = Convert.ToInt32(tIResX.Text);
            int iIResY = Convert.ToInt32(tIResY.Text);
            int iDitherMode = Convert.ToInt32(tDMode.Text);
            for (int iFile = 0; iFile < sFiles.Length; iFile++)
            {
                string sFile = sFiles[iFile];
                this.Text = iFile + " of " + sFiles.Length +
                    " (preload)"; Application.DoEvents();

                Bitmap bSrc = ResizeBitmap((Bitmap)Bitmap.FromFile(sFile), iDResX, iDResY, false, 2);
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                bSrc.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
                byte[] bT = ms.GetBuffer(); ms.Close(); ms.Dispose();
                byte[] bTR = new byte[iDResX * iDResY];
                byte[] bTG = new byte[iDResX * iDResY];
                byte[] bTB = new byte[iDResX * iDResY];
                int ibTLoc = 54;
                for (int y = 0; y < iDResY; y++)
                    for (int x = 0; x < iDResX; x++)
                    {
                        bTR[(iDResY - y) * iDResX - iDResX + (x)] = bT[ibTLoc + 2];
                        bTG[(iDResY - y) * iDResX - iDResX + (x)] = bT[ibTLoc + 1];
                        bTB[(iDResY - y) * iDResX - iDResX + (x)] = bT[ibTLoc + 0];
                        ibTLoc += 4;
                    }

                this.Text = iFile + " of " + sFiles.Length +
                    " (neut 1)"; Application.DoEvents();

                int iMin = 255, iMinR = 255, iMinG = 255, iMinB = 255;
                for (int y = 0; y < iDResY; y++)
                    for (int x = 0; x < iDResX; x++)
                    {
                        int iTR = bTR[y * (iDResX) + x];
                        int iTG = bTG[y * (iDResX) + x];
                        int iTB = bTB[y * (iDResX) + x];
                        if (iTR < iMinR) iMinR = iTR;
                        if (iTG < iMinG) iMinG = iTG;
                        if (iTB < iMinB) iMinB = iTB;
                    }
                if (iMinR < iMin) iMin = iMinR;
                if (iMinG < iMin) iMin = iMinG;
                if (iMinB < iMin) iMin = iMinB;
                for (int y = 0; y < iDResY; y++)
                    for (int x = 0; x < iDResX; x++)
                    {
                        bTR[y * (iDResX) + x] -= (byte)iMin;
                        bTG[y * (iDResX) + x] -= (byte)iMin;
                        bTB[y * (iDResX) + x] -= (byte)iMin;
                    }

                this.Text = iFile + " of " + sFiles.Length +
                    " (neut 2)"; Application.DoEvents();

                int iMax = 0, iMaxR = 0, iMaxG = 0, iMaxB = 0;
                for (int y = 0; y < iDResY; y++)
                    for (int x = 0; x < iDResX; x++)
                    {
                        int iTR = bTR[y * (iDResX) + x];
                        int iTG = bTG[y * (iDResX) + x];
                        int iTB = bTB[y * (iDResX) + x];
                        if (iTR > iMaxR) iMaxR = iTR;
                        if (iTG > iMaxG) iMaxG = iTG;
                        if (iTB > iMaxB) iMaxB = iTB;
                    }
                if (iMaxR > iMax) iMax = iMaxR;
                if (iMaxG > iMax) iMax = iMaxG;
                if (iMaxB > iMax) iMax = iMaxB;
                double dMul = 255 / iMax;
                for (int y = 0; y < iDResY; y++)
                    for (int x = 0; x < iDResX; x++)
                    {
                        int iTR = (int)Math.Round((double)bTR[y * (iDResX) + x] * dMul);
                        int iTG = (int)Math.Round((double)bTG[y * (iDResX) + x] * dMul);
                        int iTB = (int)Math.Round((double)bTB[y * (iDResX) + x] * dMul);
                        if (iTR > 255) iTR = 255; bTR[y * (iDResX) + x] = (byte)iTR;
                        if (iTG > 255) iTG = 255; bTG[y * (iDResX) + x] = (byte)iTG;
                        if (iTG > 255) iTB = 255; bTB[y * (iDResX) + x] = (byte)iTB;
                    }

                this.Text = iFile + " of " + sFiles.Length +
                    " (map)"; Application.DoEvents();

                int[] iCol = new int[iDResX * iDResY];

                // 2 colours (BW)
                Color[] cMap = new Color[2];
                cMap[0] = Color.FromArgb(000, 000, 000);
                cMap[1] = Color.FromArgb(255, 255, 255);

                if (c4cga.Checked) {
                    cMap = new Color[4]; // 4 colours (CGA)
                    cMap[0] = Color.FromArgb(000, 000, 000);
                    cMap[1] = Color.FromArgb(000, 255, 255);
                    cMap[2] = Color.FromArgb(255, 000, 255);
                    cMap[3] = Color.FromArgb(255, 255, 255);
                }

                if (c8rgbycp.Checked) {
                    cMap = new Color[8]; // 8 colours (RGBYCP)
                    cMap[0] = Color.FromArgb(000, 000, 000);
                    cMap[1] = Color.FromArgb(000, 000, 255);
                    cMap[2] = Color.FromArgb(000, 255, 000);
                    cMap[3] = Color.FromArgb(255, 000, 000);
                    cMap[4] = Color.FromArgb(000, 255, 255);
                    cMap[5] = Color.FromArgb(255, 255, 000);
                    cMap[6] = Color.FromArgb(255, 000, 255);
                    cMap[7] = Color.FromArgb(255, 255, 255);
                }

                if (c16dosvga.Checked) {
                    cMap = new Color[16]; // 16 colours DOS-VGA
                    cMap[0] = Color.FromArgb(000, 000, 000);
                    cMap[1] = Color.FromArgb(000, 000, 128);
                    cMap[2] = Color.FromArgb(000, 128, 000);
                    cMap[3] = Color.FromArgb(000, 128, 128);
                    cMap[4] = Color.FromArgb(128, 000, 128);
                    cMap[5] = Color.FromArgb(128, 000, 128);
                    cMap[6] = Color.FromArgb(255, 000, 000);
                    cMap[7] = Color.FromArgb(128, 128, 128);
                    cMap[8] = Color.FromArgb(032, 032, 032);
                    cMap[9] = Color.FromArgb(048, 096, 255);
                    cMap[10] = Color.FromArgb(032, 255, 096);
                    cMap[11] = Color.FromArgb(048, 255, 255);
                    cMap[12] = Color.FromArgb(255, 048, 048);
                    cMap[13] = Color.FromArgb(255, 096, 255);
                    cMap[14] = Color.FromArgb(255, 255, 096);
                    cMap[15] = Color.FromArgb(255, 255, 255);
                }

                if (c256rtg.Checked) {
                    // 256 colours real-time generated
                    cMap = new Color[216]; int itT = -1;
                    for (int itR = 0; itR <= 256; itR += 51)
                        for (int itG = 0; itG <= 256; itG += 51)
                            for (int itB = 0; itB <= 256; itB += 51) {
                                if (itR > 255) itR = 255;
                                if (itG > 255) itG = 255;
                                if (itB > 255) itB = 255;
                                itT++; cMap[itT] =
                                    Color.FromArgb(itR, itG, itB);
                            }
                }

                if (c256vga.Checked) {
                    int itT = -1; // 256 colours (proper)
                    cMap = new Color[256]; //8*8*4=256
                    for (int itR = 0; itR <= 256; itR += 36) //36*7=252
                        for (int itG = 0; itG <= 256; itG += 36) //36*7=252
                            for (int itB = 0; itB <= 256; itB += 85) { //85*3=255
                                if (itR > 255) itR = 255;
                                if (itG > 255) itG = 255;
                                if (itB > 255) itB = 255;
                                itT++; cMap[itT] =
                                    Color.FromArgb(itR, itG, itB);
                            }
                }

                for (int i = 0; i < iDResX * iDResY; i++)
                {
                    iCol[i] = -1;
                }
                int iLastCol = -1;
                int iLastColDist = -1;
                bool bScatter = false;
                for (int y = 0; y < iDResY; y++)
                    for (int x = 0; x < iDResX; x++)
                    {
                        int iT = y * (iDResX) + x;
                        int iThr = -1;
                        while (iCol[iT] == -1)
                        {
                            iThr += 1;
                            double dTR = (double)bTR[iT];
                            double dTG = (double)bTG[iT];
                            double dTB = (double)bTB[iT];
                            for (int c = 0; c < cMap.Length; c++)
                                if (iCol[iT] == -1)
                                    if (Math.Abs(dTR - (double)cMap[c].R) <= iThr &&
                                        Math.Abs(dTG - (double)cMap[c].G) <= iThr &&
                                        Math.Abs(dTB - (double)cMap[c].B) <= iThr)
                                        if (bScatter)
                                        {
                                            if (iLastCol != c)
                                            {
                                                iCol[iT] = c;
                                                iLastCol = -1;
                                                iLastColDist = iThr;
                                                bScatter = false;
                                            }
                                        }
                                        else
                                        {
                                            iCol[iT] = c;
                                            iLastCol = c;
                                            if (iDitherMode == 2) iLastColDist -= iThr;
                                            if (iDitherMode == 1) iLastColDist = -1;
                                            if (iDitherMode == 0) iLastColDist = 1;
                                            if (iLastColDist < 0) bScatter = true;
                                            if (iThr < 4) bScatter = false;
                                        }
                        }
                    }

                this.Text = iFile + " of " + sFiles.Length +
                    " (export)"; Application.DoEvents();

                Bitmap bRes = new Bitmap(iDResX, iDResY);
                for (int y = 0; y < iDResY; y++)
                    for (int x = 0; x < iDResX; x++)
                    {
                        bRes.SetPixel(x, y, cMap[iCol[y * (iDResX) + x]]);
                    }
                ResizeBitmap(bRes, iDResX, iDResY, false, 3).Save
                    (iFile + ".png", System.Drawing.Imaging.ImageFormat.Png);
                //("c:/dos/qb45/output.png", System.Drawing.Imaging.ImageFormat.Png);
                /*System.IO.StreamWriter sw;
                sw = System.IO.File.CreateText("c:/dos/qb45/pic.bas");
                sw.WriteLine("SCREEN 7");
                sw.WriteLine("COLOR 15, 0");
                sw.WriteLine("CLS");
                for (int y = 0; y < iResY; y++)
                    for (int x = 0; x < iResX; x++)
                    {
                        sw.WriteLine("PSET (" + x + ", " + y + "), " + iCol[y * (iResX) + x]);
                    }
                sw.WriteLine("while inkey$ = \"\"");
                sw.WriteLine("wend");
                sw.Flush(); sw.Close(); sw.Dispose();
                System.Diagnostics.Process.Start("c:/dos/qb45/bc.exe", "pic.bas pic.obj nul.lst");
                System.Diagnostics.Process.Start("c:/dos/qb45/link.exe", "pic.obj");*/
            }
        }

        private void cmdDither_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Timer tDither = new Timer();
            tDither.Tick += new EventHandler(tDither_Tick);
            tDither.Interval = 1000;
            tDither.Start();
        }
    }
}
