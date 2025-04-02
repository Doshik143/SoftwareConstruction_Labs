using ClassLibrary;
using System;
using System.IO;

namespace TestProgram
{
    internal class Program
    {
        static void Main()
        {
            try
            {
                string bookText = DownloadBook("https://www.gutenberg.org/cache/epub/1513/pg1513.txt");
                string[] lines = bookText.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);

                var htmlRoot = BookToHtmlConverter.ConvertTextToHtml(lines);

                File.WriteAllText("output.html", $"<!DOCTYPE html><html><head><meta charset='UTF-8'></head><body>{htmlRoot.OuterHTML}</body></html>");

                Console.WriteLine($"HTML Generated Successfully! Size: {htmlRoot.MemorySize / 1024} KB");
                Console.WriteLine($"Used LightweightVehicles: {TagStyleFlyweight.GetSharedStylesCount()}");
                Console.WriteLine("Result Saved In File 'output.html'");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            Console.ReadLine();
        }

        static string DownloadBook(string url)
        {
            using (var client = new System.Net.WebClient())
            {
                client.Encoding = System.Text.Encoding.UTF8;
                return client.DownloadString(url);
            }
        }
    }
}