#pragma checksum "C:\Users\kembe\OneDrive\Documentos\GitHub\Escuela_PrograII\Escuela\Views\Student\StudentRegistrar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf175c14eec62722b1f04f4509260fa1744ef47d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_StudentRegistrar), @"mvc.1.0.view", @"/Views/Student/StudentRegistrar.cshtml")]
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
#line 1 "C:\Users\kembe\OneDrive\Documentos\GitHub\Escuela_PrograII\Escuela\Views\_ViewImports.cshtml"
using Escuela;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kembe\OneDrive\Documentos\GitHub\Escuela_PrograII\Escuela\Views\_ViewImports.cshtml"
using Escuela.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf175c14eec62722b1f04f4509260fa1744ef47d", @"/Views/Student/StudentRegistrar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ad1daf75ad34d7efa7ede8e232fbd89a93ea7bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_StudentRegistrar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Escuela.Models.ViewModel.StudentViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\kembe\OneDrive\Documentos\GitHub\Escuela_PrograII\Escuela\Views\Student\StudentRegistrar.cshtml"
  
    ViewData["Title"] = "StudentRegistrar";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>StudentRegistrar</h1>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\kembe\OneDrive\Documentos\GitHub\Escuela_PrograII\Escuela\Views\Student\StudentRegistrar.cshtml"
 using (Html.BeginForm("Insertar", "Student", FormMethod.Post))
    {
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\kembe\OneDrive\Documentos\GitHub\Escuela_PrograII\Escuela\Views\Student\StudentRegistrar.cshtml"
Write(Html.LabelFor(f => f.FirtsMidName));

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\kembe\OneDrive\Documentos\GitHub\Escuela_PrograII\Escuela\Views\Student\StudentRegistrar.cshtml"
Write(Html.TextBoxFor(f => f.FirtsMidName));

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\kembe\OneDrive\Documentos\GitHub\Escuela_PrograII\Escuela\Views\Student\StudentRegistrar.cshtml"
Write(Html.ValidationMessageFor(f => f.FirtsMidName));

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\kembe\OneDrive\Documentos\GitHub\Escuela_PrograII\Escuela\Views\Student\StudentRegistrar.cshtml"
Write(Html.LabelFor(l => l.LastName));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\kembe\OneDrive\Documentos\GitHub\Escuela_PrograII\Escuela\Views\Student\StudentRegistrar.cshtml"
Write(Html.TextBoxFor(l => l.LastName));

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\kembe\OneDrive\Documentos\GitHub\Escuela_PrograII\Escuela\Views\Student\StudentRegistrar.cshtml"
Write(Html.ValidationMessageFor(l => l.LastName));

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\kembe\OneDrive\Documentos\GitHub\Escuela_PrograII\Escuela\Views\Student\StudentRegistrar.cshtml"
Write(Html.LabelFor(l => l.EnrollementsDate));

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\kembe\OneDrive\Documentos\GitHub\Escuela_PrograII\Escuela\Views\Student\StudentRegistrar.cshtml"
Write(Html.TextBoxFor(l => l.EnrollementsDate));

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\kembe\OneDrive\Documentos\GitHub\Escuela_PrograII\Escuela\Views\Student\StudentRegistrar.cshtml"
Write(Html.ValidationMessageFor(l => l.EnrollementsDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("<input type=\"submit\" value=\"Continuar\" />\r\n");
#nullable restore
#line 26 "C:\Users\kembe\OneDrive\Documentos\GitHub\Escuela_PrograII\Escuela\Views\Student\StudentRegistrar.cshtml"

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Escuela.Models.ViewModel.StudentViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
