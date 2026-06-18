using System.ComponentModel.DataAnnotations;

namespace KatzenpensionApi.Data.Models
{
    public class ContactInfoModel
    {
        [Key]
        public Guid Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Street { get; set; } = string.Empty;
        public string HouseNumber { get; set; } = string.Empty;
        public string PostalCode { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        //Verbindung zurück zu Booking
        public Guid BookingId { get; set; }
        public BookingModel Booking { get; set; } = null!;
    }
}
