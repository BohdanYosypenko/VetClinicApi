using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using VetClinic.API.DTO.Post;
using VetClinic.API.DTO.Queries;
using VetClinic.API.DTO.Responses;
using VetClinic.BLL.Domain;
using VetClinic.BLL.Services.Interfaces;
using VetClinic.DAL.Entities;

namespace VetClinic.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : Controller
    {
        private readonly IPostService _postService;
        private readonly IMapper _mapper;

        public PostsController(IPostService postService, IMapper mapper)
        {
            _postService = postService;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] CreatePostDto createPostDto)
        {
            var post = await _postService.CreatePost(_mapper.Map<Post>(createPostDto));

            var readPostDto = _mapper.Map<ReadPostDto>(post);

            return Created(nameof(GetAsync), new Response<ReadPostDto>(readPostDto));
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync(
            [FromQuery] PaginationQuery paginationQuery)
        {
            var pagination = _mapper.Map<PaginationFilter>(paginationQuery);

            var posts = await _postService.GetAllAsync(pagination);

            var result = posts.Select(x => _mapper.Map<ReadPostDto>(x));
            var pagedResponse = new PagedResponse<ReadPostDto>(result, paginationQuery);
            return Ok(pagedResponse);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync(int id)
        {
            var post = await _postService.GetAsync(id);

            if (post == null)
            {
                return NotFound();
            }

            var readAnimalDto = _mapper.Map<ReadPostDto>(post);
            return Ok(new Response<ReadPostDto>(readAnimalDto));
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsync(int id, [FromBody] UpdatePostDto updatePostDto)
        {
            var post = await _postService.GetAsync(id);

            if (post == null)
            {
                return NotFound();
            }

            var updatePost = _mapper.Map<Post>(updatePostDto);

            await _postService.UpdatePost(id, updatePost);

            return NoContent();
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var post = await _postService.GetAsync(id);

            if (post == null)
            {
                return NotFound();
            }

            await _postService.RemovePost(post);
            return NoContent();
        }
    }
}
