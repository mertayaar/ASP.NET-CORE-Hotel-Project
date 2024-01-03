using System;
using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.LoginDto
{
	public class LoginUserDto
	{
        [Required(ErrorMessage = "Please enter your user name! This field is mandatory.")]
        public string? UserName { get; set; }
        [Required(ErrorMessage = "Please enter your password! This field is mandatory.")]
        public string? Password { get; set; }
    }
}

