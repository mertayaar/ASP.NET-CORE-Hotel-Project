using System;
using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.SubscribeDto
{
    public class CreateSubscribeDto
    {
        public required int SubscribeID { get; set; }
        [Required(ErrorMessage = "The Mail field is required.")]
        [EmailAddress(ErrorMessage = "The Mail field must be a valid email address.")]
        public required string Mail { get; set; }
    }
}

