#pragma checksum "C:\Fuentes_blazor\BlazorAppPeliculas\BlazorAppPeliculas\Client\Shared\PeliculaIndividual.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c0fa1586ccd3088160efed4e338ea08f9137c441"
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
    public partial class PeliculaIndividual : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, "Id: ");
            __builder.OpenElement(3, "b");
            __builder.AddContent(4, 
#nullable restore
#line 3 "C:\Fuentes_blazor\BlazorAppPeliculas\BlazorAppPeliculas\Client\Shared\PeliculaIndividual.razor"
               indice

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n    ");
            __builder.OpenElement(6, "p");
            __builder.AddContent(7, "Titulo: ");
            __builder.OpenElement(8, "b");
            __builder.AddContent(9, 
#nullable restore
#line 4 "C:\Fuentes_blazor\BlazorAppPeliculas\BlazorAppPeliculas\Client\Shared\PeliculaIndividual.razor"
                   pelicula.titulo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n    ");
            __builder.OpenElement(11, "p");
            __builder.AddContent(12, "Lanzamiento: ");
            __builder.OpenElement(13, "b");
            __builder.AddContent(14, 
#nullable restore
#line 5 "C:\Fuentes_blazor\BlazorAppPeliculas\BlazorAppPeliculas\Client\Shared\PeliculaIndividual.razor"
                        pelicula.lanzamiento.ToString("dd-MM-yyyy")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 7 "C:\Fuentes_blazor\BlazorAppPeliculas\BlazorAppPeliculas\Client\Shared\PeliculaIndividual.razor"
     if (mostrarBotones == true)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(15, "div");
            __builder.OpenElement(16, "button");
            __builder.AddAttribute(17, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "C:\Fuentes_blazor\BlazorAppPeliculas\BlazorAppPeliculas\Client\Shared\PeliculaIndividual.razor"
                                () => eliminarPelicula.InvokeAsync(pelicula)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(18, "Borrar");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 13 "C:\Fuentes_blazor\BlazorAppPeliculas\BlazorAppPeliculas\Client\Shared\PeliculaIndividual.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 17 "C:\Fuentes_blazor\BlazorAppPeliculas\BlazorAppPeliculas\Client\Shared\PeliculaIndividual.razor"
       
    [Parameter] public Pelicula pelicula { get; set; }
    [Parameter] public int indice { get; set; }
    [Parameter] public bool mostrarBotones { get; set; }
    [Parameter] public EventCallback<Pelicula> eliminarPelicula { get; set; }
    

    //void eliminar()
    //{
    //    Console.WriteLine($"eliminando peli {pelicula.titulo}");
    //}

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591