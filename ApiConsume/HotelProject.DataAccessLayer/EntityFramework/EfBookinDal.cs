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

        public void BookingStatusChangedToApproved(int id)
        {
            var context = new Context();
            var values = context.Bookings.Find(id);
            values.Status = "Approved";
            context.SaveChanges();

        }
    }
}

