using System.Collections.Generic;

namespace MyRecordApp.Model.Discogs
{
    public record SearchResponse(ICollection<SearchResults> Results);
    public record SearchResults(string Title, string Thumb, string Year, int Id);
    
}
