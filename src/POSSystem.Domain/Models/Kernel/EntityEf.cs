using POSSystem.Domain.Models.Kernel;
using System;
using System.Text;

namespace POSSystem.Domain.Models
{
    public abstract class EntityEf<TId> : Entity<TId>, IAuditable
    {
        protected EntityEf()
        {
            Active = true;
        }

        protected EntityEf(TId id) : base(id)
        {
            Active = true;
        }

        public bool Active { get; set; }
        public string CreatedByUser { get; set; }
        public string CreatedIp { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedByUser { get; set; }
        public string ModifiedIp { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
