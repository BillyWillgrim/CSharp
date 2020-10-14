using System;

namespace MoreAccessModifiers
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            var rating = CalculateRating(excludeOrders: true);
            if (rating == 0)
            {
                Console.WriteLine("Promoted to level 2");
            }
            else
            {
                Console.WriteLine("Not promoted.");
            }
        }

        // this method is about the implementation detail of the Customer class
        // from the outside we don't really need to see this method 
        // the consumers of the custoemr class are only interested in the two fields and the Promote method
        protected int CalculateRating(bool excludeOrders)
        {
            return 0;
        }
    }
}
