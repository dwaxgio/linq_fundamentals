using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_FUNDAMENTALS
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * // 1. Defino arreglo
            int[] arregloEnteros = { 1, 2, 5, 8, 55, 66, 99, 543, 2, 101, 010, 2, 66};

            // Ej. Obtener elementos ordenados con LINQ
            // 2. Crear variable de tipo lista, 
            // 2.1 Utilizar palabra reservada FROM seguido de un alias para manejar la conexión de datos, para implementarlo sobre el arreglo
            IEnumerable<int> lst = from d in arregloEnteros // Puedo ejecutar las demas sentencias como se implementarían en sql
                                   where d == 2 || d == 66
                                   orderby d
                                   select d; // NOTA: El SELECT es lo último que se ejecuta en la consulta
            // 2.2 Mostrar en pantalla
            foreach (var o in lst) // 2.2.1 Recorro la coleccion
            {
                Console.WriteLine(o);
            }       

            Console.ReadKey();
            */



            // Para mostrar datos de manera mas compleja
            // 1. Crear arreglo de clases de la clase Complejo
            // Complejo[] lst = { new Complejo(4, "Halo"), new Complejo(68, "AC"), new Complejo(87, "NFS"), new Complejo(1, "FIFA") };
            Complejo[] lst =
            {
                // 1.2 Para asignar valores, se instancia / se implementan los new
                new Complejo(4,"Halo"),
                new Complejo(68, "AC"),
                new Complejo(87, "NFS"),
                new Complejo(1, "FIFA")
            };

            // Para obtener valores, ej, solo de 4, halo
            var oHalo = (from d in lst
                        where d.Numero == 4
                        select d).FirstOrDefault();

            /*
             * //Si quisiera solo el primer dato coincidente
             * var oComplejo = (from d in lst
             *                 where d.Nombre == "NFS"
             *                 select d).FirstOrDefault();
             * */

            Console.WriteLine(oHalo.Imprime() + "\n");

            // Para traer todos los valores
            var oLst = from d in lst
                       orderby d.Numero
                       select d;

            foreach (var o in oLst)
            {
                Console.WriteLine(o.Imprime());
            }

            Console.ReadKey();
        }
    }
}
