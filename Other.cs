using System.Diagnostics;
using System.Runtime.InteropServices;

namespace VEG
{
    class Other
    {
        [DllImport("user32.dll")]
        public static extern bool ShowWindow(System.IntPtr hWnd, int cmdShow);

        private static void Maximize()
        {
            Process p = Process.GetCurrentProcess();
            ShowWindow(p.MainWindowHandle, 3);
        }
    }
}
