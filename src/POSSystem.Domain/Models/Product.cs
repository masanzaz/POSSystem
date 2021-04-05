using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace POSSystem.Domain.Models
{
    public class Product : EntityEf<Guid>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string BarCode { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public Guid CategoryId { get; set; }

        /* EF Relation */
        public Category Category { get; set; }
    }
}
