using System.Collections.Generic;

namespace ClassLibrary
{
    public class CommandManager
    {
        private Stack<ICommand> _history = new Stack<ICommand>();

        public void Execute(ICommand command)
        {
            command.Execute();
            _history.Push(command);
        }

        public void Undo()
        {
            if (_history.Count > 0)
            {
                _history.Pop().Undo();
            }
        }
    }
}