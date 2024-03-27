using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using ServicesIntrface;
using Servicess;

namespace Api.Controllers
{

    [ApiController]
    [Route("[controller]")]

    public class BlogPostController : ControllerBase
    {
        private readonly IBlogPostEntityServiceInterfaces _blogpostService;

        public BlogPostController(IBlogPostEntityServiceInterfaces blogpostService)
        {
            _blogpostService = blogpostService;
        }

        [HttpGet]
        public IActionResult GetAllBlogPosts()
        {
            var posts = _blogpostService.GetAllBlogPosts();
            return Ok(posts);
        }

        [HttpGet("{id}")]
        public IActionResult GetBlogPostsById(Guid id) {
            var post = _blogpostService.GetBlogPostById(id);
            if (post == null)
            {
                return NotFound();
            }
            return Ok(post);
        }

        [HttpPost]
        public IActionResult AddBlogPost([FromBody] BlogPost blogpost)
        {
            _blogpostService.AddBlogPost(blogpost);
            return Ok(blogpost);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateBlogPost(Guid id, [FromBody] BlogPost blogpost)
        {
            if(id != blogpost.id)
            {
                return BadRequest();

            }
            _blogpostService.UpdateBlogPost(blogpost);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBlogPost(Guid id)
        {
            _blogpostService.DeleteBlogPost(id);
            return NoContent();
        }


    }
}

