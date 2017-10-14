using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BinToHex
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_DragDrop(object sender, DragEventArgs e)
        {
            txtPath.Text = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
        }

        private void frmMain_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Link;
        }

        private void cmdBinToHex_Click(object sender, EventArgs e)
        {
            System.IO.FileStream fsi = new System.IO.FileStream(
                txtPath.Text, System.IO.FileMode.Open);
            System.IO.FileStream fso = new System.IO.FileStream(
                txtPath.Text + ".txt", System.IO.FileMode.Create);
            for (int a = 0; a < fsi.Length; a++)
            {
                string wat = fsi.ReadByte().ToString("X");
                while (wat.Length < 2) wat = "0" + wat;
                fso.Write(new byte[] { (byte)wat[0], (byte)wat[1], (byte)' ' }, 0, 3);
            }
            fsi.Flush(); fsi.Close(); fsi.Dispose();
            fso.Flush(); fso.Close(); fso.Dispose();
        }

        private void cmdHexToBin_Click(object sender, EventArgs e)
        {
            System.IO.FileStream fsi = new System.IO.FileStream(
                txtPath.Text + ".txt", System.IO.FileMode.Open);
            System.IO.FileStream fso = new System.IO.FileStream(
                txtPath.Text, System.IO.FileMode.Create);
            for (int a = 0; a < fsi.Length; a += 3)
            {
                string wat =
                    Convert.ToString((char)fsi.ReadByte()) +
                    Convert.ToString((char)fsi.ReadByte());
                fso.WriteByte(Convert.ToByte("0x" + wat, 16));
                fsi.ReadByte();
            }
            fsi.Flush(); fsi.Close(); fsi.Dispose();
            fso.Flush(); fso.Close(); fso.Dispose();
        }
    }
}
