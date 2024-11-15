//Patrón Decorator
namespace Patron05
{
    public class Program
    {
        public static void Main()
        {
            // Habitación básica
            Room myRoom = new BasicRoom();
            Console.WriteLine($"{myRoom.GetDescripcion()} - Costo: ${myRoom.GetCosto()}");

            // Agregar flores frescas
            myRoom = new FlowerDecorator(myRoom);
            Console.WriteLine($"{myRoom.GetDescripcion()} - Costo: ${myRoom.GetCosto()}");

            // Agregar chocolate gourmet
            myRoom = new ChocolateDecorator(myRoom);
            Console.WriteLine($"{myRoom.GetDescripcion()} - Costo: ${myRoom.GetCosto()}");

            // Agregar vino de alta calidad
            myRoom = new WineDecorator(myRoom);
            Console.WriteLine($"{myRoom.GetDescripcion()} - Costo: ${myRoom.GetCosto()}");
        }
    }
}