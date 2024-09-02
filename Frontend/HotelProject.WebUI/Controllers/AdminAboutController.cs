using HotelProject.WebUI.Dtos.AboutDto;
using HotelProject.WebUI.Dtos.BookingDto;
using HotelProject.WebUI.Models.Staff;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Controllers
{
	public class AdminAboutController : Controller
	{
		private readonly IHttpClientFactory _httpClientFactory;

		public AdminAboutController(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		public async Task<IActionResult> Index()
		{
			// istemci oluşturduk
			var client = _httpClientFactory.CreateClient();
			// adrese istek yolladık
			var responseMessage = await client.GetAsync("http://localhost:8334/api/About");
			if (responseMessage.IsSuccessStatusCode)
			{
				// başarılı durum kodu dönünce gelen verileri modele dönüştürdük
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<List<ResultAboutDto>>(jsonData);
				return View(values);
			}
			return View();
		}
		[HttpGet]
		public async Task<IActionResult> UpdateAbout(int id)
		{
			// istemci oluşturduk
			var client = _httpClientFactory.CreateClient();
			// adrese istek yolladık
			var responseMessage = await client.GetAsync($"http://localhost:8334/api/About/{id}");
			if (responseMessage.IsSuccessStatusCode)
			{
				// gelen içeriği oku
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				// gelen json dataları, modele uygun şekilde dönüştürür
				var values = JsonConvert.DeserializeObject<UpdateAboutDto>(jsonData);
				return View(values);
			}
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> UpdateAbout(UpdateAboutDto model)
		{
			// istemci oluşturduk
			var client = _httpClientFactory.CreateClient();
			// gönderdiğimiz model datasını jsona uygun çevirir
			var jsonData = JsonConvert.SerializeObject(model);
			// içeriğin dönüşümü için kullanılacak sınıf
			StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
			// adrese istek yolladık
			var responseMessage = await client.PutAsync("http://localhost:8334/api/About/", stringContent);
			if (responseMessage.IsSuccessStatusCode)
			{
				return RedirectToAction("Index");
			}
			return View();
		}
	}
}
