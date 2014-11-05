using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DoggyBox.Startup))]
namespace DoggyBox
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
