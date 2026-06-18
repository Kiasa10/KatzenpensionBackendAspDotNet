namespace KatzenpensionApi.Dtos.Rooms
{
    public record RoomDto(
        Guid Id,
        string Title,
        string Cost,
        string ImageUrlReact,
        string ImageUrlAngular,
        string DescriptionShort,
        string DescriptionLong,
        int CatsPossible
        );
}


