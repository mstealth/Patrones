//Patrón Template
namespace Patron03
{
    public class Program
    {
        public static void Main()
        {
            OrderBase foodOrder = new OrderFood();
            OrderBase beverageOrder = new OrderBeverage();
            OrderBase dessertOrder = new OrderDessert();

            Console.WriteLine("Procesando Food Order:");
            foodOrder.ProcessOrder();

            Console.WriteLine("\nProcesando Beverage Order:");
            beverageOrder.ProcessOrder();

            Console.WriteLine("\nProcesando Dessert Order:");
            dessertOrder.ProcessOrder();
        }
    }
}