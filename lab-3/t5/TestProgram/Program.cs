using ClassLibrary;
using System;
using System.Text;

namespace TestProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            //CreatingTree
            var root = new LifecycleElement("div", "block", "double")
           .AddCssClass("container")
           .AddChild(new LifecycleElement("h1", "block", "double")
               .AddChild(new LightTextNode("Заголовок")))
           .AddChild(new LifecycleElement("ul", "block", "double")
               .AddChild(new LifecycleElement("li", "block", "double")
                   .AddChild(new LightTextNode("Пункт 1")))
               .AddChild(new LifecycleElement("li", "block", "double")
                   .AddChild(new LightTextNode("Пункт 2"))));
            //Iterators
            Console.WriteLine("\nОбхід в глибину:");
            var depthIterator = new DepthFirstIterator(root);
            while (depthIterator.HasNext())
            {
                Console.WriteLine(depthIterator.Next().GetType().Name);
            }

            Console.WriteLine("\nОбхід в ширину:");
            var breadthIterator = new BreadthFirstIterator(root);
            while (breadthIterator.HasNext())
            {
                Console.WriteLine(breadthIterator.Next().GetType().Name);
            }

            //Visitor
            var visitor = new ElementCounterVisitor();
            root.Accept(visitor);
            Console.WriteLine($"\nЕлементів: {visitor.ElementCount}, Текстових вузлів: {visitor.TextNodeCount}");
            
            //Command
            var commandManager = new CommandManager();
            var newElement = new LifecycleElement("p", "block", "double")
                .AddChild(new LightTextNode("Новий абзац"));

            commandManager.Execute(new AddChildCommand((LightElementNode)root, newElement));
            Console.WriteLine("\nПісля додавання:");
            Console.WriteLine(root.OuterHTML);

            commandManager.Undo();
            Console.WriteLine("\nПісля скасування:");
            Console.WriteLine(root.OuterHTML);

            //State
            var button = new LifecycleElement("button", "inline", "double")
            .AddChild(new LightTextNode("Натисни мене"));

            Console.WriteLine("\nПочатковий стан:");
            Console.WriteLine(button.OuterHTML);

            Console.WriteLine("\nСтан наведення:");
            button.ChangeState(new HoverState());
            Console.WriteLine(button.OuterHTML);

            Console.WriteLine("\nАктивний стан:");
            button.ChangeState(new ActiveState());
            Console.WriteLine(button.OuterHTML);

            Console.WriteLine("\nСтан фокусу:");
            button.ChangeState(new FocusState());
            Console.WriteLine(button.OuterHTML);

            Console.ReadLine();
        }
    }
}