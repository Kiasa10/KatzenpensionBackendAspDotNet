using KatzenpensionApi.ApiDtos.Mappings;
using KatzenpensionApi.ApiDtos.ResponseDtos;
using KatzenpensionApi.Services.RoomService;
using Microsoft.AspNetCore.Mvc;

namespace KatzenpensionApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController(IRoomService roomService) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<RoomResponseDto>>> GetAllRooms()
        {
            var rooms = await roomService.GetAllRooms();
            var response = rooms.Select(r => r.ToResponseDto()).ToList();

            return Ok(response);
        }
    }
}
