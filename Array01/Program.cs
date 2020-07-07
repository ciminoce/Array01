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
            Random r=new Random();
            #region Llenado del vector
            for (int i = 0; i < 10; i++)
            {
                celsius[i] = r.Next(1,25);
                //Console.WriteLine($"{celsius[i]}");
            }
            #endregion
            #region Calculo del promedio
            for (int i = 0; i < 10; i++)
            {
                tempPromedio += celsius[i];
            }
            tempPromedio = tempPromedio / 10;

            Console.WriteLine($"El promedio es {tempPromedio}");
            #endregion
            #region Mostrar Información final
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(celsius[i] > tempPromedio ? $"{celsius[i]}*" : $"{celsius[i]}");
            }
            #endregion
            Console.ReadLine();
        }
    }
}
