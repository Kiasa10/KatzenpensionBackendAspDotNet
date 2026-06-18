using System.ComponentModel.DataAnnotations;

namespace KatzenpensionApi.ApiDtos.RequestDtos.Validation
{
    public class BookingDateValidation : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (validationContext.ObjectInstance is not CreateBookingRequestDto dto)
            {
                return ValidationResult.Success;
            }

            if (string.IsNullOrWhiteSpace(dto.Room))
            {
                return ValidationResult.Success;
            }

            var today = DateTime.Today;
            var oneYearFromNow = today.AddDays(365);
            var firstDay = dto.FirstDay.ToLocalTime().Date;
            var lastDay = dto.LastDay.ToLocalTime().Date;
            var duration = (lastDay - firstDay).Days;

            if (firstDay < today)
            {
                return new ValidationResult("Das Startdatum darf nicht in der Vergangenheit liegen.", [nameof(dto.FirstDay)]);
            }

            if (firstDay > oneYearFromNow)
            {
                return new ValidationResult("Datum darf maximal ein Jahr in der Zukunft liegen.", [nameof(dto.FirstDay)]);
            }

            if (lastDay > oneYearFromNow)
            {
                return new ValidationResult("Datum kann höchstens ein Jahr in der Zukunft liegen.", [nameof(dto.LastDay)]);
            }

            if (lastDay <= firstDay)
            {
                return new ValidationResult("Das Enddatum muss nach dem Startdatum liegen.", [nameof(dto.LastDay)]);
            }

            if (duration < 1)
            {
                return new ValidationResult("Die minimale Buchungsdauer beträgt 1 Nacht.", [nameof(dto.LastDay)]);
            }

            if (duration > 14)
            {
                return new ValidationResult("Die maximale Buchungsdauer beträgt 14 Tage.", [nameof(dto.LastDay)]);
            }

            return ValidationResult.Success;
        }
    }
}
