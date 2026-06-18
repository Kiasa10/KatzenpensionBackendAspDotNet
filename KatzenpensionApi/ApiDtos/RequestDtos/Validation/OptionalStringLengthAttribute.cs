using System.ComponentModel.DataAnnotations;

namespace KatzenpensionApi.ApiDtos.RequestDtos.Validation
{
    public class OptionalStringLengthAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var str = value as string;

            if (string.IsNullOrEmpty(str))
            {
                return ValidationResult.Success;
            }

            if (str.Length < 3 || str.Length > 500)
            {
                return new ValidationResult(ErrorMessage ?? "Ihre Eingabe muss zwischen 3 und max. 500 Zeichen lang sein.");
            }

            return ValidationResult.Success;
        }
    }
}
