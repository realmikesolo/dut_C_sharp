using System;

namespace laba4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[] { 2, 9, 4, 3, 5, 1, 7 };
            int temp = 0;

            for (int i = 0; i <= intArray.Length - 1; i++)
            {
                for (int j = i + 1; j < intArray.Length; j++)
                {
                    if (intArray[i] > intArray[j])
                    {
                        temp = intArray[i];
                        intArray[i] = intArray[j];
                        intArray[j] = temp;
                    }
                }
            }
            Console.WriteLine("Впорядкований масив за зростанням");

            Console.WriteLine("[{0}]", string.Join(", ", intArray));

            for (int i = 0; i <= intArray.Length - 1; i++)
            {
                for (int j = i + 1; j < intArray.Length; j++)
                {
                    if (intArray[i] < intArray[j])
                    {
                        temp = intArray[i];
                        intArray[i] = intArray[j];
                        intArray[j] = temp;
                    }
                }
            }
            Console.WriteLine("Впорядкований масив за спаданням");
            Console.WriteLine("[{0}]", string.Join(", ", intArray));

        }
    }
}
