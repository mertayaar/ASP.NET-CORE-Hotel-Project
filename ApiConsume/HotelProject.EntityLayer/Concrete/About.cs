using System;
using System.ComponentModel.DataAnnotations;

namespace HotelProject.EntityLayer.Concrete
{
	public class About
	{
        [Key]
		public required int AboutUsID { get; set; }
        public required string ShortTitle { get; set; }
        public required string Title { get; set; }
        public required string Content { get; set; }
        public required int RoomCount { get; set; }
        public required int StaffCount { get; set; }
        public required int ClientCount { get; set; }
    }
}

