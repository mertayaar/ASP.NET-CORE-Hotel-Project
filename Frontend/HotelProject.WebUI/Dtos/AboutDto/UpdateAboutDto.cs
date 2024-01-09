using System;
using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.AboutDto
{
	public class UpdateAboutDto
	{

        [Required(ErrorMessage = "Please enter service description! This field is mandatory.")]
    
        public  int AboutUsID { get; set; }

        [Required(ErrorMessage = "Please enter short title! This field is mandatory.")]
        public required string ShortTitle { get; set; }

        [Required(ErrorMessage = "Please enter title! This field is mandatory.")]
        public required string Title { get; set; }

        [Required(ErrorMessage = "Please enter title! This field is mandatory.")]
        public required string Content { get; set; }
        public  int RoomCount { get; set; }
        public  int StaffCount { get; set; }
        public  int ClientCount { get; set; }
    }
}

