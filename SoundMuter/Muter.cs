using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SoundMuter
{
    internal static class Muter
    {
        private const int APPCOMMAND_VOLUME_MUTE = 0x80000;
        private const int APPCOMMAND_VOLUME_UP = 0xA0000;
        private const int APPCOMMAND_VOLUME_DOWN = 0x90000;
        private const int WM_APPCOMMAND = 0x319;

        [DllImport("user32.dll")]
        public static extern IntPtr SendMessageW(IntPtr hWnd, int Msg,
            IntPtr wParam, IntPtr lParam);

        public static void Mute(this Form form)
        {
            SendMessageW(form.Handle, WM_APPCOMMAND, form.Handle,
                (IntPtr)APPCOMMAND_VOLUME_MUTE);
        }

        public static void VolDown(this Form form)
        {
            SendMessageW(form.Handle, WM_APPCOMMAND, form.Handle,
                (IntPtr)APPCOMMAND_VOLUME_DOWN);
        }

        public static void VolUp(this Form form)
        {
            SendMessageW(form.Handle, WM_APPCOMMAND, form.Handle,
                (IntPtr)APPCOMMAND_VOLUME_UP);
        }
    }
}
