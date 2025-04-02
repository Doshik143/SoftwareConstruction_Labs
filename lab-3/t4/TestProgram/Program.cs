using ClassLibrary;
using System;
using System.IO;

namespace TestProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            string testFilePath = "test.txt";
            File.WriteAllText(testFilePath, "Hello\nWorld\nThis is a test");

            Console.WriteLine("\n1. Testing SmartTextReader: ");
            var reader = new SmartTextReader();
            var content = reader.ReadTextFile(testFilePath);
            DisplayContent(content);

            Console.WriteLine("\n2. Testing SmartTextChecker: ");
            var checker = new SmartTextChecker();
            content = checker.ReadTextFile(testFilePath);
            DisplayContent(content);

            Console.WriteLine("\n3. Testing SmartTextReaderLocker: ");

            var locker = new SmartTextReaderLocker(@"\.(doc|docx|pdf)$");

            Console.WriteLine("Attempting Read Permitted File: ");
            content = locker.ReadTextFile(testFilePath);
            DisplayContent(content);

            string restrictedFile = "restricted.doc";
            File.WriteAllText(restrictedFile, "Hello, world!");
            Console.WriteLine("\nAttempt Read Prohibited File: ");
            if (File.Exists(restrictedFile))
            {
                content = locker.ReadTextFile(restrictedFile);
            }
            else
            {
                Console.WriteLine("Access denied! (File not found)");
                content = null;
            }
            DisplayContent(content);

            File.Delete(restrictedFile);
            File.Delete(testFilePath);
            Console.ReadLine();
        }

        static void DisplayContent(char[][] content)
        {
            if (content == null)
            {
                Console.WriteLine("(no content to display)");
                return;
            }

            Console.WriteLine("File Content: ");
            foreach (var line in content)
            {
                Console.WriteLine(new string(line));
            }
        }
    }
}