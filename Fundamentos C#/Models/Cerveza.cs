using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos_C_.Models
{
    public class Cerveza : Bebida, IBebidaAlcoholica

    {
        public int Alcohol { get; set; }
        public string Marca { get; set; }
        public int id { get; set; }
        public void MaxRecomendado()
        {
            Console.WriteLine("El máximo permitido son 10 botellas");
        }
        public Cerveza(int Cantidad, string Nombre ="cerveza") : base(Nombre, Cantidad)
        {
        }

        public Cerveza(): base (null, 0)
        {
        }
    }
}
