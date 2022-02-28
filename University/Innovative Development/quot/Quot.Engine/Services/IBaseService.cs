using Quot.Engine.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quot.Engine.Services
{
    public interface IBaseService<T> where T : class
    {
        public IDbContext Context { get; set; }

        public List<T> getAll();

        public T get(int Id);

    }
    
}
