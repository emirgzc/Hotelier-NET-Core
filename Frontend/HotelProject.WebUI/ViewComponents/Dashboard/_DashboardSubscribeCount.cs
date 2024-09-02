using HotelProject.WebUI.Dtos.FollowersDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace HotelProject.WebUI.ViewComponents.Dashboard
{
	public class _DashboardSubscribeCount : ViewComponent
	{
		public async Task<IViewComponentResult> InvokeAsync()
		{
			var client = new HttpClient();
			var request = new HttpRequestMessage
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri("https://instagram-profile1.p.rapidapi.com/getprofileinfo/murattycedag"),
				Headers =
	{
		{ "x-rapidapi-key", "b022da8192mshd9dde807f5c8dd3p1fe561jsndc30b00c2ff4" },
		{ "x-rapidapi-host", "instagram-profile1.p.rapidapi.com" },
	},
			};
			using (var response = await client.SendAsync(request))
			{
				response.EnsureSuccessStatusCode();
				var body = await response.Content.ReadAsStringAsync();
				ResultInstagramFollowersDto resultInstagrams = JsonConvert.DeserializeObject<ResultInstagramFollowersDto>(body);
				ViewBag.insFollower = resultInstagrams.followers;
				ViewBag.insFollowing = resultInstagrams.following;
			}

			var client2 = new HttpClient();
			var request2 = new HttpRequestMessage
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri("https://twitter32.p.rapidapi.com/getProfile?username=murattyucedag"),
				Headers =
	{
		{ "x-rapidapi-key", "b022da8192mshd9dde807f5c8dd3p1fe561jsndc30b00c2ff4" },
		{ "x-rapidapi-host", "twitter32.p.rapidapi.com" },
	},
			};
			using (var response2 = await client2.SendAsync(request2))
			{
				response2.EnsureSuccessStatusCode();
				var body2 = await response2.Content.ReadAsStringAsync();
				ResultTwitterFollowersDto resultTwitter = JsonConvert.DeserializeObject<ResultTwitterFollowersDto>(body2);
				ViewBag.twitFollower = resultTwitter.data.user_info.followers_count;
				ViewBag.twitFollowing = resultTwitter.data.user_info.friends_count;
			}

			
			var client3 = new HttpClient();
			var request3 = new HttpRequestMessage
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri("https://fresh-linkedin-profile-data.p.rapidapi.com/get-linkedin-profile?linkedin_url=https%3A%2F%2Fwww.linkedin.com%2Fin%2Fmuhammed-emir-gozcu%2F&include_skills=false&include_certifications=false&include_publications=false&include_honors=false&include_volunteers=false&include_projects=false&include_patents=false&include_courses=false&include_organizations=false"),
				Headers =
	{
		{ "x-rapidapi-key", "b022da8192mshd9dde807f5c8dd3p1fe561jsndc30b00c2ff4" },
		{ "x-rapidapi-host", "fresh-linkedin-profile-data.p.rapidapi.com" },
	},
			};
			using (var response3 = await client3.SendAsync(request3))
			{
				response3.EnsureSuccessStatusCode();
				var body3 = await response3.Content.ReadAsStringAsync();
				ResultLinkedinFollowersDto resultLikedin = JsonConvert.DeserializeObject<ResultLinkedinFollowersDto>(body3);
				ViewBag.linkFollower = resultLikedin.data.follower_count;
			}

			return View();
		}
	}
}
