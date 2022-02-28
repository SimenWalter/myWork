using System;
using System.Collections.Generic;

#nullable disable

namespace Quot.Engine.Entities
{
    public partial class Collection
    {
        public string CollectionId { get; set; }
        public string CollectionName { get; set; }
        public string Owner { get; set; }
        public string Description { get; set; }
    }
}
