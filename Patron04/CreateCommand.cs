namespace Patron04
{
    internal class CreateCommand : ICommand
    {
        private Task tarea;
        private string descripcion;
        public CreateCommand(Task tarea, string descripcion)
        {
            this.tarea = tarea;
            this.descripcion = descripcion;
        }

        public void Execute()
        {
            tarea.Create(descripcion);
        }

        public void Undo()
        {
            tarea.Delete();
        }
    }
}
