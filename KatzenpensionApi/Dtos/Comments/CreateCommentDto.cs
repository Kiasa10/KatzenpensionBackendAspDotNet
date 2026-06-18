namespace KatzenpensionApi.Dtos.Comments
{
    public record CreateCommentDto(
        string Headline,
        string Author,
        string Content,
        string? ImagePath
        );

}
