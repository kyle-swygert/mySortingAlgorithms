using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mySortingAlgorithms
{
    internal static class MergeSort
    {

        public static int[] Sort(int[] arr)
        {
           
            // base case if array only contains 1 item.
            if (arr.Length <= 1)
            {
                return (int[])arr.Clone();
            }

            // split array into left and right sub arrays
            int mid = arr.Length / 2;

            List<int> leftList = new List<int>();
            List<int> rightList = new List<int>();


            for (int i = 0; i < mid; i++)
            {

                leftList.Add(arr[i]);

            }

            for (int i = mid; i < arr.Length; i++)
            {

                rightList.Add(arr[i]);

            }


            int[] left = leftList.ToArray();
            int[] right = rightList.ToArray();

            // apply Mergesort on both subarrays
            left = Sort(left);
            right = Sort(right);


            // merge the resultant lists and return the result. 

            

            return merge(left, right);
        }

        private static int[] merge(int[] left, int[] right)
        {
            List<int> mergedList = new List<int>();

            int leftInd = 0;
            int rightInd = 0;


            // iterate through both lists at the same time. 
            // compare each current item in each list. Insert the current smaller item into the merged list. 
            while ((leftInd < left.Length) && (rightInd < right.Length))
            {
                if (left[leftInd] <= right[rightInd])
                {
                    mergedList.Add(left[leftInd]);
                    leftInd++;
                }
                else
                {
                    mergedList.Add(right[rightInd]);
                    rightInd++;
                }



            }


            // after loop has been competed. 
            // Known: one of the two lists has had all of their items added to the merged list. 
            // add the rest of the other lists items to the merged list. 

            while (leftInd < left.Length)
            {
                mergedList.Add(left[leftInd]);
                leftInd++;
            }

            while (rightInd < right.Length)
            {
                mergedList.Add(right[rightInd]);
                rightInd++;
            }

            return mergedList.ToArray();
        }

    }
}
