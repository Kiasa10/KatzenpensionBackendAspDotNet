namespace KatzenpensionApi.Data.Models
{
    public class RoomModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Cost { get; set; } = string.Empty;
        public string ImageUrlReact { get; set; } = string.Empty;
        public string ImageUrlAngular { get; set; } = string.Empty;
        public string DescriptionShort { get; set; } = string.Empty;
        public string DescriptionLong { get; set; } = string.Empty;
        public int CatsPossible { get; set; }
    }
}

