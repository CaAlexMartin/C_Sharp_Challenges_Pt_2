using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hero_Monster_Challenge_part_1.Startup))]
namespace Hero_Monster_Challenge_part_1
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
