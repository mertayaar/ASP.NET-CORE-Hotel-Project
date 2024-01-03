using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace HotelProject.DtoLayer.Dtos.RoomDto
{
    public class RoomAddDto
    {
      

        public required int RoomID { get; set; }

        [Required(ErrorMessage = "Please enter room number! This field is mandatory.")]
        public string RoomNumber { get; set; }


        public string RoomCoverImage { get; set; }

        [Required(ErrorMessage = "Please enter price information! This field is mandatory.")]
        public int Price { get; set; }


        [Required(ErrorMessage = "Please enter title information! This field is mandatory.")]
        [StringLength(100, ErrorMessage = "Please limit your input to 100 characters or less!")]
        public string Title { get; set; }


        [Required(ErrorMessage = "Please enter bed count information! This field is mandatory.")]
        public string BedCount { get; set; }


        [Required(ErrorMessage = "Please enter bath count information! This field is mandatory.")]
        public string BathCount { get; set; }

        public string Wifi { get; set; }

        public string Description { get; set; }

        
    }
}

