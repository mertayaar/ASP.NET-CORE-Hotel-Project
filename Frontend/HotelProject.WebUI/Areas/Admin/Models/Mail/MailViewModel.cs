using System;
namespace HotelProject.WebUI.Areas.Admin.Models.Mail
{
	public class MailViewModel
	{
		public string Subject { get; set; }
        public string Name { get; set; }
        public string SenderMail { get; set; }
        public string ReceiverMail { get; set; }
        public string Body { get; set; }
    }
}

