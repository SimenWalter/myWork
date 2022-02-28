using Microsoft.EntityFrameworkCore;
using Quot.Engine.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quot.Engine.Db
{
    public interface IDbContext
    {
        public DbSet<Author> Authors { get; set; }

        public DbSet<Paragraph> Paragraphs { get; set; }
    }
}
