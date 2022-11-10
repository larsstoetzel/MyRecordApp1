using System.Collections.Generic;

namespace MyRecordApp.Model.Entities
{
    public class Artist
    {
        public int Id { get; set; }
        
        public string Name { get; set; } = string.Empty;
        public ICollection<Record> Records { get; set;} = new List<Record>();
    }
}
