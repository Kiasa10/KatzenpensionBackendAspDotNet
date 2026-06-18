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

            var response = rooms.Select(r => new RoomResponseDto(
                Id: r.Id,
                Title: r.Title,
                Cost: r.Cost,
                ImageUrlReact: r.ImageUrlReact,
                ImageUrlAngular: r.ImageUrlAngular,
                DescriptionShort: r.DescriptionShort,
                DescriptionLong: r.DescriptionLong,
                CatsPossible: r.CatsPossible)).ToList();

            return Ok(response);
        }
    }
}
