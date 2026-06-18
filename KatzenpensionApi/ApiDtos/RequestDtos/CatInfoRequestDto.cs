using KatzenpensionApi.ApiDtos.RequestDtos.Validation;
using System.ComponentModel.DataAnnotations;

namespace KatzenpensionApi.ApiDtos.RequestDtos
{
    public record CatInfoRequestDto(
        [Required(ErrorMessage = "Es muss mindestens eine Katze sein.")]
        [Range(1, 4, ErrorMessage = "Die Katzenanzahl muss zwischen 1 und 4 liegen")]
        int CatAmount,

        [OptionalStringLength(ErrorMessage = ErrorMessages.TextboxLength)]
        string? Medication,

        [Required(ErrorMessage = "Ihre Katze muss die erforderten Impfungen erhalten haben.")]
        [Range(typeof(bool), "true", "true", ErrorMessage = "Ihre Katze muss die erforderten Impfungen erhalten haben.")]
        bool Vaccination
        );
}
