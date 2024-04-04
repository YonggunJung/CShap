using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace @switch
{
    internal class Program
    {
        static int Max(int[] arr)
        {
            int m = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (m < arr[i])
                    m = arr[i];
            }

            return m;
        }

        static int Min(int[] nums)
        {
            int m = nums[0];
            foreach(int n in nums)
            {
                if (m > n)
                {
                    m = n;
                }
            }

            return m;
        }

        static string OddOrEven(int n)
        {
            string s = "";
            if (n % 2 == 0)
            {
                s = "짝수";
            }
            else
            {
                s = "홀수";
            }
            return s;
        }


        static string OddOrEven2(int n)
        {
            string s = "";
            if (n % 2 == 0)
            {
                return "짝수";
            }
            else
            {
                return "홀수";
            }
        }

        static string OddOrEven3(int n)
        {
            string s = "";
            if (n % 2 == 0)
            {
                return "짝수";
            }

            return "홀수";
        }

        static string OddOrEven4(int n)
        {
            //3항 연산자
            // 참/거짓 ? 참값 : 거짓값
            //string r = n % 2 == 0 ? "짝수" : "홀수";
            //string r = (n % 2 == 0) ? "짝수" : "홀수";
            return (n % 2 == 0) ? "짝수" : "홀수";
        }


        static void Main(string[] args)
        {
            int[] a = { 14, 33, 3, 20, 5, 17, 7, 8, 9, 10 };
            Console.WriteLine(Max(a));
            Console.WriteLine(Min(a));
            Console.WriteLine(OddOrEven4(10));
            Console.WriteLine(OddOrEven4(9));
        }
    }
}
