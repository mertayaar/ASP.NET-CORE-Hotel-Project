using System;
using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.ServiceDto
{
	public class UpdateServiceDto
	{
        public required int ServiceID { get; set; }

        [Required(ErrorMessage = "Please enter service title! This field is mandatory.")]
        public required string Title { get; set; }

        [Required(ErrorMessage = "Please enter service icon! This field is mandatory.")]
        public required string ServiceIcon { get; set; }


        [Required(ErrorMessage = "Please enter service description! This field is mandatory.")]
        [StringLength(150, ErrorMessage = "Please limit your input to 150 characters or less!")]
        public required string Description { get; set; }
    }
}

