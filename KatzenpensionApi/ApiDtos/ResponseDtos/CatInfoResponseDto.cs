namespace KatzenpensionApi.ApiDtos.ResponseDtos
{
    public record CatInfoResponseDto(
        int CatAmount,
        string? Medication,
        bool Vaccination
        );
}
