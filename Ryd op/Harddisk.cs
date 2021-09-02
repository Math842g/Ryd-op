using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace Ryd_op
{
    class Harddisk
    {
        #region GetDiskMetaData
        public static void GetDiskMetadata()
        {

            global::System.Management.ManagementScope managementScope = new global::System.Management.ManagementScope();

            global::System.Management.ObjectQuery objectQuery = new global::System.Management.ObjectQuery("select FreeSpace,Size,Name from Win32_LogicalDisk where DriveType=3");

            ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);

            ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get();

            foreach (ManagementObject managementObject in managementObjectCollection)

            {

                Console.WriteLine("Disk Name : " + managementObject["Name"].ToString());

                Console.WriteLine("FreeSpace: " + managementObject["FreeSpace"].ToString());

                Console.WriteLine("Disk Size: " + managementObject["Size"].ToString());

                Console.WriteLine("---------------------------------------------------");

            }
        }
        #endregion
        #region GetHardDidkSerialNumber
        public static string GetHardDiskSerialNumber(string drive = "C")

        {

            ManagementObject managementObject = new ManagementObject("Win32_LogicalDisk.DeviceID=\"" + drive + ":\"");

            managementObject.Get();
            Console.WriteLine(managementObject["VolumeSerialNumber"].ToString());

            return managementObject["VolumeSerialNumber"].ToString();

        }
        #endregion
    }
}
