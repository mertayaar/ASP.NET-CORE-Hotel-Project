
using System;
using Microsoft.AspNetCore.Identity;

namespace HotelProject.EntityLayer.Concrete
{
	public class AppUser : IdentityUser<int>
    {
		public required string Name { get; set; }
        public required string Surname { get; set; }
        public required string State { get; set; }
    }
}

