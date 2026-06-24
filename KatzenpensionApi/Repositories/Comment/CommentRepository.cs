using KatzenpensionApi.Data;
using KatzenpensionApi.Dtos.Comments;
using KatzenpensionApi.Repositories.Mappings;
using Microsoft.EntityFrameworkCore;

namespace KatzenpensionApi.Repositories.Comment
{
    public class CommentRepository(AppDbContext context) : ICommentRepository
    {
        public async Task<List<CommentDto>> GetAllComments()
        {
            var comments = await context.Comments.ToListAsync();
            return comments.Select(c => c.ToDto()).ToList();
        }

        public async Task<CommentDto?> CreateComment(CreateCommentWithDateDto createComment)
        {
            var newComment = createComment.ToModel();

            await context.Comments.AddAsync(newComment);

            return newComment.ToDto();
        }

        public async Task<CommentDto?> GetCommentById(Guid id)
        {
            var comment = await context.Comments.FirstOrDefaultAsync(c => c.Id == id);

            if (comment is null)
            {
                return null;
            }

            return comment.ToDto();
        }
    }
}



