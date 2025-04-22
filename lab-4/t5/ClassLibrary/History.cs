using System.Collections.Generic;

namespace ClassLibrary
{
    public class History
    {
        private readonly Stack<TextDocumentMemento> _history = new Stack<TextDocumentMemento>();

        public void Save(TextDocument document)
        {
            _history.Push(document.CreateMemento());
        }

        public void Undo(TextDocument document)
        {
            if (_history.Count > 0)
            {
                document.RestoreFromMemento(_history.Pop());
            }
        }
    }
}