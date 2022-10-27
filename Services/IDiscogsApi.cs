using MyRecordApp.Model;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRecordApp.Services
{
    public interface IDiscogsApi
    {
        [Get("/oauth/identity")]
        Task<DiscogsIdentity> CheckAccessTokenAsync([Authorize("Discogs token=")]string authorization);
    }
}
