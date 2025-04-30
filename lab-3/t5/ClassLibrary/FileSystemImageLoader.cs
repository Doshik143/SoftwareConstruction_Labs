using System.IO;

namespace ClassLibrary
{
    public class FileSystemImageLoader : IImageLoadingStrategy
    {
        public byte[] LoadImage(string href)
        {
            if (!File.Exists(href))
                throw new FileNotFoundException($"File Not Found: {href}");

            return File.ReadAllBytes(href);
        }
    }
}