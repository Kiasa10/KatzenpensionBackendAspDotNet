namespace KatzenpensionApi.Data.Models
{
    public class CommentModel
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public required string Headline { get; set; } = string.Empty;
        public required string Author { get; set; } = string.Empty;
        public required string Content { get; set; } = string.Empty;
        public string? ImagePath { get; set; }
    }
}

