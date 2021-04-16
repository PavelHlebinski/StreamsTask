using System;
using System.IO;

namespace StreamsTask.Workers
{
    public class FileStreamWorker
    {
        public void Write(string text, string fileName, string path)
        {
            try
            {
                var file = Path.Combine(path, fileName);
                using var fileStream = new FileStream(file, FileMode.OpenOrCreate, FileAccess.Write);
                using var streamWriter = new StreamWriter(fileStream);
                streamWriter.WriteLine(text);
            }
            catch
            {
                Console.WriteLine("Directory not found");
            }
        }

        public void Read(string fileName, string path)
        {
            try
            {
                var file = Path.Combine(path, fileName);
                using var fileStream = File.OpenRead(file);
                using var streamReader = new StreamReader(fileStream);
                var text = streamReader.ReadToEnd();
                Console.WriteLine($"Text from file: {text}");
            }
            catch
            {
                Console.WriteLine("File not Found");
            }
        }
    }
}
