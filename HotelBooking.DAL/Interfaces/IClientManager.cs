using HotelBooking.DAL.Entities;
using System;

namespace HotelBooking.DAL.Interfaces
{
    public interface IClientManager:IDisposable
    {
        void Create(ClientProfile item);
    }
}
