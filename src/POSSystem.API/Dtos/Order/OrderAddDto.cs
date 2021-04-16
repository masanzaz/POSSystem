using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using POSSystem.API.Dtos.OrderDetail;

namespace POSSystem.API.Dtos.Order
{
    public class OrderAddDto
    {
        [Required(ErrorMessage = "The field {0} is required")]
        public Guid CustomerId { get; set; }
        [Required(ErrorMessage = "The field {0} is required")]
        public DateTime OrderDate { get; set; }

        [Required(ErrorMessage = "The field {0} is required")]
        public string Codigo { get; set; }

        [Required(ErrorMessage = "The field {0} is required")]
        public Guid PaymentId { get; set; }
        public string Observation { get; set; }

        public IEnumerable<OrderDetailAddDto> orderDetails { get; set; }
    }
}
