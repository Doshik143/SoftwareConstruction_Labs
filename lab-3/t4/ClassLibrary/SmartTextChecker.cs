using System;

namespace ClassLibrary
{
    public class SmartTextChecker : SmartTextReader
    {
        public override char[][] ReadTextFile(string filePath)
        {
            Console.WriteLine($"Trying Open File: {filePath}");

            try
            {
                char[][] result = base.ReadTextFile(filePath);
                Console.WriteLine($"File {filePath} successfully opened and read");

                int totalLines = result.Length;
                int totalChars = 0;
                foreach (var line in result)
                {
                    totalChars += line.Length;
                }

                Console.WriteLine($"Lines Read: {totalLines}");
                Console.WriteLine($"Symbols Read: {totalChars}");
                Console.WriteLine($"File {filePath} closed");

                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error While Working With File {filePath}: {ex.Message}");
                throw;
            }
        }
    }
}