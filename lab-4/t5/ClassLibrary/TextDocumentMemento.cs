namespace ClassLibrary
{
    public class TextDocumentMemento
    {
        private readonly string _content;

        public TextDocumentMemento(string content)
        {
            _content = content;
        }

        public string GetSavedContent()
        {
            return _content;
        }
    }
}