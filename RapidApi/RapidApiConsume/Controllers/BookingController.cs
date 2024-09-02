using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RapidApiConsume.Models;
using System.Linq;

namespace RapidApiConsume.Controllers
{
	public class BookingController : Controller
	{
		public async Task<IActionResult> Index()
		{

			var client = new HttpClient();
			var request = new HttpRequestMessage
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri("https://booking-com.p.rapidapi.com/v2/hotels/search?locale=en-gb&filter_by_currency=TRY&checkin_date=2024-06-30&dest_type=city&dest_id=4308&adults_number=2&checkout_date=2024-07-15&order_by=popularity&room_number=1&units=metric&children_number=2&children_ages=5%2C0&categories_filter_ids=class%3A%3A2%2Cclass%3A%3A4%2Cfree_cancellation%3A%3A1&include_adjacency=true&page_number=0"),
				Headers =
	{
		{ "X-RapidAPI-Key", "b022da8192mshd9dde807f5c8dd3p1fe561jsndc30b00c2ff4" },
		{ "X-RapidAPI-Host", "booking-com.p.rapidapi.com" },
	},
			};
			using (var response = await client.SendAsync(request))
			{
				response.EnsureSuccessStatusCode();
				var body = await response.Content.ReadAsStringAsync();

				// ---
				var values = JsonConvert.DeserializeObject<BookingApiViewModel>(body);
				return View(values.results.ToList());
			}
		}
	}
}
