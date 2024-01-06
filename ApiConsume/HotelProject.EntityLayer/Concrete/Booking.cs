using System;
using System.ComponentModel.DataAnnotations;

namespace HotelProject.EntityLayer.Concrete
{
	public class Booking
	{
		[Key]
		public required int BookingID { get; set; }
        public required string Name { get; set; }
        public required string Mail { get; set; }
        public required DateTime Checkin { get; set; }
        public required DateTime CheckOut { get; set; }
        public required string AdultCount { get; set; }
        public required string ChildCout { get; set; }
        public required string SpecialRequest { get; set; }
        public required string Status { get; set; }
        public required string Description { get; set; }
        public required string RoomCount { get; set; }
    }
}

