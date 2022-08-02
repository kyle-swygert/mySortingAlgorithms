

namespace mySortingAlgorithms
{


    class SortingAlgorithms
    {

        static void Main(string[] args)
        {


            Console.WriteLine("Goblin Gaming Master");

            // initialize program


            // generate arrays to sort. arrays will be randomly generated with values between -10,000 and 10,000

            Random rand = new Random();


            // 10 items
            int[] ten = HelperFunctions.GenerateArray(10, -10000, 10000);


            // 100 items
            int[] hundred = HelperFunctions.GenerateArray(100, -10000, 10000);


            // 1000 items
            int[] thousand = HelperFunctions.GenerateArray(1000, -10000, 10000);


            // sort the arrays using all the sorting algorithms. 
            // time each execution of sorting for a comparison to other algorithms. 

            // TODO: implement timing feature of program. 



            int[] bubble10 = BubbleSort.Sort(ten);
            int[] bubble100 = BubbleSort.Sort(hundred);
            int[] bubble1000 = BubbleSort.Sort(thousand);


            int[] merge10 = MergeSort.Sort(ten);
            int[] merge100 = MergeSort.Sort(hundred);
            int[] merge1000 = MergeSort.Sort(thousand);


            int[] quick10 = QuickSort.Sort(ten);
            int[] quick100 = QuickSort.Sort(hundred);
            int[] quick1000 = QuickSort.Sort(thousand);


            // check that all arrays are sorted
            // TODO: Implement checking arrays


            // display and compare sorting times for all algorithms. 
            // TODO: Implement comparison of sorting times

        }




    }



}
