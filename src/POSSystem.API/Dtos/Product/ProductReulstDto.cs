using System;
using System.ComponentModel.DataAnnotations;

namespace POSSystem.API.Dtos.Product
{
    public class ProductResultDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string BarCode { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public Guid CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
