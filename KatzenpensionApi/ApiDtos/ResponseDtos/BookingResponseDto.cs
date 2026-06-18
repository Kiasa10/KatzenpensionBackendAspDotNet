namespace KatzenpensionApi.ApiDtos.ResponseDtos
{
    public record BookingResponseDto(
        Guid Id,
        string Room,
        DateTime FirstDay,
        DateTime LastDay,
        ContactInfoResponseDto ContactInfo,
        CatInfoResponseDto CatInfo
        );
}
