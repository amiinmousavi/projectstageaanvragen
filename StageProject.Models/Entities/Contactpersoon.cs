using System;
using System.Collections.Generic;

namespace StageProject.Models.Entities
{
    public partial class Contactpersoon
    {
        public int Id { get; set; }
        public string Voornaam { get; set; } = null!;
        public string Achternaam { get; set; } = null!;
        public string Tel { get; set; } = null!;
        public string Email { get; set; } = null!;
    }
}
