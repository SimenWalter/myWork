using Quot.Engine.Db;
using Quot.Engine.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quot.Engine.Services
{
    public class BaseService
    {
        public IDbContext Context { get; set; }

        public BaseService(IDbContext _context)
        {
            Context = _context;
        }
    }
}
