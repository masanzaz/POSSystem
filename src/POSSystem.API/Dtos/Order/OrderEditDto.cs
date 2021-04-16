using POSSystem.API.Dtos.OrderDetail;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace POSSystem.API.Dtos.Order
{
    public class OrderEditDto
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "The field {0} is required")]
        public DateTime OrderDate { get; set; }

        [Required(ErrorMessage = "The field {0} is required")]
        public Guid CustomerId { get; set; }

        [Required(ErrorMessage = "The field {0} is required")]
        public Guid PaymentId { get; set; }
        public string Observation { get; set; }
        public IEnumerable<OrderDetailEditDto> orderDetails { get; set; }
    }
}
