using System;

namespace Interface_Testability
{
    public class Order
    {
        public bool IsShipped;
        public Shipment Shipment;

        public DateTime DatePlaced { get; set; }
        public float TotalPrice { get; set; }
    }
}