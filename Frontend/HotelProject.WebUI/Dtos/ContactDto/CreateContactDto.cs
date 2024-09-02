using HotelProject.EntityLayer.Concrete;
using System;

namespace HotelProject.WebUI.Dtos.ContactDto
{
	public class CreateContactDto
	{
		public string Name { get; set; }
		public string Mail { get; set; }
		public string Subject { get; set; }
		public string Message { get; set; }
		public DateTime MessageDate { get; set; }
        public int MessageCategoryID { get; set; }
    }
}
