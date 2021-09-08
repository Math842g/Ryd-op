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
        public Harddisk GetDiskMetadata()
        {
            Harddisk diskMetaData = new Harddisk();
            return diskMetaData;
        }
        #endregion
        #region HardDiskSerialNumber
        public Harddisk GetHardDiskSerialNumber()
        {
            Harddisk hardDiskSerialNumber = new Harddisk();
            return hardDiskSerialNumber;
        }
        #endregion
        #region GetCpuUsage
        public Processor GetCpuUsage()
        {
            Processor cpuUsage = new Processor();
            return cpuUsage;
        }
        #endregion
        #region GetSystemInfo
        public System GetSystemInfo()
        {
            System systemInfo = new System();
            return systemInfo;
        }
        #endregion
        #region GetBootDevice
        public System GetBootDevice()
        {
            System bootDevice = new System();
            return bootDevice;
        }
        #endregion
        #region GetMemoryInfo
        public Memory GetMemoryInfo()
        {
            Memory memoryinfo = new Memory();
            return memoryinfo;
        }
        #endregion
        #region GetAllServices
        public WinServices GetAllServices()
        {
            WinServices allServices= new WinServices();
            return allServices;
        }
        #endregion
    }
}
