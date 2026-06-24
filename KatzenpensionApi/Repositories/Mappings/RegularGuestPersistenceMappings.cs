using KatzenpensionApi.Data.Models;
using KatzenpensionApi.Dtos.RegularGuests;

namespace KatzenpensionApi.Repositories.Mappings
{
    public static class RegularGuestPersistenceMappings
    {
        public static RegularGuestDto ToDto(this RegularGuestModel model)
        {
            return new RegularGuestDto(
                Id: model.Id,
                Name: model.Name,
                Age: model.Age,
                ImageUrlReact: model.ImageUrlReact,
                ImageUrlAngular: model.ImageUrlAngular,
                DescriptionShort: model.DescriptionShort,
                DescriptionLong: model.DescriptionLong
                );
        }
    }
}
