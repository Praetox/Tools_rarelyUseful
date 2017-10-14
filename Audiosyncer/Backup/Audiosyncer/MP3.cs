using System;
using System.Text;
using System.Collections.Generic;

using System.Runtime.InteropServices;

namespace Audiosyncer
{
    public class MP3
    {
        private string Pcommand; private bool isOpen;

        [DllImport("winmm.dll")]
        private static extern long mciSendString(
            string strCommand,          // The command to execute
            StringBuilder strReturn,    // The returned string (if any)
            int iReturnLength,          // The bitcount of the returned string
            IntPtr hwndCallback);       // Callback value of spec. handle
        public MP3()
        {
        }

        public void Close()
        {
            Pcommand = "close ANmCs";
            mciSendString(Pcommand, null, 0, IntPtr.Zero);
            isOpen = false;
        }

        public void Open(string sFileName)
        {
            Pcommand = "open \"" + sFileName + "\" type mpegvideo alias ANmCs";
            mciSendString(Pcommand, null, 0, IntPtr.Zero);
            isOpen = true;
        }

        public void Play(bool loop)
        {
            if (isOpen)
            {
                Pcommand = "play ANmCs";
                if (loop) Pcommand += " REPEAT";
                mciSendString(Pcommand, null, 0, IntPtr.Zero);
            }
        }
    }
}