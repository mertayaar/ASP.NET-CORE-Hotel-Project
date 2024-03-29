﻿using System;
namespace HotelProject.WebUI.Dtos.RoomDto
{
	public class ResultRoomDto
	{
        public required int RoomID { get; set; }

        public required string RoomNumber { get; set; }

        public required string RoomCoverImage { get; set; }

        public required int Price { get; set; }

        public required string Title { get; set; }

        public required string BedCount { get; set; }

        public required string BathCount { get; set; }

        public required bool Wifi { get; set; }

        public required int Stars { get; set; }

        public required string Description { get; set; }
    }
}

