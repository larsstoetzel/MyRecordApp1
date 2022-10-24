using System;
using System.Collections.Generic;

namespace MyRecordApp.Model.Entities
{
    public class Record
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;   
        public DateTime ReleaseDate { get; set; }
        public string Tracks { get; set; } = string.Empty;
        public string CoverUrl { get; set; } = string.Empty;    
        public ICollection<Artist> Artists { get; set; } = new List<Artist>();
    }
}
