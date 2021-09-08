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
        #region DiskMetaData
        public string DiskMetadata()
        {
            global::System.Management.ManagementScope managementScope = new global::System.Management.ManagementScope();

            global::System.Management.ObjectQuery objectQuery = new global::System.Management.ObjectQuery("select FreeSpace,Size,Name from Win32_LogicalDisk where DriveType=3");

            ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);

            ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get();
            string diskMetaData = "";
            foreach (ManagementObject managementObject in managementObjectCollection)

            {
                diskMetaData = "Disk Name : " + managementObject["Name"].ToString();
                diskMetaData += "\nFreeSpace: " + managementObject["FreeSpace"].ToString();
                diskMetaData += "\nDisk Size: " + managementObject["Size"].ToString();
                diskMetaData += "\n---------------------------------------------------";
            }
            return diskMetaData;
        }
        #endregion
        #region HardDidkSerialNumber
        public string HardDiskSerialNumber(string drive = "C")

        {
            ManagementObject managementObject = new ManagementObject("Win32_LogicalDisk.DeviceID=\"" + drive + ":\"");

            managementObject.Get();
            string hardDiskSerialNumber = "Harddisk serial number: " + managementObject["VolumeSerialNumber"].ToString();
            return hardDiskSerialNumber;

        }
        #endregion
    }
}
