﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace Ryd_op
{
    class System
    {
        #region GetSystemInfo
        public static string GetSystemInfo()
        {
            ObjectQuery wql = new ObjectQuery("SELECT * FROM Win32_OperatingSystem");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(wql);
            ManagementObjectCollection results = searcher.Get();
            string systemInfo = "";

            foreach (ManagementObject result in results)
            {
                systemInfo = "User:\t" + result["RegisteredUser"];
                systemInfo += "\nOrg.:\t" + result["Organization"];
                systemInfo += "\nO/S :\t" + result["Name"];
            }
            return systemInfo;
        }
        #endregion
        #region BootDeviceTest
        public static string BootDeviceTest()
        {
            string bootDeviceInfo = "starting test";
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
                bootDeviceInfo += "\nBootDevice : " + m["BootDevice"];
            }
            bootDeviceInfo += "\nTest ended";
            return bootDeviceInfo;
        }
        #endregion
    }
}
