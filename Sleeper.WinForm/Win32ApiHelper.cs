using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace Sleeper.WinForm
{
    class Win32ApiHelper
    {
        [DllImport("PowrProf.dll", SetLastError = true)]
        private static extern bool SetSuspendState(bool hibernate, bool force, bool disable);

        public static void doSuspeng() {
            SetSuspendState(false, false, false);
        }
    }
}
