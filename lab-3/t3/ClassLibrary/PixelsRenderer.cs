using System;

namespace ClassLibrary
{
    public class PixelsRenderer : IRenderer
    {
        public void RenderShape(string shapeName)
        {
            Console.WriteLine($"Drawing {shapeName} As Pixels");
        }
    }
}