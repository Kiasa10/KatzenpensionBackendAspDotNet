using KatzenpensionApi.ApiDtos.RequestDtos.Validation;
using System.ComponentModel.DataAnnotations;

namespace KatzenpensionApi.ApiDtos.RequestDtos
{
    public record ContactInfoRequestDto(

       [Required(ErrorMessage = ErrorMessages.RequiredField)]
       [StringLength(50, MinimumLength =3, ErrorMessage = ErrorMessages.TextLength)]
       string FirstName,

       [Required(ErrorMessage = ErrorMessages.RequiredField)]
       [StringLength(50, MinimumLength =3, ErrorMessage = ErrorMessages.TextLength)]
       string LastName,

       [Required(ErrorMessage = ErrorMessages.RequiredField)]
       [StringLength(50, MinimumLength =3, ErrorMessage = ErrorMessages.TextLength)]
       string Street,

       [Required(ErrorMessage = ErrorMessages.RequiredField)]
       [StringLength(10, MinimumLength =1, ErrorMessage = ErrorMessages.ShortTextLength)]
       string HouseNumber,

       [Required(ErrorMessage = ErrorMessages.RequiredField)]
       [StringLength(10, MinimumLength =1, ErrorMessage = ErrorMessages.ShortTextLength)]
       string PostalCode,

       [Required(ErrorMessage = ErrorMessages.RequiredField)]
       [StringLength(50, MinimumLength =3, ErrorMessage = ErrorMessages.TextLength)]
       string City,

       [Required(ErrorMessage = ErrorMessages.RequiredField)]
       [StringLength(50, MinimumLength =5, ErrorMessage ="Die Eingabe muss zwischen 5 und 50 Zeichen lang sein.")]
       [EmailAddress(ErrorMessage = ErrorMessages.ValidEmail)]
       [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = ErrorMessages.ValidEmail)]
       string Email,

       [Required(ErrorMessage = ErrorMessages.RequiredField)]
       [StringLength(50, MinimumLength =3, ErrorMessage = ErrorMessages.TextLength)]
       string PhoneNumber
        );
}
