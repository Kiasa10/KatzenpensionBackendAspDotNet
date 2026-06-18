using KatzenpensionApi.ApiDtos.RequestDtos.Validation;
using System.ComponentModel.DataAnnotations;

namespace KatzenpensionApi.ApiDtos.RequestDtos
{
    public record CreateCommentRequestDto(
        [Required(ErrorMessage = ErrorMessages.TextRequired)]
        [StringLength(50, MinimumLength = 3, ErrorMessage = ErrorMessages.TextLength)]
        string Headline,

        [Required(ErrorMessage = ErrorMessages.TextRequired)]
        [StringLength(50, MinimumLength = 3, ErrorMessage = ErrorMessages.TextLength)]
        string Author,

        [Required(ErrorMessage = ErrorMessages.TextRequired)]
        [StringLength(500, MinimumLength = 3, ErrorMessage = ErrorMessages.TextboxLength)]
        string Content,
        string? ImagePath
        );
}
