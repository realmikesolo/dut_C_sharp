using System;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {



            Random rnd = new Random();

            Console.WriteLine("Введіть 1 цифру: ");
            string a = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Введіть 2 цифру: ");
            string b = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Введіть 3 цифру: ");
            string c = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Введіть 4 цифру: ");
            string d = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Отримане число: ");

            if (a == c && b == d)
            {
                Console.WriteLine("Сума двох перших цифр даного чотиризначного числа рівна сумі двох його останніх цифр");
            }
            else
            {
                Console.WriteLine("Сума двох перших цифр даного чотиризначного числа не рівна сумі двох його останніх цифр");
            }

        }
    }
}