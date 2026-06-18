using KatzenpensionApi.Dtos.Bookings;

namespace KatzenpensionApi.Repositories.Booking
{
    public interface IBookingRepository
    {
        public Task<BookingDto?> GetBookingById(Guid id);
        public Task<BookingDto?> CreateBooking(CreateBookingDto createBooking);
    }
}
