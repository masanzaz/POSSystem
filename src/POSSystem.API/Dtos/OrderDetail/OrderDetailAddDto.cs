using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace POSSystem.API.Dtos.OrderDetail
{
    public class OrderDetailAddDto
    {
        public Guid OrderId { get; set; }

        [Required(ErrorMessage = "The field {0} is required")]
        public Guid ProductId { get; set; }

        [Required(ErrorMessage = "The field {0} is required")]
        public decimal UnitPrice { get; set; }

        [Required(ErrorMessage = "The field {0} is required")]
        public int Quantity { get; set; }
        public decimal Discount { get; set; }
        public decimal Total { get; set; }
    }
}
