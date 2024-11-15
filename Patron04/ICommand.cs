namespace Patron04
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}
