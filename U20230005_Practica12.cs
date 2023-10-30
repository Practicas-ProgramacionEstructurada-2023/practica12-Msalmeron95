using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {
            //POBLADO DE ARREGLOS

            //"Realizar la declaracion de dos arreglos uno que represente apellidos y otro con edades"
            //

            string [] apellidos = { "Argueta", "Zelaya",  "Contreras", "Guevara", "Martinez"};

            int [] edades = new int[5];

            edades[0]=27;
            edades[1]=29;
            edades[2]=25;
            edades[3]=43;
            edades[4]=15;

    
            //LECTURA DE ARREGLOS 

            //Almacenar en dos variables la posicion 1 posicion 4 de los arreglos.

            string primerPosicion = apellidos[0]; //Argueta
            string cuartaPosicion = apellidos[3]; //Guevara

            int primeraEdad = edades[0]; //27
            int cuartaEdad = edades[3]; //43

            //ORDENAMIENTO DE ARRGLOS
            //Array.Sort(arreglo); y Array.Reverse(arreglo);
            //Ordenar los arreglos de manera ascendeten apellidos y edades descendente

            Array.Sort(apellidos);

            Array.Sort(edades);
            Array.Reverse(edades);

            //IMPRESION DE RESULTADOS

            Console.WriteLine("----------------------------------");
            Console.WriteLine("Imprimiendo valores de posiciones  en arreglos\n");
            Console.WriteLine("Posicion 1 en arreglo Apellido >> " + primerPosicion);
            Console.WriteLine("Posicion 4 en arreglo Apellido >> " + cuartaPosicion);
            Console.WriteLine("\nPosicion 1 en arreglo Edades >> " + primeraEdad);
            Console.WriteLine("Posicion 4 en arreglo Edades >> " + cuartaEdad);      
            Console.WriteLine("----------------------------------\n\n");
    
            Console.WriteLine("Valores de arreglo Apellidos de forma ascendente");

            foreach (string apellido in apellidos)
            {
                Console.WriteLine(apellido);
            }
            Console.WriteLine("\nValores de arreglo de forma decente");

            foreach (int edad in edades)
            {
                Console.WriteLine(edad);
            }

        }
    }
}
