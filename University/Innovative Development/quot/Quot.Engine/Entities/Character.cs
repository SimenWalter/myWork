using System;
using System.Collections.Generic;

#nullable disable

namespace Quot.Engine.Entities
{
    public partial class Character
    {
        public string CharId { get; set; }
        public string CharName { get; set; }
        public string Abbrev { get; set; }
        public string Works { get; set; }
        public string Description { get; set; }
        public int? SpeechCount { get; set; }
    }
}
