using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    internal class Program
    {
        static bool is_yoon(int y)
        {
            return (y % 4 == 0 && y % 100 != 0) || y % 400 == 0;
        }

        static bool is_yoon2(int y)
        {
            if (y % 4 != 0) return false;
            if (y % 400 == 0) return true;
            if (y % 100 == 0) return false;
            return true;
        }

        static int wd_1_1(int y)
        {
            // 1900년 1월 1일은 월요일(1)
            int wd = 1 + (y - 1900);   //이건 윤년 X
            for(int i = 1904; i < y; i += 4)   // 이건 윤년 더해주는거
            {
                if (is_yoon(i)) wd++;
            }
            return wd % 7;
        }

        static int[] m_days = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};

        static int wd_month(int m)
        {
            int wd = 0;
            for (int i = 1; i< m; i++)
            {
                wd += m_days[i];
            }
            return wd % 7;
        }

        static void calendar(int y, int m)
        {
            bool yoon = is_yoon(y);

            int wd = wd_1_1(y) + wd_month(m);
            if (m > 2 && yoon) wd++;
            wd %= 7;

            int w = 0;
            int days = m_days[m];
            if (m == 2 && yoon) days++;
            string[,] cal = new string[6, 7];

            for (int i = 1; i <=days; i++)
            {
                cal[w, wd] = i.ToString();
                if (++wd > 6)
                {
                    wd = 0;
                    w++;
                }
            }
            Console.WriteLine(" 일 월 화 수 목 금 토");

            for (int i = 0;i<6 ; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    Console.Write($"{cal[i, j],3}");
                }
                Console.WriteLine();
            }

        }

        static void Main(string[] args)
        {
            calendar(2024, 4);
        }
    }
}
