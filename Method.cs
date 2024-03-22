using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class Calc
    {
        public static int Plus(int a, int b)
        {
            Console.WriteLine(a + " " + b);
            int res = a + b;


            return res;
        }
    }
    internal class Program
    {
        static int Minus(int a, int b)
        {


            return a - b;
        }

        static void PrintProfile(string name, string phone)
        {
            if (name == "" || name == null)
            {
                return;
            }
            Console.WriteLine(name + " " + phone);
        }

        static void Main(string[] args)
        {

            int s = Calc.Plus(1, 2);
            Console.WriteLine(s);
            Console.WriteLine(Calc.Plus(3, 4));

            Console.WriteLine(Minus(1, 2));

            string n = null;  // 문자열 객체가 아직 없음

            PrintProfile("홍길동", "010-1234-5678");
            PrintProfile("", "010-9876-5432");
            PrintProfile(n, "010-9876-5432");
        }
    }
}
