#pragma checksum "D:\Wesley\repos\DesignPatterns\DesignPatterns\PadroesEstruturais\Proxy\VideoGalery\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d21f782d6b09a2b999fa7299405e3adbac2bab6"
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
#line 1 "D:\Wesley\repos\DesignPatterns\DesignPatterns\PadroesEstruturais\Proxy\VideoGalery\Views\_ViewImports.cshtml"
using VideoGalery;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Wesley\repos\DesignPatterns\DesignPatterns\PadroesEstruturais\Proxy\VideoGalery\Views\_ViewImports.cshtml"
using VideoGalery.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d21f782d6b09a2b999fa7299405e3adbac2bab6", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0406b793cbecf9c455521f97b7d5d543351e3b85", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VideoGalery.Models.VideoViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Wesley\repos\DesignPatterns\DesignPatterns\PadroesEstruturais\Proxy\VideoGalery\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "D:\Wesley\repos\DesignPatterns\DesignPatterns\PadroesEstruturais\Proxy\VideoGalery\Views\Home\Index.cshtml"
 using (Html.BeginForm(null, null, FormMethod.Post))
{ 


#line default
#line hidden
#nullable disable
            WriteLiteral(" <div class=\"text-center\">\r\n     <h1 class=\"display-4\" > Video Galery</h1>\r\n </div>\r\n <table>\r\n     <tr>\r\n         <td>\r\n             <h2>\r\n                 Escolha o video:\r\n                 ");
#nullable restore
#line 18 "D:\Wesley\repos\DesignPatterns\DesignPatterns\PadroesEstruturais\Proxy\VideoGalery\Views\Home\Index.cshtml"
            Write(Html.DropDownListFor(Model => Model.SelectedVideoId, new SelectList(Model.Videos, "Id", "Name"),
                "Selecione..", new { onChange = "this.form.submit()" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n             </h2>\r\n\r\n         </td>\r\n     </tr>\r\n     <tr>\r\n         <td colspan=\"2\" style=\"padding:10px 0\">\r\n             <video");
            BeginWriteAttribute("src", " src=\"", 648, "\"", 678, 1);
#nullable restore
#line 26 "D:\Wesley\repos\DesignPatterns\DesignPatterns\PadroesEstruturais\Proxy\VideoGalery\Views\Home\Index.cshtml"
WriteAttributeValue("", 654, Url.Content(Model.Path), 654, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" width=""670"" height=""500"" controls typeof=""video/mp4"" autoplay loop
                    style=""border: 3px solid #808080""></video>

         </td>
     </tr>
     <tr>
         <td >
            <input type=""submit"" name=""HD"" value=""High Definition""  style=""background-color: #808080"" fon/> 
         </td>
     </tr>
 </table>
");
#nullable restore
#line 37 "D:\Wesley\repos\DesignPatterns\DesignPatterns\PadroesEstruturais\Proxy\VideoGalery\Views\Home\Index.cshtml"







}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Bem vindo a galery video</h1>\r\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VideoGalery.Models.VideoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
