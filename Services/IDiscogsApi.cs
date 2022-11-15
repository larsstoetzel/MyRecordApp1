using MyRecordApp.Model;
using MyRecordApp.Model.Discogs;
using Refit;
using System.Threading.Tasks;

namespace MyRecordApp.Services
{
    [Headers("User-Agent:MyRecordApp")]
    public interface IDiscogsApi
    {
        [Get("/oauth/identity")]
        Task<IApiResponse<DiscogsIdentity>> CheckAccessTokenAsync([Header("Authorization")]string authorization);

        [Get("/database/search?q={query}&format=vinyl")]
        Task<IApiResponse<SearchResponse>> SearchAsync(string query);

        [Get("/releases/{id}")]
        Task<IApiResponse<ReleaseResponse>> GetReleaseAsync(int id);
    }
}
