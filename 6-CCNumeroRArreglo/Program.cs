using System;
using System.Collections;
using System.Linq;
using C = System.Console;

namespace _6_CCNumeroRArreglo
{
    /// Practica 5
    /// 6.- Encontrar cuántos y cuál es el número que se repite más veces en un arreglo.

    /// Chávez Pérez Melissa
    /// #M21210035
    class Program
    {

        static void Main(string[] arg)
        {

            C.BackgroundColor = ConsoleColor.Blue;
            C.ForegroundColor = ConsoleColor.White;
            int occurences = 0;
            int[] array =  { 3, 6, 8, 5, 3, 5};  
             bool repetidos = false;
             for(var x=0; x<array.Length; x++)
             {
                 int a = array[x];
                 int c = x + 1;
               

                for(int y=c; y<array.Length; y++)
                 {
                     int b = array[y];
                     if(a==b)
                    {
                         repetidos = true;
                        occurences++;

                        C.WriteLine("El  numero " + a + " esta repetido en la lista" + " y aparece " + occurences + " veces");
                
                     
                        }
                 }
             }
             if (repetidos == false)
                 C.WriteLine("No hay numeros repetidos en la lista");

            C.ReadLine();
        }
    }
}
