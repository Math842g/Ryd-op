using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace Ryd_op
{
    class System
    {
        #region SystemInfo
        public string SystemInfo()
        {
            ObjectQuery wql = new ObjectQuery("SELECT * FROM Win32_OperatingSystem");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(wql);
            ManagementObjectCollection results = searcher.Get();
            string systemInfo = "";

            foreach (ManagementObject result in results)
            {
                systemInfo = "User:\t" + result["RegisteredUser"].ToString();
                systemInfo += "\nOrg.:\t" + result["Organization"].ToString();
                systemInfo += "\nO/S :\t" + result["Name"].ToString();
            }
            return systemInfo;
        }
        #endregion
        #region BootDeviceTest
        public string BootDevice()
        {
            string bootDevice = "starting test";
            ManagementScope scope = new ManagementScope("\\\\.\\ROOT\\cimv2");

            //create object query
            ObjectQuery query = new ObjectQuery("SELECT * FROM Win32_OperatingSystem");

            //create object searcher
            ManagementObjectSearcher searcher =
                                    new ManagementObjectSearcher(scope, query);

            //get a collection of WMI objects
            ManagementObjectCollection queryCollection = searcher.Get();

            //enumerate the collection.
            foreach (ManagementObject m in queryCollection)
            {
                // access properties of the WMI object
                bootDevice += "\nBootDevice : " + m["BootDevice"].ToString();
            }
            bootDevice += "\nTest ended";
            return bootDevice;
        }
        #endregion
    }
}
