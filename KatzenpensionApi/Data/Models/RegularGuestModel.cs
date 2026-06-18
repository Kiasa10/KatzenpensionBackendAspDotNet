namespace KatzenpensionApi.Data.Models
{
    public class RegularGuestModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }
        public string ImageUrlReact { get; set; } = string.Empty;
        public string ImageUrlAngular { get; set; } = string.Empty;
        public string DescriptionShort { get; set; } = string.Empty;
        public string DescriptionLong { get; set; } = string.Empty;
    }
}


