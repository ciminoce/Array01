using System;
using System.Runtime.InteropServices.ComTypes;

namespace Array01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title="Primer ejemplo de Array";
            int[] celsius=new int[10];//Defino un vector de enteros de 10 elementos
            double tempPromedio = 0;
            Random r=new Random();//Defino un objeto de tipo random
            #region Llenado del vector
            /*Ciclo para el llenado del vector
             con números generados al azar entre 1 y 24*/
            for (int i = 0; i < 10; i++)
            {
                /*Asigno en la posición que va indicando
                 la variable i del vector celsius el nro generado al azar*/
                celsius[i] = r.Next(1,25);
                //Console.WriteLine($"{celsius[i]}");
            }
            #endregion
            #region Calculo del promedio
            /*Ciclo para recorrer el vector
             e ir acumulando las temperaturas*/
            for (int i = 0; i < 10; i++)
            {
                tempPromedio += celsius[i];//Tomo la temperatura del elemento indicado por la variable i
            }
            tempPromedio = tempPromedio / 10;

            Console.WriteLine($"El promedio es {tempPromedio}");
            #endregion
            #region Mostrar Información final
            /*Ciclo para recorrer el vector
             e ir mostrando su contenido, se evalúa si
            el valor del elemento i del vector es superior 
            al promedio de temperaturas hallado anteriormente*/
            for (int i = 0; i < 10; i++)
            {
                /*Si es superior al promedio, se muestra con un asterisco*/
                Console.WriteLine(celsius[i] > tempPromedio ? $"{celsius[i]}*" : $"{celsius[i]}");
            }
            #endregion
            Console.ReadLine();
        }
    }
}
