using ClassLibrary;
using System;

namespace TestProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------Result--------------------");

            //CreateRenderers
            IRenderer vectorRenderer = new VectorRenderer();
            IRenderer pixelRenderer = new PixelsRenderer();

            //CreateShapesWithDifferentRenderers
            Shape vectorCircle = new Circle(vectorRenderer);
            Shape pixelCircle = new Circle(pixelRenderer);

            Shape vectorSquare = new Square(vectorRenderer);
            Shape pixelSquare = new Square(pixelRenderer);

            Shape vectorTriangle = new Triangle(vectorRenderer);
            Shape pixelTriangle = new Triangle(pixelRenderer);

            //DrawingShapes
            Console.WriteLine("\n↓-------Vector Renderer-------↓");
            vectorCircle.Draw();
            vectorSquare.Draw();
            vectorTriangle.Draw();

            Console.WriteLine("\n↓-------Pixel Renderer-------↓");
            pixelCircle.Draw();
            pixelSquare.Draw();
            pixelTriangle.Draw();

            //AdditionalExample(YouCanEasilyChangeTheRenderer)
            Console.WriteLine("\n\n\n-------→ChangingRendererForShape←----------");
            Shape shape = new Square(vectorRenderer);
            shape.Draw(); //VectorRenderer

            //ChangingRenderer
            shape = new Square(pixelRenderer);
            shape.Draw(); //Pixel Renderer

            Console.ReadLine();
        }
    }
}