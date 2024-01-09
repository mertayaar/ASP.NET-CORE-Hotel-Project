using System;
namespace HotelProject.WebUI.Areas.Admin.Dtos.GuestDto
{
	public class ResultGuestDto
	{
        public int GuestID { get; set; }
        public required string Name { get; set; }
        public required string Surname { get; set; }
        public required string City { get; set; }
    }
}

