using System;
namespace HotelProject.WebUI.Areas.Admin.Dtos.ContactDto
{
	public class InboxContactDto
	{
        public int ContactID { get; set; }
        public required string SenderName { get; set; }
        public required string SenderMail { get; set; }
        public required string ReceiverName { get; set; }
        public required string ReceiverMail { get; set; }
        public required string Subject { get; set; }
        public required string Message { get; set; }
        public DateTime Date { get; set; }
    }
}

