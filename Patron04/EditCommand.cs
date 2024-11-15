namespace Patron04
{
    public class EditCommand : ICommand
    {
        private Task tarea;
        private string descripcionAnterior;
        private string nuevaDescripcion;

        public EditCommand(Task tarea, string nuevaDescripcion)
        {
            this.tarea = tarea;
            this.descripcionAnterior = tarea.Descripcion;
            this.nuevaDescripcion = nuevaDescripcion;
        }

        public void Execute()
        {
            tarea.Edit(nuevaDescripcion);
        }

        public void Undo()
        {
            tarea.Edit(descripcionAnterior);
        }
    }
}
