using System;
using System.Collections.Generic;

namespace POSSystem.Domain.Models
{
    public class Category : EntityEf<Guid>
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public IEnumerable<Product> Products { get; set; }
    }
}
