using System;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            Enter:
            Console.WriteLine("Введите число: ");
            int cInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(resOutput(cInput));
            Test(cInput);
            goto Enter;
        }

        static void Test (int cInput)
        {
            if (cInput <= 0)
            {
                throw new Exception ("cInput must be positive");
            }
            else
            {
                int b = 0;
                for (int i = 1; i <= cInput; i++)
                {
                    if (cInput % i == 0 && i >= 2)
                    {
                        ++b;

                    }
                }
                 if (b >= 2)
                        {
                            Console.WriteLine("TEST VALID");
                        }
                 else
                {
                    Console.WriteLine($"Число имеет только два делителя: 1 и {cInput}");
                }
                 
                
            }
        }

        static string resOutput(int cInput)
        {
            int d = 0;
            int i = 2;
            Enter:
            if (i < cInput)
            {
                if(cInput % i == 0)
                {
                    d++;
                    i++;
                    goto Enter;
                }
                else
                {
                    i++;
                    goto Enter;
                }
            }
            else
            {
               if(d == 0)
                {
                     
                    return "Простое";
                }
               else
                {

                    return "Непростое";
                }

            }
        }
    }
}
