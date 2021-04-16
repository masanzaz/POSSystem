using POSSystem.API.Dtos.OrderDetail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POSSystem.API.Dtos.Order
{
    public class OrderResultDto
    {
        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public string Codigo { get; set; }
        public Guid PaymentId { get; set; }
        public string Observation { get; set; }
        public string paymentMethodName { get; set; }
        public IEnumerable<OrderDetailResultDto> orderDetails { get; set; }
    }
}
