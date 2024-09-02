using HotelProject.WebUI.Dtos.ContactDto;
using HotelProject.WebUI.Dtos.SendMessageDto;
using HotelProject.WebUI.Models.Staff;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Controllers
{
    public class AdminContactController : Controller
    {
		private readonly IHttpClientFactory _httpClientFactory;

		public AdminContactController(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		public async Task<IActionResult> Inbox()
		{
			// API CONSUME ETME(KULLANMA,TÜKETME)
			// istemci oluşturduk
			var client = _httpClientFactory.CreateClient();
			// adrese istek yolladık
			var responseMessage = await client.GetAsync("http://localhost:8334/api/Contact");
			// başarılı durum kodu dönerse
			if (responseMessage.IsSuccessStatusCode)
			{
				// gelen içeriği oku
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				// gelen json dataları, modele uygun şekilde dönüştürür
				var values = JsonConvert.DeserializeObject<List<InboxContactDto>>(jsonData);
				return View(values);
			}
			return View();
		}
		public async Task<IActionResult> Sendbox()
		{
			// API CONSUME ETME(KULLANMA,TÜKETME)
			// istemci oluşturduk
			var client = _httpClientFactory.CreateClient();
			// adrese istek yolladık
			var responseMessage = await client.GetAsync("http://localhost:8334/api/SendMessage");
			// başarılı durum kodu dönerse
			if (responseMessage.IsSuccessStatusCode)
			{
				// gelen içeriği oku
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				// gelen json dataları, modele uygun şekilde dönüştürür
				var values = JsonConvert.DeserializeObject<List<ResultSendboxDto>>(jsonData);
				return View(values);
			}
			return View();
		}
		[HttpGet]
		public IActionResult AddSendMessage()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> AddSendMessage(CreateSendMessageDto model)
		{
			model.SenderMail = "admin@gmail.com";
			model.SenderName = "Admin";
			model.SendDate = DateTime.Now;

			// istemci oluşturduk
			var client = _httpClientFactory.CreateClient();
			// gönderdiğimiz model datasını jsona uygun çevirir
			var jsonData = JsonConvert.SerializeObject(model);
			// içeriğin dönüşümü için kullanılacak sınıf
			StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
			// adrese istek yolladık
			var responseMessage = await client.PostAsync("http://localhost:8334/api/SendMessage", stringContent);
			if (responseMessage.IsSuccessStatusCode)
			{
				return RedirectToAction("SendBox");
			}
			return View();
		}
		public PartialViewResult SidebarAdminContactPartial()
        {
            return PartialView();
        }
        public PartialViewResult SidebarAdminContactCategoryPartial()
        {
            return PartialView();
        }
		public async Task<IActionResult> MessageDetailsBySendbox(int id)
		{
            var client = _httpClientFactory.CreateClient();
            // adrese istek yolladık
            var responseMessage = await client.GetAsync($"http://localhost:8334/api/SendMessage/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                // gelen içeriği oku
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                // gelen json dataları, modele uygun şekilde dönüştürür
                var values = JsonConvert.DeserializeObject<GetMessageByIDDto>(jsonData);
                return View(values);
            }
            return View();
        }
        public async Task<IActionResult> MessageDetailsByInbox(int id)
        {
            var client = _httpClientFactory.CreateClient();
            // adrese istek yolladık
            var responseMessage = await client.GetAsync($"http://localhost:8334/api/Contact/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                // gelen içeriği oku
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                // gelen json dataları, modele uygun şekilde dönüştürür
                var values = JsonConvert.DeserializeObject<InboxContactDto>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
