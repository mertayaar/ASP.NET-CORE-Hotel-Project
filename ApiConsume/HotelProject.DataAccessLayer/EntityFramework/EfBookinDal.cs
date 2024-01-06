using System;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.Repositories;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.DataAccessLayer.EntityFramework
{
    public class EfBookinDal : GenericRepository<Booking>, IBookingDal
    {
        public EfBookinDal(Context context) : base(context)
        {

        }
    }
}

