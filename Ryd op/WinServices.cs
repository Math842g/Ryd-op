using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace Ryd_op
{
    class WinServices
    {
        #region ListAllServices
        public string GetAllServices()
        {
            ManagementObjectSearcher windowsServicesSearcher = new ManagementObjectSearcher("root\\cimv2", "select * from Win32_Service");
            ManagementObjectCollection objectCollection = windowsServicesSearcher.Get();
            string allservices = "There are" + objectCollection.Count + "Windows services: ";

            foreach (ManagementObject windowsService in objectCollection)
            {
                PropertyDataCollection serviceProperties = windowsService.Properties;
                foreach (PropertyData serviceProperty in serviceProperties)
                {
                    if (serviceProperty.Value != null)
                    {
                        allservices += "\nmWindows service property name: " + serviceProperty.Name;
                        allservices += "\nWindows service property value: " + serviceProperty.Value;
                    }
                }
            }
            return allservices;
        }
        #endregion
    }
}
