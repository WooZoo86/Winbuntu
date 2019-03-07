using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Winbuntu
{
    public class UseData 
    {        
        public static readonly string Registry = "src/data/registry.json";
        public static StreamReader reader = new StreamReader(@"src/data/registry.json");
        public static DataHead ParseJSON() 
        {
            string json = reader.ReadToEnd();
            return JsonConvert.DeserializeObject<DataHead>(json);
        }

        public static void RegPrint()
        {
        }
    }

    /// <summary>
    /// This contains the structure of how the JSON data is parsed
    /// </summary>
    public class DataStruct
    {
        public string title { set; get; }
        public string execute { set; get; }
        public string target  { set; get; }
        public string path  { set; get; }
    }

    /// <summary>
    /// Allows each program to have it's own entry and make the whole thing easier to call
    /// </summary>
    public class DataHead
    {
        public Dictionary<string, DataStruct> progData { set; get; }
    }
}