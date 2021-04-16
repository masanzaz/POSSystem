using System;
using System.Collections.Generic;
using System.Text;

namespace POSSystem.Domain.Models
{
    public class PaymentMethod : EntityEf<Guid>
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public IEnumerable<Order> orders { get; set; }
    }
}
