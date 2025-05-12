using System;

namespace ClassLibrary
{
    public class LifecycleElement : LightElementNode
    {
        public LifecycleElement(string tagName, string displayType, string closingType)
            : base(tagName, displayType, closingType)
        {
            OnCreated();
        }

        protected internal void OnCreated()
        {
            Console.WriteLine($"Створено елемент: <{TagName}>");
        }

        protected internal void OnInserted()
        {
            Console.WriteLine($"Елемент <{TagName}> додано до DOM");
        }

        protected internal void OnTextRendered()
        {
            Console.WriteLine($"Відрендерено вміст елемента: <{TagName}>");
        }
    }
}