using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace BasicFunctions
{
    public class CopyService
    {
        /// <summary>
        /// lädt MT-Mapping-Datei
        /// </summary>
        public static Dictionary<string, string> LoadMtMapping()
        {
            try
            {
                var myJsonString = File.ReadAllText("MT_Mapping.json");
                return JsonSerializer.Deserialize<Dictionary<string, string>>(myJsonString);
            }
            catch (System.Exception)
            {
                return new Dictionary<string, string>();
            }
        }

        public static void CopyFirmwareFiles(
            List<string> files,
            Dictionary<string, string> mtMappingDict,
            string destDir
            )
        {
            foreach (var file in files)
            {
                var filename = Path.GetFileName(file);
                var devicename = filename.Remove(filename.Length - 19);
                var mtFolderExists = mtMappingDict.TryGetValue(devicename, out var mtFolder);
                if (mtFolderExists)
                {
                    var fullDestPath = Path.Combine(destDir, mtFolder, filename);
                    File.Copy(file, fullDestPath);
                }

                Console.WriteLine(devicename);


            }


        }























    }
}
