using System.Collections.Generic;

namespace ClassLibrary
{
    public class DepthFirstIterator : ILightNodeIterator
    {
        private Stack<LightNode> _stack = new Stack<LightNode>();

        public DepthFirstIterator(LightNode root)
        {
            _stack.Push(root);
        }

        public bool HasNext() => _stack.Count > 0;

        public LightNode Next()
        {
            var current = _stack.Pop();

            if (current is LightElementNode element)
            {
                for (int i = element.ChildCount - 1; i >= 0; i--)
                {
                    _stack.Push(element.GetChild(i));
                }
            }

            return current;
        }
    }
}