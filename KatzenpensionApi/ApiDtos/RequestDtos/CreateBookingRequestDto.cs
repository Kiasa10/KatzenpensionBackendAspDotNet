using KatzenpensionApi.ApiDtos.RequestDtos.Validation;
using System.ComponentModel.DataAnnotations;

namespace KatzenpensionApi.ApiDtos.RequestDtos
{

    [BookingDateValidation]
    public record CreateBookingRequestDto(
        [Required(AllowEmptyStrings =false, ErrorMessage = "Bitte wählen Sie eine Raum aus der Liste aus.")]
        [AllowedValues("commonRoom", "singleRoom", "doubleRoom", "suite", "lakeView", "mountainView", ErrorMessage ="Bitte wählen Sie einen gültigen Raum aus der Liste aus.")]
        string Room,

        [Required(ErrorMessage = "Wählen Sie ein Startdatum.")]
        DateTime FirstDay,

        [Required(ErrorMessage = "Wählen Sie ein Enddatum.")]
        DateTime LastDay,

        [Required]
        ContactInfoRequestDto ContactInfo,

        [Required]
        CatInfoRequestDto CatInfo
        );
}
