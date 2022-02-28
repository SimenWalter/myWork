using Quot.Engine.Db;
using Quot.Engine.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quot.Engine.Services
{
    public class AuthorService : BaseService, IAuthorService
    {
        public AuthorService(IDbContext _context) : base(_context)
        {

        }
        public Author get(int Id)
        {
            return Context.Authors.Find(Id);
        }

        public List<Author> getAll()
        {
            return Context.Authors.AsQueryable().ToList<Author>();
        }
    }
}
