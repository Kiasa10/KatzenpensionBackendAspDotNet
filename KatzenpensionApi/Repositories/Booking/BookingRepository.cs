using KatzenpensionApi.Data;
using KatzenpensionApi.Dtos.Bookings;
using KatzenpensionApi.Repositories.Mappings;
using Microsoft.EntityFrameworkCore;

namespace KatzenpensionApi.Repositories.Booking
{
    public class BookingRepository(AppDbContext context) : IBookingRepository
    {
        public async Task<BookingDto?> GetBookingById(Guid id)
        {
            var booking = await context.Bookings
                .Include(b => b.ContactInfo)
                .Include(b => b.CatInfo)
                .FirstOrDefaultAsync(b => b.Id == id);

            if (booking is null)
            {
                return null;
            }

            return booking.ToDto();
        }

        public async Task<BookingDto?> CreateBooking(CreateBookingDto createBooking)
        {
            var newBooking = createBooking.ToModel();
            await context.Bookings.AddAsync(newBooking);

            return newBooking.ToDto();
        }
    }
}

