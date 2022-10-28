using MyRecordApp.Model;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRecordApp.Services
{
    [Headers("User-Agent:MyRecordApp")]
    public interface IDiscogsApi
    {
        [Get("/oauth/identity")]
        Task<IApiResponse<DiscogsIdentity>> CheckAccessTokenAsync([Header("Authorization")]string authorization);
    }
}
