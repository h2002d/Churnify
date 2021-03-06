#pragma checksum "C:\Projects\Churnify\Churnify.Web.App\Views\Customer\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3266578046953a0f4dabbc7d7541f397aaa3da82"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_Search), @"mvc.1.0.view", @"/Views/Customer/Search.cshtml")]
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
#nullable restore
#line 1 "C:\Projects\Churnify\Churnify.Web.App\Views\_ViewImports.cshtml"
using Churnify.Web.App;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projects\Churnify\Churnify.Web.App\Views\_ViewImports.cshtml"
using Churnify.Domain.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3266578046953a0f4dabbc7d7541f397aaa3da82", @"/Views/Customer/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7f1a712bb93cd5d4950062b513de75282c01e2d", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Churnify.Web.App.ViewModels.Customers.CustomerSearchModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Projects\Churnify\Churnify.Web.App\Views\Customer\Search.cshtml"
 if (Model.Customers != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"page-breadcrumb\">\r\n        <div class=\"row\">\r\n            <div class=\"col-12 d-flex no-block align-items-center\">\r\n                <h4 class=\"page-title\">Search results for <b>");
#nullable restore
#line 7 "C:\Projects\Churnify\Churnify.Web.App\Views\Customer\Search.cshtml"
                                                        Write(Model.Query);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</b></h4>
            </div>
        </div>
    </div>
    <!-- ============================================================== -->
    <!-- End Bread crumb and right sidebar toggle -->
    <!-- ============================================================== -->
    <!-- ============================================================== -->
    <!-- Container fluid  -->
    <!-- ============================================================== -->
    <div class=""container-fluid"">
        <!-- ============================================================== -->
        <!-- Sales Cards  -->
        <!-- ============================================================== -->
        <div class=""row"">
            <!-- Column -->
");
#nullable restore
#line 23 "C:\Projects\Churnify\Churnify.Web.App\Views\Customer\Search.cshtml"
             foreach (var customer in Model.Customers)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-6 col-lg-4 col-xlg-3\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1193, "\"", 1228, 2);
            WriteAttributeValue("", 1200, "/Customer/Index/", 1200, 16, true);
#nullable restore
#line 26 "C:\Projects\Churnify\Churnify.Web.App\Views\Customer\Search.cshtml"
WriteAttributeValue("", 1216, customer.Id, 1216, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                        <div class=""card card-hover"">
                            <div class=""box bg-danger text-center"">
                                <h1 class=""font-light text-white""><i class=""mdi mdi-account-card-details""></i></h1>
                                <h6 class=""text-white"">");
#nullable restore
#line 30 "C:\Projects\Churnify\Churnify.Web.App\Views\Customer\Search.cshtml"
                                                  Write(customer.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 30 "C:\Projects\Churnify\Churnify.Web.App\Views\Customer\Search.cshtml"
                                                                     Write(customer.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                <h6 class=\"text-white\">Phone :<b>");
#nullable restore
#line 31 "C:\Projects\Churnify\Churnify.Web.App\Views\Customer\Search.cshtml"
                                                            Write(customer.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></h6>\r\n                                <h6 class=\"text-white\">Email :<b>");
#nullable restore
#line 32 "C:\Projects\Churnify\Churnify.Web.App\Views\Customer\Search.cshtml"
                                                            Write(customer.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></h6>\r\n                            </div>\r\n                        </div>\r\n                    </a>\r\n                </div>\r\n");
#nullable restore
#line 37 "C:\Projects\Churnify\Churnify.Web.App\Views\Customer\Search.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 41 "C:\Projects\Churnify\Churnify.Web.App\Views\Customer\Search.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"page-breadcrumb\">\r\n        <div class=\"row\">\r\n            <div class=\"col-12 d-flex no-block align-items-center\">\r\n                <h4 class=\"page-title\">No records for <b>");
#nullable restore
#line 47 "C:\Projects\Churnify\Churnify.Web.App\Views\Customer\Search.cshtml"
                                                    Write(Model.Query);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</b></h4>
            </div>
        </div>
    </div>
    <div class=""container-fluid"">
        <!-- ============================================================== -->
        <!-- Sales Cards  -->
        <!-- ============================================================== -->
        <div class=""row"">
            <div class=""col-md-6 col-lg-4 col-xlg-3"" style=""margin:auto;"">
                <a href=""/Customer/Create"">
                    <div class=""card card-hover"">
                        <div class=""box bg-danger text-center"">
                            <h1 class=""font-light text-white""><i class=""mdi mdi-account-card-details""></i></h1>
                            <h6 class=""text-white"">New</h6>
                        </div>
                    </div>
                </a>
            </div>
        </div>
    </div>
");
#nullable restore
#line 68 "C:\Projects\Churnify\Churnify.Web.App\Views\Customer\Search.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Churnify.Web.App.ViewModels.Customers.CustomerSearchModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
