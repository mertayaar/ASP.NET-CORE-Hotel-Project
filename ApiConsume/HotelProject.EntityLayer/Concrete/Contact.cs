using System;
namespace HotelProject.EntityLayer.Concrete
{
	public class Contact
	{
		public int ContactID { get; set; }
        public required string Name { get; set; }
        public required string Mail { get; set; }
        public required string Subject { get; set; }
        public required string Message { get; set; }
        public DateTime Date { get; set; }
    }
}

