using KatzenpensionApi.Data.Models;
using KatzenpensionApi.Dtos.Bookings;

namespace KatzenpensionApi.Repositories.Mappings
{
    public static class BookingPersistenceMappings
    {
        public static BookingDto ToDto(this BookingModel model)
        {
            return new BookingDto(
                Id: model.Id,
                Room: model.Room,
                FirstDay: model.FirstDay,
                LastDay: model.LastDay,
                ContactInfo: model.ContactInfo.ToDto(),
                CatInfo: model.CatInfo.ToDto()
                );
        }

        private static ContactInfoDto ToDto(this ContactInfoModel model)
        {
            return new ContactInfoDto(
                FirstName: model.FirstName,
                LastName: model.LastName,
                Street: model.Street,
                HouseNumber: model.HouseNumber,
                PostalCode: model.PostalCode,
                City: model.City,
                Email: model.Email,
                PhoneNumber: model.PhoneNumber
                );
        }

        private static CatInfoDto ToDto(this CatInfoModel model)
        {
            return new CatInfoDto(
                CatAmount: model.CatAmount,
                Medication: model.Medication,
                Vaccination: model.Vaccination
                );
        }

        public static BookingModel ToModel(this CreateBookingDto dto)
        {
            var bookingId = Guid.NewGuid();

            var bookingModel = new BookingModel
            {
                Id = bookingId,
                Room = dto.Room,
                FirstDay = dto.FirstDay,
                LastDay = dto.LastDay,
            };

            bookingModel.ContactInfo = new ContactInfoModel
            {
                Id = Guid.NewGuid(),
                FirstName = dto.ContactInfo.FirstName,
                LastName = dto.ContactInfo.LastName,
                Street = dto.ContactInfo.Street,
                HouseNumber = dto.ContactInfo.HouseNumber,
                PostalCode = dto.ContactInfo.PostalCode,
                City = dto.ContactInfo.City,
                Email = dto.ContactInfo.Email,
                PhoneNumber = dto.ContactInfo.PhoneNumber,
                Booking = bookingModel
            };

            bookingModel.CatInfo = new CatInfoModel
            {
                Id = Guid.NewGuid(),
                CatAmount = dto.CatInfo.CatAmount,
                Medication = dto.CatInfo.Medication,
                Vaccination = dto.CatInfo.Vaccination,
                Booking = bookingModel
            };

            return bookingModel;
        }
    }
}
