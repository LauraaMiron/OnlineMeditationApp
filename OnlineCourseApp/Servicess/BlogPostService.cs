using Data.Repositories;
using System;
using ServicesIntrface;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Microsoft.Extensions.DependencyInjection;


namespace Servicess
{
    public class BlogPostService : IBlogPostEntityServiceInterfaces
    {
        private readonly IBlogPostEntityRepository _blogpostrepository;

        public BlogPostService(IBlogPostEntityRepository blogpostrepository)
        {
            _blogpostrepository = blogpostrepository;
        }
        public IEnumerable<BlogPost> GetAllBlogPosts()
        {
            return _blogpostrepository.GetAll();
        }

        public void AddBlogPost(BlogPost blogPost)
        {
            _blogpostrepository.Add(blogPost);
        }
        public void UpdateBlogPost(BlogPost blogPost)
        {
            _blogpostrepository.Update(blogPost);
        }
        public void DeleteBlogPost(Guid id)
        {
            _blogpostrepository.Delete(id);
        }

        BlogPost? IBlogPostEntityServiceInterfaces.GetBlogPostById(Guid id)
        {
            return _blogpostrepository.GetById(id);
        }


    }
}

