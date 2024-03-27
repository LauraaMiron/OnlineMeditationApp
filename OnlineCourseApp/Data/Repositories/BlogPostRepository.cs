using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class BlogPostRepository : IBlogPostEntityRepository
    {
        private readonly List<BlogPost> blogPosts;
     
        public BlogPostRepository()
        {
            blogPosts = new List<BlogPost>();

            // Create an instance of BlogPost and add it to the repository
            Guid postId = Guid.NewGuid();
            string postTitle = "Sample Blog Post";
            string postDescription = "This is a sample blog post description.";
            BlogPost samplePost = new BlogPost(postId, postTitle, postDescription);
            blogPosts.Add(samplePost);
        }
        public void Add(BlogPost entity)
        {
            blogPosts.Add(entity);
        }

        public void Delete(Guid id)
        {   
            blogPosts.Remove(GetById(id));  
        }

        public IEnumerable<BlogPost> GetAll()
        {
            return blogPosts;
        }

        public BlogPost GetById(Guid id)
        {
            return blogPosts.FirstOrDefault(post => post.id == id);
        }

        public void Update(BlogPost entity)
        {
            BlogPost postToUpdate = blogPosts.FirstOrDefault(post => post.id == entity.id);
            if (postToUpdate != null)
            {
                postToUpdate.title = entity.title;
                postToUpdate.description = entity.description;
            }
        }
    }
}
