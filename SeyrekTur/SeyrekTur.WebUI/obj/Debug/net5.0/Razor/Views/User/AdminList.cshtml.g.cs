#pragma checksum "C:\Users\hp\Desktop\veli\SeyrekTur\SeyrekTur.WebUI\Views\User\AdminList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f60b97c2382769d996ff3d3041a81928f3e06f0a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_AdminList), @"mvc.1.0.view", @"/Views/User/AdminList.cshtml")]
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
#line 1 "C:\Users\hp\Desktop\veli\SeyrekTur\SeyrekTur.WebUI\Views\_ViewImports.cshtml"
using SeyrekTur.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hp\Desktop\veli\SeyrekTur\SeyrekTur.WebUI\Views\_ViewImports.cshtml"
using SeyrekTur.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\hp\Desktop\veli\SeyrekTur\SeyrekTur.WebUI\Views\_ViewImports.cshtml"
using SeyrekTur.WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\hp\Desktop\veli\SeyrekTur\SeyrekTur.WebUI\Views\User\AdminList.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hp\Desktop\veli\SeyrekTur\SeyrekTur.WebUI\Views\User\AdminList.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f60b97c2382769d996ff3d3041a81928f3e06f0a", @"/Views/User/AdminList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c320f3338149fce3c6914d30e9759a1301abb001", @"/Views/_ViewImports.cshtml")]
    public class Views_User_AdminList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TicketRoute>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/user/iptalbilet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display:inline;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<div class=""row"">
    <div class=""col-md-12"">
        <h1 class=""h3"">Checking of Ticket</h1> <hr /> <br />
        <table id=""exampledatatable"" class=""table table-danger table-bordered shadow-sm mt-3"">
            <thead>
                <tr>
                    <th style=""width:20px;"">BiletID</th>
                    <th style=""width:145px;"">Ad - Soyad</th>
                    <th");
            BeginWriteAttribute("style", " style=\"", 452, "\"", 460, 0);
            EndWriteAttribute();
            WriteLiteral(@">Mail</th>
                    <th style=""width:25px;"">Başlangıç</th>
                    <th style=""width:25px;"">Bitiş</th>
                    <th style=""width:70px;"">KoltukNo</th>
                    <th style=""width:80px;"">Fiyat</th>
                    <th style=""width:85px;"">GüzergahNo</th>
                    <th style=""width:165px;"">İptal</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 24 "C:\Users\hp\Desktop\veli\SeyrekTur\SeyrekTur.WebUI\Views\User\AdminList.cshtml"
                 if (Model.Tickets.Count > 0)
                {
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\hp\Desktop\veli\SeyrekTur\SeyrekTur.WebUI\Views\User\AdminList.cshtml"
     foreach (var item in Model.Tickets)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\n    <td>");
#nullable restore
#line 29 "C:\Users\hp\Desktop\veli\SeyrekTur\SeyrekTur.WebUI\Views\User\AdminList.cshtml"
   Write(item.TicketId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 30 "C:\Users\hp\Desktop\veli\SeyrekTur\SeyrekTur.WebUI\Views\User\AdminList.cshtml"
   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 30 "C:\Users\hp\Desktop\veli\SeyrekTur\SeyrekTur.WebUI\Views\User\AdminList.cshtml"
              Write(item.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 31 "C:\Users\hp\Desktop\veli\SeyrekTur\SeyrekTur.WebUI\Views\User\AdminList.cshtml"
   Write(item.Mail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 32 "C:\Users\hp\Desktop\veli\SeyrekTur\SeyrekTur.WebUI\Views\User\AdminList.cshtml"
   Write(item.From);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 33 "C:\Users\hp\Desktop\veli\SeyrekTur\SeyrekTur.WebUI\Views\User\AdminList.cshtml"
   Write(item.To);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 34 "C:\Users\hp\Desktop\veli\SeyrekTur\SeyrekTur.WebUI\Views\User\AdminList.cshtml"
   Write(item.SeatNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 35 "C:\Users\hp\Desktop\veli\SeyrekTur\SeyrekTur.WebUI\Views\User\AdminList.cshtml"
   Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ₺</td>\n    <td>");
#nullable restore
#line 36 "C:\Users\hp\Desktop\veli\SeyrekTur\SeyrekTur.WebUI\Views\User\AdminList.cshtml"
   Write(item.RouteId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f60b97c2382769d996ff3d3041a81928f3e06f0a8313", async() => {
                WriteLiteral("\n            <input type=\"hidden\" name=\"biletId\"");
                BeginWriteAttribute("value", " value=\"", 1345, "\"", 1367, 1);
#nullable restore
#line 39 "C:\Users\hp\Desktop\veli\SeyrekTur\SeyrekTur.WebUI\Views\User\AdminList.cshtml"
WriteAttributeValue("", 1353, item.TicketId, 1353, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n            <button type=\"submit\" class=\"btn btn-danger btn-md mr-2\" style=\"color: white;\">Bileti İptal Et</button>\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </td>\n</tr>");
#nullable restore
#line 43 "C:\Users\hp\Desktop\veli\SeyrekTur\SeyrekTur.WebUI\Views\User\AdminList.cshtml"
     }

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Users\hp\Desktop\veli\SeyrekTur\SeyrekTur.WebUI\Views\User\AdminList.cshtml"
       }
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>Sistemde henüz kayıtlı bilet yok!</p>");
#nullable restore
#line 46 "C:\Users\hp\Desktop\veli\SeyrekTur\SeyrekTur.WebUI\Views\User\AdminList.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\n\n        </table>\n    </div>\n</div>\n<br />\n<br />\n");
            WriteLiteral("<br />\n<br />\n<a href=\"/User/ExportDinamicExcelBlogList\" class=\"btn btn-primary\">Excel Listesini İndir</a>\n\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
<link rel=""stylesheet"" type=""text/css"" href=""https://cdn.datatables.net/v/dt/dt-1.12.1/af-2.4.0/datatables.min.css"" />

<script type=""text/javascript"" src=""https://cdn.datatables.net/v/dt/dt-1.12.1/af-2.4.0/datatables.min.js""></script>

<script>
    $(document).ready(function () {
        $(""#exampledatatable"").DataTable();
    })
</script>

");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TicketRoute> Html { get; private set; }
    }
}
#pragma warning restore 1591
