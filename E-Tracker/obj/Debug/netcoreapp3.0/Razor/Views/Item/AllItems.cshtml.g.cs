#pragma checksum "C:\Users\CYBERSPACE_ACADEMY\Documents\CyberspaceProjects\ETracker10.0\E-Tracker\Views\Item\AllItems.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e7d0d074f1b40eb3448c0af6dab8200a3f55dd3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Item_AllItems), @"mvc.1.0.view", @"/Views/Item/AllItems.cshtml")]
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
#line 1 "C:\Users\CYBERSPACE_ACADEMY\Documents\CyberspaceProjects\ETracker10.0\E-Tracker\Views\_ViewImports.cshtml"
using E_Tracker;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\CYBERSPACE_ACADEMY\Documents\CyberspaceProjects\ETracker10.0\E-Tracker\Views\_ViewImports.cshtml"
using E_Tracker.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\CYBERSPACE_ACADEMY\Documents\CyberspaceProjects\ETracker10.0\E-Tracker\Views\_ViewImports.cshtml"
using E_Tracker.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\CYBERSPACE_ACADEMY\Documents\CyberspaceProjects\ETracker10.0\E-Tracker\Views\_ViewImports.cshtml"
using E_Tracker.Dto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\CYBERSPACE_ACADEMY\Documents\CyberspaceProjects\ETracker10.0\E-Tracker\Views\_ViewImports.cshtml"
using E_Tracker.CreateDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\CYBERSPACE_ACADEMY\Documents\CyberspaceProjects\ETracker10.0\E-Tracker\Views\_ViewImports.cshtml"
using E_Tracker.Data.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\CYBERSPACE_ACADEMY\Documents\CyberspaceProjects\ETracker10.0\E-Tracker\Views\_ViewImports.cshtml"
using E_Tracker.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\CYBERSPACE_ACADEMY\Documents\CyberspaceProjects\ETracker10.0\E-Tracker\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\CYBERSPACE_ACADEMY\Documents\CyberspaceProjects\ETracker10.0\E-Tracker\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.SignalR;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e7d0d074f1b40eb3448c0af6dab8200a3f55dd3", @"/Views/Item/AllItems.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a7148bee2a85ded08507e78291586a140e4bcc9", @"/Views/_ViewImports.cshtml")]
    public class Views_Item_AllItems : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<E_Tracker.Dto.ItemDto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateItem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Item", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateItem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateService", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Service", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\CYBERSPACE_ACADEMY\Documents\CyberspaceProjects\ETracker10.0\E-Tracker\Views\Item\AllItems.cshtml"
  
    ViewData["Title"] = "AllItems";
    var url1 = $"{@Url.Action("ApproveItem", "Item", null, this.Url.ActionContext.HttpContext.Request.Scheme)}";
    var url2 = $"{@Url.Action("DeleteItem", "Item", null, this.Url.ActionContext.HttpContext.Request.Scheme)}";
    var url3 = $"{@Url.Action("ActivateItem", "Item", null, this.Url.ActionContext.HttpContext.Request.Scheme)}";
    var category = TempData["CategoryName"];



