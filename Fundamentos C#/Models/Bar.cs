using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos_C_.Models
{
    public class Bar
    {
        public string nombre { get; set; }
        public List<Cerveza> cervezas { get; set; } = new List<Cerveza>();

        public Bar(string nombre)
        {
            this.nombre = nombre;           
        }
    }
}
