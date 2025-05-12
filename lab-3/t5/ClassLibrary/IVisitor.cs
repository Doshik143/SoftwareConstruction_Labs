namespace ClassLibrary
{
    public interface IVisitor
    {
        void Visit(LightElementNode element);
        void Visit(LightTextNode textNode);
    }
}