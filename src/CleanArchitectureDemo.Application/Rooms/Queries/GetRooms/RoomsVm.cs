using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureDemo.Application.Rooms.Queries.GetRooms
{
    public class RoomsVm
    {
        public RoomsVm()
        {
            
        }

        public IList<RoomDto> Rooms { get; set; }
    }
}
