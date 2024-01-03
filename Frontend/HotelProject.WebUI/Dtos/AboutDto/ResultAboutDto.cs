using System;
namespace HotelProject.WebUI.Dtos.AboutDto
{
	public class ResultAboutDto
	{
        public required int AboutUsID { get; set; }
        public required string ShortTitle { get; set; }
        public required string Title { get; set; }
        public required string Content { get; set; }
        public required int RoomCount { get; set; }
        public required int StaffCount { get; set; }
        public required int ClientCount { get; set; }
    }
}

