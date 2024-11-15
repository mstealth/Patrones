namespace Patron03
{
    public class OrderDessert : OrderBase
    {
        protected override void PrepareOrder()
        {
            Console.WriteLine("Preparando dessert order...");
        }

        protected override void CalculatePrice()
        {
            Console.WriteLine("Calculando precio con descuento para dessert...");
        }
    }
}
