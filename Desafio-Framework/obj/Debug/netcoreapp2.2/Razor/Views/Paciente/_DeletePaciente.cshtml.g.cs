#pragma checksum "C:\Users\Ragner\Documents\GitHub\Desafio-Framework\Desafio-Framework\Views\Paciente\_DeletePaciente.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b69d2c214a27724493e419e2d5f8e817e3e618cd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Paciente__DeletePaciente), @"mvc.1.0.view", @"/Views/Paciente/_DeletePaciente.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Paciente/_DeletePaciente.cshtml", typeof(AspNetCore.Views_Paciente__DeletePaciente))]
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
#line 1 "C:\Users\Ragner\Documents\GitHub\Desafio-Framework\Desafio-Framework\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\Ragner\Documents\GitHub\Desafio-Framework\Desafio-Framework\Views\_ViewImports.cshtml"
using Desafio_Framework;

#line default
#line hidden
#line 2 "C:\Users\Ragner\Documents\GitHub\Desafio-Framework\Desafio-Framework\Views\Paciente\_DeletePaciente.cshtml"
using Desafio_Framework.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b69d2c214a27724493e419e2d5f8e817e3e618cd", @"/Views/Paciente/_DeletePaciente.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"076f953dcd9214840cc2f7ea9bb5e459efbd6222", @"/Views/_ViewImports.cshtml")]
    public class Views_Paciente__DeletePaciente : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<String>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(48, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Ragner\Documents\GitHub\Desafio-Framework\Desafio-Framework\Views\Paciente\_DeletePaciente.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(85, 82, false);
#line 6 "C:\Users\Ragner\Documents\GitHub\Desafio-Framework\Desafio-Framework\Views\Paciente\_DeletePaciente.cshtml"
Write(Html.PartialAsync("_ModalHeader", new ModalHeader { Heading = "Delete Paciente" }));

#line default
#line hidden
            EndContext();
            BeginContext(171, 77, true);
            WriteLiteral("    <div class=\"modal-body form-horizontal\">\r\n        Are you want to delete ");
            EndContext();
            BeginContext(249, 5, false);
#line 9 "C:\Users\Ragner\Documents\GitHub\Desafio-Framework\Desafio-Framework\Views\Paciente\_DeletePaciente.cshtml"
                          Write(Model);

#line default
#line hidden
            EndContext();
            BeginContext(254, 15, true);
            WriteLiteral("?\r\n    </div>\r\n");
            EndContext();
            BeginContext(278, 79, false);
#line 11 "C:\Users\Ragner\Documents\GitHub\Desafio-Framework\Desafio-Framework\Views\Paciente\_DeletePaciente.cshtml"
   Write(Html.PartialAsync("_ModalFooter", new ModalFooter { SubmitButtonText="Delete"}));

#line default
#line hidden
            EndContext();
#line 11 "C:\Users\Ragner\Documents\GitHub\Desafio-Framework\Desafio-Framework\Views\Paciente\_DeletePaciente.cshtml"
                                                                                        
}

#line default
#line hidden
            BeginContext(362, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<String> Html { get; private set; }
    }
}
#pragma warning restore 1591
