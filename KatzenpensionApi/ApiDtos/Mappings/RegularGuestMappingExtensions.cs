using KatzenpensionApi.ApiDtos.ResponseDtos;
using KatzenpensionApi.Dtos.RegularGuests;

namespace KatzenpensionApi.ApiDtos.Mappings
{
    public static class RegularGuestMappingExtensions
    {
        public static RegularGuestResponseDto ToResponseDto(this RegularGuestDto guest)
        {
            return new RegularGuestResponseDto(
                Id: guest.Id,
                Name: guest.Name,
                Age: guest.Age,
                ImageUrlReact: guest.ImageUrlReact,
                ImageUrlAngular: guest.ImageUrlAngular,
                DescriptionShort: guest.DescriptionShort,
                DescriptionLong: guest.DescriptionLong
                );
        }
    }
}

