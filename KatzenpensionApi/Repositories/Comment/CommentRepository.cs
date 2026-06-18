using KatzenpensionApi.Data;
using KatzenpensionApi.Data.Models;
using KatzenpensionApi.Dtos.Comments;
using Microsoft.EntityFrameworkCore;

namespace KatzenpensionApi.Repositories.Comment
{
    public class CommentRepository(AppDbContext context) : ICommentRepository
    {
        public async Task<List<CommentDto>> GetAllComments()
        {
            return await context.Comments.Select(c => new CommentDto(
                c.Id,
                c.Date,
                c.Headline,
                c.Author,
                c.Content,
                c.ImagePath)).ToListAsync();
        }

        public async Task<CommentDto?> CreateComment(CreateCommentWithDateDto createComment)
        {
            Guid id = Guid.NewGuid();
            var newComment = new CommentModel
            {
                Id = id,
                Date = createComment.Date,
                Headline = createComment.Headline,
                Author = createComment.Author,
                Content = createComment.Content,
                ImagePath = createComment.ImagePath,
            };

            await context.Comments.AddAsync(newComment);

            return new CommentDto(
                newComment.Id,
                newComment.Date,
                newComment.Headline,
                newComment.Author,
                newComment.Content,
                newComment.ImagePath);
        }

        public async Task<CommentDto?> GetCommentById(Guid id)
        {
            var comment = await context.Comments.FirstOrDefaultAsync(c => c.Id == id);

            if (comment is null)
            {
                return null;
            }

            var foundComment = new CommentDto(
                comment.Id,
                comment.Date,
                comment.Headline,
                comment.Author,
                comment.Content,
                comment.ImagePath
                );

            return foundComment;
        }
    }
}



