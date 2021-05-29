using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArchitectureDemo.Application.Common.Mappings;
using CleanArchitectureDemo.Domain.Entities;
using CleanArchitectureDemo.Domain.Enums;

namespace CleanArchitectureDemo.Application.Rooms.Queries.GetRooms
{
    public class RoomDto : IMapFrom<Room>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public RoomType Type { get; set; }

        public int? Capacity { get; set; }

        public bool Active { get; set; }
    }
}
