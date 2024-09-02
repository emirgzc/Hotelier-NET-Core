using HotelProject.WebUI.Dtos.RoomDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Controllers
{
    public class AdminRoomController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AdminRoomController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            // API CONSUME ETME(KULLANMA,TÜKETME)
            // istemci oluşturduk
            var client = _httpClientFactory.CreateClient();
            // adrese istek yolladık
            var responseMessage = await client.GetAsync("http://localhost:8334/api/Room");
            // başarılı durum kodu dönerse
            if (responseMessage.IsSuccessStatusCode)
            {
                // gelen içeriği oku
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                // gelen json dataları, modele uygun şekilde dönüştürür
                var values = JsonConvert.DeserializeObject<List<ResultRoomDto>>(jsonData);
                return View(values);
            }
            return View();
        }
        [HttpGet]
        public IActionResult AddRoom()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddRoom(CreateRoomDto model)
        {
            // istemci oluşturduk
            var client = _httpClientFactory.CreateClient();
            // gönderdiğimiz model datasını jsona uygun çevirir
            var jsonData = JsonConvert.SerializeObject(model);
            // içeriğin dönüşümü için kullanılacak sınıf
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            // adrese istek yolladık
            var responseMessage = await client.PostAsync("http://localhost:8334/api/Room", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        public async Task<IActionResult> DeleteRoom(int id)
        {
            // istemci oluşturduk
            var client = _httpClientFactory.CreateClient();
            // adrese istek yolladık
            var responseMessage = await client.DeleteAsync($"http://localhost:8334/api/Room/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> UpdateRoom(int id)
        {
            // istemci oluşturduk
            var client = _httpClientFactory.CreateClient();
            // adrese istek yolladık
            var responseMessage = await client.GetAsync($"http://localhost:8334/api/Room/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                // gelen içeriği oku
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                // gelen json dataları, modele uygun şekilde dönüştürür
                var values = JsonConvert.DeserializeObject<UpdateRoomDto>(jsonData);
                return View(values);
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UpdateRoom(UpdateRoomDto model)
        {
            // istemci oluşturduk
            var client = _httpClientFactory.CreateClient();
            // gönderdiğimiz model datasını jsona uygun çevirir
            var jsonData = JsonConvert.SerializeObject(model);
            // içeriğin dönüşümü için kullanılacak sınıf
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            // adrese istek yolladık
            var responseMessage = await client.PutAsync("http://localhost:8334/api/Room/", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
