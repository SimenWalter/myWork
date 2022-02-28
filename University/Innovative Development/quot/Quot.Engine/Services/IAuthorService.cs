using Quot.Engine.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quot.Engine.Services
{
    public interface IAuthorService
    {
        public Author get(int Id);

        public List<Author> getAll();
    }
}
