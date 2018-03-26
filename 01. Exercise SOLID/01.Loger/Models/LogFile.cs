using System;
using System.IO;
using _01.Loger.Models.Contracts;

namespace _01.Loger.Models
{
    public class LogFile : ILogFile
    {
        private const string DafaultPath = "./data/";

        public LogFile(string fileName)
        {
            Path = DafaultPath + fileName;
            InitializeFile();
            Size = 0;
        }

        private void InitializeFile()
        {
            Directory.CreateDirectory(DafaultPath);
            File.AppendAllText(this.Path, "");
        }

        public string Path { get; }
        public int Size { get; private set; }

        public void WriteToFile(string errorLog)
        {
            File.AppendAllText(this.Path, errorLog + Environment.NewLine);

            int addedSize = 0;
            for (int i = 0; i < errorLog.Length; i++)
            {
                addedSize += errorLog[i];
            }

            this.Size += addedSize;
        }
    }
}