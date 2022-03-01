using System;
using System.Collections.Generic;

namespace ConsoleApp1_pallindromicPartitions
{
    class Program
    {
        //    List<string> pallindromePartiton = new List<String>() {"nitin" };
        //    string[] pallindromepartition = new string[] { "nitin" };

        //   public void ISpallindrome()
        //    {


        //    }
        //   void partitionpallindrome()
        //    {
        //       for (int i=0;i<pallindromepartition.Length;i++)
        //        {




        //        }
        //       foreach(string s in pallindromePartiton)
        //        {

        //        }

        //    }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("enter a string");
            string str = Console.ReadLine();
            //int n = str.Length - 1;
            //string temp = str;
            //char[] chr = str.ToCharArray();
            // Array.Reverse(chr);
            string revstring = string.Empty;



        for (int i=str.Length-1;i>=0;i--)
            {

                 revstring += str[i];
            }

        if (str==revstring)
            {
                Console.WriteLine("Pallindrome");
            }
        else
            {
                Console.WriteLine(" Not Pallindrome ");
            }

            Console.WriteLine("Enter another String");
            string s = Console.ReadLine();
            int n = s.Length - 1;
            int flag = 0;
            for (int i = 0; i < s.Length; i++,n--)
            {
                if (s[i]==s[n])
                {
                    continue;
                }
                else
                {
                    flag = -1;
                    break;
                }
            }

            if (flag==-1)
            {
                Console.WriteLine(" Not Pallindrome");
            }
            else
            {
                Console.WriteLine("pallindrome");
            }


            PrintAllPalindrome.Calculate();

            DiamondPyramid obj = new DiamondPyramid();          
            obj.DiamondPyramidmethod();
        }
    }
}
