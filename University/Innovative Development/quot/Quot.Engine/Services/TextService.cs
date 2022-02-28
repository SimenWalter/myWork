using Quot.Engine.Db;
using Quot.Engine.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quot.Engine.Services
{
    public class TextService : BaseService, ITextService
    {
        public TextService(IDbContext _context) : base(_context)
        {

        }
        public Paragraph get(String text)
        {
            return Context.Paragraphs.Find(text);
        }

        public List<Paragraph> getAll()
        {
            return Context.Paragraphs.AsQueryable().ToList<Paragraph>();
        }
    }
}