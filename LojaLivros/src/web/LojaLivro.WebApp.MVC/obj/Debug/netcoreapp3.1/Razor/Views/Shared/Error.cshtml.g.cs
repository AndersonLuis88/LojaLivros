#pragma checksum "D:\00.ESTUDOS\000.TESTES\Loja de Livros\LojaLivros\src\web\LojaLivro.WebApp.MVC\Views\Shared\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3897d92b3d35f4a984915a6d522ebaff9e0cb058"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Error), @"mvc.1.0.view", @"/Views/Shared/Error.cshtml")]
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
#line 1 "D:\00.ESTUDOS\000.TESTES\Loja de Livros\LojaLivros\src\web\LojaLivro.WebApp.MVC\Views\_ViewImports.cshtml"
using LojaLivro.WebApp.MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\00.ESTUDOS\000.TESTES\Loja de Livros\LojaLivros\src\web\LojaLivro.WebApp.MVC\Views\_ViewImports.cshtml"
using LojaLivro.WebApp.MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3897d92b3d35f4a984915a6d522ebaff9e0cb058", @"/Views/Shared/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"041672395e38804b7faceba8c3c63b3fbb8f9a00", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LojaLivro.WebApp.MVC.Models.ErrorViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\00.ESTUDOS\000.TESTES\Loja de Livros\LojaLivros\src\web\LojaLivro.WebApp.MVC\Views\Shared\Error.cshtml"
  
    ViewData["Title"] = "Ocorreu um erro";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "D:\00.ESTUDOS\000.TESTES\Loja de Livros\LojaLivros\src\web\LojaLivro.WebApp.MVC\Views\Shared\Error.cshtml"
  
    if (Model == null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div>\r\n            <h2>Ooops! Ocorreu um erro, mas não se preocupe. Nosso time será avisado e iremos corrigir em breve!</h2>\r\n        </div>\r\n");
#nullable restore
#line 12 "D:\00.ESTUDOS\000.TESTES\Loja de Livros\LojaLivros\src\web\LojaLivro.WebApp.MVC\Views\Shared\Error.cshtml"
    }
    else
    {
        ViewData["Title"] = Model.Titulo;


#line default
#line hidden
#nullable disable
            WriteLiteral("        <div>\r\n            <h2>");
#nullable restore
#line 18 "D:\00.ESTUDOS\000.TESTES\Loja de Livros\LojaLivros\src\web\LojaLivro.WebApp.MVC\Views\Shared\Error.cshtml"
           Write(Html.Raw(Model.Mensagem));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n        </div>\r\n");
#nullable restore
#line 20 "D:\00.ESTUDOS\000.TESTES\Loja de Livros\LojaLivros\src\web\LojaLivro.WebApp.MVC\Views\Shared\Error.cshtml"

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LojaLivro.WebApp.MVC.Models.ErrorViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
