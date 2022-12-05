using System;

namespace laba2
{
    class Program
    {
        static void Main(string[] args)
        {
            int nn = 0;
            int nk = 0;
            int k = 0;
            double result = 0;


            Console.Write("Введіть значеня NN= ");
            string strnn = Console.ReadLine();
            int.TryParse(strnn, out nn);


            Console.Write("Введіть значення NK= ");
            string strnk = Console.ReadLine();
            int.TryParse(strnk, out nk);
            if (nk < nn)
            {
                Console.WriteLine("Помилка введення");
                Console.ReadLine();
                return;
            }

            for (k = nn; k < nk; k++)
            {
                result += Math.Pow(k, 2) + Math.Pow((-1), k - 1) * 2 * k - 1 / (Math.Pow(k, 2) + 8);
            }


            Console.WriteLine($"Результат ={result:n2} {result} nn = {nn} nk = {nk}");
            Console.ReadLine();
        }
    }
}