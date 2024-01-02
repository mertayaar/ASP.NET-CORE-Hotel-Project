using System;
using System.ComponentModel.DataAnnotations;

namespace HotelProject.EntityLayer.Concrete
{
	public class Service
	{
        [Key]
        public required int ServiceID { get; set; }

        public required string Title { get; set; }

        public required string ServiceIcon { get; set; }

        public required string Description { get; set; }
    }
}

