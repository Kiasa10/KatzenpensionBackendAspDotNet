using KatzenpensionApi.ApiDtos.Mappings;
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
        public async Task<ActionResult<List<RegularGuestResponseDto>>> GetAllRegularGuests()
        {
            var guests = await guestService.GetAllGuests();
            var response = guests.Select(g => g.ToResponseDto()).ToList();

            return Ok(response);
        }
    }
}
