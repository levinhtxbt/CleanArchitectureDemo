using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArchitectureDemo.Domain.Common;
using CleanArchitectureDemo.Domain.Enums;

namespace CleanArchitectureDemo.Domain.Entities
{
    public class Event : AuditableEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime? StartTime { get; set; }

        public DateTime? EndTime { get; set; }

        public string MeetingUrl { get; set; }

        public EventType Type { get; set; }

        public Room Room { get; set; }
    }
}
