#pragma checksum "C:\Users\46962757875\Documents\Vai se foder\exercicios-c\McBonaldsMVC\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "142cd60de06dbf31e85e81894bf3c4f6c2165c8e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Layout.cshtml", typeof(AspNetCore.Views_Shared__Layout))]
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
#line 1 "C:\Users\46962757875\Documents\Vai se foder\exercicios-c\McBonaldsMVC\Views\_ViewImports.cshtml"
using McBonaldsMVC;

#line default
#line hidden
#line 2 "C:\Users\46962757875\Documents\Vai se foder\exercicios-c\McBonaldsMVC\Views\_ViewImports.cshtml"
using McBonaldsMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"142cd60de06dbf31e85e81894bf3c4f6c2165c8e", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cecd1f98a04a4696ecde4ba045dcb777a275b8f0", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("toggleMobileMenu()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("active"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cliente", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("flex-container"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\46962757875\Documents\Vai se foder\exercicios-c\McBonaldsMVC\Views\Shared\_Layout.cshtml"
  
    var nomeView = (string) ViewData["NomeView"];

#line default
#line hidden
            BeginContext(58, 40, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"pt-br\">\r\n\r\n");
            EndContext();
            BeginContext(98, 1093, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "142cd60de06dbf31e85e81894bf3c4f6c2165c8e6037", async() => {
                BeginContext(104, 667, true);
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <!-- PASSOS DO MENU RESPONSIVO -->
    <!-- PASSO 1 - Certifique-se de que essa linha abaixo existe no seu código -->
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <meta http-equiv=""X-UA-Compatible"" content=""ie=edge"">
    <title>McBonald's</title>
    <link href=""img/logo_simbolo.png"" rel=""icon"" type=""image/x-icon""/>
    <link href=""https://fonts.googleapis.com/css?family=Fredoka+One&display=swap"" rel=""stylesheet"">
    <link href=""https://fonts.googleapis.com/css?family=Londrina+Solid:900%7COpen+Sans"" rel=""stylesheet"">
    <link href=""/css/style.css"" rel=""stylesheet"" type=""text/css"">
");
                EndContext();
#line 18 "C:\Users\46962757875\Documents\Vai se foder\exercicios-c\McBonaldsMVC\Views\Shared\_Layout.cshtml"
     if(!"Home".Equals(nomeView))
    {

#line default
#line hidden
                BeginContext(813, 161, true);
                WriteLiteral("    <link href=\"/css/style-secondary-pages.css\" rel=\"stylesheet\" type=\"text/css\">\r\n    <link href=\"/css/style-form-pages.css\" rel=\"stylesheet\" type=\"text/css\">\r\n");
                EndContext();
#line 22 "C:\Users\46962757875\Documents\Vai se foder\exercicios-c\McBonaldsMVC\Views\Shared\_Layout.cshtml"
    }

#line default
#line hidden
                BeginContext(981, 203, true);
                WriteLiteral("    \r\n    <!-- PASSO 2 - Copie a linha do <script> abaixo para o seu HTML -->\r\n    <!-- Importar o Font Awesome para o projeto -->\r\n    <script src=\"https://kit.fontawesome.com/349a64cb04.js\"></script>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1191, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(1195, 3379, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "142cd60de06dbf31e85e81894bf3c4f6c2165c8e8868", async() => {
                BeginContext(1224, 716, true);
                WriteLiteral(@"
    <header>
        <nav>
            <div class=""section-container"">
                <ul>
                    <!-- PASSO 3 - Adicione esse li à sua ul -->
                    <li id=""bt-mobile-menu"">
                        <!-- HTML para colocar os ícones do FA -->
                        <a href=""javascript:void(0);"" class=""icon"" onclick=""toggleMobileMenu()"">
                            <i class=""fa fa-bars""></i>
                        </a>
                    </li>
                    <!-- PASSO 4 - Adicione essa class=""bt-common-menu"" nas suas li -->
                    <!-- PASSO 5 - Adicione o onclick=""toggleMobileMenu()"" nas tags a -->
                    <li class=""bt-common-menu"">");
                EndContext();
                BeginContext(1940, 101, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "142cd60de06dbf31e85e81894bf3c4f6c2165c8e9985", async() => {
                    BeginContext(2028, 9, true);
                    WriteLiteral("Principal");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2041, 85, true);
                WriteLiteral("</li>\r\n                    <li class=\"bt-common-menu\"><a onclick=\"toggleMobileMenu()\"");
                EndContext();
                BeginWriteAttribute("href", " href=\'", 2126, "\'", 2174, 2);
#line 44 "C:\Users\46962757875\Documents\Vai se foder\exercicios-c\McBonaldsMVC\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2133, Url.Action("Index", "Home"), 2133, 28, false);

#line default
#line hidden
                WriteAttributeValue("", 2161, "#hamburgueres", 2161, 13, true);
                EndWriteAttribute();
                BeginContext(2175, 102, true);
                WriteLiteral(">Hamburgueres</a></li>\r\n                    <li class=\"bt-common-menu\"><a onclick=\"toggleMobileMenu()\"");
                EndContext();
                BeginWriteAttribute("href", " href=\'", 2277, "\'", 2319, 2);
#line 45 "C:\Users\46962757875\Documents\Vai se foder\exercicios-c\McBonaldsMVC\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2284, Url.Action("Index", "Home"), 2284, 28, false);

#line default
#line hidden
                WriteAttributeValue("", 2312, "#shakes", 2312, 7, true);
                EndWriteAttribute();
                BeginContext(2320, 96, true);
                WriteLiteral(">Shakes</a></li>\r\n                    <li class=\"bt-common-menu\"><a onclick=\"toggleMobileMenu()\"");
                EndContext();
                BeginWriteAttribute("href", " href=\'", 2416, "\'", 2460, 2);
#line 46 "C:\Users\46962757875\Documents\Vai se foder\exercicios-c\McBonaldsMVC\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2423, Url.Action("Index", "Home"), 2423, 28, false);

#line default
#line hidden
                WriteAttributeValue("", 2451, "#historia", 2451, 9, true);
                EndWriteAttribute();
                BeginContext(2461, 98, true);
                WriteLiteral(">História</a></li>\r\n                    <li class=\"bt-common-menu\"><a onclick=\"toggleMobileMenu()\"");
                EndContext();
                BeginWriteAttribute("href", " href=\'", 2559, "\'", 2600, 2);
#line 47 "C:\Users\46962757875\Documents\Vai se foder\exercicios-c\McBonaldsMVC\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2566, Url.Action("Index", "Home"), 2566, 28, false);

#line default
#line hidden
                WriteAttributeValue("", 2594, "#local", 2594, 6, true);
                EndWriteAttribute();
                BeginContext(2601, 64, true);
                WriteLiteral(">Local</a></li>\r\n                    <li class=\"bt-common-menu\">");
                EndContext();
                BeginContext(2665, 85, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "142cd60de06dbf31e85e81894bf3c4f6c2165c8e14407", async() => {
                    BeginContext(2741, 5, true);
                    WriteLiteral("Login");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2750, 207, true);
                WriteLiteral("</li>\r\n                    <li><a id=\"bt-peca_ja\" href=\"pedidos.html\">Peça já!</a></li>\r\n                </ul>\r\n            </div>\r\n            <!-- Enfia aqui esta porra!! dsclp pfv n quis te ofender :-->\r\n");
                EndContext();
#line 53 "C:\Users\46962757875\Documents\Vai se foder\exercicios-c\McBonaldsMVC\Views\Shared\_Layout.cshtml"
             if("Home".Equals(nomeView)){
                Html.RenderPartial("_HeaderHomePage");
            }

#line default
#line hidden
                BeginContext(3071, 47, true);
                WriteLiteral("        </nav>\r\n        \r\n    </header>\r\n\r\n    ");
                EndContext();
                BeginContext(3119, 12, false);
#line 60 "C:\Users\46962757875\Documents\Vai se foder\exercicios-c\McBonaldsMVC\Views\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(3131, 1436, true);
                WriteLiteral(@"

<footer>
        <div class=""section-container"">
            <address>
                Avenida de Limeira, 539 - Campos Elíseos - SP
                <br />
                mcbonaldsemail.com
                <br />
                11 1234 6789
            </address>
            <a href=""#"">Voltar para o topo!</a>
        </div>
    </footer>

    <!-- PASSO 6 - Adicione a tag script e seu conteúdo antes do body fechar -->
    <!-- Agora vá para o style.css desse projeto! -->
    <script>
        function toggleMobileMenu() {
            var ul = document.querySelector(""nav ul"");
            var commonButtons = document.querySelectorAll(""nav .bt-common-menu"");
            var icon = document.querySelector("".icon > i"");

            ul.classList.toggle(""mobile-mode"");

            if (icon.classList.contains(""fa-bars"")) {
                icon.classList.remove(""fa-bars"");
                icon.classList.remove(""fa"");

                icon.classList.add(""fas"");
                icon.c");
                WriteLiteral(@"lassList.add(""fa-skull"");
            } else {
                icon.classList.remove(""fas"");
                icon.classList.remove(""fa-skull"");

                icon.classList.add(""fa"");
                icon.classList.add(""fa-bars"");
            }

            for (var button of commonButtons) {
                button.classList.toggle(""active"");
            }

        }
        
    </script>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4574, 13, true);
            WriteLiteral("\r\n\r\n</html>\r\n");
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
