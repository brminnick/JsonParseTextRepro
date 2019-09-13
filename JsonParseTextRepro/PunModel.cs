using System;

namespace JsonParseTextRepro
{
    public class PunModel
    {
        public int PunNumber { get; set; }

        public string PunImageUrl { get; set; } = string.Empty;

        public bool IsSolved { get; set; } = false;

        public DateTime PunCreatedDate { get; set; }

        public string PunUrl { get; set; } = string.Empty;

        public bool IsFavorite { get; set; }
    }
}