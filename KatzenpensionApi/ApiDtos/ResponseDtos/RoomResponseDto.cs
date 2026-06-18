namespace KatzenpensionApi.ApiDtos.ResponseDtos
{
    public record RoomResponseDto(
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
