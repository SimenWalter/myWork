using System;
using System.Collections.Generic;

#nullable disable

namespace Quot.Engine.Entities
{
    public partial class Calculation
    {
        public string CalculationId { get; set; }
        public string Description { get; set; }
        public int? Total { get; set; }
    }
}
