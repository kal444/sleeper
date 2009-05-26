using System.Runtime.InteropServices;

namespace Sleeper.WinForm
{
    class Win32ApiHelper
    {
        [DllImport("PowrProf.dll", SetLastError = true)]
        private static extern bool SetSuspendState(bool hibernate, bool force, bool disable);

        public static void DoSuspeng() {
            SetSuspendState(false, false, false);
        }
    }
}
