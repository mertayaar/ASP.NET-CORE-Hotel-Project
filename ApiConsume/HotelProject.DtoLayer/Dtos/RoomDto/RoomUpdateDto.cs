using System;
using System.ComponentModel.DataAnnotations;

namespace HotelProject.DtoLayer.Dtos.RoomDto
{
	public class RoomUpdateDto
	{
        public required int RoomID { get; set; }


        [Required(ErrorMessage = "Please enter room number! This field is mandatory.")]
        public required string RoomNumber { get; set; }

        [Required(ErrorMessage = "Please add a room image. This field is mandatory.!")]
        public required string RoomCoverImage { get; set; }

        [Required(ErrorMessage = "Please enter price information! This field is mandatory.")]
        public required int Price { get; set; }

        [Required(ErrorMessage = "Please enter title information! This field is mandatory.")]
        [StringLength(100, ErrorMessage = "Please limit your input to 100 characters or less!")]
        public required string Title { get; set; }


        [Required(ErrorMessage = "Please enter bed count information! This field is mandatory.")]
        public required string BedCount { get; set; }


        [Required(ErrorMessage = "Please enter bath count information! This field is mandatory.")]
        public required string BathCount { get; set; }

        public required string Wifi { get; set; }

        public required string Description { get; set; }
    }
}

