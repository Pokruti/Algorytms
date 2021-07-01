using System;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        public static int StrangeSum(int[] inputArray)
        {
            int sum = 0;
            for (int i = 0; i < inputArray.Length; i++)  // O(N)
            {
                for (int j = 0; j < inputArray.Length; j++) // O(N)
                {
                    for (int k = 0; k < inputArray.Length; k++) // O(N)
                    {
                        int y = 0;

                        if (j != 0)
                        {
                            y = k / j;                      
                        }

                        sum += inputArray[i] + i + k + j + y; 
                    }
                }
            }

            return sum; // O(1)
        }

        //Общая производительность алгоритма составит O(N^3 +1)
    }
}
