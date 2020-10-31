using System.IO;
using Newtonsoft.Json;

namespace ContactsApp
{
    /// <summary>
    /// Static class for save\load with json
    /// </summary>
    public static class ProjectManager
    {
        /// <summary>
        /// Uses Newtonsoft Json library to save data to specified file.
        /// </summary>
        /// <param name="data">Wrapper class with data to save.</param>
        /// <param name="file">Location of file to save.</param>
        public static void SaveToFile(Project data, string file)
        {
            JsonSerializer serializer = new JsonSerializer
            {
                Formatting = Formatting.Indented,
                TypeNameHandling = TypeNameHandling.All
            };

            using (StreamWriter sw = new StreamWriter(file))
            using (JsonWriter writer = new JsonTextWriter(sw))
            { 
                serializer.Serialize(writer, data);
            }
        }

        /// <summary>
        /// Uses Newtonsoft Json library to load data from specified file.
        /// </summary>
        /// <param name="file">Location of file with saved data.</param>
        public static Project LoadFromFile(string file)
        {
            JsonSerializer serializer = new JsonSerializer
            {
                Formatting = Formatting.Indented,
                TypeNameHandling = TypeNameHandling.All
            };

            using (StreamReader sr = new StreamReader(file))
            using (JsonReader reader = new JsonTextReader(sr))
            {
                return (Project) serializer.Deserialize<Project>(reader);
            }
        }
        
    }
}
