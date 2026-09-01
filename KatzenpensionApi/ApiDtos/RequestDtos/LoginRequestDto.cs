using System.ComponentModel.DataAnnotations;

namespace KatzenpensionApi.ApiDtos.RequestDtos
{
    public class LoginRequestDto
    {
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Falsches Passwort, bitte erneut versuchen.")]
        public string Password { get; set; } = string.Empty;
    }
}
