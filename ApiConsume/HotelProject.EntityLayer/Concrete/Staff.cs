using System;
using System.ComponentModel.DataAnnotations;

namespace HotelProject.EntityLayer.Concrete
{
	public class Staff
	{
        [Key]
        public required int StaffID { get; set; }

        public required string Name { get; set; }

        public required string Title { get; set; }

        public required string Image { get; set; }

        public required string SocialMedia1 { get; set; }

        public required string SocialMedia2 { get; set; }

        public required string SocialMedia3 { get; set; }
    }
}

