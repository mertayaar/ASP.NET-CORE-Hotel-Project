using System;
namespace HotelProject.WebUI.Areas.Admin.Dtos.BookingDto
{
	public class ApprovedReservationDto { 
        public required int BookingID { get; set; }
        public required string Status { get; set; }

    }
}

 