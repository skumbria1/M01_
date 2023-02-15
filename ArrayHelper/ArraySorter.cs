using System;

namespace ArrayHelper
{
    public class ArraySorter
    {
        public static bool TryBubbleSort (int[] array, bool ascending) 
            // ascending: true - ascending, false - descending
        {
            if (array != null)
            {
                var target = ascending ? 1 : -1;
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = 0; j < array.Length - i - 1; j++)
                    {
                        if (Math.Sign(array[j].CompareTo(array[j + 1])) == target)
                        {
                            int t = array[j];
                            array[j] = array[j + 1];
                            array[j + 1] = t;
                        }
                    }
                }
                return true;
            }
            return false;
        }

        public static void ArrayOutput (int[] array)
        {
            foreach (int number in array)
            {
                Console.Write(number + " ");
            }
        }
    }
}
