using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.Dtos.AppUserDto;
using HotelProject.WebUI.Dtos.RoomDto;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Controllers
{
	public class AdminUsersController : Controller
	{
        private readonly IHttpClientFactory _httpClientFactory;

        public AdminUsersController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        //public async Task<IActionResult> Index()
        //{
        //    // API CONSUME ETME(KULLANMA,TÜKETME)
        //    // istemci oluşturduk
        //    var client = _httpClientFactory.CreateClient();
        //    // adrese istek yolladık
        //    var responseMessage = await client.GetAsync("http://localhost:8334/api/AppUser");
        //    // başarılı durum kodu dönerse
        //    if (responseMessage.IsSuccessStatusCode)
        //    {
        //        // gelen içeriği oku
        //        var jsonData = await responseMessage.Content.ReadAsStringAsync();
        //        // gelen json dataları, modele uygun şekilde dönüştürür
        //        var values = JsonConvert.DeserializeObject<List<ResultAppUserDto>>(jsonData);
        //        return View(values);
        //    }
        //    return View();
        //}
        public async Task<IActionResult> UserList()
        {
            // API CONSUME ETME(KULLANMA,TÜKETME)
            // istemci oluşturduk
            var client = _httpClientFactory.CreateClient();
            // adrese istek yolladık
            var responseMessage = await client.GetAsync("http://localhost:8334/api/AppUser");
            // başarılı durum kodu dönerse
            if (responseMessage.IsSuccessStatusCode)
            {
                // gelen içeriği oku
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                // gelen json dataları, modele uygun şekilde dönüştürür
                var values = JsonConvert.DeserializeObject<List<ResultAppUserListDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
