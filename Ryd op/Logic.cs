using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ryd_op
{
    class Logic
    {
        #region DiskMetaData
        public string GetDiskMetadata()
        {
            Harddisk diskMetaData = new Harddisk();
            return diskMetaData.GetDiskMetadata();
        }
        #endregion
        #region HardDiskSerialNumber
        public string GetHardDiskSerialNumber()
        {
            Harddisk hardDiskSerialNumber = new Harddisk();
            return hardDiskSerialNumber.GetDiskMetadata();
        }
        #endregion
        #region GetCpuUsage
        public string GetCpuUsage()
        {
            Processor cpuUsage = new Processor();
            return cpuUsage.GetCpuUsage();
        }
        #endregion
        #region GetSystemInfo
        public string GetSystemInfo()
        {
            System systemInfo = new System();
            return systemInfo.GetSystemInfo();
        }
        #endregion
        #region GetBootDevice
        public string GetBootDevice()
        {
            System bootDevice = new System();
            return bootDevice.GetBootDevice();
        }
        #endregion
        #region GetMemoryInfo
        public string GetMemoryInfo()
        {
            Memory memoryinfo = new Memory();
            return memoryinfo.GetMemoryInfo();
        }
        #endregion
        #region GetAllServices
        public string GetAllServices()
        {
            WinServices allServices= new WinServices();
            return allServices.GetAllServices();
        }
        #endregion
    }
}
