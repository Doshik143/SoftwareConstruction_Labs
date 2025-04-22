using ClassLibrary;
using System;

namespace TestProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------------------------");
            var editor = new TextEditor("Initial Text");
            editor.Print();

            Console.WriteLine("> Edit Document...");
            Console.WriteLine("-------");
            editor.Edit("FirstVersionOfText");
            editor.Print();

            Console.WriteLine("Edit Again...");
            Console.WriteLine("-------");
            editor.Edit("SecondVersionOfText");
            editor.Print();

            Console.WriteLine("Canceling Last Edit...");
            Console.WriteLine("-------");
            editor.Undo();
            editor.Print();

            Console.WriteLine("Canceling Again...");
            Console.WriteLine("-------");
            editor.Undo();
            editor.Print();

            Console.WriteLine("Attempting To Cancel When There Is No More History...");
            Console.WriteLine("-------");
            editor.Undo();
            editor.Print();

            Console.ReadLine();
        }
    }
}