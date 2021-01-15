using BlazorAppPeliculas.Client.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAppPeliculas.Client.Repositories
{
    interface IRepositorio
    {
        List<Pelicula> obtenerPeliculas();
    } 
}
