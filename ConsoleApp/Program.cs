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
            const string rootDir = "../Data/Quelle/LCOS";
            const string destDir = "../Data/Ziel/DeviceFiles";
            var pathToFirmwareVersion = Directory.GetDirectories(rootDir);
            // pathToFirmwareVersion.ToList().ForEach(x => Console.WriteLine(x));
            foreach (var item in pathToFirmwareVersion)
            {
                Console.WriteLine(item);
            }
            const string selectedMajorMinorFolder = "../Data/Quelle/LCOS/10.32";


            var pathToBuilds = Directory.GetDirectories(selectedMajorMinorFolder);
            // pathToFirmwareVersion.ToList().ForEach(x => Console.WriteLine(x));
            foreach (var item in pathToBuilds)
            {
                Console.WriteLine(item);
            }

            const string selectedBuildFolder = "../Data/Quelle/LCOS/10.32/BUIL0157";

            var filesOfBuild = Directory.GetFiles(selectedBuildFolder);
            // pathToFirmwareVersion.ToList().ForEach(x => Console.WriteLine(x));
            foreach (var item in filesOfBuild)
            {
                Console.WriteLine(item);
            }

            // var service = new CopyService();             
            var mtMapDict = CopyService.LoadMtMapping();
            foreach (var item in mtMapDict)
            {
                Console.WriteLine($"Modell: {item.Key}, MT-Nummer: {item.Value}");
            }

            CopyService.CopyFirmwareFiles(filesOfBuild.ToList(), mtMapDict, destDir);

            Console.ReadKey();




        }
    }
}
