using System;
namespace HotelProject.WebUI.Areas.Admin.Models.Staff
{
	public class StaffViewModel
	{
        public required int StaffID { get; set; }

        public required string Name { get; set; }

        public required string Title { get; set; }

        public required string Image { get; set; }

    }
}

