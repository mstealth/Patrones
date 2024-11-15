//Patrón Command
namespace Patron04
{
    public class Program
    {
        public static void Main()
        {
            Task tarea = new Task();
            TaskManager taskManager = new TaskManager();

            // Crear una nueva tarea
            ICommand createCommand = new CreateCommand(tarea, "Aprender patrones de diseño");
            taskManager.ExecuteCommand(createCommand);

            // Editar la tarea
            ICommand editCommand = new EditCommand(tarea, "Aprender patrones de diseño en c#");
            taskManager.ExecuteCommand(editCommand);

            // Completar la tarea
            ICommand completeCommand = new CompleteCommand(tarea);
            taskManager.ExecuteCommand(completeCommand);

            // Deshacer las últimas acciones
            Console.WriteLine("\nDeshaciendo último comando:");
            taskManager.UndoLastCommand();  // Deshacer completar

            Console.WriteLine("\nDeshaciendo otro comando:");
            taskManager.UndoLastCommand();  // Deshacer edición
        }
    }
}