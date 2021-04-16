using System;
using System.Collections.Generic;
using System.Text;

namespace POSSystem.Domain.Models
{
    public class OrderDetail : EntityEf<Guid>
    {
        public Guid OrderId { get; set; }
        public Guid ProductId { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public decimal Discount { get; set; }
        public decimal Total { get; set; }

        /* EF Relation */
        public Order order { get; set; }
        public Product product { get; set; }

    }
}
