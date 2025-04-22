namespace ClassLibrary
{
    public class TextDocument
    {
        public string Content { get; private set; }

        public TextDocument(string content)
        {
            Content = content;
        }

        public void Edit(string newContent)
        {
            Content = newContent;
        }
        //CreatingSnapshot
        public TextDocumentMemento CreateMemento()
        {
            return new TextDocumentMemento(Content);
        }
        //RestoringStateFromSnapshot
        public void RestoreFromMemento(TextDocumentMemento memento)
        {
            Content = memento.GetSavedContent();
        }

        public override string ToString()
        {
            return Content;
        }
    }
}