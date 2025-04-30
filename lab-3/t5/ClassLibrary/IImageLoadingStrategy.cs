namespace ClassLibrary
{
    public interface IImageLoadingStrategy
    {
        byte[] LoadImage(string href);
    }
}