using System;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.DataAccessLayer.Abstract
{
	public interface IBookingDal: IGenericDal<Booking>
	{
        void BookingStatusChangedToApproved(int id);
    }
}

