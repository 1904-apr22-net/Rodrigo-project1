#pragma checksum "C:\Revature\Project1\Rodrigo-project1\StoreApplication\StoreApplication.WebUI\Views\Customer\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ca738c9e8c1718b2fa464a27a01b91b19544ec9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_Details), @"mvc.1.0.view", @"/Views/Customer/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Customer/Details.cshtml", typeof(AspNetCore.Views_Customer_Details))]
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
#line 1 "C:\Revature\Project1\Rodrigo-project1\StoreApplication\StoreApplication.WebUI\Views\_ViewImports.cshtml"
using StoreApplication.WebUI;

#line default
#line hidden
#line 2 "C:\Revature\Project1\Rodrigo-project1\StoreApplication\StoreApplication.WebUI\Views\_ViewImports.cshtml"
using StoreApplication.WebUI.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ca738c9e8c1718b2fa464a27a01b91b19544ec9", @"/Views/Customer/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8ba69398849250613e82aa94266b0123ba214f2", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<StoreApplication.WebUI.Models.OrderViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(66, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Revature\Project1\Rodrigo-project1\StoreApplication\StoreApplication.WebUI\Views\Customer\Details.cshtml"
  
    ViewData["Title"] = "Details";
    //Layout = "Details";

#line default
#line hidden
            BeginContext(138, 22, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n");
            EndContext();
            BeginContext(1236, 84, true);
            WriteLiteral("<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1321, 38, false);
#line 48 "C:\Revature\Project1\Rodrigo-project1\StoreApplication\StoreApplication.WebUI\Views\Customer\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1359, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1415, 45, false);
#line 51 "C:\Revature\Project1\Rodrigo-project1\StoreApplication\StoreApplication.WebUI\Views\Customer\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(1460, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1516, 44, false);
#line 54 "C:\Revature\Project1\Rodrigo-project1\StoreApplication\StoreApplication.WebUI\Views\Customer\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(1560, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1616, 44, false);
#line 57 "C:\Revature\Project1\Rodrigo-project1\StoreApplication\StoreApplication.WebUI\Views\Customer\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Products));

#line default
#line hidden
            EndContext();
            BeginContext(1660, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1716, 41, false);
#line 60 "C:\Revature\Project1\Rodrigo-project1\StoreApplication\StoreApplication.WebUI\Views\Customer\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1757, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1813, 45, false);
#line 63 "C:\Revature\Project1\Rodrigo-project1\StoreApplication\StoreApplication.WebUI\Views\Customer\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.OrderTime));

#line default
#line hidden
            EndContext();
            BeginContext(1858, 90, true);
            WriteLiteral("\r\n            </th>\r\n\r\n\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 71 "C:\Revature\Project1\Rodrigo-project1\StoreApplication\StoreApplication.WebUI\Views\Customer\Details.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1997, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2046, 33, false);
#line 75 "C:\Revature\Project1\Rodrigo-project1\StoreApplication\StoreApplication.WebUI\Views\Customer\Details.cshtml"
           Write(Html.DisplayFor(model => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(2079, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2135, 44, false);
#line 78 "C:\Revature\Project1\Rodrigo-project1\StoreApplication\StoreApplication.WebUI\Views\Customer\Details.cshtml"
           Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(2179, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2235, 43, false);
#line 81 "C:\Revature\Project1\Rodrigo-project1\StoreApplication\StoreApplication.WebUI\Views\Customer\Details.cshtml"
           Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(2278, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2334, 32, false);
#line 84 "C:\Revature\Project1\Rodrigo-project1\StoreApplication\StoreApplication.WebUI\Views\Customer\Details.cshtml"
           Write(string.Join(", ", item.Products));

#line default
#line hidden
            EndContext();
            BeginContext(2366, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2422, 36, false);
#line 87 "C:\Revature\Project1\Rodrigo-project1\StoreApplication\StoreApplication.WebUI\Views\Customer\Details.cshtml"
           Write(Html.DisplayFor(model => item.Price));

#line default
#line hidden
            EndContext();
            BeginContext(2458, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2514, 40, false);
#line 90 "C:\Revature\Project1\Rodrigo-project1\StoreApplication\StoreApplication.WebUI\Views\Customer\Details.cshtml"
           Write(Html.DisplayFor(model => item.OrderTime));

#line default
#line hidden
            EndContext();
            BeginContext(2554, 46, true);
            WriteLiteral("\r\n            </td>\r\n\r\n      \r\n        </tr>\r\n");
            EndContext();
#line 95 "C:\Revature\Project1\Rodrigo-project1\StoreApplication\StoreApplication.WebUI\Views\Customer\Details.cshtml"
        }

#line default
#line hidden
            BeginContext(2611, 22, true);
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<StoreApplication.WebUI.Models.OrderViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591