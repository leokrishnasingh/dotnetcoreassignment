#pragma checksum "C:\Users\krishnasingh01\source\repos\Nagarro.ASPNETcore.Assignment\Nagarro.EventManagement.UI\Views\Event\UserInvitedInEvents.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a2d915d558ca18a69f24b0d5c3c29b0aa48923a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Event_UserInvitedInEvents), @"mvc.1.0.view", @"/Views/Event/UserInvitedInEvents.cshtml")]
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
#line 1 "C:\Users\krishnasingh01\source\repos\Nagarro.ASPNETcore.Assignment\Nagarro.EventManagement.UI\Views\_ViewImports.cshtml"
using Nagarro.EventManagement.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\krishnasingh01\source\repos\Nagarro.ASPNETcore.Assignment\Nagarro.EventManagement.UI\Views\_ViewImports.cshtml"
using Nagarro.EventManagement.UI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\krishnasingh01\source\repos\Nagarro.ASPNETcore.Assignment\Nagarro.EventManagement.UI\Views\_ViewImports.cshtml"
using Nagarro.EventManagement.Business;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\krishnasingh01\source\repos\Nagarro.ASPNETcore.Assignment\Nagarro.EventManagement.UI\Views\_ViewImports.cshtml"
using Nagarro.EventManagement.Shared;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a2d915d558ca18a69f24b0d5c3c29b0aa48923a", @"/Views/Event/UserInvitedInEvents.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4538f901afb1610167139e522599a5ae80f00554", @"/Views/_ViewImports.cshtml")]
    public class Views_Event_UserInvitedInEvents : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Nagarro.EventManagement.Shared.EventDTO>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\krishnasingh01\source\repos\Nagarro.ASPNETcore.Assignment\Nagarro.EventManagement.UI\Views\Event\UserInvitedInEvents.cshtml"
  
    ViewData["Title"] = "UserInvitedInEvents";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Events Invited In!!!</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a2d915d558ca18a69f24b0d5c3c29b0aa48923a4462", async() => {
                WriteLiteral("Create New");
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
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            \r\n            <th>\r\n                ");
#nullable restore
#line 17 "C:\Users\krishnasingh01\source\repos\Nagarro.ASPNETcore.Assignment\Nagarro.EventManagement.UI\Views\Event\UserInvitedInEvents.cshtml"
           Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "C:\Users\krishnasingh01\source\repos\Nagarro.ASPNETcore.Assignment\Nagarro.EventManagement.UI\Views\Event\UserInvitedInEvents.cshtml"
           Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "C:\Users\krishnasingh01\source\repos\Nagarro.ASPNETcore.Assignment\Nagarro.EventManagement.UI\Views\Event\UserInvitedInEvents.cshtml"
           Write(Html.DisplayNameFor(model => model.Location));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            \r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 30 "C:\Users\krishnasingh01\source\repos\Nagarro.ASPNETcore.Assignment\Nagarro.EventManagement.UI\Views\Event\UserInvitedInEvents.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            \r\n            <td>\r\n                ");
#nullable restore
#line 34 "C:\Users\krishnasingh01\source\repos\Nagarro.ASPNETcore.Assignment\Nagarro.EventManagement.UI\Views\Event\UserInvitedInEvents.cshtml"
           Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "C:\Users\krishnasingh01\source\repos\Nagarro.ASPNETcore.Assignment\Nagarro.EventManagement.UI\Views\Event\UserInvitedInEvents.cshtml"
           Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "C:\Users\krishnasingh01\source\repos\Nagarro.ASPNETcore.Assignment\Nagarro.EventManagement.UI\Views\Event\UserInvitedInEvents.cshtml"
           Write(Html.DisplayFor(modelItem => item.Location));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            \r\n            <td>\r\n");
            WriteLiteral("                ");
#nullable restore
#line 45 "C:\Users\krishnasingh01\source\repos\Nagarro.ASPNETcore.Assignment\Nagarro.EventManagement.UI\Views\Event\UserInvitedInEvents.cshtml"
           Write(Html.ActionLink("Details", "Details", new { id=item.EventId }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n");
            WriteLiteral("            </td>\r\n        </tr>\r\n");
#nullable restore
#line 49 "C:\Users\krishnasingh01\source\repos\Nagarro.ASPNETcore.Assignment\Nagarro.EventManagement.UI\Views\Event\UserInvitedInEvents.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Nagarro.EventManagement.Shared.EventDTO>> Html { get; private set; }
    }
}
#pragma warning restore 1591
