namespace ClassLibrary
{
    public abstract class Shape
    {
        protected IRenderer renderer;
        public string Name { get; protected set; }

        protected Shape(IRenderer renderer)
        {
            this.renderer = renderer;
        }

        public abstract void Draw();
    }
}