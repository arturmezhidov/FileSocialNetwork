using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Cors;
using System.Web.Http.Cors;

namespace FileSocialNetwork.Presenter.WebService.Providers
{
    public class AccountCorsPolicyProviderFactory : ICorsPolicyProviderFactory
    {
        public ICorsPolicyProvider GetCorsPolicyProvider(System.Net.Http.HttpRequestMessage request)
        {
        // //   var route = request.GetRouteData();
        ////    var controller = (string)route.Values["controller"];
        //    var corsRequestContext = request.GetCorsRequestContext();
        //    var originRequested = corsRequestContext.Origin;
        //    var policy = GetPolicyForControllerAndOrigin(
        //      controller, originRequested);
        //    return new AccountCorsPolicyProvider(policy);

            return null;
        }
        private CorsPolicy GetPolicyForControllerAndOrigin(
         string controller, string originRequested)
        {
            // Ищем по базе данных, чтобы определить, разрешено ли
            // контроллеру иметь дело с данным источником,
            // и, если да, создаем CorsPolicy (иначе возвращаем null)
            var policy = new CorsPolicy();
            policy.Origins.Add(originRequested);
            policy.Methods.Add("GET");
            return policy;
        }
    }
}