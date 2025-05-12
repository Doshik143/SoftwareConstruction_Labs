using System.Collections.Generic;

namespace ClassLibrary
{
    public class BreadthFirstIterator : ILightNodeIterator
    {
        private Queue<LightNode> _queue = new Queue<LightNode>();

        public BreadthFirstIterator(LightNode root)
        {
            _queue.Enqueue(root);
        }

        public bool HasNext() => _queue.Count > 0;

        public LightNode Next()
        {
            var current = _queue.Dequeue();

            if (current is LightElementNode element)
            {
                for (int i = 0; i < element.ChildCount; i++)
                {
                    _queue.Enqueue(element.GetChild(i));
                }
            }

            return current;
        }
    }
}