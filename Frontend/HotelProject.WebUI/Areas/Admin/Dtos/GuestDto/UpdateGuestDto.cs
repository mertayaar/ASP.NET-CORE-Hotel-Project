using System;
namespace HotelProject.WebUI.Areas.Admin.Dtos.GuestDto
{
    public class UpdateGuestDto
    {
        public int GuestID { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? City { get; set; }
    }
}

