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

        static int wd11(int y)
        {
            int wd = 1 + y - 1900;
            for (int i = 1904; i<y; i += 4)
            {
                if (is_yoon(i)) wd++;
            }
            return wd % 7;
        }

        static int[] m_days = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        static int[] m_days_y = { 0, 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        static int wdm1(int m, int[] m_days)
        {
            int wd = 0;
            for (int i = 1; i<m; i++)
            {
                wd += m_days[i];
            }
            return wd % 7;
        }

        public static void calendar(int y, int m)
        {
            bool yoon = is_yoon(y);
            int[] m_days = yoon? Program.m_days_y: Program.m_days;

            int wd = (wd11(y) + wdm1(m, m_days)) % 7;

            int days = m_days[m];
            int w = 0;

            string[,] cal = new string[6, 7];

            for (int i = 1; i <=days; i++)
            {
                cal[w, wd] = i.ToString();
                if(++wd > 6)
                {
                    wd = 0;
                    w++;
                }
            }

            Console.WriteLine(" 일 월 화 수 목 금 토");
            for (int i = 0; i<6;i++)
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
            calendar(2024, 5);
            
        }
    }
}
