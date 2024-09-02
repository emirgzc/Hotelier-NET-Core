using HotelProject.WebUI.Dtos.ServiceDto;
using HotelProject.WebUI.Models.Staff;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Controllers
{
	public class ServiceController : Controller
	{
		private readonly IHttpClientFactory _httpClientFactory;

		public ServiceController(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}
		public async Task<IActionResult> Index()
		{
			// istemci oluşturduk
			var client = _httpClientFactory.CreateClient();
			// adrese istek yolladık
			var responseMessage = await client.GetAsync("http://localhost:8334/api/Service");
			if (responseMessage.IsSuccessStatusCode)
			{
				// başarılı durum kodu dönünce gelen verileri modele dönüştürdük
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<List<ResultServiceDto>>(jsonData);
				return View(values);
			}
			return View();
		}
		[HttpGet]
		public IActionResult AddService()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> AddService(CreateServiceDto createServiceDto)
		{
			if (!ModelState.IsValid)
			{
				// hatalar dto sayesinde gösterilir
				return View();
			}
			// istemci oluşturduk
			var client = _httpClientFactory.CreateClient();
			// gönderdiğimiz model datasını jsona uygun çevirir
			var jsonData = JsonConvert.SerializeObject(createServiceDto);
			// içeriğin dönüşümü için kullanılacak sınıf
			StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
			var responseMessage = await client.PostAsync("http://localhost:8334/api/Service", stringContent);
			if (responseMessage.IsSuccessStatusCode)
			{
				return RedirectToAction("Index");
			}
			return View();
		}
		public async Task<IActionResult> DeleteService(int id)
		{
			// istemci oluşturduk
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.DeleteAsync($"http://localhost:8334/api/Service/{id}");
			if (responseMessage.IsSuccessStatusCode)
			{
				return RedirectToAction("Index");
			}
			return View();
		}
		[HttpGet]
		public async Task<IActionResult> UpdateService(int id)
		{
			// istemci oluşturduk
			var client = _httpClientFactory.CreateClient();
			// adrese istek yolladık
			var responseMessage = await client.GetAsync($"http://localhost:8334/api/Service/{id}");
			if (responseMessage.IsSuccessStatusCode)
			{
				// istekten gelen verilerin alınması
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				// verileri modele çevirme(ayıklama)
				var values = JsonConvert.DeserializeObject<UpdateServiceDto>(jsonData);
				return View(values);
			}
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> UpdateService(UpdateServiceDto updateServiceDto)
		{
			if (!ModelState.IsValid)
			{
				return View();
			}
			// istemci oluşturduk
			var client = _httpClientFactory.CreateClient();
			// modelden gelen jsona dönüştürme
			var jsonData = JsonConvert.SerializeObject(updateServiceDto);
			// içeriğin dönüşümü için kullanılacak sınıf
			StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
			// adrese istek yolladık
			var responseMessage = await client.PutAsync("http://localhost:8334/api/Service/", stringContent);
			if (responseMessage.IsSuccessStatusCode)
			{
				return RedirectToAction("Index");
			}
			return View();
		}
	}
}
