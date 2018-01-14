using Microsoft.AspNet.Identity.EntityFramework;

namespace HotelBooking.DAL.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public virtual ClientProfile ClientProfile { get; set; }
    }
}
