﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DtoLayer.Dtos.RoomDto
{
	public class RoomAddDto
	{
		[Required(ErrorMessage ="Lütfen oda numarasını yazınız")]
		public string RoomNumber { get; set; }
		public string RoomCoverImage { get; set; }
		[Required(ErrorMessage = "Lütfen fiyat bilgisi yazınız")]
		public int Price { get; set; }
		[Required(ErrorMessage = "Lütfen oda başlığı bilgisi yazınız")]
		public string Title { get; set; }
		[Required(ErrorMessage = "Lütfen yatak sayısı yazınız")]
		public string BedCount { get; set; }
		[Required(ErrorMessage = "Lütfen banyo sayısı yazınız")]
		public string BathCount { get; set; }
		public string Wifi { get; set; }
		public string Description { get; set; }
	}
}
