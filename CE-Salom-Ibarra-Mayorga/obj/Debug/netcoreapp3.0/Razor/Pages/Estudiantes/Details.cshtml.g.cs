#pragma checksum "C:\Users\Francisco Ponce\Desktop\CE-Salom-Ibarra-Mayorga\CE-Salom-Ibarra-Mayorga\Pages\Estudiantes\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cad7fd3d2179a983f91fc1d3149f9c0fa07db82f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(CESIM.Pages.Estudiantes.Pages_Estudiantes_Details), @"mvc.1.0.razor-page", @"/Pages/Estudiantes/Details.cshtml")]
namespace CESIM.Pages.Estudiantes
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
#line 1 "C:\Users\Francisco Ponce\Desktop\CE-Salom-Ibarra-Mayorga\CE-Salom-Ibarra-Mayorga\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Francisco Ponce\Desktop\CE-Salom-Ibarra-Mayorga\CE-Salom-Ibarra-Mayorga\Pages\_ViewImports.cshtml"
using CESIM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Francisco Ponce\Desktop\CE-Salom-Ibarra-Mayorga\CE-Salom-Ibarra-Mayorga\Pages\_ViewImports.cshtml"
using CESIM.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cad7fd3d2179a983f91fc1d3149f9c0fa07db82f", @"/Pages/Estudiantes/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6211cf14a41dfe50727f87b7da0991092d38b58", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Estudiantes_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\Users\Francisco Ponce\Desktop\CE-Salom-Ibarra-Mayorga\CE-Salom-Ibarra-Mayorga\Pages\Estudiantes\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Listas de estudiantes</h1>\r\n\r\n<div>\r\n    <h4>Estudiante</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "C:\Users\Francisco Ponce\Desktop\CE-Salom-Ibarra-Mayorga\CE-Salom-Ibarra-Mayorga\Pages\Estudiantes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Estudiante.Nombres));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "C:\Users\Francisco Ponce\Desktop\CE-Salom-Ibarra-Mayorga\CE-Salom-Ibarra-Mayorga\Pages\Estudiantes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Estudiante.Nombres));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "C:\Users\Francisco Ponce\Desktop\CE-Salom-Ibarra-Mayorga\CE-Salom-Ibarra-Mayorga\Pages\Estudiantes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Estudiante.Apellidos));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "C:\Users\Francisco Ponce\Desktop\CE-Salom-Ibarra-Mayorga\CE-Salom-Ibarra-Mayorga\Pages\Estudiantes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Estudiante.Apellidos));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "C:\Users\Francisco Ponce\Desktop\CE-Salom-Ibarra-Mayorga\CE-Salom-Ibarra-Mayorga\Pages\Estudiantes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Estudiante.Sexo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "C:\Users\Francisco Ponce\Desktop\CE-Salom-Ibarra-Mayorga\CE-Salom-Ibarra-Mayorga\Pages\Estudiantes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Estudiante.Sexo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "C:\Users\Francisco Ponce\Desktop\CE-Salom-Ibarra-Mayorga\CE-Salom-Ibarra-Mayorga\Pages\Estudiantes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Estudiante.Nacimiento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "C:\Users\Francisco Ponce\Desktop\CE-Salom-Ibarra-Mayorga\CE-Salom-Ibarra-Mayorga\Pages\Estudiantes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Estudiante.Nacimiento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 39 "C:\Users\Francisco Ponce\Desktop\CE-Salom-Ibarra-Mayorga\CE-Salom-Ibarra-Mayorga\Pages\Estudiantes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Estudiante.Codigo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "C:\Users\Francisco Ponce\Desktop\CE-Salom-Ibarra-Mayorga\CE-Salom-Ibarra-Mayorga\Pages\Estudiantes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Estudiante.Codigo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 45 "C:\Users\Francisco Ponce\Desktop\CE-Salom-Ibarra-Mayorga\CE-Salom-Ibarra-Mayorga\Pages\Estudiantes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Estudiante.Tutor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 48 "C:\Users\Francisco Ponce\Desktop\CE-Salom-Ibarra-Mayorga\CE-Salom-Ibarra-Mayorga\Pages\Estudiantes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Estudiante.Tutor.tutorID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cad7fd3d2179a983f91fc1d3149f9c0fa07db82f8809", async() => {
                WriteLiteral("Listar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 53 "C:\Users\Francisco Ponce\Desktop\CE-Salom-Ibarra-Mayorga\CE-Salom-Ibarra-Mayorga\Pages\Estudiantes\Details.cshtml"
                           WriteLiteral(Model.Estudiante.estudianteID);

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cad7fd3d2179a983f91fc1d3149f9c0fa07db82f11006", async() => {
                WriteLiteral("Volver al menu principal");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CESIM.Pages.Estudiantes.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CESIM.Pages.Estudiantes.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CESIM.Pages.Estudiantes.DetailsModel>)PageContext?.ViewData;
        public CESIM.Pages.Estudiantes.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
