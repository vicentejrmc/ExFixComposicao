using System;
using System.Collections.Generic;
using System.Text;

namespace ExFixComposicao.Entities
{
    internal class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }

        public OrderItem() 
        { 
        }

        public OrderItem(int quantity, double price)
        {
            Quantity = quantity;
            Price = price;
        }

        public double SubTotal(int quantity, double price)
        {
           double subTotal = 0.0;
           return quantity * price;
        }
    }
}
