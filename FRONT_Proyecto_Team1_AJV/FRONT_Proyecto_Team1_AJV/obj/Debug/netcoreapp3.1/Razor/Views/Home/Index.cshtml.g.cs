#pragma checksum "C:\Users\victo\source\repos\FE-ProyectoFinal-Development\FRONT_Proyecto_Team1_AJV\FRONT_Proyecto_Team1_AJV\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "445cad04c02482fa0303c611a4dfd4c4263aa0c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\victo\source\repos\FE-ProyectoFinal-Development\FRONT_Proyecto_Team1_AJV\FRONT_Proyecto_Team1_AJV\Views\_ViewImports.cshtml"
using FRONT_Proyecto_Team1_AJV;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\victo\source\repos\FE-ProyectoFinal-Development\FRONT_Proyecto_Team1_AJV\FRONT_Proyecto_Team1_AJV\Views\_ViewImports.cshtml"
using FRONT_Proyecto_Team1_AJV.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"445cad04c02482fa0303c611a4dfd4c4263aa0c1", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"755f2c04eee4b5948710a1224704e08c686da52e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\victo\source\repos\FE-ProyectoFinal-Development\FRONT_Proyecto_Team1_AJV\FRONT_Proyecto_Team1_AJV\Views\Home\Index.cshtml"
   ViewData["Title"] = "Home Page"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("<div hidden id=\"tokenAPI\">\n    <!-- Token para el CRUD de la API -->\n");
            DefineSection("Token", async() => {
                WriteLiteral("\n        <script>CallToken(\'token@token.com\', \'TokenPassword\');</script>\n    ");
            }
            );
            WriteLiteral("    <!-- FIN DE TOKEN -->\n</div>\n");
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
