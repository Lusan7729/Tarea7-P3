#pragma checksum "C:\Users\LUIS ANTONIO DE AZA\source\repos\__tarea7\__tarea7\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52a02bb46358323d602228beecd78f63de46fea0"
// <auto-generated/>
#pragma warning disable 1591
namespace __tarea7.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\LUIS ANTONIO DE AZA\source\repos\__tarea7\__tarea7\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LUIS ANTONIO DE AZA\source\repos\__tarea7\__tarea7\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\LUIS ANTONIO DE AZA\source\repos\__tarea7\__tarea7\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\LUIS ANTONIO DE AZA\source\repos\__tarea7\__tarea7\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\LUIS ANTONIO DE AZA\source\repos\__tarea7\__tarea7\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\LUIS ANTONIO DE AZA\source\repos\__tarea7\__tarea7\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\LUIS ANTONIO DE AZA\source\repos\__tarea7\__tarea7\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\LUIS ANTONIO DE AZA\source\repos\__tarea7\__tarea7\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\LUIS ANTONIO DE AZA\source\repos\__tarea7\__tarea7\_Imports.razor"
using __tarea7;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\LUIS ANTONIO DE AZA\source\repos\__tarea7\__tarea7\_Imports.razor"
using __tarea7.Shared;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddAttribute(2, "b-g4206jzy9x");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "sidebar");
            __builder.AddAttribute(5, "b-g4206jzy9x");
            __builder.OpenComponent<__tarea7.Shared.NavMenu>(6);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "main");
            __builder.AddAttribute(10, "b-g4206jzy9x");
            __builder.AddMarkupContent(11, "<div class=\"top-row px-4\" b-g4206jzy9x><a href=\"https://docs.microsoft.com/aspnet/\" target=\"_blank\" b-g4206jzy9x>About</a></div>\r\n\r\n        ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "content px-4");
            __builder.AddAttribute(14, "b-g4206jzy9x");
            __builder.AddContent(15, 
#nullable restore
#line 14 "C:\Users\LUIS ANTONIO DE AZA\source\repos\__tarea7\__tarea7\Shared\MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
