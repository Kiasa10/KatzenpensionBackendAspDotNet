namespace KatzenpensionApi.Dtos.Bookings
{
    public record CreateBookingDto(
        string Room,
        DateTime FirstDay,
        DateTime LastDay,
        ContactInfoDto ContactInfo,
        CatInfoDto CatInfo
        );
}


