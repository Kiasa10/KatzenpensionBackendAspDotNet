using KatzenpensionApi.ApiDtos.ResponseDtos;
using KatzenpensionApi.Services.RegularGuestService;
using Microsoft.AspNetCore.Mvc;


namespace KatzenpensionApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegularGuestController(IRegularGuestService guestService) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<RegularGuestResponseDto>>> getAllRegularGuests()
        {
            var guests = await guestService.GetAllGuests();
            var response = guests.Select(g => new RegularGuestResponseDto(
                Id: g.Id,
                Name: g.Name,
                Age: g.Age,
                ImageUrlReact: g.ImageUrlReact,
                ImageUrlAngular: g.ImageUrlAngular,
                DescriptionShort: g.DescriptionShort,
                DescriptionLong: g.DescriptionLong
                )).ToList();

            return Ok(response);
        }
    }
}
