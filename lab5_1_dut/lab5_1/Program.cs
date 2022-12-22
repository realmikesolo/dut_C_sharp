using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace laba5_1
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] arr = {
                {10, 20, 15, 14, 13, 25, 5, 4, 3 },
                {10, 20, 15, 14, 13, 25, 5, 4, 3 },
                {10, 20, 15, 14, 13, 25, 5, 4, 3 }
            };



            int m = arr.GetLength(0) - 1;
            int n = arr.GetLength(1) - 1;

            for (int i = 0; i <= m; i++)
            {
                if (arr[i, 0] < arr[i, 1])
                {
                    arr[i, 0] = 0;

                }
                for (int j = 1; j < n; j++)
                {
                    if ((arr[i, j - 1] > arr[i, j]) && (arr[i, j] < arr[i, j + 1]))
                    {
                        arr[i, j] = 0;
                    }
                }
                if (arr[i, n] < arr[i, n - 1])
                {
                    arr[i, n] = 0;
                }
            }

            for (int a = 0; a <= m; a++)
            {
                for (int b = 0; b <= n; b++)
                {
                    Console.Write(arr[a, b] + " ");
                }
                Console.Write("\n");
            }


        }
    }
}