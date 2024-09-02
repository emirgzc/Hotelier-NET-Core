using FluentValidation;
using FluentValidation.AspNetCore;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.Dtos.GuestDto;
using HotelProject.WebUI.ValidationRules.GuestValidationRules;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.WebUI
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			// identity kullanmak için
			services.AddDbContext<Context>();
			services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<Context>();

			// api kullanmak için tanýmlama yapýyoruz
			services.AddHttpClient();

			services.AddTransient<IValidator<CreateGuestDto>, CreateGuestValidator>();
			services.AddTransient<IValidator<UpdateGuestDto>, UpdateGuestValidator>();

			// fluentvalidation tanýmlamasý yapýyoruz
			services.AddControllersWithViews().AddFluentValidation();

			// auto mapper tanýmlama
			services.AddAutoMapper(typeof(Startup));

			// proje seviyesi authorize 
			services.AddMvc(config =>
			{
				var policy = new AuthorizationPolicyBuilder()
				.RequireAuthenticatedUser()
				.Build();
				config.Filters.Add(new AuthorizeFilter(policy));
			});

			// login indexe yönlendirme yaptýk(giriþ yapmayan kullanýcý için)
			services.ConfigureApplicationCookie(options =>
			{
				options.Cookie.HttpOnly = true;
				// giriþ yaptýktan sonra ne kadar sistemde kalabilir
				options.ExpireTimeSpan = TimeSpan.FromMinutes(20);
				options.LoginPath = "/Login/Index/";
			});

		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			else
			{
				app.UseExceptionHandler("/Home/Error");
			}

			app.UseStatusCodePagesWithReExecute("/ErrorPage/Error404/", "?code={0}");
			app.UseHttpsRedirection();

			app.UseStaticFiles();

			//proje seviyesi authorize
			app.UseAuthentication();

			app.UseRouting();

			app.UseAuthorization();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllerRoute(
					name: "default",
					pattern: "{controller=Home}/{action=Index}/{id?}");
			});
		}
	}
}
