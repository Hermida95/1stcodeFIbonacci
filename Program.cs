using System;

namespace PACDesarrollo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bucle para que no se pare
            while (true) 
            {
                // Pedir el nº de cifras de Fibonacci, leerlo y convertirlo a un entero 
                Console.Write("\nIntroduce un número entero entre 7 y 22:");
                 
                 string respuesta = Console.ReadLine();
                 int n;

                 bool rbien = int.TryParse (respuesta, out n);


                 //Comprobamos que esté entre los valores requeridos
                 if (rbien && n>=7 && n<=22)
                  {
                    // Si el número es válido, generamos la secuencia de Fibonacci y la mostramos en ambos sentidos con el numero de cifras pedido
                    Console.WriteLine("Secuencia de Fibonacci:");

                    //Fibonacci 
                     int[] fibonacci = new int[n]; 

                     fibonacci[0] = 0;
                     fibonacci[1] = 1;
                      for (int i = 2; i < n; i++)
                      {
                         fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
                      }
                         for (int i = 0; i < n; i++)
                          {
                           Console.Write(fibonacci[i] + " ");
                          }
                    
                     //GenerarFibonacciInvertido(numero);

                           Console.WriteLine("\nSecuencia de Fibonacci en orden inverso:");
                     
                            for (int i = n - 1; i >= 0; i--)
                            {
                             Console.Write(fibonacci[i] +  " ");
                            }

                            // Salir del bucle ya que la entrada es válida
                             break;
                  }

                else
                {
                    // Mensaje de error y repetimos el proceso
                    Console.WriteLine("Error: Debes introducir un número entero entre 7 y 22. Intentalo de nuevo.");
                }
            }
        }

        
    }
}
