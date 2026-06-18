using System.ComponentModel.DataAnnotations;

namespace KatzenpensionApi.Data.Models
{
    public class CatInfoModel
    {
        [Key]
        public Guid Id { get; set; }
        public int CatAmount { get; set; }
        public string? Medication { get; set; } = string.Empty;
        public bool Vaccination { get; set; }
        //Verbindung zurück zu Booking
        public Guid BookingId { get; set; }
        public BookingModel Booking { get; set; } = null!;
    }
}
