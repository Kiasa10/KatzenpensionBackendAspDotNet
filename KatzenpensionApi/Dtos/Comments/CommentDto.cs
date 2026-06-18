namespace KatzenpensionApi.Dtos.Comments
{
    public record CommentDto(
        Guid Id,
        DateTime Date,
        string Headline,
        string Author,
        string Content,
        string? ImagePath
        );
}



