namespace ClassLibrary
{
    public class LightTextNode : LightNode
    {
        private string _text;

        public LightTextNode(string text) : base(null)
        {
            _text = text;
        }

        public override string OuterHTML => _text;
        public override string InnerHTML => _text;

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}