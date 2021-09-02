using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace Ryd_op
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int choice = 0;
                //Printing a menu for the user
                Console.WriteLine("Chose a service:" + "\n\n1. Show harddisk metadata" + "\n2. Show harddisk serial number" + "\n3. Show cpu usage" + "\n4. Show memory info" + "\n5. Show system info" + "\n6. Boot device test" + "\n7. List all windows services" + "\n8. exit");
                //Catches if the user inserts anything else than a number
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("You have to insert a number");
                }
                //Breaks the loop if the user inserts 8 in the console
                if(choice == 8)
                {
                    break;
                }
                //Picking a case depending on what the user inputs
                switch (choice)
                {
                    case 1:
                        Harddisk.GetDiskMetadata();
                        break;
                    case 2:
                        Harddisk.GetHardDiskSerialNumber();
                        break;
                    case 3:
                        Processor.GetCpuUsage();
                        break;
                    case 4:
                        Memory.GetMemoryInfo();
                        break;
                    case 5:
                        System.GetSystemInfo();
                        break;
                    case 6:
                        System.BootDeviceTest();
                        break;
                    case 7:
                        WinServices.ListAllServices();
                        break;
                }
                //Makes the user press any key to continue
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();

                Console.Clear();
            }
        } //Slut main
    }
}
