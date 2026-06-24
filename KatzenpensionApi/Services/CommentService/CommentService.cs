using KatzenpensionApi.Dtos.Comments;
using KatzenpensionApi.Repositories.Comment;
using KatzenpensionApi.Services.SaveDbService;

namespace KatzenpensionApi.Services.CommentService
{
    public class CommentService(ICommentRepository commentRepo, ISaveDbService saveDbService) : ICommentService
    {
        public async Task<List<CommentDto>> GetAllComments()
        {
            return await commentRepo.GetAllComments();
        }

        public async Task<CommentDto?> CreateComment(CreateCommentDto createComment)
        {
            var date = DateTime.Now;
            var comment = new CreateCommentWithDateDto(
                date,
                createComment.Headline,
                createComment.Author,
                createComment.Content,
                createComment.ImagePath);

            var response = await commentRepo.CreateComment(comment);
            await saveDbService.SaveDbChanges();

            return response;
        }

        public async Task<CommentDto?> GetCommentById(Guid id)
        {
            return await commentRepo.GetCommentById(id);
        }
    }
}
