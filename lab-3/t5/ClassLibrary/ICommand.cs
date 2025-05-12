namespace ClassLibrary
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}