﻿namespace HotelProject.WebUI.Dtos.AboutDto
{
    public class UpdateAboutDto
    {
        public int AboutID { get; set; }
        public string TitleOne { get; set; }
        public string TitleTwo { get; set; }
        public string Content { get; set; }
        public int RoomCount { get; set; }
        public int StaffCount { get; set; }
        public int CustomerCount { get; set; }
    }
}
