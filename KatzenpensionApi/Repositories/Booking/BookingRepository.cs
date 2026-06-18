using KatzenpensionApi.Data;
using KatzenpensionApi.Data.Models;
using KatzenpensionApi.Dtos.Bookings;
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

            var foundBooking = new BookingDto(
                booking.Id,
                booking.Room,
                booking.FirstDay,
                booking.LastDay,
                new ContactInfoDto(
                    booking.ContactInfo.FirstName,
                    booking.ContactInfo.LastName,
                    booking.ContactInfo.Street,
                    booking.ContactInfo.HouseNumber,
                    booking.ContactInfo.PostalCode,
                    booking.ContactInfo.City,
                    booking.ContactInfo.Email,
                    booking.ContactInfo.PhoneNumber
                    ),
                new CatInfoDto(
                    booking.CatInfo.CatAmount,
                    booking.CatInfo.Medication,
                    booking.CatInfo.Vaccination
                    ));

            return foundBooking;
        }

        public async Task<BookingDto?> CreateBooking(CreateBookingDto createBooking)
        {
            var id = Guid.NewGuid();
            var newBooking = new BookingModel
            {
                Id = id,
                Room = createBooking.Room,
                FirstDay = createBooking.FirstDay,
                LastDay = createBooking.LastDay,
            };

            var contactInfo = new ContactInfoModel
            {
                Id = Guid.NewGuid(),
                FirstName = createBooking.ContactInfo.FirstName,
                LastName = createBooking.ContactInfo.LastName,
                Street = createBooking.ContactInfo.Street,
                HouseNumber = createBooking.ContactInfo.HouseNumber,
                PostalCode = createBooking.ContactInfo.PostalCode,
                City = createBooking.ContactInfo.City,
                Email = createBooking.ContactInfo.Email,
                PhoneNumber = createBooking.ContactInfo.PhoneNumber,
                Booking = newBooking,
            };

            var catInfo = new CatInfoModel
            {
                Id = Guid.NewGuid(),
                CatAmount = createBooking.CatInfo.CatAmount,
                Medication = createBooking.CatInfo.Medication,
                Vaccination = createBooking.CatInfo.Vaccination,
                Booking = newBooking
            };

            newBooking.ContactInfo = contactInfo;
            newBooking.CatInfo = catInfo;

            await context.Bookings.AddAsync(newBooking);

            return new BookingDto(
                newBooking.Id,
                newBooking.Room,
                newBooking.FirstDay,
                newBooking.LastDay,
                new ContactInfoDto(
                    contactInfo.FirstName,
                    contactInfo.LastName,
                    contactInfo.Street,
                    contactInfo.HouseNumber,
                    contactInfo.PostalCode,
                    contactInfo.City,
                    contactInfo.Email,
                    contactInfo.PhoneNumber
                    ),
                new CatInfoDto(
                    catInfo.CatAmount,
                    catInfo.Medication,
                    catInfo.Vaccination
                    ));
        }
    }
}

