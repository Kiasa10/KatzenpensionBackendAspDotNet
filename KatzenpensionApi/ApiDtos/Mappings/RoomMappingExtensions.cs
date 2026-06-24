using KatzenpensionApi.ApiDtos.ResponseDtos;
using KatzenpensionApi.Dtos.Rooms;

namespace KatzenpensionApi.ApiDtos.Mappings
{
    public static class RoomMappingExtensions
    {
        public static RoomResponseDto ToResponseDto(this RoomDto room)
        {
            return new RoomResponseDto(
                Id: room.Id,
                Title: room.Title,
                Cost: room.Cost,
                ImageUrlReact: room.ImageUrlReact,
                ImageUrlAngular: room.ImageUrlAngular,
                DescriptionShort: room.DescriptionShort,
                DescriptionLong: room.DescriptionLong,
                CatsPossible: room.CatsPossible
                );
        }
    }
}
