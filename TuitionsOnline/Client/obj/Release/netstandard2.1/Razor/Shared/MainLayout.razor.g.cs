#pragma checksum "D:\Projects\12_17_2020\TuitionsOnline\TuitionsOnline\Client\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17e71a4973b7ed943c13765f744567630114f33c"
// <auto-generated/>
#pragma warning disable 1591
namespace TuitionsOnline.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Projects\12_17_2020\TuitionsOnline\TuitionsOnline\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\12_17_2020\TuitionsOnline\TuitionsOnline\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\12_17_2020\TuitionsOnline\TuitionsOnline\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projects\12_17_2020\TuitionsOnline\TuitionsOnline\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Projects\12_17_2020\TuitionsOnline\TuitionsOnline\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Projects\12_17_2020\TuitionsOnline\TuitionsOnline\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Projects\12_17_2020\TuitionsOnline\TuitionsOnline\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Projects\12_17_2020\TuitionsOnline\TuitionsOnline\Client\_Imports.razor"
using TuitionsOnline.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Projects\12_17_2020\TuitionsOnline\TuitionsOnline\Client\_Imports.razor"
using TuitionsOnline.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Projects\12_17_2020\TuitionsOnline\TuitionsOnline\Client\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Projects\12_17_2020\TuitionsOnline\TuitionsOnline\Client\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Projects\12_17_2020\TuitionsOnline\TuitionsOnline\Client\_Imports.razor"
using Blazorise;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\12_17_2020\TuitionsOnline\TuitionsOnline\Client\Shared\MainLayout.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projects\12_17_2020\TuitionsOnline\TuitionsOnline\Client\Shared\MainLayout.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Blazored.Modal.BlazoredModal>(0);
            __builder.AddAttribute(1, "HideCloseButton", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 6 "D:\Projects\12_17_2020\TuitionsOnline\TuitionsOnline\Client\Shared\MainLayout.razor"
                                true

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(2, "\n\n\n");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "main resolution_style");
            __builder.AddAttribute(5, "style", "background-color: #f2f0e9; position: absolute; z-index:10000");
            __builder.AddMarkupContent(6, "\n    ");
            __builder.OpenComponent<Blazored.Toast.BlazoredToasts>(7);
            __builder.AddAttribute(8, "Position", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazored.Toast.Configuration.ToastPosition>(
#nullable restore
#line 10 "D:\Projects\12_17_2020\TuitionsOnline\TuitionsOnline\Client\Shared\MainLayout.razor"
                              Blazored.Toast.Configuration.ToastPosition.BottomCenter

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(9, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\n\n");
            __builder.OpenElement(11, "body");
            __builder.AddMarkupContent(12, "\n    ");
            __builder.OpenComponent<TuitionsOnline.Client.Shared.NavMenu>(13);
            __builder.CloseComponent();
            __builder.AddMarkupContent(14, "\n\n    ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "container");
            __builder.AddMarkupContent(17, "\n        ");
            __builder.AddContent(18, 
#nullable restore
#line 17 "D:\Projects\12_17_2020\TuitionsOnline\TuitionsOnline\Client\Shared\MainLayout.razor"
         Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(19, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\n");
            __builder.AddMarkupContent(22, @"<footer class=""footer_style"">
    <div class=""footer_labels"" style=""text-decoration: underline;"">

        <div>
            <a class=""nav-link text-light"" href=""privacypolicy"">Privacy Policy</a>
        </div>

        <div class=""footer_elements"">
            <a class=""nav-link text-light"" href=""terms&conditions"">Terms and Conditions</a>
        </div>
        <div class=""footer_FAQ"">
            <a class=""nav-link text-light"" href=""faq"">FAQ</a>
        </div>

    </div>
    
</footer>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
