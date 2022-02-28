using System;
using System.Collections.Generic;

#nullable disable

namespace Quot.Engine.Entities
{
    public partial class Paragraph
    {
        public string WorkId { get; set; }
        public int ParagraphId { get; set; }
        public int? ParagraphNum { get; set; }
        public string CharId { get; set; }
        public string PlainText { get; set; }
        public string PhoneticText { get; set; }
        public string StemText { get; set; }
        public string ParagraphType { get; set; }
        public byte? Section { get; set; }
        public int? Chapter { get; set; }
        public short? CharCount { get; set; }
        public short? WordCount { get; set; }
    }
}
