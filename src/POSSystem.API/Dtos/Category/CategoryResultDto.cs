using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POSSystem.API.Dtos.Category
{
    public class CategoryResultDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

    }
}
