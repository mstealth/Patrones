namespace Patron04
{
    public class Task
    {
        public string Descripcion { get; set; }
        public bool IsCompleted { get; set; }

        public void Create(string descripcion)
        {
            Descripcion = descripcion;
            Console.WriteLine($"Tarea '{Descripcion}' creada.");
        }

        public void Edit(string nuevaDescripcion)
        {
            Console.WriteLine($"Tarea '{Descripcion}' editada a '{nuevaDescripcion}'.");
            Descripcion = nuevaDescripcion;
        }

        public void Complete()
        {
            IsCompleted = true;
            Console.WriteLine($"Tarea '{Descripcion}' marcada como completa.");
        }

        public void Delete()
        {
            Console.WriteLine($"Tarea '{Descripcion}' borrada.");
            Descripcion = null;
            IsCompleted = false;
        }
    }
}
