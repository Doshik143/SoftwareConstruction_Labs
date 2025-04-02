using ClassLibrary;
using System;

namespace TestProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            //CreatieListOf 3 Items
            var ul = new LightElementNode("ul", "block", "double");
            ul.AddCssClass("list");

            for (int i = 1; i <= 3; i++)
            {
                var li = new LightElementNode("li", "block", "double");
                li.AddChild(new LightTextNode($"Item {i}"));
                ul.AddChild(li);
            }

            //CreateHeader
            var h1 = new LightElementNode("h1", "block", "double");
            h1.AddChild(new LightTextNode("MyList"));

            //CreateContainer
            var div = new LightElementNode("div", "block", "double");
            div.AddCssClass("container");
            div.AddChild(h1);
            div.AddChild(ul);

            //HTML Output
            Console.WriteLine("\nOuterHTML Of Container: ");
            Console.WriteLine(div.OuterHTML);

            Console.WriteLine("\nInnerHTML Of Container: ");
            Console.WriteLine(div.InnerHTML);

            Console.WriteLine("\nOuterHTML Of List: ");
            Console.WriteLine(ul.OuterHTML);

            //CreateTable
            var table = new LightElementNode("table", "block", "double")
                .AddCssClass("data-table")
                .AddChild(new LightElementNode("tr", "block", "double")
                    .AddChild(new LightElementNode("th", "block", "double")
                        .AddChild(new LightTextNode("Name")))
                    .AddChild(new LightElementNode("th", "block", "double")
                        .AddChild(new LightTextNode("Age"))))
                .AddChild(new LightElementNode("tr", "block", "double")
                    .AddChild(new LightElementNode("td", "block", "double")
                        .AddChild(new LightTextNode("Tom")))
                    .AddChild(new LightElementNode("td", "block", "double")
                        .AddChild(new LightTextNode("24"))));

            Console.WriteLine("\nTable: ");
            Console.WriteLine(table.OuterHTML);
            Console.ReadLine();
        }
    }
}