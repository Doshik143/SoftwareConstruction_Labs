using ClassLibrary;
using System;
using System.IO;
using System.Text;

namespace TestProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            //OrdinaryLogger
            Console.WriteLine("Використання звичайного логера:");
            Logger consoleLogger = new Logger();
            consoleLogger.Log("Це інформаційне повідомлення");
            consoleLogger.Warn("Це попередження");
            consoleLogger.Error("Це помилка");

            //FileLogger
            Console.WriteLine("\nВикористання файлового логера:");
            string logFilePath = "application.log";
            FileLoggerAdapter fileLogger = new FileLoggerAdapter(logFilePath);

            fileLogger.Log("Це інформаційне повідомлення у файл");
            fileLogger.Warn("Це попередження у файл");
            fileLogger.Error("Це помилка у файл");

            Console.WriteLine($"\nПеревірте вміст файлу {logFilePath}");
            Console.WriteLine("Вміст файлу:");
            Console.WriteLine(File.ReadAllText(logFilePath));

            Console.ReadLine();
        }
    }
}