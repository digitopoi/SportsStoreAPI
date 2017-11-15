using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(SportsStoreAPI.IdentityConfig))]

namespace SportsStoreAPI
{
    public class IdentityConfig
    {
        public void Configuration(IAppBuilder app) { }
    }
}