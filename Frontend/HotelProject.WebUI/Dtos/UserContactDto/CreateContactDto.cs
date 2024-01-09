using System;
using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.UserContactDto
{
	public class CreateContactDto
	{
        public int ContactID { get; set; }

        [Required(ErrorMessage = "Please provide your name.")]
        public required string SenderName { get; set; }

        [Required(ErrorMessage = "Please enter a valid email address.")]
        [EmailAddress(ErrorMessage = "The email address is not in a valid format.")]
        public required string SenderMail { get; set; }

        [Required(ErrorMessage = "Please provide a subject.")]
        public required string Subject { get; set; }

        [Required(ErrorMessage = "Please select a date.")]
        [DataType(DataType.DateTime, ErrorMessage = "Invalid date format. Please select a valid date and time.")]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Please enter a message.")]
        public required string Message { get; set; }

        public string? ReceiverName { get; set; }
        public string? ReceiverMail { get; set; }
    }
}

