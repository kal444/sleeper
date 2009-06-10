using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Management;

namespace Sleeper.ConsoleApp
{
    /// <summary>
    /// Tester program to try out a few things related to suspend/wake on windows
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Win32ApiHelper.IsSystemResumeAutomatic());

            DateTime lastBootUpTime = new DateTime();
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("select * from win32_OperatingSystem");
            foreach (ManagementObject queryObj in searcher.Get())
            {
                var timeStr = Convert.ToString(queryObj["LastBootUpTime"]);
                Console.WriteLine(timeStr);
                lastBootUpTime = ManagementDateTimeConverter.ToDateTime(timeStr);
                Console.WriteLine(lastBootUpTime);
            }

            IntPtr status = Marshal.AllocCoTaskMem(Marshal.SizeOf(typeof(long)));
            Win32ApiHelper.CallNtPowerInformation(
              Win32ApiHelper.POWER_INFORMATION_LEVEL.LastSleepTime,
              (IntPtr)null,
              0,
              status,
              (UInt32)Marshal.SizeOf(typeof(long))
              );

            long lastSleepTime = (long) Marshal.PtrToStructure(status, typeof(long));
            Console.WriteLine(DateTime.FromFileTime(lastBootUpTime.ToFileTime() + lastSleepTime));

            Win32ApiHelper.CallNtPowerInformation(
              Win32ApiHelper.POWER_INFORMATION_LEVEL.LastWakeTime,
              (IntPtr)null,
              0,
              status,
              (UInt32)Marshal.SizeOf(typeof(long))
              );

            long lastWakeTime = (long)Marshal.PtrToStructure(status, typeof(long));
            Console.WriteLine(DateTime.FromFileTime(lastBootUpTime.ToFileTime() + lastWakeTime));
        }
    }
}
