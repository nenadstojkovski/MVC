#pragma checksum "C:\Users\Nenad\Desktop\G4 MVC\Homework 3\PizzaHut\PizzaHut\Views\User\_PartialUserBodyView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76ed19ca85754cb3ea46df40b99e6408c81f07e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User__PartialUserBodyView), @"mvc.1.0.view", @"/Views/User/_PartialUserBodyView.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/_PartialUserBodyView.cshtml", typeof(AspNetCore.Views_User__PartialUserBodyView))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Nenad\Desktop\G4 MVC\Homework 3\PizzaHut\PizzaHut\Views\_ViewImports.cshtml"
using PizzaHut;

#line default
#line hidden
#line 2 "C:\Users\Nenad\Desktop\G4 MVC\Homework 3\PizzaHut\PizzaHut\Views\_ViewImports.cshtml"
using PizzaHut.Models;

#line default
#line hidden
#line 3 "C:\Users\Nenad\Desktop\G4 MVC\Homework 3\PizzaHut\PizzaHut\Views\_ViewImports.cshtml"
using PizzaHut.Models.IRepositories;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76ed19ca85754cb3ea46df40b99e6408c81f07e6", @"/Views/User/_PartialUserBodyView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"837425a39d7d38fbfcc94e7b5c980ecc75bcc3d0", @"/Views/_ViewImports.cshtml")]
    public class Views_User__PartialUserBodyView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PizzaHut.Models.User>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(43, 9, true);
            WriteLiteral("<tbody>\r\n");
            EndContext();
#line 3 "C:\Users\Nenad\Desktop\G4 MVC\Homework 3\PizzaHut\PizzaHut\Views\User\_PartialUserBodyView.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(93, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(142, 37, false);
#line 7 "C:\Users\Nenad\Desktop\G4 MVC\Homework 3\PizzaHut\PizzaHut\Views\User\_PartialUserBodyView.cshtml"
           Write(Html.DisplayFor(modelItem => item.ID));

#line default
#line hidden
            EndContext();
            BeginContext(179, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(235, 39, false);
#line 10 "C:\Users\Nenad\Desktop\G4 MVC\Homework 3\PizzaHut\PizzaHut\Views\User\_PartialUserBodyView.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(274, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(330, 40, false);
#line 13 "C:\Users\Nenad\Desktop\G4 MVC\Homework 3\PizzaHut\PizzaHut\Views\User\_PartialUserBodyView.cshtml"
           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
            EndContext();
            BeginContext(370, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(426, 42, false);
#line 16 "C:\Users\Nenad\Desktop\G4 MVC\Homework 3\PizzaHut\PizzaHut\Views\User\_PartialUserBodyView.cshtml"
           Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
            EndContext();
            BeginContext(468, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(524, 39, false);
#line 19 "C:\Users\Nenad\Desktop\G4 MVC\Homework 3\PizzaHut\PizzaHut\Views\User\_PartialUserBodyView.cshtml"
           Write(Html.DisplayFor(modelItem => item.City));

#line default
#line hidden
            EndContext();
            BeginContext(563, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(619, 40, false);
#line 22 "C:\Users\Nenad\Desktop\G4 MVC\Homework 3\PizzaHut\PizzaHut\Views\User\_PartialUserBodyView.cshtml"
           Write(Html.DisplayFor(modelItem => item.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(659, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(715, 65, false);
#line 25 "C:\Users\Nenad\Desktop\G4 MVC\Homework 3\PizzaHut\PizzaHut\Views\User\_PartialUserBodyView.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(780, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(801, 71, false);
#line 26 "C:\Users\Nenad\Desktop\G4 MVC\Homework 3\PizzaHut\PizzaHut\Views\User\_PartialUserBodyView.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(872, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(893, 69, false);
#line 27 "C:\Users\Nenad\Desktop\G4 MVC\Homework 3\PizzaHut\PizzaHut\Views\User\_PartialUserBodyView.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(962, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 30 "C:\Users\Nenad\Desktop\G4 MVC\Homework 3\PizzaHut\PizzaHut\Views\User\_PartialUserBodyView.cshtml"
    }

#line default
#line hidden
            BeginContext(1005, 8, true);
            WriteLiteral("</tbody>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PizzaHut.Models.User>> Html { get; private set; }
    }
}
#pragma warning restore 1591
