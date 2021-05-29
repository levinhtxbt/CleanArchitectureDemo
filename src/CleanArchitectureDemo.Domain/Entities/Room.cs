using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArchitectureDemo.Domain.Enums;

namespace CleanArchitectureDemo.Domain.Entities
{
    public class Room
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public RoomType Type { get; set; }

        public int? Capacity { get; set; }

        public bool Active { get; set; }

        public ICollection<Event> Events { get; set; }
    }
}
