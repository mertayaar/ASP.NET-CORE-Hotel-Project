using System;
namespace HotelProject.EntityLayer.Concrete
{
	public class Guest
	{
		public int GuestID { get; set; }
        public required string Name { get; set; }
        public required string Surname { get; set; }
        public required string City { get; set; }

    }
}

