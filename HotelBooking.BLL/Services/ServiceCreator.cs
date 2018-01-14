using HotelBooking.BLL.Interfaces;
using HotelBooking.DAL.Repositories;

namespace HotelBooking.BLL.Services
{
    public class ServiceCreator : IServiceCreator
    {
        public IUserService CreateUserService(string connection)
        {
            return new UserService(new IdentityUnitOfWork(connection));
        }
    }
}
