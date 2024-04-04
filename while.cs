using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @switch
{
    internal class Program
    {
        static int InputInt(string s)
        {
            Console.Write(s + ":");
            

            return int.Parse(Console.ReadLine());
        }

        static int InputInt(string s, int start, int end)
        {
            string msg = s + "(" + start + "~" + end + ")";
            
            int v = 0;

            while (true)
            {
                v = InputInt(msg);
                if (v >= start && v <= end)
                    break;
                Console.WriteLine("다시 입력해주세요");

            }


            return v;
        }

        static bool CheckPassword(string pass)
        {
            Console.Write("비밀번호:");
            string user = Console.ReadLine();
            return (user == pass);
        }

        static bool CheckPassword2(string pass, int retry)
        {
            for (int i = 1; i<=retry; i++)
            {
                if (CheckPassword(pass))
                {
                    return true;
                }
                if (i != retry)
                Console.WriteLine("재시도 ({0}번 남음)", retry - i);
            }
            return false;
        }

        static bool CheckPassword(string pass, int retry)
        {
            for (int i = 1; i <= retry; i++)
            {
                if (i != 1)
                    Console.WriteLine("재시도 ({0}번 남음)", retry - i +1);

                if (CheckPassword(pass))
                {
                    return true;
                }
                
            }
            return false;
        }

        static void Main(string[] args)
        {
            string p = "pass";
            if (CheckPassword(p, 3))
            {
                Console.WriteLine("통과");
            }
            else
            {
                Console.WriteLine("실패");
            }
        }
    }
}
