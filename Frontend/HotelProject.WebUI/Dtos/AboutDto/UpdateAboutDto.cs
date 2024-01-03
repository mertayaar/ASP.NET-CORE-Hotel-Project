using System;
using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.AboutDto
{
	public class UpdateAboutDto
	{

        [Required(ErrorMessage = "Please enter service description! This field is mandatory.")]
        [StringLength(150, ErrorMessage = "Please limit your input to 150 characters or less!")]
        public required int AboutUsID { get; set; }

        [Required(ErrorMessage = "Please enter short title! This field is mandatory.")]
        public required string ShortTitle { get; set; }

        [Required(ErrorMessage = "Please enter title! This field is mandatory.")]
        public required string Title { get; set; }
        public required string Content { get; set; }
        public required int RoomCount { get; set; }
        public required int StaffCount { get; set; }
        public required int ClientCount { get; set; }
    }
}

