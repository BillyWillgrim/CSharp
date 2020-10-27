using System;

namespace Interface_Testability
{
    internal class OrderProcessor
    {
        private readonly ShipemtCalculator _shippingCalculator;

        public OrderProcessor()
        {
            _shippingCalculator = new ShipemtCalculator();
        }

        public void Process(Order order)
        {

            if (order.IsShipped)
            {
                throw new InvalidOperationException("This order is already processed");
            }
            order.Shipment = new Shipment
            {
                Cost = _shippingCalculator.CalculateShipping(order),
                ShippingDate = DateTime.Today.AddDays(1)
            };
        }
    }
}