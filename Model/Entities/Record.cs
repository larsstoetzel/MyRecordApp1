using System.Collections.Generic;

namespace MyRecordApp.Model.Entities
{
    public class Record
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;   
        public string? ReleaseDate { get; set; }
        public ICollection<Track> Tracks { get; set; } = new List<Track>();
        public string CoverUrl { get; set; } = string.Empty; 
        public ICollection<Label> Labels { get; set; } = new List<Label>();       
        public ICollection<Artist> Artists { get; set; } = new List<Artist>();
    }
}
