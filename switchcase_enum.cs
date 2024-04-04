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
        // 1  2  3  4  5  6  7  8  9  10 11 12
        // 31 28 31 30 31 30 31 31 30 31 30 31
        static int MonthDaysArray(int m)
        {
            if (!(m >= 1 && m<=12))
            {
                return 0;
            }
            /*int[] days= { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            return days[m];*/

            int[] days = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            return days[m-1];
        }
        static int MonthDaysSwitch1(int m)
        {
            int days = 0;
            switch (m)
            {
                case 2:
                    days = 28;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    days = 30;
                    break;
                default:
                    days = 31;
                    break;
            }

            return days;
        }
        static int MonthDaysSwitch2(int m)
        {
            switch (m)
            {
                case 2:
                    return 28;    // return을 바로쓰면 break가 필요 없다.
                case 4:
                case 6:
                case 9:
                case 11:
                    return 30;

            }
            return 31;
        }
        static int MonthDaysIf(int m)
        {
            if (m == 2)
            {
                return 28;
            }
            if (m == 4 || m == 6 || m == 9 || m == 11) 
            {
                return 30;
            }
            return 31;
        }

        static Char Weekday(int d)
        {
            if (d<1|| d > 7)
            {
                return ' ';
            }
            string s = "월화수목금토일";
            return s[d - 1];
        }
        static string Weekday2(int d)
        {
            if (d < 1 || d > 7)
            {
                return "";
            }
            string[] s = {"월요일", "화요일" , "수요일" , "목요일" , "금요일" , "토요일" , "일요일" };
            return s[d - 1];
        }

        enum Category 
        { 
            Cake, IceCream, Bread
        }

        enum City
        {
            Seoul = 2,
            Daejun,
            Busan = 51,
            Jeju = 10
        }
        static void EnumTest()
        {
            City myCity;
            myCity = City.Busan;

            int local_number = (int)myCity;

            Console.WriteLine("0" + local_number);


        }

        enum WeekDay
        {
            Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
        }
        static string kor_week = "월화수목금토일";
        static char WeekDayChar(WeekDay d)
        {
            return kor_week[(int)d];
        }
        static void EnumTest2()
        {
            WeekDay d = WeekDay.Monday;

        }
        static void Main(string[] args)
        {
            char c = WeekDayChar(WeekDay.Monday);
            Console.WriteLine(c);
        }
    }
}
