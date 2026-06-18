using KatzenpensionApi.Dtos.Bookings;

namespace KatzenpensionApi.Services.BookingService
{
    public interface IBookingService
    {
        public Task<BookingDto?> GetBookingById(Guid id);
        public Task<BookingDto?> CreateBooking(CreateBookingDto createBooking);
    }
}
