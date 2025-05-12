namespace ClassLibrary
{
    public class AddChildCommand : ICommand
    {
        private LightElementNode _parent;
        private LightNode _child;
        private bool _executed = false;

        public AddChildCommand(LightElementNode parent, LightNode child)
        {
            _parent = parent;
            _child = child;
        }

        public void Execute()
        {
            if (!_executed)
            {
                _parent.AddChild(_child);
                _executed = true;
            }
        }

        public void Undo()
        {
            if (_executed)
            {
                _parent.RemoveChild(_child);
                _executed = false;
            }
        }
    }
}