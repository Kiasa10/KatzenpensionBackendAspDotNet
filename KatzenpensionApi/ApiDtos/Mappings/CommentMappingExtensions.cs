using KatzenpensionApi.ApiDtos.RequestDtos;
using KatzenpensionApi.ApiDtos.ResponseDtos;
using KatzenpensionApi.Dtos.Comments;

namespace KatzenpensionApi.ApiDtos.Mappings
{
    public static class CommentMappingExtensions
    {
        public static CommentResponseDto ToResponseDto(this CommentDto comment)
        {
            return new CommentResponseDto(
                Id: comment.Id,
                Date: comment.Date,
                Headline: comment.Headline,
                Author: comment.Author,
                Content: comment.Content,
                ImagePath: comment.ImagePath
                );
        }

        public static CreateCommentDto ToServiceDto(this CreateCommentRequestDto request)
        {
            return new CreateCommentDto(
                Headline: request.Headline,
                Author: request.Author,
                Content: request.Content,
                ImagePath: request.ImagePath
                );
        }
    }
}
