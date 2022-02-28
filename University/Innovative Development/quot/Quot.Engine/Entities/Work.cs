using System;
using System.Collections.Generic;

#nullable disable

namespace Quot.Engine.Entities
{
    public partial class Work
    {
        public string WorkId { get; set; }
        public string Title { get; set; }
        public string LongTitle { get; set; }
        public short? Date { get; set; }
        public string GenreType { get; set; }
        public string Notes { get; set; }
        public string Source { get; set; }
        public int? TotalWords { get; set; }
        public int? TotalParagraphs { get; set; }
    }
}
