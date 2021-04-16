using StreamsTask.Workers;
using System;

namespace StreamsTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = Environment.CurrentDirectory + "\\..\\..\\..\\Files";
            var text = "some string";
            var fileName = "Testfile.txt";
            FileStreamWorker fileStreamWorker = new FileStreamWorker();
            fileStreamWorker.Write(text, fileName, path);
            fileStreamWorker.Read(fileName, path);
        }
    }
}
