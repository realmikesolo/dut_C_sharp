using System;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {

            double pi = 3.141592;
            double t = 2;


            Console.WriteLine("Введіть довжину маятника:");
            double l = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Висота = " + l);
            Console.WriteLine();

            Console.WriteLine("Прискорення сили тяжіння:");
            double g = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Прискорення = " + g);
            Console.WriteLine();


            double dif = (l / g);

            Console.WriteLine("Період коливання маятника = " + t * pi * Math.Sqrt(dif));



        }
    }
}