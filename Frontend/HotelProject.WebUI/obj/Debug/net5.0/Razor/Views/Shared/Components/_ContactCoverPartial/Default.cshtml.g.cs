#pragma checksum "C:\Users\emirgzc\source\repos\HotelProjectForApi\Frontend\HotelProject.WebUI\Views\Shared\Components\_ContactCoverPartial\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4eaf95632501c2e5d7f46ae50d00569ee853c2238c8f22808a8a2aaa2a0a3788"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__ContactCoverPartial_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_ContactCoverPartial/Default.cshtml")]
namespace AspNetCore
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\emirgzc\source\repos\HotelProjectForApi\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\emirgzc\source\repos\HotelProjectForApi\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Models

#nullable disable
    ;
#nullable restore
#line 3 "C:\Users\emirgzc\source\repos\HotelProjectForApi\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Models.Staff

#nullable disable
    ;
#nullable restore
#line 4 "C:\Users\emirgzc\source\repos\HotelProjectForApi\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Models.Testimonial

#nullable disable
    ;
#nullable restore
#line 5 "C:\Users\emirgzc\source\repos\HotelProjectForApi\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.ServiceDto

#nullable disable
    ;
#nullable restore
#line 6 "C:\Users\emirgzc\source\repos\HotelProjectForApi\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.RegisterDto

#nullable disable
    ;
#nullable restore
#line 7 "C:\Users\emirgzc\source\repos\HotelProjectForApi\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.LoginDto

#nullable disable
    ;
#nullable restore
#line 8 "C:\Users\emirgzc\source\repos\HotelProjectForApi\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.AboutDto

#nullable disable
    ;
#nullable restore
#line 9 "C:\Users\emirgzc\source\repos\HotelProjectForApi\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.RoomDto

#nullable disable
    ;
#nullable restore
#line 10 "C:\Users\emirgzc\source\repos\HotelProjectForApi\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.TestimonialDto

#nullable disable
    ;
#nullable restore
#line 11 "C:\Users\emirgzc\source\repos\HotelProjectForApi\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.StaffDto

#nullable disable
    ;
#nullable restore
#line 12 "C:\Users\emirgzc\source\repos\HotelProjectForApi\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.BookingDto

#nullable disable
    ;
#nullable restore
#line 13 "C:\Users\emirgzc\source\repos\HotelProjectForApi\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.ContactDto

#nullable disable
    ;
#nullable restore
#line 14 "C:\Users\emirgzc\source\repos\HotelProjectForApi\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.GuestDto

#nullable disable
    ;
#nullable restore
#line 15 "C:\Users\emirgzc\source\repos\HotelProjectForApi\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.SendMessageDto

#nullable disable
    ;
#nullable restore
#line 16 "C:\Users\emirgzc\source\repos\HotelProjectForApi\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.WorkLocationDto

#nullable disable
    ;
#nullable restore
#line 17 "C:\Users\emirgzc\source\repos\HotelProjectForApi\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.FollowersDto

#nullable disable
    ;
#nullable restore
#line 18 "C:\Users\emirgzc\source\repos\HotelProjectForApi\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Models.Mail

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"4eaf95632501c2e5d7f46ae50d00569ee853c2238c8f22808a8a2aaa2a0a3788", @"/Views/Shared/Components/_ContactCoverPartial/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"72e1e9cab3ccf2d993ae500bc50c56fc96b510e2814edc2ff817cbc061108e91", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components__ContactCoverPartial_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""container-fluid page-header mb-5 p-0"" style=""background-image: url(/hotel/img/carousel-1.jpg);"">
	<div class=""container-fluid page-header-inner py-5"">
		<div class=""container text-center pb-5"">
			<h1 class=""display-3 text-white mb-3 animated slideInDown"">İletişim</h1>
			<nav aria-label=""breadcrumb"">
				<ol class=""breadcrumb justify-content-center text-uppercase"">
					<li class=""breadcrumb-item""><a href=""/Default/Index/"">Ana Sayfa</a></li>
					<li class=""breadcrumb-item""><a href=""#"">İletişim</a></li>
					<li class=""breadcrumb-item text-white active"" aria-current=""page"">İletişim</li>
				</ol>
			</nav>
		</div>
	</div>
</div>
");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
