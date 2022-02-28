using System;
using System.Collections.Generic;

#nullable disable

namespace Quot.Engine.Entities
{
    public partial class Chapter
    {
        public string WorkId { get; set; }
        public int ChapterId { get; set; }
        public byte? Section { get; set; }
        public byte? Chapter1 { get; set; }
        public string Description { get; set; }
    }
}
