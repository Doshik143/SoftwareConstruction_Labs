namespace ClassLibrary
{
    public class ElementCounterVisitor : IVisitor
    {
        public int ElementCount { get; private set; }
        public int TextNodeCount { get; private set; }

        public void Visit(LightElementNode element)
        {
            ElementCount++;
        }

        public void Visit(LightTextNode textNode)
        {
            TextNodeCount++;
        }
    }
}