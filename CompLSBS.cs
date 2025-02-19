//using System;
//using System.Diagnostics;
//class CompLSBS
//{
//    class BinarySearchEx
//    {
//        static int BSearch(int[] arr, int key)
//        {
//            //Array.Sort(arr);
//            int left = 0, right = arr.Length - 1;
//            while (left <= right)
//            {
//                int mid = (left + right) / 2;
//                if (arr[mid] == key)
//                {
//                    return mid;
//                }
//                if (arr[mid] < key)
//                {
//                    left = mid + 1;
//                }
//                else
//                    right = mid - 1;
//            }
//            return -1;

//        }
//        static int LinearSearch(int[] arr, int key)
//        {
//            for (int i = 0; i < arr.Length; i++)
//            {
//                if (arr[i] == key)
//                    return i;
//            }
//            return -1;
//        }

//        class Program
//        {
//            static void Main(string[] args)
//            {
//                int[] arr = new int[1000000];
//                for (int i = 0; i < arr.Length; i++)
//                {
//                    arr[i] = i;
//                }
//                Stopwatch sw = Stopwatch.StartNew();
//                sw.Start();
//                int resLinear = LinearSearch(arr, 999995);
//                sw.Stop();
//                Console.WriteLine($"time = {sw.ElapsedMilliseconds}");

//                Console.WriteLine(resLinear);
//                Array.Sort(arr);
//                sw.Restart();
//                int resBinary = BSearch(arr, 999995);
//                sw.Stop();
//                Console.WriteLine($"time = {sw.ElapsedMilliseconds}");

//                Console.WriteLine(resBinary);
//            }
//        }
//    }
//}