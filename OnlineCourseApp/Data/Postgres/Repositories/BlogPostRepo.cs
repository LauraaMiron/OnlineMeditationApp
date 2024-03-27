using Data.Postgres.Configuration;
using Data.Repositories;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Postgres.Repositories
{
    internal class BlogPostRepo : IBlogPostEntityRepository
    {
        private readonly ApplicationDbContext _context;
        public BlogPostRepo(ApplicationDbContext context)
        {
            _context = context;
        }


        public void Add(BlogPost entity)
        {
            var post = Entities.BlogPost.FromDomain(entity);
            _context.BlogPost.Add(post);
            try
            {
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.InnerException.Message);
            }
        }

        public void Delete(Guid id)
        {
            var entityToDelete = _context.BlogPost.FirstOrDefault(e => e.id.Equals(id));
            if (entityToDelete == null) return;
            _context.BlogPost.Remove(entityToDelete);
            _context.SaveChanges();
        }

        public IEnumerable<BlogPost> GetAll()
        {
            var posts = _context.BlogPost.ToList();
            return posts.Select(Entities.BlogPost.ToDomain);
        }

        public BlogPost GetById(Guid id)
        {
            var entity = _context.BlogPost.FirstOrDefault(e => e.id.Equals(id));
            return entity != null ? Entities.BlogPost.ToDomain(entity) : null;
        }

        public void Update(BlogPost entity)
        {
            var post = Entities.BlogPost.FromDomain(entity);
            _context.BlogPost.Update(post);
            _context.SaveChanges();
        }
    }
}
