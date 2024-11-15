namespace Patron03
{
    public class OrderBeverage : OrderBase
    {
        protected override void PrepareOrder()
        {
            Console.WriteLine("Preparando beverage order...");
        }

        protected override bool CheckAvailability()
        {
            Console.WriteLine("Revisando disponibilidad de beverage...");
            // Lógica personalizada para verificar disponibilidad de bebidas
            return true;
        }

        protected override void CalculatePrice()
        {
            Console.WriteLine("Calculando precio del impuesto para beverage...");
        }
    }
}
