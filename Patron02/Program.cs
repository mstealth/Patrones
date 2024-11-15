//Patrón Observer
namespace Patron02
{
    public class Program
    {
        public static void Main()
        {
            // Creamos el servicio de mensajería
            MessageService messageService = new MessageService();

            // Creamos dispositivos y los añadimos al servicio de notificación
            IObservador dispositivo1 = new Telefono(1, 101);
            IObservador dispositivo2 = new Telefono(2, 101);
            IObservador dispositivo3 = new Tablet(3, 102);

            messageService.Attach(dispositivo1);
            messageService.Attach(dispositivo2);
            messageService.Attach(dispositivo3);
            Console.WriteLine();

            // Enviamos un mensaje
            messageService.SendMessage("Hola, este es un mensaje de prueba!");
            Console.WriteLine();

            // Removemos un dispositivo y enviamos otro mensaje
            messageService.Detach(dispositivo1);
            Console.WriteLine();

            // Enviamos un mensaje nuevo
            messageService.SendMessage("Este es otro mensaje!");
        }
    }
}