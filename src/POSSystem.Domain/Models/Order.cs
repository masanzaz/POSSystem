using System;
using System.Collections.Generic;
using System.Text;

namespace POSSystem.Domain.Models
{
    public class Order : EntityEf<Guid>
    {
        public Guid CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public string Codigo { get; set; }
        public Guid PaymentId { get; set; }
        public string Observation { get; set; }

        /* EF Relation */
        public Customer customer { get; set; }
        public PaymentMethod paymentMethod { get; set; }
        public IEnumerable<OrderDetail> orderDetails { get; set; }

    }
}
