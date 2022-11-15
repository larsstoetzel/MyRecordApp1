using MyRecordApp.Model.Entities;
using System.Collections.Generic;

namespace MyRecordApp.Model.Records
{
    public record RecordDetails(
        string Title, 
        string Labels,
        ICollection<Artist> Artists,
        string ReleaseDate,
        string CoverUrl,
        ICollection<Track> Tracks);
}
