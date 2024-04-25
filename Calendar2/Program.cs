using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar2
{
    internal class Program
    {
        static bool is_yoon(int y)  // 연도가 윤년인지 확인하는거. 윤년이면 true
        {
            return (y % 4 == 0 && y % 100 != 0) || y % 400 == 0;
        }

        static int wd_1_1(int y)  // 연도별 1월 1일 요일 구하는거
        {
            int wd = 1 + (y - 1900);
            for (int i = 1904; i<y; i += 4)
            {
                if (is_yoon(i)) wd++;
            }
            return wd % 7;
        }

        static int[] m_days = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 }; // 평년 월의 일 수
        static int[] m_days_yoon = { 0, 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 }; // 윤년 월의 일수


        static int wd_month(int m, int[] days)   //월의 1일 요일 구하는거
        {
            int wd = 0;

            for(int i = 1; i<m; i++)
            {
                wd += days[i];
            }
            return wd % 7;
        }

        static void calendar(int y, int m)   // 달력 만드는거
        {
            bool yoon = is_yoon(y);   // 불 타입 yoon을 만들었는데 y가 윤연이니??
            int[] m_days = yoon ? Program.m_days_yoon : Program.m_days;   // 맞으면 앞에꺼 아니면 뒤에꺼

            // 연도 1월 1일 요일을 구하고 월의 날짜수를 더해서 요일구하기
            int wd = (wd_1_1(y) + wd_month(m, m_days)) % 7;  


            int days = m_days[m];
            int w = 0;

            string[,] cal = new string[6, 7];

            for (int i = 1; i<=days; i++)
            {
                cal[w, wd] = i.ToString();
                if(++wd > 6)
                {
                    wd = 0;
                    w++;
                }
            }


            Console.WriteLine(" 일 월 화 수 목 금 토");
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j <7; j++)
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
