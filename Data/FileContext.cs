using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Models;

namespace FileData
{
    public class FileContext
    {
        public IList<Adult> Adults { get; private set; }
        public IList<Adult> Sadults { get; private set; }

        private readonly string adultsFile = "adults.json";
        private readonly string sadultsFile = "sadults.json";

        public FileContext()
        {
            Adults = File.Exists(adultsFile) ? ReadData<Adult>(adultsFile) : new List<Adult>();
            Sadults = File.Exists(sadultsFile) ? ReadData<Adult>(sadultsFile) : new List<Adult>();
        }

        private IList<T> ReadData<T>(string s)
        {
            using (var jsonReader = File.OpenText(s))
            {
                return JsonSerializer.Deserialize<List<T>>(jsonReader.ReadToEnd());
            }
        }

        public void SaveChanges()
        { 
            // storing persons
            string jsonAdults = JsonSerializer.Serialize(Adults, new JsonSerializerOptions
            {
                WriteIndented = true
            });
            using (StreamWriter outputFile = new StreamWriter(adultsFile, false))
            {
                outputFile.Write(jsonAdults);
            }
            
            string jsonsAdults = JsonSerializer.Serialize(Sadults, new JsonSerializerOptions
            {
                WriteIndented = true
            });
            using (StreamWriter outputFile = new StreamWriter(sadultsFile, false))
            {
                outputFile.Write(jsonsAdults);
            }
            
        }
    }
}