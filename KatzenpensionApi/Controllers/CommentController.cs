using KatzenpensionApi.ApiDtos.RequestDtos;
using KatzenpensionApi.ApiDtos.ResponseDtos;
using KatzenpensionApi.Dtos.Comments;
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

            var response = comments.Select(
                c => new CommentResponseDto(
                Id: c.Id,
                Date: c.Date,
                Headline: c.Headline,
                Author: c.Author,
                Content: c.Content,
                ImagePath: c.ImagePath
                )).ToList();

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
            var response = new CommentResponseDto(
                comment.Id,
                comment.Date,
                comment.Headline,
                comment.Author,
                comment.Content,
                comment.ImagePath);

            return Ok(response);
        }

        [HttpPost]
        public async Task<ActionResult> CreateComment(CreateCommentRequestDto createComment)
        {
            var comment = new CreateCommentDto(
                createComment.Headline,
                createComment.Author,
                createComment.Content,
                createComment.ImagePath);

            var c = await commentService.CreateComment(comment);

            if (c is null)
            {
                return BadRequest("Comment could not be created");
            }

            var response = new CommentResponseDto(
                c.Id,
                c.Date,
                createComment.Headline,
                createComment.Author,
                createComment.Content,
                createComment.ImagePath);

            return CreatedAtAction(nameof(GetCommentById), new { id = c.Id }, response);
        }


    }
}
