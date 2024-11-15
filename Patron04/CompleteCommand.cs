namespace Patron04
{
    public class CompleteCommand : ICommand
    {
        private Task tarea;

        public CompleteCommand(Task tarea)
        {
            this.tarea = tarea;
        }

        public void Execute()
        {
            tarea.Complete();
        }

        public void Undo()
        {
            tarea.IsCompleted = false;
            Console.WriteLine($"Tarea '{tarea.Descripcion}' marcada como imcompleta.");
        }
    }
}