using System;
using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.RegisterDto
{
	public class CreateNewUserDto
	{

        [Required(ErrorMessage = "Please enter your name! This field is mandatory.")]
        public required string Name { get; set; }

        [Required(ErrorMessage = "Please enter your surname! This field is mandatory.")]
        public required string Surname { get; set; }

        [Required(ErrorMessage = "Please enter your state! This field is mandatory.")]
        public required string State { get; set; }

        [Required(ErrorMessage = "Please enter your user name! This field is mandatory.")]
        public required string UserName { get; set; }

        [Required(ErrorMessage = "Please enter your mail! This field is mandatory.")]
        public required string Mail { get; set; }

        [Required(ErrorMessage = "Please enter your password! This field is mandatory.")]
        public required string Password { get; set; }

        [Required(ErrorMessage = "Please enter your password again! This field is mandatory.")]
        [Compare("Password",ErrorMessage = "Passwords do not match!")]
        public required string ConfirmPassword { get; set; }

    }
}

