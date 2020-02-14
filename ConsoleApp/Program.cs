using System;
using BasicFunctions;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var service = new CopyService();
            var mtMapDict = service.LoadMtMapping();
            foreach (var item in mtMapDict)
            {
                Console.WriteLine($"Modell: {item.Key}, MT-Nummer: {item.Value}");
            }
            Console.ReadKey();
        }
    }
}
