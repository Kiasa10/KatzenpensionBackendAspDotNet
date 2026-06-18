namespace KatzenpensionApi.ApiDtos.ResponseDtos
{
    public record CommentResponseDto(
        Guid Id,
        DateTime Date,
        string Headline,
        string Author,
        string Content,
        string? ImagePath
        );
}
