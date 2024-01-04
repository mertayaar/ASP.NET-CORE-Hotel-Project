using System;
namespace HotelProject.WebUI.Dtos.TestimonialDto
{
	public class ResultTestimonialDto
	{
        public required int TestimonialID { get; set; }

        public required string Name { get; set; }

        public required string Title { get; set; }

        public required string Description { get; set; }

        public required string Image { get; set; }
    }
}

