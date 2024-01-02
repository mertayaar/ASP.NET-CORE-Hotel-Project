using System;
using System.ComponentModel.DataAnnotations;

namespace HotelProject.EntityLayer.Concrete
{
	public class Testimonial
	{
        [Key]
        public int TestimonialID { get; set; }

        public required string Name { get; set; }

        public required string Title { get; set; }

        public required string Description { get; set; }

        public required string Image { get; set; }
    }
}

