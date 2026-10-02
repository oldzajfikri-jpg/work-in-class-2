using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work_in_class_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i<= 5; i++)
            {
               if (i % 2 == 0)
                {

                    int N = int.Parse(Console.ReadLine());
                    Console.Write("Enter a number: ");

                    sum = sum + N;

                }
                

                }
            }

        }
    }

