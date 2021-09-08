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
            int choice = 0;
            Logic logic = new Logic();

            //looping so an user can use multiple services
            do
            {
                //Printing a menu for the user
                Console.Write("Chose a service:" + "\n\n1. Show harddisk metadata" + "\n2. Show harddisk serial number" + "\n3. Show cpu usage" + "\n4. Show memory info" + "\n5. Show system info" + "\n6. Boot device test" + "\n7. List all windows services" + "\n8. exit" + "\n\nEnter your choice: ");
                //Catches if the user inserts anything else than a number
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("You have to insert a number");
                }
                //Picking a case depending on what the user inputs
                switch (choice)
                {
                    case 1:
                        PrintToConsole(logic.GetDiskMetadata().DiskMetadata());
                        break;
                    case 2:
                        PrintToConsole(logic.GetHardDiskSerialNumber().HardDiskSerialNumber());
                        break;
                    case 3:
                        PrintToConsole(logic.GetCpuUsage().CpuUsage());
                        break;
                    case 4:
                        PrintToConsole(logic.GetMemoryInfo().MemoryInfo());
                        break;
                    case 5:
                        PrintToConsole(logic.GetSystemInfo().SystemInfo());
                        break;
                    case 6:
                        PrintToConsole(logic.GetBootDevice().BootDevice());
                        break;
                    case 7:
                        PrintToConsole(logic.GetAllServices().AllServices());
                        break;
                }
                //Makes the user press any key to continue
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                //clears the console
                Console.Clear();
            } while (choice != 8);
        } 
        
        public static void PrintToConsole(string textToPrint)
        {
            Console.WriteLine(textToPrint);
        }
    }
}
