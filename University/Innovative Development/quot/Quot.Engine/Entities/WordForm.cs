using System;
using System.Collections.Generic;

#nullable disable

namespace Quot.Engine.Entities
{
    public partial class WordForm
    {
        public int WordFormId { get; set; }
        public string PlainText { get; set; }
        public string PhoneticText { get; set; }
        public string StemText { get; set; }
        public int? Occurences { get; set; }
    }
}
