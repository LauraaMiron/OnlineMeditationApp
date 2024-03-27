using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories;
public interface  IBlogPostEntityRepository
{
    IEnumerable<BlogPost> GetAll();
    BlogPost GetById(Guid id);

    void Add(BlogPost entity);
    void Update(BlogPost entity);
    void Delete(Guid id);
}
