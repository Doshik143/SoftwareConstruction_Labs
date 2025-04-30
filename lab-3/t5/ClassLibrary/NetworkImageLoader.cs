using System.Net;

namespace ClassLibrary
{
    public class NetworkImageLoader : IImageLoadingStrategy
    {
        public byte[] LoadImage(string href)
        {
            using (WebClient client = new WebClient())
            {
                return client.DownloadData(href);
            }
        }
    }
}