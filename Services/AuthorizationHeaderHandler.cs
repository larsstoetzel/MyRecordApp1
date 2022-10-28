using MyRecordApp.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyRecordApp.Services
{
    public class AuthorizationHeaderHandler : DelegatingHandler
    {
        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
           if(request.Headers.Authorization == null)
            {
                var token = Settings.Default.AccessToken;
                request.Headers.Authorization = new AuthenticationHeaderValue("Discogs token=", token);
            }
            return await base.SendAsync(request, cancellationToken);
        }
    }
}
