using System;

namespace Constructors
{

    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer(2);
            customer.Id = 1;
            customer.Name = "Jeff";

            var order = new Order();

            customer.Orders.Add(order);

            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);

        }
    }
}
