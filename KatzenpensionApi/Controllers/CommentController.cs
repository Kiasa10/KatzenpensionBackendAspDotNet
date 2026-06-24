using KatzenpensionApi.ApiDtos.Mappings;
using KatzenpensionApi.ApiDtos.RequestDtos;
using KatzenpensionApi.ApiDtos.ResponseDtos;
using KatzenpensionApi.Services.CommentService;
using Microsoft.AspNetCore.Mvc;

namespace KatzenpensionApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController(ICommentService commentService) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<CommentResponseDto>>> GetAllComments()
        {
            var comments = await commentService.GetAllComments();
            var response = comments.Select(c => c.ToResponseDto()).ToList();

            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CommentResponseDto>> GetCommentById(Guid id)
        {
            var comment = await commentService.GetCommentById(id);

            if (comment is null)
            {
                return BadRequest();
            }

            return Ok(comment.ToResponseDto());
        }

        [HttpPost]
        public async Task<ActionResult> CreateComment(CreateCommentRequestDto createComment)
        {
            var comment = createComment.ToServiceDto();
            var createdComment = await commentService.CreateComment(comment);

            if (createdComment is null)
            {
                return BadRequest("Comment could not be created");
            }

            var response = createdComment.ToResponseDto();

            return CreatedAtAction(nameof(GetCommentById), new { id = response.Id }, response);
        }


    }
}
