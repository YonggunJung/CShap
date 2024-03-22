using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("s");
        }
        static void 구구단(string[] args)
        {
            int d = 9;
            for (int i = 1; i<=d; i++)
            {
                Console.WriteLine("{0} 단", i);
                for (int j = 1; j <= d; j++)
                {
                    Console.WriteLine("{0} x {1} = {2, 2}", i, j, i * j);
                }
            }
            
        }
        static void 리버스별찍기(string[] args)
        {
            int n = 5;
            for (int i = 5; i>=1; i--)
            {
                //Console.Write(i);
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                    
                }
                Console.WriteLine();
            }
            for (int i = 1; i <= n; i++)
            {
                //Console.WriteLine(i);
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


        }
        static void 별찍기(string[] args)
        {
            int n = 5;
            for (int i = 1; i<=n; i++)
            {
                //Console.WriteLine(i);
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
        static void 성적표오류(string[] args)
        {
            int score = 95;
            string grade = "";
            if (score >= 60)
            {
                grade = "D";
            }
            else if (score >= 70)
            {
                grade = "C";
            }
            else if (score >= 80)
            {
                grade = "B";
            }
            else if (score >= 90)
            {
                grade = "A";
            }
            else if (score >= 95)
            {
                grade = "A+";
            }
            else
            {
                grade = "F";
            }
            Console.WriteLine(grade);
        }
        static void 성적표(string[] args)
        {
            int score = 95;
            string grade = "";
            if (score >= 95)
            {
                grade = "A+";
            }
            else if (score >= 90)
            {
                grade = "A";
            }
            else if (score >= 80)
            {
                grade = "B";
            }
            else if (score >= 70)
            {
                grade = "C";
            }
            else if (score >= 60)
            {
                grade = "D";
            }
            else
            {
                grade = "F";
            }
            Console.WriteLine(grade);
        }
        static void 원넓이(string[] args)
        {
            Console.Write("r:");
            int r = int.Parse(Console.ReadLine());

            double a = r * r * 3.14;
            Console.WriteLine(a);
        }
        static void 삼각형넓이(string[] args)
        {
            Console.Write("w:");
            string s = Console.ReadLine();
            int w = int.Parse(s);


            Console.Write("h:");
            s = Console.ReadLine();
            int h = int.Parse(s);

            double a = w * h * 0.5;
            Console.WriteLine(a);
        }
    }
}
