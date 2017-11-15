using Microsoft.AspNet.Identity.EntityFramework;

namespace SportsStoreAPI.Infrastructure.Identity
{
    public class StoreRole : IdentityRole
    {
        public StoreRole() : base() { }
        public StoreRole(string name) : base(name) { }
    }
}