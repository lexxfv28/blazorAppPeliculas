#pragma checksum "C:\Fuentes_blazor\BlazorAppPeliculas\BlazorAppPeliculas\Client\Shared\ListadoPeliculas.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e754c866c6df8416914015cf1074c2991ad176c9"
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
    public partial class ListadoPeliculas : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "input");
            __builder.AddAttribute(1, "type", "checkbox");
            __builder.AddAttribute(2, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 3 "C:\Fuentes_blazor\BlazorAppPeliculas\BlazorAppPeliculas\Client\Shared\ListadoPeliculas.razor"
                              mostrarBotones

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => mostrarBotones = __value, mostrarBotones));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n \r\n");
            __Blazor.BlazorAppPeliculas.Client.Shared.ListadoPeliculas.TypeInference.CreateListadoGenerico_0(__builder, 5, 6, 
#nullable restore
#line 5 "C:\Fuentes_blazor\BlazorAppPeliculas\BlazorAppPeliculas\Client\Shared\ListadoPeliculas.razor"
                          peliculas

#line default
#line hidden
#nullable disable
            , 7, (pelicula) => (__builder2) => {
                __builder2.OpenComponent<BlazorAppPeliculas.Client.Shared.PeliculaIndividual>(8);
                __builder2.AddAttribute(9, "pelicula", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorAppPeliculas.Client.Entidades.Pelicula>(
#nullable restore
#line 7 "C:\Fuentes_blazor\BlazorAppPeliculas\BlazorAppPeliculas\Client\Shared\ListadoPeliculas.razor"
                                      pelicula

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(10, "indice", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 7 "C:\Fuentes_blazor\BlazorAppPeliculas\BlazorAppPeliculas\Client\Shared\ListadoPeliculas.razor"
                                                        peliculas.IndexOf(pelicula)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(11, "mostrarBotones", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 7 "C:\Fuentes_blazor\BlazorAppPeliculas\BlazorAppPeliculas\Client\Shared\ListadoPeliculas.razor"
                                                                                                     mostrarBotones

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(12, "eliminarPelicula", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<BlazorAppPeliculas.Client.Entidades.Pelicula>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<BlazorAppPeliculas.Client.Entidades.Pelicula>(this, 
#nullable restore
#line 7 "C:\Fuentes_blazor\BlazorAppPeliculas\BlazorAppPeliculas\Client\Shared\ListadoPeliculas.razor"
                                                                                                                                       eliminar

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
            }
            );
            __builder.AddMarkupContent(13, "\r\n\r\n");
            __builder.OpenComponent<BlazorAppPeliculas.Client.Shared.Confirmacion>(14);
            __builder.AddAttribute(15, "onConfirm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 11 "C:\Fuentes_blazor\BlazorAppPeliculas\BlazorAppPeliculas\Client\Shared\ListadoPeliculas.razor"
                                             eliminarPeliculaConfirmacion

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(16, "onCancel", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 11 "C:\Fuentes_blazor\BlazorAppPeliculas\BlazorAppPeliculas\Client\Shared\ListadoPeliculas.razor"
                                                                                     cancelarEliminacionPelicula

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(17, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(18, "<div>¿Desea eliminar la película?</div>");
            }
            ));
            __builder.AddComponentReferenceCapture(19, (__value) => {
#nullable restore
#line 11 "C:\Fuentes_blazor\BlazorAppPeliculas\BlazorAppPeliculas\Client\Shared\ListadoPeliculas.razor"
                    confirmacion = (BlazorAppPeliculas.Client.Shared.Confirmacion)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 16 "C:\Fuentes_blazor\BlazorAppPeliculas\BlazorAppPeliculas\Client\Shared\ListadoPeliculas.razor"
       
    [Parameter] public List<Pelicula> peliculas { get; set; }
    //[Parameter] public RenderFragment childContent { get; set; }
    bool mostrarBotones = true;
    Confirmacion confirmacion;
    Pelicula peliculaABorrar;

    //protected override async Task OnInitializedAsync()
    //{
    //    await Task.Delay(3000);
    //    this.peliculas = ObtenerPeliculas();
    //}


    async Task eliminar(Pelicula pelicula)
    {
        //var confirmacion = await js.confirm($"¿Desea borrarla pelicula {pelicula.titulo}?");

        //if (confirmacion == true)
        //{
        //    Console.WriteLine("eliminando " + pelicula.titulo);
        //    peliculas.Remove(pelicula);
        //}
        confirmacion.mostrar();
        peliculaABorrar = pelicula;
    }

    void eliminarPeliculaConfirmacion()
    {
        peliculas.Remove(peliculaABorrar);
        peliculaABorrar = null;
        confirmacion.ocultar();
    }

    void cancelarEliminacionPelicula()
    {
        confirmacion.ocultar();
        peliculaABorrar = null;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
    }
}
namespace __Blazor.BlazorAppPeliculas.Client.Shared.ListadoPeliculas
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateListadoGenerico_0<Titem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.List<Titem> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment<Titem> __arg1)
        {
        __builder.OpenComponent<global::BlazorAppPeliculas.Client.Shared.ListadoGenerico<Titem>>(seq);
        __builder.AddAttribute(__seq0, "listado", __arg0);
        __builder.AddAttribute(__seq1, "hayRegistros", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591