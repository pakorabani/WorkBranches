﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatisticArray
{
   public static class OptionsManager
    {
        public static int CountLess100(int[] arr)
        {
            return arr.Count(x => x < 100);
        }

        public static int MaxNum(int[] arr)
        {
            return arr.Max();
        }
        
        public static int[] ReverseArr(int[] arr)
        {
            return arr.Reverse().ToArray();
        }
        public static void SortArr(int[] arr)
        {
             Array.Sort(arr);
            Console.WriteLine(string.Join(", ", arr));
        }
        public static void PrintArr(int[]arr)
        {
            Console.WriteLine(string.Join(", ",arr));
        }
        
        public static void PrintOdds(int[]arr)
        {
            foreach (var number in arr)
            {
                if (number % 2 != 0)
                {
                    Console.Write(number + "");
                }
            }
        }

    }
}
