using Quot.Engine.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quot.Engine.Services
{
    public interface ITextService
    {
        public Paragraph get(String text);

        public List<Paragraph> getAll();
    }
}