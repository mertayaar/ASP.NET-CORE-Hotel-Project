using System;
using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.BookingDto
{
	public class CreateBookingDto
	{
        
        public int BookingID { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public required string Name { get; set; }

        [Required(ErrorMessage = "Mail is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public required string Mail { get; set; }

        [Required(ErrorMessage = "Check-in date is required")]
        public required DateTime Checkin { get; set; }

        [Required(ErrorMessage = "Check-out date is required")]
        public required DateTime CheckOut { get; set; }

        [Required(ErrorMessage = "Adult count is required")]
        public required string AdultCount { get; set; }

        [Required(ErrorMessage = "Child count is required")]
        public required string ChildCout { get; set; }

        public required string SpecialRequest { get; set; }

        [Required(ErrorMessage = "Status is required")]
        public required string Status { get; set; }

        [Required(ErrorMessage = "Room count is required")]
        public required string RoomCount { get; set; }

        [Required(ErrorMessage = "Description is required")]
        public required string Description { get; set; }
    }
}

