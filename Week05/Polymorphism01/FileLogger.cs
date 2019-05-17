namespace Polymorphism01
{
    using System.Collections.Generic;
    using System.IO;

    public class FileLogger : ILogger
    {
        private readonly string fileName;

        public FileLogger(string fileName)
        {
            this.fileName = fileName;
        }

        public void Log(string s)
        {
            File.AppendAllLines(this.fileName, new List<string> {s});
        }
    }
}