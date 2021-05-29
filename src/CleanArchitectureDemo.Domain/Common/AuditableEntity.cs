using System;

namespace CleanArchitectureDemo.Domain.Common
{
    public class AuditableEntity
    {
        public string CreatedBy { get; set; }

        public DateTime CreatedAt { get; set; }

        public string LastModifiedBy { get; set; }

        public DateTime? LastModified { get; set; }
    }
}
