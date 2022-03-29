using Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.IO;

namespace File
{
    public class ReadFileJson
    {
        public static List<Passenger>? getData(string pathFile)
        {
            
            StreamReader r = new StreamReader(pathFile);
            string jsonString = r.ReadToEnd();
            var lst = JsonConvert.DeserializeObject<List<Passenger>>(jsonString, new IsoDateTimeConverter { DateTimeFormat = "dd/MM/yyyy" }) as List<Passenger>;
            if (lst != null)
                return lst;
            return null;
        }
    }
}
