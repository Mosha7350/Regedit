using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using Microsoft.Win32;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var loc_mach = Registry.LocalMachine.OpenSubKey("SOFTWARE").OpenSubKey("Microsoft").OpenSubKey("Windows").OpenSubKey("CurrentVersion").OpenSubKey("Run");

            foreach (var item in loc_mach.GetSubKeyNames())
            {

                
                Console.WriteLine(item);
            }
           

            foreach (var item in loc_mach.GetValueNames())
            {
                Console.WriteLine(item);
            }
            loc_mach.Close();

            Console.ReadLine();
        }
    }
}
