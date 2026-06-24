using KatzenpensionApi.Data.Models;
using KatzenpensionApi.Dtos.Comments;

namespace KatzenpensionApi.Repositories.Mappings
{
    public static class CommentPersistenceMappings
    {
        public static CommentDto ToDto(this CommentModel model)
        {
            return new CommentDto(
                Id: model.Id,
                Date: model.Date,
                Headline: model.Headline,
                Author: model.Author,
                Content: model.Content,
                ImagePath: model.ImagePath
                );
        }

        public static CommentModel ToModel(this CreateCommentWithDateDto dto)
        {
            return new CommentModel
            {
                Id = Guid.NewGuid(),
                Date = dto.Date,
                Headline = dto.Headline,
                Author = dto.Author,
                Content = dto.Content,
                ImagePath = dto.ImagePath
            };
        }

    }
}
