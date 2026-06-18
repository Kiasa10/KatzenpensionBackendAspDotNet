namespace KatzenpensionApi.Dtos.RegularGuests
{
    public record RegularGuestDto(
        Guid Id,
        string Name,
        int Age,
        string ImageUrlReact,
        string ImageUrlAngular,
        string DescriptionShort,
        string DescriptionLong
        );

}


