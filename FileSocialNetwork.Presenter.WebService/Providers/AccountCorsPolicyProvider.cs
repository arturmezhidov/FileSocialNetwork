using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Cors;
using System.Web.Http.Cors;

namespace FileSocialNetwork.Presenter.WebService.Providers
{
    public class AccountCorsPolicyProvider : ICorsPolicyProvider
    {
        CorsPolicy policy;

        //public AccountCorsPolicyProvider(CorsPolicy policy)
        //{
        //    this.policy = policy;
        //}

        public Task<CorsPolicy> GetCorsPolicyAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var corsRequestContext = request.GetCorsRequestContext();
            var originRequested = corsRequestContext.Origin;
            
            policy = new CorsPolicy();
            policy.Origins.Add(originRequested);
            policy.Methods.Add(corsRequestContext.HttpMethod);

         //   policy.Methods.Add("GET");

            return Task.FromResult(policy);
        }
    }
}