#pragma checksum "C:\Fuentes_blazor\BlazorAppPeliculas\BlazorAppPeliculas\Client\Shared\ListadoGenerico.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74d4a9dfc5d0f7fdd79fda92706c0cec3e6e6d7f"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorAppPeliculas.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Fuentes_blazor\BlazorAppPeliculas\BlazorAppPeliculas\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Fuentes_blazor\BlazorAppPeliculas\BlazorAppPeliculas\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Fuentes_blazor\BlazorAppPeliculas\BlazorAppPeliculas\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Fuentes_blazor\BlazorAppPeliculas\BlazorAppPeliculas\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Fuentes_blazor\BlazorAppPeliculas\BlazorAppPeliculas\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Fuentes_blazor\BlazorAppPeliculas\BlazorAppPeliculas\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Fuentes_blazor\BlazorAppPeliculas\BlazorAppPeliculas\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Fuentes_blazor\BlazorAppPeliculas\BlazorAppPeliculas\Client\_Imports.razor"
using BlazorAppPeliculas.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Fuentes_blazor\BlazorAppPeliculas\BlazorAppPeliculas\Client\_Imports.razor"
using BlazorAppPeliculas.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Fuentes_blazor\BlazorAppPeliculas\BlazorAppPeliculas\Client\_Imports.razor"
using BlazorAppPeliculas.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Fuentes_blazor\BlazorAppPeliculas\BlazorAppPeliculas\Client\_Imports.razor"
using BlazorAppPeliculas.Client.Entidades;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Fuentes_blazor\BlazorAppPeliculas\BlazorAppPeliculas\Client\_Imports.razor"
using BlazorAppPeliculas.Client.Repositories;

#line default
#line hidden
#nullable disable
    public partial class ListadoGenerico<Titem> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 3 "C:\Fuentes_blazor\BlazorAppPeliculas\BlazorAppPeliculas\Client\Shared\ListadoGenerico.razor"
 if (listado == null)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Fuentes_blazor\BlazorAppPeliculas\BlazorAppPeliculas\Client\Shared\ListadoGenerico.razor"
     if (cargando == null)
    {
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "Cargando...");
#nullable restore
#line 9 "C:\Fuentes_blazor\BlazorAppPeliculas\BlazorAppPeliculas\Client\Shared\ListadoGenerico.razor"
                                
    }
    else
    {
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, 
#nullable restore
#line 13 "C:\Fuentes_blazor\BlazorAppPeliculas\BlazorAppPeliculas\Client\Shared\ListadoGenerico.razor"
         cargando

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 13 "C:\Fuentes_blazor\BlazorAppPeliculas\BlazorAppPeliculas\Client\Shared\ListadoGenerico.razor"
                 
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Fuentes_blazor\BlazorAppPeliculas\BlazorAppPeliculas\Client\Shared\ListadoGenerico.razor"
     


}
else if (listado.Count == 0)
{


    

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Fuentes_blazor\BlazorAppPeliculas\BlazorAppPeliculas\Client\Shared\ListadoGenerico.razor"
     if (noHayRegistros == null)
    {
        

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "No hay películas que mostrar");
#nullable restore
#line 24 "C:\Fuentes_blazor\BlazorAppPeliculas\BlazorAppPeliculas\Client\Shared\ListadoGenerico.razor"
                                                 
    }
    else
    {
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, 
#nullable restore
#line 28 "C:\Fuentes_blazor\BlazorAppPeliculas\BlazorAppPeliculas\Client\Shared\ListadoGenerico.razor"
         noHayRegistros

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 28 "C:\Fuentes_blazor\BlazorAppPeliculas\BlazorAppPeliculas\Client\Shared\ListadoGenerico.razor"
                       
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Fuentes_blazor\BlazorAppPeliculas\BlazorAppPeliculas\Client\Shared\ListadoGenerico.razor"
     
}
else
{
    foreach (var elemento in listado)
    {
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, 
#nullable restore
#line 35 "C:\Fuentes_blazor\BlazorAppPeliculas\BlazorAppPeliculas\Client\Shared\ListadoGenerico.razor"
         hayRegistros(elemento)

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 35 "C:\Fuentes_blazor\BlazorAppPeliculas\BlazorAppPeliculas\Client\Shared\ListadoGenerico.razor"
                               
    }


}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "C:\Fuentes_blazor\BlazorAppPeliculas\BlazorAppPeliculas\Client\Shared\ListadoGenerico.razor"
       
    [Parameter] public RenderFragment cargando { get; set; }
    [Parameter] public RenderFragment noHayRegistros { get; set; }
    [Parameter] public RenderFragment<Titem> hayRegistros { get; set; }
    [Parameter] public List<Titem> listado { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
