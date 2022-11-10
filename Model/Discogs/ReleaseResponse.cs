using System.Collections.Generic;

namespace MyRecordApp.Model.Discogs
{
    public record ReleaseResponse
        (int Id,
        string Title,
        string Thumb,
        string Released,
        ICollection<ReleaseArtistResponse> Artist,
        ICollection<ReleaseLabelResponse> Label,
        ICollection<ReleaseTrackResponse> Tracklist);
    public record ReleaseTrackResponse(string Title);  
    public record ReleaseArtistResponse(string Name);
    public record ReleaseLabelResponse(string Name);
}
