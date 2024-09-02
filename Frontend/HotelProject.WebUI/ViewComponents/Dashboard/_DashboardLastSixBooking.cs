using HotelProject.WebUI.Dtos.BookingDto;
using HotelProject.WebUI.Dtos.StaffDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace HotelProject.WebUI.ViewComponents.Dashboard
{
    public class _DashboardLastSixBooking : ViewComponent
	{
		private readonly IHttpClientFactory _httpClientFactory;

		public _DashboardLastSixBooking(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			// API CONSUME ETME(KULLANMA,TÜKETME)
			// istemci oluşturduk
			var client = _httpClientFactory.CreateClient();
			// adrese istek yolladık
			var responseMessage = await client.GetAsync("http://localhost:8334/api/Booking/LastSixBooking");
			// başarılı durum kodu dönerse
			if (responseMessage.IsSuccessStatusCode)
			{
				// gelen içeriği oku
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				// gelen json dataları, modele uygun şekilde dönüştürür
				var values = JsonConvert.DeserializeObject<List<ResultLastSixBookingDto>>(jsonData);
				return View(values);
			}
			return View();
		}
	}
}
