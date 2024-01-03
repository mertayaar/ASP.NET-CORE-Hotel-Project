using System;
namespace HotelProject.DtoLayer.Dtos.TestimonialDto
{
	public class TestimonialAddDto
	{
        public required int TestimonialID { get; set; }

        public required string Name { get; set; }

        public required string Title { get; set; }

        public required string Description { get; set; }

        public required string Image { get; set; }
    }
}

