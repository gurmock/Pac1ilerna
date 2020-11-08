using System;
using System.Security.Cryptography.X509Certificates;

namespace PAC_desarrollo_UF1
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Declaro las variables fila y colum y pido al usuario que introduzca el numero de filas y columnas
             Tambien declaro una variable booleana para comparar las matrices*/
            bool iguales = true;
            int fila1, colum1;
            Console.WriteLine("Escribe el numero de filas de la primera matriz");
            fila1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Escribe el numero de filas de la primera matriz");
            colum1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"La primera matriz tiene {fila1} filas y {colum1} columnas");

            int fila2, colum2;
            Console.WriteLine("Escribe el numero de filas de la segunda matriz");
            fila2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Escribe el numero de filas de la segunda matriz");
            colum2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"La segunda matriz tiene {fila2} filas y {colum2} columnas");

            //Como valor de la matriz uso las variables en las que el usuario indica el numero de filas y columnas que quiere.
            int[,] matriz1 = new int[fila1, colum1];
            int[,] matriz2 = new int[fila2, colum2];

            // Con este bucle for recorremos la matriz ingresando los valores de esta.
            Console.WriteLine("Introduce los datos de la primera matriz");

            for (int i = 0; i < matriz1.GetLength(0);i ++)
            { 
                for (int x = 0;x < matriz1.GetLength(1);x++)
                {
                    Console.WriteLine($"Introduce el valor para la posicion {i} Fila y {x} Columna de la primera matriz");
                    matriz1[i, x] = Int32.Parse(Console.ReadLine());
                }
            }


            //Repetimos el bucle para la segunda matriz
            Console.WriteLine("Introduce los datos de la segunda matriz");


            for (int i = 0; i < matriz2.GetLength(0); i++)
            {
                for (int x = 0; x < matriz2.GetLength(1); x++)
                {
                    Console.WriteLine($"Introduce el valor para la posicion {i} Fila y {x} Columna de la segunda matriz");
                    matriz2[i, x] = Int32.Parse(Console.ReadLine());
                }
            }

            //Ahora con oto bucle for vamos a comprobar los valores de la matriz

            for (int i = 0; i < matriz1.GetLength(0); i++)
            {
                for (int x = 0; x < matriz1.GetLength(1); x++) 
                {
                    Console.WriteLine($"En la posicion{i},{x} De la primera matriz esta el numero {matriz1[i,x]}");
                }
            }

            Console.WriteLine("Fin de la primera matriz");

            //Repetimos el bucle para mostrar los valores de la segunda matriz
            for (int i = 0; i < matriz2.GetLength(0); i++)
            {
                for (int x = 0; x < matriz2.GetLength(1); x++)
                {
                    Console.WriteLine($"En la posicion{i},{x} De la segunda matriz esta el numero {matriz2[i, x]}");
                }
            }

            Console.WriteLine("Fin de la segunda matriz");

            //Con Este if vamos a comprobar si las matrices se pueden comparar.

            if (matriz1.GetLength(0) == matriz2.GetLength(0) && matriz1.GetLength(1) == matriz2.GetLength(1))
            {
                Console.WriteLine("Las matrices son iguales por lo que se pueden comparar.");
                //Como si se cumple esta condicion significa que las matrices son iguales y las podemos comparar vamos a hacerlo con un bucle for
                for (int i = 0; i < matriz1.GetLength(0);i++) 
                {
                    for (int x = 0; x < matriz1.GetLength(1);x++) 
                    {
                        if (matriz1[i,x] != matriz2[i,x]) 
                        {
                            iguales = false;
                        }
                    }
                }
                //Ahora vamos con la variable iguales vamos a indicar si las matrices son iguales.
                if (iguales)
                {
                    Console.WriteLine("Las matrices son iguales");
                }
                else
                    Console.WriteLine("Las matrices no son iguales");

            }
            else

                Console.WriteLine("Las matrices no se pueden comparar");
        }
    }
}
 