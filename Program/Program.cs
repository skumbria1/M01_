using System;
using ArrayHelper;
using RectangleHelper;

namespace Program
{
    class Program
    {
        static void BubbleSortOutput(int[] array)
        {
            Console.WriteLine("Original array: ");
            ArraySorter.ArrayOutput(array);
            Console.WriteLine();

            if (ArraySorter.TryBubbleSort(array, true))
            {
                Console.WriteLine("Array after bubble sort (ascending): ");
                ArraySorter.ArrayOutput(array);
                Console.WriteLine();
            }

            if (ArraySorter.TryBubbleSort(array, false))
            {
                Console.WriteLine("Array after bubble sort (descending): ");
                ArraySorter.ArrayOutput(array);
                Console.WriteLine();
            }
        }

        static void PositiveSumOutput(int[,] array)
        {
            int sum;
            if (PositiveSum.TryCalculation(array, out sum))
            {
                Console.WriteLine("Original two-dimensional array: ");
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        Console.Write(array[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("Sum of all positive elements is " + sum);
            }
        }

        static void RectangleCalculationOutput(int width, int height)
        {
            Console.WriteLine("Rectangle is " + width + " x " + height);
            Console.WriteLine("Perimeter is " + RectangleCalculation.Perimeter(width, height));
            Console.WriteLine("Square is " + RectangleCalculation.Square(width, height));
        }

        static void Main (string[] args)
        {
            int[] array1 = new int[] { 4, 5, 3, 1, 2, 3, 10, 14, -2, 5, 0, 26, -16};
            BubbleSortOutput(array1);
            Console.WriteLine("\n");

            int[,] array2 = new int[4, 2] { { 9, 999 }, { 3, 33 }, { 5, 55 }, { 4, 17 } };
            PositiveSumOutput(array2);
            Console.WriteLine("\n");

            int width = 5, height = 7;
            RectangleCalculationOutput(width, height);
        }
    }
}
