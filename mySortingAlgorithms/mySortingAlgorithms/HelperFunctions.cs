using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mySortingAlgorithms
{
    internal static class HelperFunctions
    {

        public static bool IsSorted(int[] arr)
        {

            bool correctlySorted = true;

            int length = arr.Length;

            for (int i = 0; i < (length - 1); i++)
            {

                if (arr[i] > arr[i + 1])
                {
                    correctlySorted = false;
                    break;
                }

            }

            return correctlySorted;
        }

        public static int[] GenerateArray(int length, int minVal, int maxVal)
        {
            Random rand = new Random();

            int[] result = new int[length];

            for (int i = 0; i < length; i++)
            {

                result[i] = rand.Next(minVal, maxVal);

            }

            return result;
        }


    }
}
