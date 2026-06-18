namespace KatzenpensionApi.Dtos.Bookings
{
    public record BookingDto(
        Guid Id,
        string Room,
        DateTime FirstDay,
        DateTime LastDay,
        ContactInfoDto ContactInfo,
        CatInfoDto CatInfo
        );
    public record ContactInfoDto(
       string FirstName,
       string LastName,
       string Street,
       string HouseNumber,
       string PostalCode,
       string City,
       string Email,
       string PhoneNumber
       );

    public record CatInfoDto(
        int CatAmount,
        string? Medication,
        bool Vaccination
        );
}
