using System;
using System.IO;

namespace ClassLibrary
{
    public class FileWriter
    {
        private string _filePath;

        public FileWriter(string filePath)
        {
            _filePath = filePath;
        }

        public void Write(string text)
        {
            File.AppendAllText(_filePath, text);
        }

        public void WriteLine(string text)
        {
            File.AppendAllText(_filePath, text + Environment.NewLine);
        }
    }
}