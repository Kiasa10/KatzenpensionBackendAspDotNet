using KatzenpensionApi.Dtos.Comments;

namespace KatzenpensionApi.Repositories.Comment
{
    public interface ICommentRepository
    {
        public Task<List<CommentDto>> GetAllComments();
        public Task<CommentDto?> CreateComment(CreateCommentWithDateDto createComment);
        public Task<CommentDto?> GetCommentById(Guid id);
    }
}
