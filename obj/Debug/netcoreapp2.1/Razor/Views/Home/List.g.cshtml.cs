#pragma checksum "C:\Users\Amir\source\repos\AmirAliAkbari-CrudTest\Views\Home\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "804377cf89a7cba8a373a840d59efa2cb4628116"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_List), @"mvc.1.0.view", @"/Views/Home/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/List.cshtml", typeof(AspNetCore.Views_Home_List))]
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
#line 1 "C:\Users\Amir\source\repos\AmirAliAkbari-CrudTest\Views\_ViewImports.cshtml"
using AmirAliAkbari_CrudTest;

#line default
#line hidden
#line 2 "C:\Users\Amir\source\repos\AmirAliAkbari-CrudTest\Views\_ViewImports.cshtml"
using AmirAliAkbari_CrudTest.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"804377cf89a7cba8a373a840d59efa2cb4628116", @"/Views/Home/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f55d511b79842849c0392d57270ca4e43536c4e1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Amir\source\repos\AmirAliAkbari-CrudTest\Views\Home\List.cshtml"
  
    ViewData["Title"] = "Home Page";


#line default
#line hidden
            BeginContext(47, 593, true);
            WriteLiteral(@"
<style>
    .myGrid {
        width: 100%;
    }

        .myGrid td {
            border: 1px solid gray;
            padding: 1px;
        }
</style>

<div>
    <br />
    <a href=""/Home/Index"">Add New</a>
    <table class=""myGrid"">
        <thead>
            <tr>
                <td>First Name</td>
                <td>Last Name</td>
                <td>DateOfBirth</td>
                <td>PhoneNumber</td>
                <td>Email</td>
                <td>BankAccountNumber</td>
                <td></td>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 33 "C:\Users\Amir\source\repos\AmirAliAkbari-CrudTest\Views\Home\List.cshtml"
             for (int i = 0; i < Model.Count; i++)
            {

#line default
#line hidden
            BeginContext(707, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(754, 18, false);
#line 36 "C:\Users\Amir\source\repos\AmirAliAkbari-CrudTest\Views\Home\List.cshtml"
                   Write(Model[i].FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(772, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(804, 17, false);
#line 37 "C:\Users\Amir\source\repos\AmirAliAkbari-CrudTest\Views\Home\List.cshtml"
                   Write(Model[i].LastName);

#line default
#line hidden
            EndContext();
            BeginContext(821, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(853, 20, false);
#line 38 "C:\Users\Amir\source\repos\AmirAliAkbari-CrudTest\Views\Home\List.cshtml"
                   Write(Model[i].DateOfBirth);

#line default
#line hidden
            EndContext();
            BeginContext(873, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(905, 20, false);
#line 39 "C:\Users\Amir\source\repos\AmirAliAkbari-CrudTest\Views\Home\List.cshtml"
                   Write(Model[i].PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(925, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(957, 14, false);
#line 40 "C:\Users\Amir\source\repos\AmirAliAkbari-CrudTest\Views\Home\List.cshtml"
                   Write(Model[i].Email);

#line default
#line hidden
            EndContext();
            BeginContext(971, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1003, 26, false);
#line 41 "C:\Users\Amir\source\repos\AmirAliAkbari-CrudTest\Views\Home\List.cshtml"
                   Write(Model[i].BankAccountNumber);

#line default
#line hidden
            EndContext();
            BeginContext(1029, 59, true);
            WriteLiteral("</td>\r\n                    <td>\r\n                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1088, "\"", 1122, 2);
            WriteAttributeValue("", 1095, "/Home/Index?id=", 1095, 15, true);
#line 43 "C:\Users\Amir\source\repos\AmirAliAkbari-CrudTest\Views\Home\List.cshtml"
WriteAttributeValue("", 1110, Model[i].Id, 1110, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1123, 45, true);
            WriteLiteral(">Edit</a>\r\n                        <a href=\"\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1168, "\"", 1209, 3);
            WriteAttributeValue("", 1178, "deleteItem(event,", 1178, 17, true);
#line 44 "C:\Users\Amir\source\repos\AmirAliAkbari-CrudTest\Views\Home\List.cshtml"
WriteAttributeValue(" ", 1195, Model[i].Id, 1196, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 1208, ")", 1208, 1, true);
            EndWriteAttribute();
            BeginContext(1210, 63, true);
            WriteLiteral(">Delete</a>\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 47 "C:\Users\Amir\source\repos\AmirAliAkbari-CrudTest\Views\Home\List.cshtml"
            }

#line default
#line hidden
            BeginContext(1288, 753, true);
            WriteLiteral(@"        </tbody>
    </table>
</div>

<script type=""text/javascript"">
    function deleteItem(e, id) {
        e.preventDefault();
        e.stopPropagation();
        if (confirm(""Are you sure to delete selected item ?"")) {
            const url = '/Home/Delete?id=' + id.toString();
            const oParams = {
                headers: {
                    ""content-type"": ""application/json;charset=UTF-8""
                },
                method: ""POST""
            }

            fetch(url, oParams)
                .then(res => {
                    if (res.status == 200)
                        window.location.reload();
                })
                .then(error => console.log(error));
        }
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
