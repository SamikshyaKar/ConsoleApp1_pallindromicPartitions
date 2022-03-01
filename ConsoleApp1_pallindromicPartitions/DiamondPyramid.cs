using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_pallindromicPartitions
{
   public  class DiamondPyramid
    {
        int i, j, N;

        public void DiamondPyramidmethod()
        {
            Console.WriteLine("Enter the Number of Rows ");
            N = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i <= N; i++)
            {
                for (j = 1; j <= N - i; j++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= i; j++)
                {
                    Console.Write("{0}", j);
                }
                for (j = i - 1; j >= 1; j--)
                {
                    Console.Write("{0}", j);
                }
                Console.Write("\n");
            }
        }

            public void DiamondPyramidmethodFull()
            {
                Console.WriteLine("Enter the Number of Rows ");
                N = Convert.ToInt32(Console.ReadLine());

                for (i = 0; i <= N; i++)
                {
                    for (j = 1; j <= N - i; j++)
                    {
                        Console.Write(" ");
                    }
                    for (j = 1; j <= i; j++)
                    {
                        Console.Write("{0}", j);
                    }
                    for (j = i - 1; j >= 1; j--)
                    {
                        Console.Write("{0}", j);
                    }
                    Console.Write("\n");
                }

                for (i = N-1; i >=1; i--)
                {
                    for (j = 1; j <= N - i; j++)
                    {
                        Console.Write(" ");
                    }
                    for (j = 1; j <= i; j++)
                    {
                        Console.Write("{0}", j);
                    }
                    for (j = i - 1; j >= 1; j--)
                    {
                        Console.Write("{0}", j);
                    }
                    Console.Write("\n");
                }

            }





        }
}
