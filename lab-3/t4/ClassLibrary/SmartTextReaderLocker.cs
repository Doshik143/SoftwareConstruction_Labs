using System;
using System.IO;
using System.Text.RegularExpressions;

namespace ClassLibrary
{
    public class SmartTextReaderLocker : SmartTextReader
    {
        private Regex _restrictedFilesPattern;

        public SmartTextReaderLocker(string pattern)
        {
            _restrictedFilesPattern = new Regex(pattern);
        }

        public override char[][] ReadTextFile(string filePath)
        {
            if (_restrictedFilesPattern.IsMatch(filePath))
            {
                Console.WriteLine("Access denied!");
                return null;
            }
            if (!File.Exists(filePath))
            {
                Console.WriteLine("File not found!");
                return null;
            }

            return base.ReadTextFile(filePath);
        }
    }
}