using System;

namespace ClassLibrary
{
    public class FileLoggerAdapter : Logger
    {
        private FileWriter _fileWriter;

        public FileLoggerAdapter(string filePath)
        {
            _fileWriter = new FileWriter(filePath);
        }

        public new void Log(string message)
        {
            _fileWriter.WriteLine($"[LOG] {DateTime.Now}: {message}");
        }

        public new void Error(string message)
        {
            _fileWriter.WriteLine($"[ERROR] {DateTime.Now}: {message}");
        }

        public new void Warn(string message)
        {
            _fileWriter.WriteLine($"[WARN] {DateTime.Now}: {message}");
        }
    }
}