using KatzenpensionApi.Data.Models;
using KatzenpensionApi.Dtos.Rooms;

namespace KatzenpensionApi.Repositories.Mappings
{
    public static class RoomPersistenceMappings
    {
        public static RoomDto ToDto(this RoomModel model)
        {
            return new RoomDto(
                Id: model.Id,
                Title: model.Title,
                Cost: model.Cost,
                ImageUrlReact: model.ImageUrlReact,
                ImageUrlAngular: model.ImageUrlAngular,
                DescriptionShort: model.DescriptionShort,
                DescriptionLong: model.DescriptionLong,
                CatsPossible: model.CatsPossible
                );
        }
    }
}
