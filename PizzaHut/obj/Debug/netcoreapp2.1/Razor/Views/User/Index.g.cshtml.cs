#pragma checksum "C:\Users\Nenad\Desktop\G4 MVC\sedc7-08-aspnetmvc\g4\Class 03\PizzaHut\PizzaHut\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c7b60af1cecb9210a644a61b4633644794b9d08f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Index), @"mvc.1.0.view", @"/Views/User/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/Index.cshtml", typeof(AspNetCore.Views_User_Index))]
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
#line 1 "C:\Users\Nenad\Desktop\G4 MVC\sedc7-08-aspnetmvc\g4\Class 03\PizzaHut\PizzaHut\Views\_ViewImports.cshtml"
using PizzaHut;

#line default
#line hidden
#line 2 "C:\Users\Nenad\Desktop\G4 MVC\sedc7-08-aspnetmvc\g4\Class 03\PizzaHut\PizzaHut\Views\_ViewImports.cshtml"
using PizzaHut.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7b60af1cecb9210a644a61b4633644794b9d08f", @"/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8efdecd17e5559cbb270cc9907425448905b2398", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PizzaHut.Models.User>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(42, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Nenad\Desktop\G4 MVC\sedc7-08-aspnetmvc\g4\Class 03\PizzaHut\PizzaHut\Views\User\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(85, 29, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(114, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "407783a6a8aa401f97f75a2a99a3448b", async() => {
                BeginContext(137, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(151, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(244, 38, false);
#line 16 "C:\Users\Nenad\Desktop\G4 MVC\sedc7-08-aspnetmvc\g4\Class 03\PizzaHut\PizzaHut\Views\User\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ID));

#line default
#line hidden
            EndContext();
            BeginContext(282, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(338, 40, false);
#line 19 "C:\Users\Nenad\Desktop\G4 MVC\sedc7-08-aspnetmvc\g4\Class 03\PizzaHut\PizzaHut\Views\User\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(378, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(434, 41, false);
#line 22 "C:\Users\Nenad\Desktop\G4 MVC\sedc7-08-aspnetmvc\g4\Class 03\PizzaHut\PizzaHut\Views\User\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(475, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(531, 43, false);
#line 25 "C:\Users\Nenad\Desktop\G4 MVC\sedc7-08-aspnetmvc\g4\Class 03\PizzaHut\PizzaHut\Views\User\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(574, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(630, 40, false);
#line 28 "C:\Users\Nenad\Desktop\G4 MVC\sedc7-08-aspnetmvc\g4\Class 03\PizzaHut\PizzaHut\Views\User\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
            EndContext();
            BeginContext(670, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(726, 41, false);
#line 31 "C:\Users\Nenad\Desktop\G4 MVC\sedc7-08-aspnetmvc\g4\Class 03\PizzaHut\PizzaHut\Views\User\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(767, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 37 "C:\Users\Nenad\Desktop\G4 MVC\sedc7-08-aspnetmvc\g4\Class 03\PizzaHut\PizzaHut\Views\User\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(902, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(951, 37, false);
#line 41 "C:\Users\Nenad\Desktop\G4 MVC\sedc7-08-aspnetmvc\g4\Class 03\PizzaHut\PizzaHut\Views\User\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ID));

#line default
#line hidden
            EndContext();
            BeginContext(988, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1044, 39, false);
#line 44 "C:\Users\Nenad\Desktop\G4 MVC\sedc7-08-aspnetmvc\g4\Class 03\PizzaHut\PizzaHut\Views\User\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1083, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1139, 40, false);
#line 47 "C:\Users\Nenad\Desktop\G4 MVC\sedc7-08-aspnetmvc\g4\Class 03\PizzaHut\PizzaHut\Views\User\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1179, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1235, 42, false);
#line 50 "C:\Users\Nenad\Desktop\G4 MVC\sedc7-08-aspnetmvc\g4\Class 03\PizzaHut\PizzaHut\Views\User\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
            EndContext();
            BeginContext(1277, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1333, 39, false);
#line 53 "C:\Users\Nenad\Desktop\G4 MVC\sedc7-08-aspnetmvc\g4\Class 03\PizzaHut\PizzaHut\Views\User\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.City));

#line default
#line hidden
            EndContext();
            BeginContext(1372, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1428, 40, false);
#line 56 "C:\Users\Nenad\Desktop\G4 MVC\sedc7-08-aspnetmvc\g4\Class 03\PizzaHut\PizzaHut\Views\User\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(1468, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1524, 53, false);
#line 59 "C:\Users\Nenad\Desktop\G4 MVC\sedc7-08-aspnetmvc\g4\Class 03\PizzaHut\PizzaHut\Views\User\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { id = item.ID }));

#line default
#line hidden
            EndContext();
            BeginContext(1577, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1598, 59, false);
#line 60 "C:\Users\Nenad\Desktop\G4 MVC\sedc7-08-aspnetmvc\g4\Class 03\PizzaHut\PizzaHut\Views\User\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { id = item.ID }));

#line default
#line hidden
            EndContext();
            BeginContext(1657, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1678, 69, false);
#line 61 "C:\Users\Nenad\Desktop\G4 MVC\sedc7-08-aspnetmvc\g4\Class 03\PizzaHut\PizzaHut\Views\User\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1747, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 64 "C:\Users\Nenad\Desktop\G4 MVC\sedc7-08-aspnetmvc\g4\Class 03\PizzaHut\PizzaHut\Views\User\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1794, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
