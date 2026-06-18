
using KatzenpensionApi.ApiDtos.RequestDtos;
using KatzenpensionApi.ApiDtos.ResponseDtos;
using KatzenpensionApi.Dtos.Bookings;
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

            var responseBooking = new BookingResponseDto(
                booking.Id,
                booking.Room,
                booking.FirstDay,
                booking.LastDay,
                new ContactInfoResponseDto(
                    booking.ContactInfo.FirstName,
                    booking.ContactInfo.LastName,
                    booking.ContactInfo.Street,
                    booking.ContactInfo.HouseNumber,
                    booking.ContactInfo.PostalCode,
                    booking.ContactInfo.City,
                    booking.ContactInfo.Email,
                    booking.ContactInfo.PhoneNumber),
                new CatInfoResponseDto(
                    booking.CatInfo.CatAmount,
                    booking.CatInfo.Medication,
                    booking.CatInfo.Vaccination
                    ));

            return Ok(responseBooking);
        }

        [HttpPost]
        public async Task<ActionResult> CreateBooking(CreateBookingRequestDto createBooking)
        {
            var booking = new CreateBookingDto(
                createBooking.Room,
                createBooking.FirstDay,
                createBooking.LastDay,
                new ContactInfoDto(
                    createBooking.ContactInfo.FirstName,
                    createBooking.ContactInfo.LastName,
                    createBooking.ContactInfo.Street,
                    createBooking.ContactInfo.HouseNumber,
                    createBooking.ContactInfo.PostalCode,
                    createBooking.ContactInfo.City,
                    createBooking.ContactInfo.Email,
                    createBooking.ContactInfo.PhoneNumber),
                new CatInfoDto(
                    createBooking.CatInfo.CatAmount,
                    createBooking.CatInfo.Medication,
                    createBooking.CatInfo.Vaccination
                    ));

            var newBooking = await bookingService.CreateBooking(booking);

            if (newBooking is null)
            {
                return BadRequest("Booking could not be created");
            }

            var responseBooking = new BookingResponseDto(
                newBooking.Id,
                newBooking.Room,
                newBooking.FirstDay,
                newBooking.LastDay,
                new ContactInfoResponseDto(
                    newBooking.ContactInfo.FirstName,
                    newBooking.ContactInfo.LastName,
                    newBooking.ContactInfo.Street,
                    newBooking.ContactInfo.HouseNumber,
                    newBooking.ContactInfo.PostalCode,
                    newBooking.ContactInfo.City,
                    newBooking.ContactInfo.Email,
                    newBooking.ContactInfo.PhoneNumber),
                new CatInfoResponseDto(
                    newBooking.CatInfo.CatAmount,
                    newBooking.CatInfo.Medication,
                    newBooking.CatInfo.Vaccination));

            return CreatedAtAction(nameof(GetBookingById), new { id = newBooking.Id }, responseBooking);
        }
    }
}
