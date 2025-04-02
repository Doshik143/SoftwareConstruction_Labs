using System;

namespace ClassLibrary
{
    public class VectorRenderer : IRenderer
    {
        public void RenderShape(string shapeName)
        {
            Console.WriteLine($"Drawing {shapeName} As Vector");
        }
    }
}