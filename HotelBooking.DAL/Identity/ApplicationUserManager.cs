using HotelBooking.DAL.Entities;
using Microsoft.AspNet.Identity;

namespace HotelBooking.DAL.Identity
{
    public class ApplicationUserManager : UserManager<ApplicationUser>
    {
        public ApplicationUserManager(IUserStore<ApplicationUser> store)
                : base(store)
        {
        }
    }
}
