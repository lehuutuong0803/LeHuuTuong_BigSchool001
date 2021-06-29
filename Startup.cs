using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LeHuuTuong_BigSchool001.Startup))]
namespace LeHuuTuong_BigSchool001
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
