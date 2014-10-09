using Owin;
using System.Net.Http.Formatting;
using System.Web.Http;

namespace OwinKatanaWebApiSample
{
    public class StartUp
    {
        public void Configuration(IAppBuilder appBuilder)
        {
            HttpConfiguration httpConfiguration = new HttpConfiguration();
            httpConfiguration.Routes.MapHttpRoute(
                name: "DefaultApi", 
                routeTemplate: "{controller}/{id}", 
                defaults: new { id= RouteParameter.Optional}
            );

            httpConfiguration.Formatters.Clear();
            httpConfiguration.Formatters.Add(new JsonMediaTypeFormatter());
            appBuilder.UseWebApi(httpConfiguration);
        }
    }
}
