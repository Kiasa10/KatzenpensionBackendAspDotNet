namespace KatzenpensionApi.Data.Models
{
    public class BookingModel
    {
        public Guid Id { get; set; }
        public string Room { get; set; } = string.Empty;
        public DateTime FirstDay { get; set; }
        public DateTime LastDay { get; set; }
        public ContactInfoModel ContactInfo { get; set; } = null!;
        public CatInfoModel CatInfo { get; set; } = null!;

    }
}
