namespace ClassLibrary
{
    public abstract class LightNode
    {
        private string _tagName;
        protected string TagName => _tagName;
        protected LightNode(string tagName)
        {
            _tagName = tagName;
        }
        public virtual string OuterHTML { get; }
        public abstract string InnerHTML { get; }
    }
}