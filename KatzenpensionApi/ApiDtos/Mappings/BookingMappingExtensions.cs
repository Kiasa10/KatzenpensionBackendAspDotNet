using KatzenpensionApi.ApiDtos.RequestDtos;
using KatzenpensionApi.ApiDtos.ResponseDtos;
using KatzenpensionApi.Dtos.Bookings;

namespace KatzenpensionApi.ApiDtos.Mappings
{
    public static class BookingMappingExtensions
    {
        public static BookingResponseDto ToResponseDto(this BookingDto src)
        {
            return new BookingResponseDto(
                Id: src.Id,
                Room: src.Room,
                FirstDay: src.FirstDay,
                LastDay: src.LastDay,
                ContactInfo: src.ContactInfo.ToResponseDto(),
                CatInfo: src.CatInfo.ToResponseDto()
                );
        }

        private static ContactInfoResponseDto ToResponseDto(this ContactInfoDto src)
        {
            return new ContactInfoResponseDto(
                FirstName: src.FirstName,
                LastName: src.LastName,
                Street: src.Street,
                HouseNumber: src.HouseNumber,
                PostalCode: src.PostalCode,
                City: src.City,
                Email: src.Email,
                PhoneNumber: src.PhoneNumber
                );
        }

        private static CatInfoResponseDto ToResponseDto(this CatInfoDto src)
        {
            return new CatInfoResponseDto(
                CatAmount: src.CatAmount,
                Medication: src.Medication,
                Vaccination: src.Vaccination
                );
        }

        public static CreateBookingDto ToServiceDto(this CreateBookingRequestDto src)
        {
            return new CreateBookingDto(
                Room: src.Room,
                FirstDay: src.FirstDay,
                LastDay: src.LastDay,
                ContactInfo: src.ContactInfo.ToServiceDto(),
                CatInfo: src.CatInfo.ToServiceDto()
                );
        }

        private static ContactInfoDto ToServiceDto(this ContactInfoRequestDto src)
        {
            return new ContactInfoDto(
                FirstName: src.FirstName,
                LastName: src.LastName,
                Street: src.Street,
                HouseNumber: src.HouseNumber,
                PostalCode: src.PostalCode,
                City: src.City,
                Email: src.Email,
                PhoneNumber: src.PhoneNumber
                );
        }

        private static CatInfoDto ToServiceDto(this CatInfoRequestDto src)
        {
            return new CatInfoDto(
                CatAmount: src.CatAmount,
                Medication: src.Medication,
                Vaccination: src.Vaccination
                );
        }
    }
}
