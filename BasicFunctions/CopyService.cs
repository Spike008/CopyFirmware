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
        public Dictionary<string, string> LoadMtMapping()
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

    }
}
