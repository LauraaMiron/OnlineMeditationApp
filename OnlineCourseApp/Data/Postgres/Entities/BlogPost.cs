using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Postgres.Entities
{
    public class BlogPost 
    {
        public BlogPost() { }
        public BlogPost(string _id,string _title,string _description) { 
            id = _id;
            title = _title;
            description = _description; 
        }
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }

        public static Domain.BlogPost ToDomain(BlogPost blogPost)
        {
            return new Domain.BlogPost(
                Guid.Parse(blogPost.id),
                blogPost.title,
                blogPost.description);
        }

        public static BlogPost FromDomain(Domain.BlogPost blogPost)
        {
            return new BlogPost(
                blogPost.id.ToString(),
                blogPost.title,
                blogPost.description

            );
        }



    }
}