#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\CYBERSPACE_ACADEMY\Documents\CyberspaceProjects\ETracker10.0\E-Tracker\Views\Item\AllItems.cshtml"
 if (ViewBag.ItemGroup != null)
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>Items for ");
#nullable restore
#line 14 "C:\Users\CYBERSPACE_ACADEMY\Documents\CyberspaceProjects\ETracker10.0\E-Tracker\Views\Item\AllItems.cshtml"
             Write(ViewBag.ItemGroup?.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 14 "C:\Users\CYBERSPACE_ACADEMY\Documents\CyberspaceProjects\ETracker10.0\E-Tracker\Views\Item\AllItems.cshtml"
                                             if (category != null) { category = "in " + category + " Category"; }; 

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 14 "C:\Users\CYBERSPACE_ACADEMY\Documents\CyberspaceProjects\ETracker10.0\E-Tracker\Views\Item\AllItems.cshtml"
                                                                                                                Write(category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
#nullable restore
#line 15 "C:\Users\CYBERSPACE_ACADEMY\Documents\CyberspaceProjects\ETracker10.0\E-Tracker\Views\Item\AllItems.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>Items ");
#nullable restore
#line 18 "C:\Users\CYBERSPACE_ACADEMY\Documents\CyberspaceProjects\ETracker10.0\E-Tracker\Views\Item\AllItems.cshtml"
                if (category != null) { category = "in " + category + " Category"; }; 

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 18 "C:\Users\CYBERSPACE_ACADEMY\Documents\CyberspaceProjects\ETracker10.0\E-Tracker\Views\Item\AllItems.cshtml"
                                                                                   Write(category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
#nullable restore
#line 19 "C:\Users\CYBERSPACE_ACADEMY\Documents\CyberspaceProjects\ETracker10.0\E-Tracker\Views\Item\AllItems.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\CYBERSPACE_ACADEMY\Documents\CyberspaceProjects\ETracker10.0\E-Tracker\Views\Item\AllItems.cshtml"
 if (ViewBag.ItemGroup != null && User.HasClaim(CustomClaims.Permission, CustomClaimsValues.CreateItem) && ViewBag.IsAllItems ?? true)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\r\n");
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2e7d0d074f1b40eb3448c0af6dab8200a3f55dd310176", async() => {
                WriteLiteral("Create New Item");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-itemGroupId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 24 "C:\Users\CYBERSPACE_ACADEMY\Documents\CyberspaceProjects\ETracker10.0\E-Tracker\Views\Item\AllItems.cshtml"
                                                                    WriteLiteral(ViewBag.ItemGroup?.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["itemGroupId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-itemGroupId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["itemGroupId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </p>\r\n");
#nullable restore
#line 26 "C:\Users\CYBERSPACE_ACADEMY\Documents\CyberspaceProjects\ETracker10.0\E-Tracker\Views\Item\AllItems.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("<table id=\"myTable\" class=\"table table-striped table-primary\">\r\n    <thead>\r\n        <tr>\r\n\r\n            <th>\r\n                ");
#nullable restore
#line 33 "C:\Users\CYBERSPACE_ACADEMY\Documents\CyberspaceProjects\ETracker10.0\E-Tracker\Views\Item\AllItems.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n");
            WriteLiteral("            <th>\r\n                Item Group\r\n            </th>\r\n");
            WriteLiteral("            <th>\r\n                Date of Expiry\r\n");
            WriteLiteral("            </th>\r\n            <th>\r\n                Approval Status\r\n");
            WriteLiteral("            </th>\r\n            <th>\r\n                Tag Number\r\n");
            WriteLiteral("            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 60 "C:\Users\CYBERSPACE_ACADEMY\Documents\CyberspaceProjects\ETracker10.0\E-Tracker\Views\Item\AllItems.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n\r\n                <td>\r\n                    ");
#nullable restore
#line 65 "C:\Users\CYBERSPACE_ACADEMY\Documents\CyberspaceProjects\ETracker10.0\E-Tracker\Views\Item\AllItems.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n");
            WriteLiteral("                <td>\r\n                    ");
#nullable restore
#line 71 "C:\Users\CYBERSPACE_ACADEMY\Documents\CyberspaceProjects\ETracker10.0\E-Tracker\Views\Item\AllItems.cshtml"
               Write(Html.DisplayFor(modelItem => item.ItemGroup.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n");
            WriteLiteral("                <td>\r\n                    ");
#nullable restore
#line 77 "C:\Users\CYBERSPACE_ACADEMY\Documents\CyberspaceProjects\ETracker10.0\E-Tracker\Views\Item\AllItems.cshtml"
               Write(item.ExpiredDate.ToLongDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 78 "C:\Users\CYBERSPACE_ACADEMY\Documents\CyberspaceProjects\ETracker10.0\E-Tracker\Views\Item\AllItems.cshtml"
                     if (item.IsApproved == true && item.IsActive == true && item.ExpiredDate.Date <= DateTime.Now.Date)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <i class=\"fa fa-exclamation-triangle\" data-toggle=\"tooltip\" data-placement=\"top\" title=\"Expired\"></i>\r\n");
#nullable restore
#line 81 "C:\Users\CYBERSPACE_ACADEMY\Documents\CyberspaceProjects\ETracker10.0\E-Tracker\Views\Item\AllItems.cshtml"
                    }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n                <td>\r\n");
#nullable restore
#line 85 "C:\Users\CYBERSPACE_ACADEMY\Documents\CyberspaceProjects\ETracker10.0\E-Tracker\Views\Item\AllItems.cshtml"
                      string status = "";

#line default
#line hidden
#nullable disable
#nullable restore
#line 87 "C:\Users\CYBERSPACE_ACADEMY\Documents\CyberspaceProjects\ETracker10.0\E-Tracker\Views\Item\AllItems.cshtml"
                       if (item.IsApproved == true) status = "APPROVED"; else status = "NOT APPROVED"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
#nullable restore
#line 88 "C:\Users\CYBERSPACE_ACADEMY\Documents\CyberspaceProjects\ETracker10.0\E-Tracker\Views\Item\AllItems.cshtml"
               Write(status);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 91 "C:\Users\CYBERSPACE_ACADEMY\Documents\CyberspaceProjects\ETracker10.0\E-Tracker\Views\Item\AllItems.cshtml"
               Write(Html.DisplayFor(modelItem => item.TagNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
#nullable restore
#line 94 "C:\Users\CYBERSPACE_ACADEMY\Documents\CyberspaceProjects\ETracker10.0\E-Tracker\Views\Item\AllItems.cshtml"
                     if (User.HasClaim(CustomClaims.Permission, CustomClaimsValues.UpdateItem) && item.IsActive == true && item.IsApproved != true)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2e7d0d074f1b40eb3448c0af6dab8200a3f55dd317800", async() => {
                WriteLiteral("<i class=\"fa fa-edit\" data-toggle=\"tooltip\" data-placement=\"top\" title=\"Edit\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-itemId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 96 "C:\Users\CYBERSPACE_ACADEMY\Documents\CyberspaceProjects\ETracker10.0\E-Tracker\Views\Item\AllItems.cshtml"
                                                                               WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["itemId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-itemId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["itemId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral(" ");
            WriteLiteral("|\r\n");
#nullable restore
#line 98 "C:\Users\CYBERSPACE_ACADEMY\Documents\CyberspaceProjects\ETracker10.0\E-Tracker\Views\Item\AllItems.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2e7d0d074f1b40eb3448c0af6dab8200a3f55dd320657", async() => {
                WriteLiteral("<i class=\"fa fa-eye\" data-toggle=\"tooltip\" data-placement=\"top\" title=\"Details\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-itemId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 100 "C:\Users\CYBERSPACE_ACADEMY\Documents\CyberspaceProjects\ETracker10.0\E-Tracker\Views\Item\AllItems.cshtml"
                                                                        WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["itemId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-itemId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["itemId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 104 "C:\Users\CYBERSPACE_ACADEMY\Documents\CyberspaceProjects\ETracker10.0\E-Tracker\Views\Item\AllItems.cshtml"
                     if (User.HasClaim(CustomClaims.Permission, CustomClaimsValues.DeleteItem) && item.IsActive == true)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            WriteLiteral("|<a href=\"#\" onClick=\"Delete(\'");
#nullable restore
#line 106 "C:\Users\CYBERSPACE_ACADEMY\Documents\CyberspaceProjects\ETracker10.0\E-Tracker\Views\Item\AllItems.cshtml"
                                                   Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\', \'");
#nullable restore
#line 106 "C:\Users\CYBERSPACE_ACADEMY\Documents\CyberspaceProjects\ETracker10.0\E-Tracker\Views\Item\AllItems.cshtml"
                                                               Write(url2);

#line default
#line hidden
#nullable disable
            WriteLiteral("\' )\"><i class=\"fa fa-trash\" data-toggle=\"tooltip\" data-placement=\"top\" title=\"Delete\"></i></a>\r\n");
#nullable restore
#line 107 "C:\Users\CYBERSPACE_ACADEMY\Documents\CyberspaceProjects\ETracker10.0\E-Tracker\Views\Item\AllItems.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 108 "C:\Users\CYBERSPACE_ACADEMY\Documents\CyberspaceProjects\ETracker10.0\E-Tracker\Views\Item\AllItems.cshtml"
                     if (User.HasClaim(CustomClaims.Permission, CustomClaimsValues.DeleteItem) && item.IsActive == false)
                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            WriteLiteral("|<a href=\"#\" onClick=\"Restore(\'");
#nullable restore
#line 111 "C:\Users\CYBERSPACE_ACADEMY\Documents\CyberspaceProjects\ETracker10.0\E-Tracker\Views\Item\AllItems.cshtml"
                                                    Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\', \'");
#nullable restore
#line 111 "C:\Users\CYBERSPACE_ACADEMY\Documents\CyberspaceProjects\ETracker10.0\E-Tracker\Views\Item\AllItems.cshtml"
                                                                Write(url3);

#line default
#line hidden
#nullable disable
            WriteLiteral("\' )\"><i class=\"fas fa-trash-restore\" data-toggle=\"tooltip\" data-placement=\"top\" title=\"Restore\"></i></a>\r\n");
#nullable restore
#line 112 "C:\Users\CYBERSPACE_ACADEMY\Documents\CyberspaceProjects\ETracker10.0\E-Tracker\Views\Item\AllItems.cshtml"
                    }

                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 120 "C:\Users\CYBERSPACE_ACADEMY\Documents\CyberspaceProjects\ETracker10.0\E-Tracker\Views\Item\AllItems.cshtml"
                     if (User.HasClaim(CustomClaims.Permission, CustomClaimsValues.ApproveItem) && item.IsApproved == false && item.IsActive == true)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            WriteLiteral("|<a href=\"#\" onClick=\"Approve(\'");
#nullable restore
#line 122 "C:\Users\CYBERSPACE_ACADEMY\Documents\CyberspaceProjects\ETracker10.0\E-Tracker\Views\Item\AllItems.cshtml"
                                                    Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\', \'");
#nullable restore
#line 122 "C:\Users\CYBERSPACE_ACADEMY\Documents\CyberspaceProjects\ETracker10.0\E-Tracker\Views\Item\AllItems.cshtml"
                                                                Write(url1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\' )\"><i class=\"fa fa-check-square\" data-toggle=\"tooltip\" data-placement=\"top\" title=\"Approve\"></i></a>\r\n");
#nullable restore
#line 125 "C:\Users\CYBERSPACE_ACADEMY\Documents\CyberspaceProjects\ETracker10.0\E-Tracker\Views\Item\AllItems.cshtml"
                                                                                                           
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 128 "C:\Users\CYBERSPACE_ACADEMY\Documents\CyberspaceProjects\ETracker10.0\E-Tracker\Views\Item\AllItems.cshtml"
                     if (User.HasClaim(CustomClaims.Permission, CustomClaimsValues.UpdateService) && item.IsApproved == true && item.IsActive == true && item.ItemType.Name.Equals("servicing", StringComparison.OrdinalIgnoreCase))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            WriteLiteral("|\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2e7d0d074f1b40eb3448c0af6dab8200a3f55dd328091", async() => {
                WriteLiteral("<i class=\"fa fa-wrench\" data-toggle=\"tooltip\" data-placement=\"top\" title=\"Service\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-itemId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 131 "C:\Users\CYBERSPACE_ACADEMY\Documents\CyberspaceProjects\ETracker10.0\E-Tracker\Views\Item\AllItems.cshtml"
                                                                                     WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["itemId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-itemId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["itemId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 134 "C:\Users\CYBERSPACE_ACADEMY\Documents\CyberspaceProjects\ETracker10.0\E-Tracker\Views\Item\AllItems.cshtml"
                                                                                                                                          

                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 137 "C:\Users\CYBERSPACE_ACADEMY\Documents\CyberspaceProjects\ETracker10.0\E-Tracker\Views\Item\AllItems.cshtml"
                     if (User.HasClaim(CustomClaims.Permission, CustomClaimsValues.UpdateService) && item.IsApproved == true && item.IsActive == true && item.ItemType.Name.Equals("renewal", StringComparison.OrdinalIgnoreCase))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            WriteLiteral("|\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2e7d0d074f1b40eb3448c0af6dab8200a3f55dd331535", async() => {
                WriteLiteral("<i class=\"fa fa-redo\" data-toggle=\"tooltip\" data-placement=\"top\" title=\"Renew\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-itemId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 140 "C:\Users\CYBERSPACE_ACADEMY\Documents\CyberspaceProjects\ETracker10.0\E-Tracker\Views\Item\AllItems.cshtml"
                                                                                     WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["itemId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-itemId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["itemId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 143 "C:\Users\CYBERSPACE_ACADEMY\Documents\CyberspaceProjects\ETracker10.0\E-Tracker\Views\Item\AllItems.cshtml"
                                                                                                                                          

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n            </tr>\r\n");
#nullable restore
#line 148 "C:\Users\CYBERSPACE_ACADEMY\Documents\CyberspaceProjects\ETracker10.0\E-Tracker\Views\Item\AllItems.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>
<script>
    function Delete(id, url) {
        Swal.fire({
            title: 'Are you sure?',
            text: ""You won't be able to revert this!"",
            icon: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: 'Yes, delete it!'
        }).then((result) => {
            if (result.value) {
                //Swal.fire(
                //    'Deleted!',
                //    'Your file has been deleted.',
                //    'success'
                //)

                window.location.replace(url + ""?itemId="" + id)
            }
        })
    }

    function Approve(id, url) {
        Swal.fire({
            title: 'Are you sure?',
            text: ""You won't be able to revert this!"",
            icon: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
      ");
            WriteLiteral(@"      confirmButtonText: 'Yes, Approve it!'
        }).then((result) => {
            if (result.value) {
                //Swal.fire(
                //    'Deleted!',
                //    'Your file has been deleted.',
                //    'success'
                //)

                window.location.replace(url + ""?itemId="" + id)
            }
        })
    }

    function Restore(id, url) {
        Swal.fire({
            title: 'Are you sure?',
            text: ""You won't be able to revert this!"",
            icon: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: 'Yes, Restore it!'
        }).then((result) => {
            if (result.value) {
                //Swal.fire(
                //    'Deleted!',
                //    'Your file has been deleted.',
                //    'success'
                //)

                window.location.replace(url + ""?item");
            WriteLiteral("Id=\" + id)\r\n            }\r\n        })\r\n    }\r\n</script>\r\n\r\n<!-- Modal HTML -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<E_Tracker.Dto.ItemDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
