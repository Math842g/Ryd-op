using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace Ryd_op
{
    class Processor
    {
        #region GetCpuUsage
        public static void GetCpuUsage()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("select * from Win32_PerfFormattedData_PerfOS_Processor");

            foreach (ManagementObject obj in searcher.Get())
            {
                var usage = obj["PercentProcessorTime"];
                var name = obj["Name"];
                Console.WriteLine(name + " : " + usage);
                Console.WriteLine("CPU");
            }
        }
        #endregion
    }
}
