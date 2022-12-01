using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        public static int big(int[] arr, int startIndex, int endIndIndex) 
        {
            int ele = 0;
            for(int i = startIndex; i <= endIndIndex; i++)
            {
                if (ele < arr[i])
                {
                    ele = arr[i];
                }
            }
            return ele;
        }
        public static int small(int[] arr, int startIndex, int endIndIndex)
        {
            int ele = arr[startIndex];
            for (int i = startIndex; i <= endIndIndex; i++)
            {
                if (ele > arr[i])
                {
                    ele = arr[i];
                }
            }
            return ele;
        }
        public static int getIndex(int[] arr, int ele)
        {
            int index = -1;
            for(int i = 0; i<arr.Length; i++)
            {
                if (arr[i] == ele)
                {
                    return i;
                }
            }
            return index;
        }


            public static void rearrange(int[] arr, int n)
        {
            int startInd = 0;
            int lastInd = arr.Length-1;
            int bigEle = 0;
            int smallEle = 0;
            /*int temp = 0;*/
            while(startInd < lastInd)
            {
                bigEle = big(arr, startInd, lastInd);
                smallEle = small(arr, startInd, lastInd);

                arr[getIndex(arr, bigEle)] = arr[startInd];
                arr[startInd] = bigEle;

                arr[getIndex(arr, smallEle)] = arr[startInd+1];
                arr[startInd+1] = smallEle;


                startInd = startInd + 2;
            }

        }
        static void Main(string[] args)
        {
            int[] arr = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 110 };
            rearrange(arr, arr.Length);
            foreach(int ele in arr)
            {
                Console.WriteLine(ele);
            }
        }
    }
}
