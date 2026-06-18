namespace KatzenpensionApi.Dtos.Comments
{
    public record CreateCommentWithDateDto(
        DateTime Date,
        string Headline,
        string Author,
        string Content,
        string? ImagePath
        );
}
