#pragma checksum "C:\Users\hdayan\Desktop\study\final\Assetify\Views\Assets\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f1d4edd75ace6bfee5caeba00ce7e7c1f65cb59"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Assets_Details), @"mvc.1.0.view", @"/Views/Assets/Details.cshtml")]
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
#line 1 "C:\Users\hdayan\Desktop\study\final\Assetify\Views\_ViewImports.cshtml"
using Assetify;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hdayan\Desktop\study\final\Assetify\Views\_ViewImports.cshtml"
using Assetify.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f1d4edd75ace6bfee5caeba00ce7e7c1f65cb59", @"/Views/Assets/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cfc74125117d556694db23b8fe1cb4d7f8a88cca", @"/Views/_ViewImports.cshtml")]
    public class Views_Assets_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Assetify.Models.Asset>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\hdayan\Desktop\study\final\Assetify\Views\Assets\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Asset</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\hdayan\Desktop\study\final\Assetify\Views\Assets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\hdayan\Desktop\study\final\Assetify\Views\Assets\Details.cshtml"
       Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Users\hdayan\Desktop\study\final\Assetify\Views\Assets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EstimatedPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\Users\hdayan\Desktop\study\final\Assetify\Views\Assets\Details.cshtml"
       Write(Html.DisplayFor(model => model.EstimatedPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Users\hdayan\Desktop\study\final\Assetify\Views\Assets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Furnished));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\Users\hdayan\Desktop\study\final\Assetify\Views\Assets\Details.cshtml"
       Write(Html.DisplayFor(model => model.Furnished));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\Users\hdayan\Desktop\study\final\Assetify\Views\Assets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TypeId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\Users\hdayan\Desktop\study\final\Assetify\Views\Assets\Details.cshtml"
       Write(Html.DisplayFor(model => model.TypeId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "C:\Users\hdayan\Desktop\study\final\Assetify\Views\Assets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Condition));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "C:\Users\hdayan\Desktop\study\final\Assetify\Views\Assets\Details.cshtml"
       Write(Html.DisplayFor(model => model.Condition));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "C:\Users\hdayan\Desktop\study\final\Assetify\Views\Assets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Size));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "C:\Users\hdayan\Desktop\study\final\Assetify\Views\Assets\Details.cshtml"
       Write(Html.DisplayFor(model => model.Size));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 50 "C:\Users\hdayan\Desktop\study\final\Assetify\Views\Assets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.GardenSize));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 53 "C:\Users\hdayan\Desktop\study\final\Assetify\Views\Assets\Details.cshtml"
       Write(Html.DisplayFor(model => model.GardenSize));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 56 "C:\Users\hdayan\Desktop\study\final\Assetify\Views\Assets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BalconySize));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 59 "C:\Users\hdayan\Desktop\study\final\Assetify\Views\Assets\Details.cshtml"
       Write(Html.DisplayFor(model => model.BalconySize));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 62 "C:\Users\hdayan\Desktop\study\final\Assetify\Views\Assets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Rooms));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 65 "C:\Users\hdayan\Desktop\study\final\Assetify\Views\Assets\Details.cshtml"
       Write(Html.DisplayFor(model => model.Rooms));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 68 "C:\Users\hdayan\Desktop\study\final\Assetify\Views\Assets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Floor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 71 "C:\Users\hdayan\Desktop\study\final\Assetify\Views\Assets\Details.cshtml"
       Write(Html.DisplayFor(model => model.Floor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 74 "C:\Users\hdayan\Desktop\study\final\Assetify\Views\Assets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TotalFloor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 77 "C:\Users\hdayan\Desktop\study\final\Assetify\Views\Assets\Details.cshtml"
       Write(Html.DisplayFor(model => model.TotalFloor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 80 "C:\Users\hdayan\Desktop\study\final\Assetify\Views\Assets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NumOfParking));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 83 "C:\Users\hdayan\Desktop\study\final\Assetify\Views\Assets\Details.cshtml"
       Write(Html.DisplayFor(model => model.NumOfParking));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 86 "C:\Users\hdayan\Desktop\study\final\Assetify\Views\Assets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 89 "C:\Users\hdayan\Desktop\study\final\Assetify\Views\Assets\Details.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 92 "C:\Users\hdayan\Desktop\study\final\Assetify\Views\Assets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EntryDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 95 "C:\Users\hdayan\Desktop\study\final\Assetify\Views\Assets\Details.cshtml"
       Write(Html.DisplayFor(model => model.EntryDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 98 "C:\Users\hdayan\Desktop\study\final\Assetify\Views\Assets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CreatedAt));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 101 "C:\Users\hdayan\Desktop\study\final\Assetify\Views\Assets\Details.cshtml"
       Write(Html.DisplayFor(model => model.CreatedAt));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 104 "C:\Users\hdayan\Desktop\study\final\Assetify\Views\Assets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IsElevator));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 107 "C:\Users\hdayan\Desktop\study\final\Assetify\Views\Assets\Details.cshtml"
       Write(Html.DisplayFor(model => model.IsElevator));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 110 "C:\Users\hdayan\Desktop\study\final\Assetify\Views\Assets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IsBalcony));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 113 "C:\Users\hdayan\Desktop\study\final\Assetify\Views\Assets\Details.cshtml"
       Write(Html.DisplayFor(model => model.IsBalcony));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 116 "C:\Users\hdayan\Desktop\study\final\Assetify\Views\Assets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IsTerrace));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 119 "C:\Users\hdayan\Desktop\study\final\Assetify\Views\Assets\Details.cshtml"
       Write(Html.DisplayFor(model => model.IsTerrace));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 122 "C:\Users\hdayan\Desktop\study\final\Assetify\Views\Assets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IsStorage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 125 "C:\Users\hdayan\Desktop\study\final\Assetify\Views\Assets\Details.cshtml"
       Write(Html.DisplayFor(model => model.IsStorage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 128 "C:\Users\hdayan\Desktop\study\final\Assetify\Views\Assets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IsRenovated));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 131 "C:\Users\hdayan\Desktop\study\final\Assetify\Views\Assets\Details.cshtml"
       Write(Html.DisplayFor(model => model.IsRenovated));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 134 "C:\Users\hdayan\Desktop\study\final\Assetify\Views\Assets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IsRealtyCommission));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 137 "C:\Users\hdayan\Desktop\study\final\Assetify\Views\Assets\Details.cshtml"
       Write(Html.DisplayFor(model => model.IsRealtyCommission));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 140 "C:\Users\hdayan\Desktop\study\final\Assetify\Views\Assets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IsAircondition));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 143 "C:\Users\hdayan\Desktop\study\final\Assetify\Views\Assets\Details.cshtml"
       Write(Html.DisplayFor(model => model.IsAircondition));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 146 "C:\Users\hdayan\Desktop\study\final\Assetify\Views\Assets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IsMamad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 149 "C:\Users\hdayan\Desktop\study\final\Assetify\Views\Assets\Details.cshtml"
       Write(Html.DisplayFor(model => model.IsMamad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 152 "C:\Users\hdayan\Desktop\study\final\Assetify\Views\Assets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IsPandorDoors));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 155 "C:\Users\hdayan\Desktop\study\final\Assetify\Views\Assets\Details.cshtml"
       Write(Html.DisplayFor(model => model.IsPandorDoors));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 158 "C:\Users\hdayan\Desktop\study\final\Assetify\Views\Assets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IsAccessible));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 161 "C:\Users\hdayan\Desktop\study\final\Assetify\Views\Assets\Details.cshtml"
       Write(Html.DisplayFor(model => model.IsAccessible));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 164 "C:\Users\hdayan\Desktop\study\final\Assetify\Views\Assets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IsKosherKitchen));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 167 "C:\Users\hdayan\Desktop\study\final\Assetify\Views\Assets\Details.cshtml"
       Write(Html.DisplayFor(model => model.IsKosherKitchen));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 170 "C:\Users\hdayan\Desktop\study\final\Assetify\Views\Assets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IsKosherBoiler));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 173 "C:\Users\hdayan\Desktop\study\final\Assetify\Views\Assets\Details.cshtml"
       Write(Html.DisplayFor(model => model.IsKosherBoiler));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 176 "C:\Users\hdayan\Desktop\study\final\Assetify\Views\Assets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IsOnPillars));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 179 "C:\Users\hdayan\Desktop\study\final\Assetify\Views\Assets\Details.cshtml"
       Write(Html.DisplayFor(model => model.IsOnPillars));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 182 "C:\Users\hdayan\Desktop\study\final\Assetify\Views\Assets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IsBars));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 185 "C:\Users\hdayan\Desktop\study\final\Assetify\Views\Assets\Details.cshtml"
       Write(Html.DisplayFor(model => model.IsBars));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 188 "C:\Users\hdayan\Desktop\study\final\Assetify\Views\Assets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IsForSell));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 191 "C:\Users\hdayan\Desktop\study\final\Assetify\Views\Assets\Details.cshtml"
       Write(Html.DisplayFor(model => model.IsForSell));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 194 "C:\Users\hdayan\Desktop\study\final\Assetify\Views\Assets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IsCommercial));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 197 "C:\Users\hdayan\Desktop\study\final\Assetify\Views\Assets\Details.cshtml"
       Write(Html.DisplayFor(model => model.IsCommercial));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 200 "C:\Users\hdayan\Desktop\study\final\Assetify\Views\Assets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IsRoomates));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 203 "C:\Users\hdayan\Desktop\study\final\Assetify\Views\Assets\Details.cshtml"
       Write(Html.DisplayFor(model => model.IsRoomates));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 206 "C:\Users\hdayan\Desktop\study\final\Assetify\Views\Assets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IsImmediate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 209 "C:\Users\hdayan\Desktop\study\final\Assetify\Views\Assets\Details.cshtml"
       Write(Html.DisplayFor(model => model.IsImmediate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 212 "C:\Users\hdayan\Desktop\study\final\Assetify\Views\Assets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IsNearTrainStation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 215 "C:\Users\hdayan\Desktop\study\final\Assetify\Views\Assets\Details.cshtml"
       Write(Html.DisplayFor(model => model.IsNearTrainStation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 218 "C:\Users\hdayan\Desktop\study\final\Assetify\Views\Assets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IsNearLightTrainStation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 221 "C:\Users\hdayan\Desktop\study\final\Assetify\Views\Assets\Details.cshtml"
       Write(Html.DisplayFor(model => model.IsNearLightTrainStation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 224 "C:\Users\hdayan\Desktop\study\final\Assetify\Views\Assets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IsNearBeach));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 227 "C:\Users\hdayan\Desktop\study\final\Assetify\Views\Assets\Details.cshtml"
       Write(Html.DisplayFor(model => model.IsNearBeach));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 230 "C:\Users\hdayan\Desktop\study\final\Assetify\Views\Assets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IsActive));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 233 "C:\Users\hdayan\Desktop\study\final\Assetify\Views\Assets\Details.cshtml"
       Write(Html.DisplayFor(model => model.IsActive));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 236 "C:\Users\hdayan\Desktop\study\final\Assetify\Views\Assets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.RemovedReason));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 239 "C:\Users\hdayan\Desktop\study\final\Assetify\Views\Assets\Details.cshtml"
       Write(Html.DisplayFor(model => model.RemovedReason));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 242 "C:\Users\hdayan\Desktop\study\final\Assetify\Views\Assets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 245 "C:\Users\hdayan\Desktop\study\final\Assetify\Views\Assets\Details.cshtml"
       Write(Html.DisplayFor(model => model.Address.AddressID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0f1d4edd75ace6bfee5caeba00ce7e7c1f65cb5928806", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 250 "C:\Users\hdayan\Desktop\study\final\Assetify\Views\Assets\Details.cshtml"
                           WriteLiteral(Model.AssetID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0f1d4edd75ace6bfee5caeba00ce7e7c1f65cb5930948", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Assetify.Models.Asset> Html { get; private set; }
    }
}
#pragma warning restore 1591
