using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace ServicesIntrface
{
    public interface IBlogPostEntityServiceInterfaces
    {
        IEnumerable<BlogPost> GetAllBlogPosts();
        BlogPost GetBlogPostById(Guid id);
        void AddBlogPost(BlogPost blogPost);
        void UpdateBlogPost(BlogPost blogPost);
        void DeleteBlogPost(Guid id);
    }
}