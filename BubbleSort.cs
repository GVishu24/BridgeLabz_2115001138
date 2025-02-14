//using System;


//namespace SortingAlgo
//{
//    class BubbleSort
//    {
//        public static void Sort(int[] arr)
//        {
//            int n = arr.Length;
//            bool swapped;

//            for (int i = 0; i < n - 1; i++)
//            {
//                swapped = false;

//                for (int j = 0; j < n - i - 1; j++)
//                {
//                    if (arr[j] > arr[j + 1])
//                    {
//                        (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
//                        swapped = true;
//                    }
//                }
//                if (!swapped)
//                    break;
//            }
//        }
//        class Program
//        {
//            static void Main()
//            {
//                int[] arr = { 97, 85, 76, 95, 36, 55, 67, 25 };
//                Sort(arr);
//                Console.WriteLine("sorted marks= ");
//                foreach (int k in arr)
//                {
//                    Console.Write(k+ " ");
              
//                } 
//            }
//        }
//    }
//}



