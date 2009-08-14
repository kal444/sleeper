using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace Sleeper.ConsoleApp
{
    class Win32ApiHelper
    {
        [DllImport("Kernel32.dll", SetLastError = true)]
        public static extern void GetSystemTimeAsFileTime(out long lpSystemTimeAsFileTime);

        [DllImport("Kernel32.dll", SetLastError=true)]
        public static extern bool IsSystemResumeAutomatic();

        [DllImport("PowrProf.dll", SetLastError=true)]
        public static extern UInt32 CallNtPowerInformation(
            POWER_INFORMATION_LEVEL InformationLevel, 
            IntPtr lpInputBuffer,
            UInt32 nInputBufferSize, 
            IntPtr lpOutputBuffer,
            UInt32 nOutputBufferSize);

        public enum POWER_INFORMATION_LEVEL
        {
            AdministratorPowerPolicy = 9,
            LastSleepTime = 15,
            LastWakeTime = 14,
            ProcessorInformation = 11,
            ProcessorPowerPolicyAc = 18,
            ProcessorPowerPolicyCurrent = 22,
            ProcessorPowerPolicyDc = 19,
            SystemBatteryState = 5,
            SystemExecutionState = 16,
            SystemPowerCapabilities = 4,
            SystemPowerInformation = 12,
            SystemPowerPolicyAc = 0,
            SystemPowerPolicyCurrent = 8,
            SystemPowerPolicyDc = 1,
            SystemReserveHiberFile = 10,
            SystemWakeSource = 35,
            VerifyProcessorPowerPolicyAc = 20,
            VerifyProcessorPowerPolicyDc = 21,
            VerifySystemPolicyAc = 2,
            VerifySystemPolicyDc = 3
        }
    }
}
