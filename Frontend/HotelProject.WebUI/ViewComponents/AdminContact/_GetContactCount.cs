using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Threading.Tasks;

namespace HotelProject.WebUI.ViewComponents.AdminContact
{
	public class _GetContactCount : ViewComponent
	{
		private readonly IHttpClientFactory _httpClientFactory;

		public _GetContactCount(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}
		public async Task<string> InvokeAsync()
		{
			// API CONSUME ETME(KULLANMA,TÜKETME)
			// istemci oluşturduk
			var client = _httpClientFactory.CreateClient();
			// adrese istek yolladık
			var responseMessage = await client.GetAsync("http://localhost:8334/api/Contact/GetContactCount");

			// gelen içeriği oku
			var jsonData = await responseMessage.Content.ReadAsStringAsync();

			return jsonData;
		}
	}
}
