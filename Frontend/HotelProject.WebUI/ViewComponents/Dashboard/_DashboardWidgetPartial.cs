﻿using HotelProject.WebUI.Dtos.GuestDto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace HotelProject.WebUI.ViewComponents.Dashboard
{
	public class _DashboardWidgetPartial : ViewComponent
	{
		private readonly IHttpClientFactory _httpClientFactory;

		public _DashboardWidgetPartial(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("http://localhost:8334/api/DashboardWidget/StaffCount");
			var jsonData = await responseMessage.Content.ReadAsStringAsync();
			ViewBag.staffCount = jsonData;

			var client2 = _httpClientFactory.CreateClient();
			var responseMessage2 = await client2.GetAsync("http://localhost:8334/api/DashboardWidget/BookingCount");
			var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
			ViewBag.bookingCount = jsonData2;

			var client3 = _httpClientFactory.CreateClient();
			var responseMessage3 = await client3.GetAsync("http://localhost:8334/api/DashboardWidget/AppUserCount");
			var jsonData3 = await responseMessage3.Content.ReadAsStringAsync();
			ViewBag.appUserCount = jsonData3;

			var client4 = _httpClientFactory.CreateClient();
			var responseMessage4 = await client4.GetAsync("http://localhost:8334/api/DashboardWidget/RoomCount");
			var jsonData4 = await responseMessage4.Content.ReadAsStringAsync();
			ViewBag.roomCount = jsonData4;

			return View();
		}
	}
}