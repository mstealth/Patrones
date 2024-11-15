namespace Patron03
{
    public abstract class OrderBase
    {
        public void ProcessOrder()
        {
            TakeOrder();
            if (CheckAvailability())
            {
                PrepareOrder();
                CalculatePrice();
                CompleteOrder();
            }
            else
            {
                Console.WriteLine("Producto no disponible.");
            }
        }

        protected void TakeOrder()
        {
            Console.WriteLine("Tomando orden del cliente...");
        }

        protected virtual bool CheckAvailability()
        {
            Console.WriteLine("Revisando disponibilidad...");
            return true;
        }

        protected abstract void PrepareOrder();

        protected virtual void CalculatePrice()
        {
            Console.WriteLine("Calculando precio...");
        }

        protected void CompleteOrder()
        {
            Console.WriteLine("Orden está completa y lista para entrega!");
        }
    }
}
