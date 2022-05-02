using System;
using System.Collections.Generic;

namespace StageProject.Models.Entities
{
    public partial class Bedrijf
    {
        public int? Id { get; set; }
        public string? Naam { get; set; }
        public string? Adres { get; set; }
        public string? Stad { get; set; }
        public string? Website { get; set; }
        public string? Logo { get; set; }
    }
}
