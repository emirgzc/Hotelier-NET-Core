#pragma checksum "C:\Users\emirgzc\source\repos\HotelProjectForApi\Frontend\HotelProject.WebUI\Views\AdminUsers\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "114707bc33853e1e2aba52819c48ee46846c6abd768fe253537eecf5b7cadc10"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminUsers_Index), @"mvc.1.0.view", @"/Views/AdminUsers/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"114707bc33853e1e2aba52819c48ee46846c6abd768fe253537eecf5b7cadc10", @"/Views/AdminUsers/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"72e1e9cab3ccf2d993ae500bc50c56fc96b510e2814edc2ff817cbc061108e91", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_AdminUsers_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<HotelProject.EntityLayer.Concrete.AppUser>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\emirgzc\source\repos\HotelProjectForApi\Frontend\HotelProject.WebUI\Views\AdminUsers\Index.cshtml"
  
	ViewData["Title"] = "Index";
	Layout = "~/Views/AdminLayout/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n\r\n\r\n<div class=\"table-responsive\">\r\n\t<table class=\"table table-xs mb-0\">\r\n\t\t<thead>\r\n\t\t\t<tr>\r\n\t\t\t\t<th>#</th>\r\n\t\t\t\t<th>Ad Soyad</th>\r\n\t\t\t\t<th>Şehir</th>\r\n\t\t\t\t<th>Mail Adresi</th>\r\n\t\t\t\t<th>Telefon Numarası</th>\r\n\t\t\t</tr>\r\n\t\t</thead>\r\n\t\t<tbody>\t\t\t\r\n");
#nullable restore
#line 22 "C:\Users\emirgzc\source\repos\HotelProjectForApi\Frontend\HotelProject.WebUI\Views\AdminUsers\Index.cshtml"
    foreach (var item in Model)
			{

#line default
#line hidden
#nullable disable

            WriteLiteral("\t\t\t\t<tr>\r\n\t\t\t\t\t<td><img");
            BeginWriteAttribute("src", " src=\"", 459, "\"", 479, 1);
            WriteAttributeValue("", 465, 
#nullable restore
#line 25 "C:\Users\emirgzc\source\repos\HotelProjectForApi\Frontend\HotelProject.WebUI\Views\AdminUsers\Index.cshtml"
                    item.ImageUrl

#line default
#line hidden
#nullable disable
            , 465, 14, false);
            EndWriteAttribute();
            WriteLiteral(" class=\" rounded-circle mr-3\"");
            BeginWriteAttribute("alt", " alt=\"", 509, "\"", 515, 0);
            EndWriteAttribute();
            WriteLiteral("></td>\r\n\t\t\t\t\t<td>");
            Write(
#nullable restore
#line 26 "C:\Users\emirgzc\source\repos\HotelProjectForApi\Frontend\HotelProject.WebUI\Views\AdminUsers\Index.cshtml"
          item.Name

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(" ");
            Write(
#nullable restore
#line 26 "C:\Users\emirgzc\source\repos\HotelProjectForApi\Frontend\HotelProject.WebUI\Views\AdminUsers\Index.cshtml"
                     item.Surname

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n\t\t\t\t\t<td>");
            Write(
#nullable restore
#line 27 "C:\Users\emirgzc\source\repos\HotelProjectForApi\Frontend\HotelProject.WebUI\Views\AdminUsers\Index.cshtml"
          item.City

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n\t\t\t\t\t<td>");
            Write(
#nullable restore
#line 28 "C:\Users\emirgzc\source\repos\HotelProjectForApi\Frontend\HotelProject.WebUI\Views\AdminUsers\Index.cshtml"
          item.Email

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\t\t\t\t\r\n\t\t\t\t\t<td>");
            Write(
#nullable restore
#line 29 "C:\Users\emirgzc\source\repos\HotelProjectForApi\Frontend\HotelProject.WebUI\Views\AdminUsers\Index.cshtml"
          item.PhoneNumber

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\t\t\t\t\r\n\t\t\t\t</tr>\r\n");
#nullable restore
#line 31 "C:\Users\emirgzc\source\repos\HotelProjectForApi\Frontend\HotelProject.WebUI\Views\AdminUsers\Index.cshtml"
			}

#line default
#line hidden
#nullable disable

            WriteLiteral("\t\t</tbody>\r\n\t</table>\r\n\t<br />\r\n\t<a href=\"#\" class=\"btn btn-primary\">Yeni Kullanıcı Ekle</a>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<HotelProject.EntityLayer.Concrete.AppUser>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
