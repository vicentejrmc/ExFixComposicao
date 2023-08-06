using ExFixComposicao.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExFixComposicao.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    }
}
