namespace KatzenpensionApi.ApiDtos.ResponseDtos
{
    public record ContactInfoResponseDto(
       string FirstName,
       string LastName,
       string Street,
       string HouseNumber,
       string PostalCode,
       string City,
       string Email,
       string PhoneNumber
        );
}
