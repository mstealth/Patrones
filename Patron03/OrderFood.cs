namespace Patron03
{
    public class OrderFood : OrderBase
    {
        protected override void PrepareOrder()
        {
            Console.WriteLine("Preparando la orden...");
        }
    }
}
