using System;
using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Areas.Admin.Dtos.ServiceDto
{
	public class CreateServiceDto
	{
        public required int ServiceID { get; set; }

        [Required(ErrorMessage = "Please enter service title! This field is mandatory.")]
        public required string Title { get; set; }

        [Required(ErrorMessage = "Please enter service icon! This field is mandatory.")]
        public required string ServiceIcon { get; set; }

        public required string Description { get; set; }
    }
}

