﻿using System;

namespace Interface_Testability
{
    class Program
    {
        static void Main(string[] args)
        {
            var orderProcessor = new OrderProcessor();

            var order = new Order { DatePlaced = DateTime.Now, TotalPrice = 100f };

            orderProcessor.Process(order);
        }
    }
}
