using System;
using System.Collections.Generic;

namespace StageProject.Models.Entities
{
    public partial class StageVoorstel
    {
        public int Id { get; set; }
        public string AanvragerId { get; set; } = null!;
        public int? ContactPersoonId { get; set; }
        public string Titel { get; set; } = null!;
        public string Academiejaar { get; set; } = null!;
        public int Semester { get; set; }
        public string DescriptieZoekertje { get; set; } = null!;
        public string WiezijnWij { get; set; } = null!;
        public string GezochteProfiel { get; set; } = null!;
        public string Aanbieding { get; set; } = null!;
        public int StatusStagevoorstelId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DatePublished { get; set; }
    }
}
