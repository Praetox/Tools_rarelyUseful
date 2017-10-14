using System;
using System.Text;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace VirtuaPad
{
    #region MP3 player class
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

        public void Close(int ID)
        {
            Pcommand = "close Praetox" + ID;
            mciSendString(Pcommand, null, 0, IntPtr.Zero);
            isOpen = false;
        }

        public void Open(int ID, string sFileName)
        {
            Pcommand = "open \"" + sFileName + "\" type mpegvideo alias Praetox" + ID;
            mciSendString(Pcommand, null, 0, IntPtr.Zero);
            isOpen = true;
        }

        public void Play(int ID, bool loop)
        {
            if (isOpen)
            {
                Pcommand = "play Praetox" + ID + " from 0";
                if (loop) Pcommand += " REPEAT";
                mciSendString(Pcommand, null, 0, IntPtr.Zero);
            }
        }
    }
    #endregion
}
