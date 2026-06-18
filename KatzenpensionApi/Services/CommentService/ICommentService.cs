using KatzenpensionApi.Dtos.Comments;

namespace KatzenpensionApi.Services.CommentService
{
    public interface ICommentService
    {
        public Task<List<CommentDto>> GetAllComments();
        public Task<CommentDto?> CreateComment(CreateCommentDto createComment);
        public Task<CommentDto?> GetCommentById(Guid id);
    }
}
