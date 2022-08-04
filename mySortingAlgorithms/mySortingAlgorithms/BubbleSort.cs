using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mySortingAlgorithms
{
    internal static class BubbleSort
    {

        public static int[] Sort(int[] arr)
        {

            int[] result = (int[])arr.Clone();

            // each iteration of the outer loop 'bubbles' the largest item to the largest sub-array index. 
            for (int i = 0; i < result.Length; i++)
            {

                // each iteration of the inner loop compares the two indexes next to each other and swaps them if the smaller index holds the larger value. 
                for (int j = 0; j < (result.Length - i - 1); j++)
                {

                    if (result[j] > result[j + 1])
                    {
                        int temp = result[j];

                        result[j] = result[j + 1];

                        result[j + 1] = temp;

                    }


                }

            }

            /*
                Notes:
            
                For every iteration of the outer loop, all the indexes of the sub-array are checked in the inner loop, causing all indexes of the current sub-array to be accessed and checked each time the outer loop is run. (Not sure if this makes correct sense...) This causes the sorting algorithm to have a time efficiency of O(n^2). 

                Best Case efficiency is when the array is already sorted. 
                Worst Case efficiency is when the array is sorted in reverse order. 
             
             
             
             
             */


            return result;
        }


    }
}
