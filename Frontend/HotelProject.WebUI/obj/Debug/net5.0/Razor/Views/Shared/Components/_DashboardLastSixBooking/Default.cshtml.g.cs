#pragma checksum "C:\Users\emirgzc\source\repos\HotelProjectForApi\Frontend\HotelProject.WebUI\Views\Shared\Components\_DashboardLastSixBooking\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "ed04ddc539cee2051785064fbf6852b32780b1b8a5ec5f925f5d82fb4c1f0626"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__DashboardLastSixBooking_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_DashboardLastSixBooking/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"ed04ddc539cee2051785064fbf6852b32780b1b8a5ec5f925f5d82fb4c1f0626", @"/Views/Shared/Components/_DashboardLastSixBooking/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"72e1e9cab3ccf2d993ae500bc50c56fc96b510e2814edc2ff817cbc061108e91", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components__DashboardLastSixBooking_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ResultLastSixBookingDto>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral(@"
<div class=""row"">
	<div class=""col-lg-12"">
		<div class=""card"">
			<div class=""card-body"">
				<div class=""active-member"">
					<div class=""table-responsive"">
						<table class=""table table-xs mb-0"">
							<thead>
								<tr>
									<th>Müşteri</th>
									<th>Şehir</th>
									<th>Ülke</th>
									<th>Durum</th>
								</tr>
							</thead>
							<tbody>
							
");
#nullable restore
#line 21 "C:\Users\emirgzc\source\repos\HotelProjectForApi\Frontend\HotelProject.WebUI\Views\Shared\Components\_DashboardLastSixBooking\Default.cshtml"
         foreach (var item in Model)
								{

#line default
#line hidden
#nullable disable

            WriteLiteral("\t\t\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t\t\t<td>");
            Write(
#nullable restore
#line 24 "C:\Users\emirgzc\source\repos\HotelProjectForApi\Frontend\HotelProject.WebUI\Views\Shared\Components\_DashboardLastSixBooking\Default.cshtml"
               item.Name

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t\t<td>");
            Write(
#nullable restore
#line 25 "C:\Users\emirgzc\source\repos\HotelProjectForApi\Frontend\HotelProject.WebUI\Views\Shared\Components\_DashboardLastSixBooking\Default.cshtml"
               item.City

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t\t\t\t<span>");
            Write(
#nullable restore
#line 27 "C:\Users\emirgzc\source\repos\HotelProjectForApi\Frontend\HotelProject.WebUI\Views\Shared\Components\_DashboardLastSixBooking\Default.cshtml"
                  item.Country

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(@"</span>
										</td>
										<td>
											<div>
												<div class=""progress"" style=""height: 6px"">
													<div class=""progress-bar bg-success"" style=""width: 100%""></div>
												</div>
											</div>
										</td>
										<td><i class=""fa fa-circle-o text-success  mr-2""></i> ");
            Write(
#nullable restore
#line 36 "C:\Users\emirgzc\source\repos\HotelProjectForApi\Frontend\HotelProject.WebUI\Views\Shared\Components\_DashboardLastSixBooking\Default.cshtml"
                                                                 item.Status

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\t\t\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t\t</tr>\r\n");
#nullable restore
#line 38 "C:\Users\emirgzc\source\repos\HotelProjectForApi\Frontend\HotelProject.WebUI\Views\Shared\Components\_DashboardLastSixBooking\Default.cshtml"
								}

#line default
#line hidden
#nullable disable

            WriteLiteral("\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t</tbody>\r\n\t\t\t\t\t\t</table>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ResultLastSixBookingDto>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
