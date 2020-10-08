using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_FUNDAMENTALS
{
    // 3. Implementación 'compleja' para varios tipos de datos
    class Complejo
    {
        public int Numero { get; set; }
        public string Cadena { get; set; }

        public Complejo(int pNumero, string pCadena) // Constructor con parametros de entrada
        {
            this.Numero = pNumero;
            this.Cadena = pCadena;
        }

        // Metodo para imprimir en pantalla
        public string Imprime()
        {
            return Numero + " " + Cadena;
        }
    }
}
