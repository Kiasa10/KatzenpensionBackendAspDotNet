using KatzenpensionApi.Dtos.Bookings;
using KatzenpensionApi.Repositories.Booking;
using KatzenpensionApi.Services.SaveDbService;

namespace KatzenpensionApi.Services.BookingService
{
    public class BookingService(IBookingRepository bookingRepo, ISaveDbService saveDbService) : IBookingService
    {
        public async Task<BookingDto?> GetBookingById(Guid id)
        {
            return await bookingRepo.GetBookingById(id);
        }

        public async Task<BookingDto?> CreateBooking(CreateBookingDto createBooking)
        {
            var response = await bookingRepo.CreateBooking(createBooking);
            saveDbService.SaveDbChanges();

            return response;
        }
    }
}
