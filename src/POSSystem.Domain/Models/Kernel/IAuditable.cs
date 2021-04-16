using System;
using System.Collections.Generic;
using System.Text;

namespace POSSystem.Domain.Models.Kernel
{
    public interface IAuditable
    {
        bool Active { get; set; }
        string CreatedByUser { get; set; }
        string CreatedIp { get; set; }
        DateTime CreatedDate { get; set; }
        string ModifiedByUser { get; set; }
        string ModifiedIp { get; set; }
        DateTime? ModifiedDate { get; set; }
    }
}
