namespace ClassLibrary
{
    public abstract class LightNodeWithLifecycle : LightNode
    {
        protected LightNodeWithLifecycle(string tagName) : base(tagName)
        {
            OnCreated();
        }
        protected virtual void OnCreated() { }
        protected virtual void OnInserted() { }
        protected virtual void OnRemoved() { }
        protected virtual void OnStylesApplied() { }
        protected virtual void OnTextRendered() { }

        public void Create()
        {
            OnCreated();
        }

        public void Insert()
        {
            OnInserted();
        }

        public void Remove()
        {
            OnRemoved();
        }

        public override string OuterHTML
        {
            get
            {
                OnStylesApplied();
                OnTextRendered();
                return "<div></div>";
            }
        }

        protected virtual string BuildHtml()
        {
            return base.OuterHTML;
        }
    }
}