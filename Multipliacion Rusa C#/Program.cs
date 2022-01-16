using System;

namespace MultiplicacionRusa_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            int multiplicador;
            int multiplicando;
            int res = 0;

            Console.WriteLine("Introduzca su multiplicador");
            multiplicador = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca su multiplicando");
            multiplicando = int.Parse(Console.ReadLine());

            ElapsedTime timer = new ElapsedTime();
            timer.startTimeMeasure();

            while (multiplicador != 0)
            {
                if ((multiplicador % 2) == 1)
                {
                    res = res + multiplicando;
                }
                multiplicando = multiplicando * 2;
                multiplicador = (multiplicador / 2);
                //Console.WriteLine("multiplicador    multiplicando");
                //Console.WriteLine(multiplicador + "  " + multiplicando);
            }
            Console.WriteLine("El resultado es: " + res);

            timer.endTimeMeasure();
            Console.WriteLine("Tiempo de ejecucion: " + timer.getElapsedTime().TotalMilliseconds + " milisegundos");
        }
    }
}
