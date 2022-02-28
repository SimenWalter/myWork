using System;
using System.Collections.Generic;

#nullable disable

namespace Quot.Engine.Entities
{
    public partial class Author
    {
        public string AuthorId { get; set; }
        public string AuthorDisplayName { get; set; }
        public string AuthorSortName { get; set; }
        public short? YearBorn { get; set; }
        public short? YearDied { get; set; }
    }
}
