using System;

namespace ArrayHelper
{
    public class PositiveSum
    {
        public static bool TryCalculation (int[,] array, out int sum)
        {
            sum = 0;
            if (array != null)
            {
                foreach (int number in array)
                {
                    if (number > 0)
                    {
                        sum += number;
                    }
                }
            return true;
            }
            return false;
        }
    }
}