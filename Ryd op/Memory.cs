using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace Ryd_op
{
    class Memory
    {
        #region GetMemoryInfo
        public static string GetMemoryInfo()
        {
            ObjectQuery wql = new ObjectQuery("SELECT * FROM Win32_OperatingSystem");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(wql);
            ManagementObjectCollection results = searcher.Get();
            string memoryInfo = "";

            foreach (ManagementObject result in results)
            {
                memoryInfo = "Total Visible Memory: " + result["TotalVisibleMemorySize"] + "KB";
                memoryInfo += "\nFree Physical Memory: " + result["FreePhysicalMemory"] + "KB";
                memoryInfo += "\nTotal Virtual Memory: " + result["TotalVirtualMemorySize"] + "KB";
                memoryInfo += "\nFree Virtual Memory: " + result["FreeVirtualMemory"] + "KB";
            }
            return memoryInfo;
        }
        #endregion
    }
}
