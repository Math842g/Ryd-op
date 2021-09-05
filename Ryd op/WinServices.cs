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
        public static string ListAllServices()
        {
            ManagementObjectSearcher windowsServicesSearcher = new ManagementObjectSearcher("root\\cimv2", "select * from Win32_Service");
            ManagementObjectCollection objectCollection = windowsServicesSearcher.Get();
            string serviceInfo = "There are" + objectCollection.Count + "Windows services: ";

            foreach (ManagementObject windowsService in objectCollection)
            {
                PropertyDataCollection serviceProperties = windowsService.Properties;
                foreach (PropertyData serviceProperty in serviceProperties)
                {
                    if (serviceProperty.Value != null)
                    {
                        serviceInfo += "\nmWindows service property name: " + serviceProperty.Name;
                        serviceInfo += "\nWindows service property value: " + serviceProperty.Value;
                    }
                }
            }
            return serviceInfo;
        }
        #endregion
    }
}
