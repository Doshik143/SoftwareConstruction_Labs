using System;

namespace ClassLibrary
{
    public class TextEditor
    {
        private readonly TextDocument _document;
        private readonly History _history;

        public TextEditor(string initialContent)
        {
            _document = new TextDocument(initialContent);
            _history = new History();
            Save(); //SaveInitialState
        }

        public void Edit(string newContent)
        {
            Save(); //SaveStateBeforeChange
            _document.Edit(newContent);
        }

        public void Save()
        {
            _history.Save(_document);
        }

        public void Undo()
        {
            _history.Undo(_document);
        }

        public void Print()
        {
            Console.WriteLine($"\t↓---Current Content---↓\n\n→ {_document}");
            Console.WriteLine("--------------------------------------------------");
        }
    }
}