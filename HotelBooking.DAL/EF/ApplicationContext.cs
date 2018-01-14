using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using HotelBooking.DAL.Entities;

namespace HotelBooking.DAL.EF
{
    public class ApplicationContext: IdentityDbContext<ApplicationUser>
    {
        public ApplicationContext(string conectionString) : base(conectionString) { }

        public DbSet<ClientProfile> ClientProfiles { get; set; }
    }
}
