#pragma checksum "C:\Users\emirgzc\source\repos\HotelProjectForApi\Frontend\HotelProject.WebUI\Views\Shared\Components\_NavbarPartial\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "c127c2cf81ff14410052b64e169d19e6c3971af016922fafb5c59b69c2f0fd84"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__NavbarPartial_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_NavbarPartial/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"c127c2cf81ff14410052b64e169d19e6c3971af016922fafb5c59b69c2f0fd84", @"/Views/Shared/Components/_NavbarPartial/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"72e1e9cab3ccf2d993ae500bc50c56fc96b510e2814edc2ff817cbc061108e91", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components__NavbarPartial_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""container-fluid bg-dark px-0"">
    <div class=""row gx-0"">
        <div class=""col-lg-3 bg-dark d-none d-lg-block"">
            <a href=""/Default/Index/"" class=""navbar-brand w-100 h-100 m-0 p-0 d-flex align-items-center justify-content-center"">
                <h1 class=""m-0 text-primary text-uppercase"">Hotelier</h1>
            </a>
        </div>
        <div class=""col-lg-9"">
            <div class=""row gx-0 bg-white d-none d-lg-flex"">
                <div class=""col-lg-7 px-5 text-start"">
                    <div class=""h-100 d-inline-flex align-items-center py-2 me-4"">
                        <i class=""fa fa-envelope text-primary me-2""></i>
                        <p class=""mb-0"">hotelapi@example.com</p>
                    </div>
                    <div class=""h-100 d-inline-flex align-items-center py-2"">
                        <i class=""fa fa-phone-alt text-primary me-2""></i>
                        <p class=""mb-0"">+090 552 627 52 63</p>
                    </div>
     ");
            WriteLiteral("           </div>\r\n                <div class=\"col-lg-5 px-5 text-end\">\r\n                    <div class=\"d-inline-flex align-items-center py-2\">\r\n                        <a class=\"me-3\"");
            BeginWriteAttribute("href", " href=\"", 1209, "\"", 1216, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fab fa-facebook-f\"></i></a>\r\n                        <a class=\"me-3\"");
            BeginWriteAttribute("href", " href=\"", 1296, "\"", 1303, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fab fa-twitter\"></i></a>\r\n                        <a class=\"me-3\"");
            BeginWriteAttribute("href", " href=\"", 1380, "\"", 1387, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fab fa-linkedin-in\"></i></a>\r\n                        <a class=\"me-3\"");
            BeginWriteAttribute("href", " href=\"", 1468, "\"", 1475, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fab fa-instagram\"></i></a>\r\n                        <a");
            BeginWriteAttribute("class", " class=\"", 1541, "\"", 1549, 0);
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 1550, "\"", 1557, 0);
            EndWriteAttribute();
            WriteLiteral(@"><i class=""fab fa-youtube""></i></a>
                    </div>
                </div>
            </div>
            <nav class=""navbar navbar-expand-lg bg-dark navbar-dark p-3 p-lg-0"">
                <a href=""index.html"" class=""navbar-brand d-block d-lg-none"">
                    <h1 class=""m-0 text-primary text-uppercase"">Hotelier</h1>
                </a>
                <button type=""button"" class=""navbar-toggler"" data-bs-toggle=""collapse"" data-bs-target=""#navbarCollapse"">
                    <span class=""navbar-toggler-icon""></span>
                </button>
                <div class=""collapse navbar-collapse justify-content-between"" id=""navbarCollapse"">
                    <div class=""navbar-nav mr-auto py-0"">
                        <a href=""/Default/Index/"" class=""nav-item nav-link active"">Ana Sayfa</a>
                        <a href=""/Booking/Index/"" class=""nav-item nav-link"">Rezervasyon</a>
                        <a");
            BeginWriteAttribute("href", " href=\"", 2516, "\"", 2523, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""nav-item nav-link"">İletişim</a>
                        <a href=""/Contact/Index/"" class=""nav-item nav-link"">Destek</a>
                        <a href=""/Login/Index/"" class=""nav-item nav-link"">Giriş Yap</a>
                        
                    </div>
                    <a href=""#"" class=""btn btn-primary rounded-0 py-4 px-md-5 d-none d-lg-block"">İletişim<i class=""fa fa-arrow-right ms-3""></i></a>
                </div>
            </nav>
        </div>
    </div>
</div>");
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
