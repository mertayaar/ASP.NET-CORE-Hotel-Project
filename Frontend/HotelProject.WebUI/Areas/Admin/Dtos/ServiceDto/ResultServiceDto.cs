using System;
namespace HotelProject.WebUI.Areas.Admin.Dtos.ServiceDto
{
	public class ResultServiceDto
	{
        public required int ServiceID { get; set; }

        public required string Title { get; set; }

        public required string ServiceIcon { get; set; }

        public required string Description { get; set; }
    }
}

