using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace ContactsApp
{
    public static class ProjectManager
    {
        public static string FilePath = @"C:\json\json.txt";

        public static void SaveToFile(Project data, string file)
        {
            JsonSerializer serializer = new JsonSerializer
            {
                Formatting = Formatting.Indented,
                //DateFormatHandling = DateFormatHandling.IsoDateFormat,
                //DateTimeZoneHandling = DateTimeZoneHandling.RoundtripKind
            };

            using (StreamWriter sw = new StreamWriter(file))
            using (JsonWriter writer = new JsonTextWriter(sw))
            { 
                serializer.Serialize(writer, data);
            }
        }

        public static Project LoadFromFile(string file)
        {
            Project projectData = new Project();

            JsonSerializer serializer = new JsonSerializer
            {
                Formatting = Formatting.Indented,
                //DateFormatHandling = DateFormatHandling.IsoDateFormat,
                //DateTimeZoneHandling = DateTimeZoneHandling.RoundtripKind
            };

            StreamReader sr = new StreamReader(file);
            JsonReader reader = new JsonTextReader(sr);

            projectData = (Project)serializer.Deserialize<Project>(reader);


            return projectData;

        }
        
    }
}
