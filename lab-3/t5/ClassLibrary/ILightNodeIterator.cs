namespace ClassLibrary
{
    public interface ILightNodeIterator
    {
        bool HasNext();
        LightNode Next();
    }
}