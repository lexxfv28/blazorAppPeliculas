using BlazorAppPeliculas.Client.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAppPeliculas.Client.Repositories.Impl
{
    public class Repositorio : IRepositorio
    {
        public List<Pelicula> obtenerPeliculas()
        {
            return new List<Pelicula>()
            {
                new Pelicula(){titulo="Batman", lanzamiento=new DateTime(1990,12,2) },
                new Pelicula(){titulo="Flash", lanzamiento=new DateTime(1993,4,7) },
                new Pelicula(){titulo="Phantom 2040", lanzamiento=new DateTime(1995,5,6) },
                new Pelicula(){titulo="Gargoyles", lanzamiento=new DateTime(2022,1,23) }
            };
        }
    }
}
