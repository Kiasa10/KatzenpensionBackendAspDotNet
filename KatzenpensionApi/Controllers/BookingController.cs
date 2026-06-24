
using KatzenpensionApi.ApiDtos.Mappings;
using KatzenpensionApi.ApiDtos.RequestDtos;
using KatzenpensionApi.ApiDtos.ResponseDtos;
using KatzenpensionApi.Services.BookingService;
using Microsoft.AspNetCore.Mvc;

namespace KatzenpensionApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController(IBookingService bookingService) : ControllerBase
    {

        [HttpGet("{id}")]
        public async Task<ActionResult<BookingResponseDto>> GetBookingById(Guid id)
        {
            var booking = await bookingService.GetBookingById(id);

            if (booking is null)
            {
                return NotFound();
            }

            return Ok(booking.ToResponseDto());
        }

        [HttpPost]
        public async Task<ActionResult> CreateBooking(CreateBookingRequestDto createBooking)
        {
            var bookingServiceDto = createBooking.ToServiceDto();
            var newBooking = await bookingService.CreateBooking(bookingServiceDto);

            if (newBooking is null)
            {
                return BadRequest("Booking could not be created");
            }

            var responseBooking = newBooking.ToResponseDto();

            return CreatedAtAction(nameof(GetBookingById), new { id = newBooking.Id }, responseBooking);
        }
    }
}
