using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_FUNDAMENTALS
{
    public class Persona
    {
        public int Edad { get; set; }
        public string Nombre { get; set; }

        public string EdadYNombre()
        {
            return this.Edad + " - " + Nombre;
        }
    }
}
