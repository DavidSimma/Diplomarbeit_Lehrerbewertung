#pragma checksum "D:\SimonHTL\Diplomarbeit\Website\Diplomarbeit\Diplomarbeit\Views\Formular\Ergebnis_Formular.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e893094fdeb295c56f8426736b72e542cee5dc0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Formular_Ergebnis_Formular), @"mvc.1.0.view", @"/Views/Formular/Ergebnis_Formular.cshtml")]
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
#line 1 "D:\SimonHTL\Diplomarbeit\Website\Diplomarbeit\Diplomarbeit\Views\_ViewImports.cshtml"
using Diplomarbeit;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\SimonHTL\Diplomarbeit\Website\Diplomarbeit\Diplomarbeit\Views\_ViewImports.cshtml"
using Diplomarbeit.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e893094fdeb295c56f8426736b72e542cee5dc0", @"/Views/Formular/Ergebnis_Formular.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74002a458069235984eee92451c86b8f63ba76c4", @"/Views/_ViewImports.cshtml")]
    public class Views_Formular_Ergebnis_Formular : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<h1 style=""position: relative; top: 100px; text-align: center"">Ergebnis</h1>
<div style=""position: relative; top: 130px; min-height: 40px; text-align: center"">
    <select id=""wahlFormular""></select>
</div>
<div id=""antwort"" style=""position: relative; top: 130px; min-height: 380px; text-align: center"">
    <h5 style=""position: relative; top: 120px"">Hier werden die Formulare angezeigt</h5>
</div>
<div style=""position: relative; top: 150px; min-height: 110px"">
    <button id=""zurueck2"" style=""float:left"">vorheriges Formular</button>
    <button id=""weiter2"" style=""float:right"">nächstes Formular</button>
</div>
<div style=""position: relative; top:70px; min-height: 50px"">

</div>

");
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
