using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entity
{
    public class BlogPostEntity
    {
      
        

            public BlogPostEntity(Guid _id, string _title, string _description)
            {

                id = _id;
                title = _title;
                description = _description;

            }
        public Guid id { get; set; }
        public string title { get; set; }
        public string description { get; set; }

    }

}
