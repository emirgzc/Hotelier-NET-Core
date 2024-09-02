using HotelProject.WebUI.Dtos.BookingDto;
using HotelProject.WebUI.Dtos.ContactDto;
using HotelProject.WebUI.Dtos.MessageCategoryDto;
using HotelProject.WebUI.Dtos.RoomDto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Controllers
{
	[AllowAnonymous]
	public class ContactController : Controller
	{
		private readonly IHttpClientFactory _httpClientFactory;

		public ContactController(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}
		public async Task<IActionResult> Index()
		{
			// API CONSUME ETME(KULLANMA,TÜKETME)
			// istemci oluşturduk
			var client = _httpClientFactory.CreateClient();
			// adrese istek yolladık
			var responseMessage = await client.GetAsync("http://localhost:8334/api/MessageCategory");

			// gelen içeriği oku
			var jsonData = await responseMessage.Content.ReadAsStringAsync();
			// gelen json dataları, modele uygun şekilde dönüştürür
			var values = JsonConvert.DeserializeObject<List<ResultMessageCategoryDto>>(jsonData);
			List<SelectListItem> values2 = (from x in values
											select new SelectListItem
											{
												Text = x.MessageCategoryName,
												Value = x.MessageCategoryID.ToString()
											}).ToList();
			ViewBag.categoryMessage = values2;
			return View();

		}
		[HttpGet]
		public PartialViewResult AddContact()
		{
			return PartialView();
		}
		[HttpPost]
		public async Task<IActionResult> AddContact(CreateContactDto createContactDto)
		{
			createContactDto.MessageDate = DateTime.Now;
			// istemci oluşturduk
			var client = _httpClientFactory.CreateClient();
			// verileri stringe çevirdik
			var jsonData = JsonConvert.SerializeObject(createContactDto);
			// içeriğin dönüşümü için kullanılacak sınıf
			StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
			await client.PostAsync("http://localhost:8334/api/Contact", stringContent);

			return RedirectToAction("Index", "Default");
		}
	}
}
