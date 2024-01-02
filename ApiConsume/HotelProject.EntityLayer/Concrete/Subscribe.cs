using System;
using System.ComponentModel.DataAnnotations;

namespace HotelProject.EntityLayer.Concrete
{
    public class Subscribe
    {
        [Key]
        public int SubscribeID { get; set; }

        public required string Mail { get; set; }
    }
}

