using System;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        public static int BinarySearch(int[] inputArray, int searchValue)
        {
            int min = 0;
            int max = inputArray.Length - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (searchValue == inputArray[mid])
                {
                    return mid;                             // N/(2*2*2*2*.....*2)
                }                                           // N/2^X
                else if (searchValue < inputArray[mid])     //2^X = N
                {                                           //log2(2^X) = log2(N)	
                    max = mid - 1;                          //x*log2(2) = log2(N)
                }                                           //x*1 = log2(N)
                else                                        //O(log2(N))
                {
                    min = mid + 1;
                }
            }
            return -1;
        }
    }
}
