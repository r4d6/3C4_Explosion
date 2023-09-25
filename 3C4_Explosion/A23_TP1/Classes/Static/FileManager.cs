using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml;

namespace A23_TP1.Classes
{
    public static class FileManager
    {
        private static JsonSerializerOptions JsonSerializerOptions = new JsonSerializerOptions()
        {
            WriteIndented = true
        };

        public enum FileName
        {
            Courses,
            Evaluations,
            Groups,
            Lessons,
            Periods,
            Users,
        };

        private static readonly List<string> FileNames = new List<string>()
        {
            "courses.txt",
            "evaluations.txt",
            "groups.txt",
            "lessons.txt",
            "periods.txt",
            "users.txt",
        };

        private static string GetFileName(FileName fileName)
        {
            return FileNames[(int)fileName];
        }

        public static T? ReadFromFileOrDefault<T>(FileName courses, T objectToDeserializeInto, T defaultObject)
        {
            var fileName = GetFileName(courses);
            try
            {
                string jsonContent = File.ReadAllText(fileName);

                var deserializedObject = JsonSerializer.Deserialize<T>(jsonContent, JsonSerializerOptions);
                if (deserializedObject != null)
                {
                    objectToDeserializeInto = deserializedObject;
                }
                else
                {
                    Console.WriteLine($"Cannot deserialize file {fileName}, deserialized object is null, using default");
                    objectToDeserializeInto = defaultObject;
                }

                return objectToDeserializeInto;
            }
            catch (IOException e)
            {
                Console.WriteLine($"Cannot open file {fileName} for reading, using default object.\n\nError : {e.Message}");
                objectToDeserializeInto = defaultObject;
                return default;
            }
        }

        public static void WriteFile<T>(FileName courses, T objectToSerialize)
        {
            var fileName = GetFileName(courses);
            try
            {
                using (var streamWriter = new StreamWriter(fileName))
                {
                    string jsonWriterString = JsonSerializer.Serialize(objectToSerialize, JsonSerializerOptions);
                    streamWriter.WriteLine(jsonWriterString);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine($"Cannot open file {fileName} for writing.\n\nError : {e.Message}");
            }
        }
    }
}
