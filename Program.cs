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


            /*
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
             * 

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
            */

            /*---------------------------------------------------------------------------------------
             * */

            // Linq fundamentals 2 ***********************
            // 1. Se llena lista de elementos
            List<Persona> lst = new List<Persona>() // Se inicializa lista
            {
                new Persona(){Edad = 25, Nombre="Jenny"},
                new Persona(){Edad = 29, Nombre="Edward"},
                new Persona(){Edad = 38, Nombre="Jhon"}
            };

            // 2 Con linq, se busca valor requerido
            /* var edward = (from d in lst
                           where d.Nombre == "Edward"
                           select d).FirstOrDefault();

             Console.WriteLine(edward.Nombre + " edad: " + edward.Edad);

             Console.WriteLine("\n");
            */

            /*
             * // Ordenado por nombre
            var oPersona = from d in lst
                           orderby d.Nombre
                           select d;


            foreach(var o in oPersona)
            {
                Console.WriteLine(o.Nombre + " edad: " + o.Edad);
            }
            */

            /*
            // Ordenado por nombre, segunda manera
            List<string> oLst = (from d in lst
                                 orderby d.Nombre
                                 //select d.EdadYNombre()).ToList(); // Retorna todos los nombres y las edades
                                 //select d.EdadYNombre()).Take(2).ToList();// Take(2) indica que va a tomar solo dos elementos, posterior a ordenarlos
                                 select d.EdadYNombre()).Skip(1).Take(2).ToList();// Skip(2) indica que va a saltar los dos primeros, pero que tome los dos siguientes
            */

            // Para join de listas
            // 1. Creo segunda lista
            List<Persona> lst2 = new List<Persona>()
            {
                new Persona(){Edad = 51, Nombre = "Olga"},
                new Persona(){Edad = 50, Nombre = "Fabio"}
            };

            /*List<string> oLst = (from d in lst
                                 select d)
                                 .Union(lst2)
                                 .OrderBy(d => d.Nombre) // => expresion lambda en donde d es como parametro, y luego de => es el codigo dentro del metodo
                                 .Select(d => d.EdadYNombre())
                                 .ToList();
            */

            // Otra manera de obtener resultado en lista, con subconsultas
            List<string> lstListasOrdenadas = (
                                                from a in
                                                    (from d in lst
                                                     select d)
                                                    .Union
                                                    (from d in lst2
                                                     select d)
                                                orderby a.Nombre
                                                select a.EdadYNombre()
                                                )
                                                .ToList();

            foreach (var o in lstListasOrdenadas)
            {
                Console.WriteLine(o);
            }

            // Si quisiera contar numero de objetos en lista
            int numeroObjetos = lstListasOrdenadas.Count;

            Console.WriteLine("\nNúmero de objetos: " + numeroObjetos);

            Console.ReadKey();
            
        }
    }

}
