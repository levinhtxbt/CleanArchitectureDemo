using System.Threading.Tasks;
using CleanArchitectureDemo.Application.Rooms.Queries.GetRooms;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitectureDemo.WebUI.Controllers
{
    public class RoomController : BaseController
    {

        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<RoomsVm>> GetAll()
        {
            var vm = await Mediator.Send(new GetRoomsQuery());

            return base.Ok(vm);
        }
    }
}
