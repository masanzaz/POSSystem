﻿using System;
using System.ComponentModel.DataAnnotations;

namespace POSSystem.API.Dtos.PaymentMethod
{
    public class PaymentEditDto
    {
        [Required(ErrorMessage = "The field {0} is required")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "The field {0} is required")]
        [StringLength(50, ErrorMessage = "The field {0} must be between {2} and {1} characters", MinimumLength = 2)]
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
