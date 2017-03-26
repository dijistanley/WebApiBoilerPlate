using Microsoft.Owin;
using Owin;


[assembly: OwinStartup(typeof(WebAppBoilerPlate.Startup))]
namespace WebAppBoilerPlate
{
    public partial class Startup
    {
        //public static OAuthBearerAuthenticationOptions OAuthBearerOptions { get; private set; }
        //public static GoogleOAuth2AuthenticationOptions googleAuthOptions { get; private set; }
        //public static FacebookAuthenticationOptions facebookAuthOptions { get; private set; }

        public void Configuration(IAppBuilder app)
        {
            //HttpConfiguration config = new HttpConfiguration();
            ConfigureOAuth(app);

            //WebApiConfig.Register(config);
            //app.UseCors(CorsOptions.AllowAll);
            //app.UseWebApi(config);
            
        }
        
    }
}