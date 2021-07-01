using System;

namespace Task03
{
    class Program
    {
        static void Main(string[] args) // Вычисление чисел последовательности Фибоноччи с помощью рекурсии
        {
            static int Fibfunc(int numFirst, int numSecond, int nFib)
            {
                if (nFib == 0)
                {
                    return numFirst;
                }
                else
                {
                    return Fibfunc(numSecond, numFirst + numSecond, nFib - 1);
                }
                

            }

            static int Fibfunccycle(int numFirst, int numSecond, int nFib) //Вычисление чисел последовательности Фибоноччи с помощью цикла
            {

                int fSum = 0;
                if (nFib == 1)
                {
                    fSum = numFirst;
                    return fSum;
                }
                if (nFib == 2)
                {
                    fSum = numSecond;
                    return fSum;
                }
                else 
                {
                    for (int i = 1; i < nFib; i++)
                    {
                        fSum = numFirst + numSecond;
                        numFirst = numSecond;
                        numSecond = fSum;
                        
                    }
                   return fSum;
                }
               
            }
        

            Console.WriteLine("Введите номер числа из ряда Фибоначчи:");
            int numFib = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Fibfunc(0, 1, numFib));
            Console.WriteLine(Fibfunccycle(0, 1, numFib));

            Console.ReadKey();
        }
    }
}
