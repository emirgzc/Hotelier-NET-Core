#pragma checksum "C:\Users\emirgzc\source\repos\HotelProjectForApi\Frontend\HotelProject.WebUI\Views\Role\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8bcd3fcd135cce3bb3fab9d5af026149ee145eb7c62222759975b7d104d248c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Role_Index), @"mvc.1.0.view", @"/Views/Role/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"8bcd3fcd135cce3bb3fab9d5af026149ee145eb7c62222759975b7d104d248c1", @"/Views/Role/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"72e1e9cab3ccf2d993ae500bc50c56fc96b510e2814edc2ff817cbc061108e91", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Role_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<HotelProject.EntityLayer.Concrete.AppRole>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\emirgzc\source\repos\HotelProjectForApi\Frontend\HotelProject.WebUI\Views\Role\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/AdminLayout/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>#</th>\r\n        <th>Rol Adı</th>\r\n        <th>Sil</th>\r\n        <th>Güncelle</th>\r\n    </tr>\r\n");
#nullable restore
#line 17 "C:\Users\emirgzc\source\repos\HotelProjectForApi\Frontend\HotelProject.WebUI\Views\Role\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable

            WriteLiteral("        <tr>\r\n            <td>");
            Write(
#nullable restore
#line 20 "C:\Users\emirgzc\source\repos\HotelProjectForApi\Frontend\HotelProject.WebUI\Views\Role\Index.cshtml"
                 item.Id

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n            <td>");
            Write(
#nullable restore
#line 21 "C:\Users\emirgzc\source\repos\HotelProjectForApi\Frontend\HotelProject.WebUI\Views\Role\Index.cshtml"
                 item.Name

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 453, "\"", 485, 2);
            WriteAttributeValue("", 460, "/Role/DeleteRole/", 460, 17, true);
            WriteAttributeValue("", 477, 
#nullable restore
#line 22 "C:\Users\emirgzc\source\repos\HotelProjectForApi\Frontend\HotelProject.WebUI\Views\Role\Index.cshtml"
                                           item.Id

#line default
#line hidden
#nullable disable
            , 477, 8, false);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn mb-1 btn-rounded btn-outline-danger\">Sil</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 567, "\"", 599, 2);
            WriteAttributeValue("", 574, "/Role/UpdateRole/", 574, 17, true);
            WriteAttributeValue("", 591, 
#nullable restore
#line 23 "C:\Users\emirgzc\source\repos\HotelProjectForApi\Frontend\HotelProject.WebUI\Views\Role\Index.cshtml"
                                           item.Id

#line default
#line hidden
#nullable disable
            , 591, 8, false);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn mb-1 btn-rounded btn-outline-warning\">Güncelle</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 25 "C:\Users\emirgzc\source\repos\HotelProjectForApi\Frontend\HotelProject.WebUI\Views\Role\Index.cshtml"
    }

#line default
#line hidden
#nullable disable

            WriteLiteral("</table>\r\n<a href=\"/Role/AddRole/\" class=\"btn mb-1 btn-rounded btn-outline-success\">Yeni Rol Ekle</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<HotelProject.EntityLayer.Concrete.AppRole>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
