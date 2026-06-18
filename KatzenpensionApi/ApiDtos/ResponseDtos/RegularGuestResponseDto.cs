namespace KatzenpensionApi.ApiDtos.ResponseDtos
{
    public record RegularGuestResponseDto(
        Guid Id,
        string Name,
        int Age,
        string ImageUrlReact,
        string ImageUrlAngular,
        string DescriptionShort,
        string DescriptionLong
        );
}
