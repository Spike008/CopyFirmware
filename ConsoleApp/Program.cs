using System;
using System.IO;
using BasicFunctions;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var pathToFirmwareVersion = Directory.GetDirectories("../Data/Quelle/LCOS");
            // pathToFirmwareVersion.ToList().ForEach(x => Console.WriteLine(x));
            foreach (var item in pathToFirmwareVersion)
            {
                Console.WriteLine(item);
            }

            // var service = new CopyService();             
            var mtMapDict = CopyService.LoadMtMapping();
            foreach (var item in mtMapDict)
            {
                Console.WriteLine($"Modell: {item.Key}, MT-Nummer: {item.Value}");
            }
            Console.ReadKey();
        }
    }
}
