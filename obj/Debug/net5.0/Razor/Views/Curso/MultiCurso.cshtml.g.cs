#pragma checksum "C:\Documents and Settings\vsant\Mis documentos\cursos\aspcore\HolaMundo\Views\Curso\MultiCurso.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4f326fd05a6d7e2da7895c7978005cd230372c1f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Curso_MultiCurso), @"mvc.1.0.view", @"/Views/Curso/MultiCurso.cshtml")]
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
#line 1 "C:\Documents and Settings\vsant\Mis documentos\cursos\aspcore\HolaMundo\Views\_ViewImports.cshtml"
using HolaMundo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Documents and Settings\vsant\Mis documentos\cursos\aspcore\HolaMundo\Views\_ViewImports.cshtml"
using HolaMundo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f326fd05a6d7e2da7895c7978005cd230372c1f", @"/Views/Curso/MultiCurso.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6347fbb7baf218229e9b8364d3a4ea17a6caa847", @"/Views/_ViewImports.cshtml")]
    public class Views_Curso_MultiCurso : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Curso>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "ListaOBjetosEscuela", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Documents and Settings\vsant\Mis documentos\cursos\aspcore\HolaMundo\Views\Curso\MultiCurso.cshtml"
  
    ViewData["Title"] = "Información Alumno";
    Layout = "Simple";
    ViewData["Controller"] = "curso";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>ID: ");
#nullable restore
#line 8 "C:\Documents and Settings\vsant\Mis documentos\cursos\aspcore\HolaMundo\Views\Curso\MultiCurso.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n\r\n<strong> Desde la vista layout</strong>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4f326fd05a6d7e2da7895c7978005cd230372c1f4075", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</partial>\r\n<p>\r\n    <i>");
#nullable restore
#line 15 "C:\Documents and Settings\vsant\Mis documentos\cursos\aspcore\HolaMundo\Views\Curso\MultiCurso.cshtml"
  Write(ViewBag.CosaDinamica);

#line default
#line hidden
#nullable disable
            WriteLiteral("</i>\r\n    <i>");
#nullable restore
#line 16 "C:\Documents and Settings\vsant\Mis documentos\cursos\aspcore\HolaMundo\Views\Curso\MultiCurso.cshtml"
  Write(ViewBag.Fecha);

#line default
#line hidden
#nullable disable
            WriteLiteral("</i>\r\n</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Curso>> Html { get; private set; }
    }
}
#pragma warning restore 1591
