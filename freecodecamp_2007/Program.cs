using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freecodecamp_2007
{
    class Program
    {
        public static int pairwise(int[] arr, int result)
        {
            int neededNumber;
            int neededNumberIndex;
            int sum = 0;
            Dictionary<int, int> numPairs = new Dictionary<int, int>();
            for(int i = 0; i < arr.Length; i++)
            {
                neededNumber = result - arr[i];
                if(numPairs.ContainsKey(neededNumber))
                {
                    neededNumberIndex = numPairs[neededNumber];
                    sum = sum + (i + neededNumberIndex);
                    continue;
                }
                if (!numPairs.ContainsKey(arr[i]))
                {
                    numPairs.Add(arr[i], i);
                }
            }
            return sum;
        }

        static void Main(string[] args)
        {
            //result: 6
            //int[] numbers = { 7, 9, 11, 13, 15 };
            //int sum = pairwise(numbers, 20);

            //result: 2
            //int[] numbers = { 1, 1, 2 };
            //int sum = pairwise(numbers, 3);

            // Case 1
            //result: 11
            //int[] numbers = { 1, 4, 2, 3, 0, 5 };
            //int sum = pairwise(numbers, 7);

            // Case 2
            //result: 1
            //int[] numbers = { 1, 3, 2, 4 };
            //int sum = pairwise(numbers, 4);

            // Case 3
            //result: 1
            //int[] numbers = { 1, 1, 1 };
            //int sum = pairwise(numbers, 1);

            // Case 4
            //result: 10
            int[] numbers = { 0, 0, 0, 0, 1, 1 };
            int sum = pairwise(numbers, 1);

            //result: 0
            // Case 5
            //int[] numbers = { };
            //int sum = pairwise(numbers, 100);

            Console.WriteLine($"{sum}");
            Console.ReadKey();
        }
    }
}
