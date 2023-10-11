using Fundamentos_C_.Errors;
using Fundamentos_C_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos_C_.Service
{
    public class SearcherBeer
    {
        List<Cerveza> cervezas = new List<Cerveza>()
        {
            new Cerveza(){ Alcohol=7, Cantidad=10, Nombre="Pale Ale", Marca="Minerva"},
            new Cerveza(){ Alcohol = 8, Cantidad = 10, Nombre = "Ticus", Marca = "Colima"},
            new Cerveza(){ Alcohol = 7, Cantidad = 10, Nombre = "Stout", Marca = "Minerva" },
            new Cerveza(){ Alcohol = 6, Cantidad = 10, Nombre = "Piedra Lisa", Marca = "Colima" }
        };
        public int GetCantidad(string Nombre)
        {
            var cerveza = (from d in cervezas
                          where d.Nombre == Nombre
                          select d).FirstOrDefault();
            if(cerveza == null)
            {
                throw new BeerNotFoundException("La cerveza se ha terminado");
            }
            return cerveza.Cantidad;
        }
    }
}
