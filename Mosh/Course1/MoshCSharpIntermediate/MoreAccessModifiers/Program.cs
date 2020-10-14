namespace MoreAccessModifiers
{

    public class GoldCustomer : Customer
    {
        public void OfferVoucher()
        {
            var rating = this.CalculateRating(excludeOrders: true);
        }
    }

    class Program
    {
        
        static void Main(string[] args)
        {
            var customer = new Customer();


        }
    }
}
