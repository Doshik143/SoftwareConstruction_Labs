using ClassLibrary;
using System;
using System.IO;
using System.Net;

namespace TestProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //CreatingContainer
            var container = new LightElementNode("div", "block", "double");
            container.AddCssClass("gallery-container");
            //AddingLocalImage
            try
            {
                Console.WriteLine("\t↓-------Trying_To_Load_Local_IMG-------↓\n");
                var localImage = new LightImageNode("image.jpg", new FileSystemImageLoader());
                Console.WriteLine($"Added Local IMG: {localImage.GetSourceInfo()}");

                localImage.AddEventListener("click", () => {
                    Console.WriteLine("Local Image Clicked!");
                });

                container.AddChild(localImage);
                Console.WriteLine($"IMG Size: {localImage.MemorySize} byte");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                Console.WriteLine($"Current Directory: {Directory.GetCurrentDirectory()}");
                Console.WriteLine("List Of Available Files:");
                foreach (var file in Directory.GetFiles(Directory.GetCurrentDirectory()))
                {
                    Console.WriteLine($"- {Path.GetFileName(file)}");
                }
            }
            //AddingNetworkImage
            try
            {
                Console.WriteLine("\n\t↓-------Trying_To_Download_Network_IMG-------↓\n");
                var webImage = new LightImageNode("https://example.com/image.jpg", new NetworkImageLoader());
                Console.WriteLine($"Added Network Image: {webImage.GetSourceInfo()}");

                webImage.AddEventListener("mouseover", () => {
                    Console.WriteLine("Mouse Cursor Is Placed On Network IMG Shown!");
                });

                container.AddChild(webImage);
            }
            catch (WebException ex)
            {
                Console.WriteLine($"Download Error: {ex.Message}");
            }
            //Output_HTML
            Console.WriteLine("\n\t↓-------Generated_HTML-------↓\n");
            Console.WriteLine(container.OuterHTML);
            //SimulationOfEvents
            Console.WriteLine("\n\t↓-------Simulation Of Events-------↓\n");
            foreach (var child in container.GetChildren())
            {
                if (child is LightImageNode img)
                {
                    img.TriggerEvent("click");
                    img.TriggerEvent("mouseover");
                }
            }
            //SavingResult
            File.WriteAllText("output.html", container.OuterHTML);
            Console.WriteLine("\n >Result Saved To File. 'output.html'");

            Console.ReadLine();
        }
    }
}