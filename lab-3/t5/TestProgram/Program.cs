using ClassLibrary;
using System;

namespace TestProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            //CreateButton
            var button = new LightElementNode("button", "inline", "double");
            button.AddCssClass("btn-primary");
            button.AddChild(new LightTextNode("press me"));
            //AddingEventHandlers
            button.AddEventListener("click", () => {
                Console.WriteLine(" *Button Has Been Pressed!*");
            });

            button.AddEventListener("mouseover", () => {
                Console.WriteLine(" →Mouse Cursor Is On The Button!←");
            });

            //CreateLink
            var link = new LightElementNode("a", "inline", "double");
            link.AddCssClass("nav-link");
            link.AddChild(new LightTextNode("link"));

            link.AddEventListener("click", () => {
                Console.WriteLine(" *Link Was Clicked!*");
            });
            //CreatingContainer
            var container = new LightElementNode("div", "block", "double");
            container.AddCssClass("container");
            container.AddChild(button);
            container.AddChild(link);
            //HTML_Output
            Console.WriteLine("\t↓-------Generated_HTML-------↓\n");
            Console.WriteLine(container.OuterHTML);
            //SimulationOfEvents
            Console.WriteLine("\n\t↓-------Simulation_Of_Events-------↓\n");
            button.TriggerEvent("click");
            button.TriggerEvent("mouseover");
            link.TriggerEvent("click");
            //CreatingListWithEventHandlers
            var list = new LightElementNode("ul", "block", "double");
            for (int i = 1; i <= 3; i++)
            {
                var item = new LightElementNode("li", "block", "double");
                item.AddChild(new LightTextNode($"Item {i}"));

                int current = i;
                item.AddEventListener("click", () => {
                    Console.WriteLine($"An Item Is Selected {current}");
                });
                list.AddChild(item);
            }

            Console.WriteLine("\n\t↓-------Events_For_List-------↓");
            foreach (var child in list.GetChildren())
            {
                if (child is LightElementNode element)
                {
                    element.TriggerEvent("click");
                }
            }
            Console.ReadLine();
        }
    }
}