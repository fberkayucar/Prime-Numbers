using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Which number's prime numbers would you like to list?: ");
            int numb = Convert.ToInt32(Console.ReadLine());
            int i = 2, j;
            int counter;
            int k = 0;
            while (i <= numb)
            {
                counter = 0;
                j = 2;
                while (j < i)
                {
                    if (i % j == 0)
                    {
                        counter++;
                    }
                    j++;
                }
                if (counter == 0)
                {
                    Console.WriteLine("Prime number = " + i);
                    k++;
                }
                i++;
            }
            Console.WriteLine(k + " prime number were found.");
            Console.WriteLine("\nPress enter to exit...");
            
        }
    }
}
