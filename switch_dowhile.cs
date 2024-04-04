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
            //int v = InputInt(msg);
            //정상 범위
            // v >= start && v <= end
            // start <= v %% v <= end
            // 비정상 범위
            // v < start || v > end
            // !(v >= start && v <= end)
            // !(start <= v %% v <= end)
            int v = 0;

            //while (true)
            //{
            //    v = InputInt(msg);
            //    if (v >= start && v <= end)
            //        break;
            //    Console.WriteLine("다시 입력해주세요");

            //}

            //bool first = true;
            //do
            //{
            //    if (!first)
            //    {
            //        Console.WriteLine("다시 입력해주세요");
            //    }
            //    first = false;
            //    v = InputInt(msg);
            //} while (!(v >= start && v <= end));  // 한번해봐 대신 틀리면 반복

            bool retry = false;
            do
            {
                if(retry)
                    Console.WriteLine("다시 입력해주세요");
                retry = true;
                v = InputInt(msg);
            } while (!(v >= start && v <= end));




            return v;
        }

        static void Main(string[] args)
        {
            int w = InputInt("입력", 1, 7);

            string s = "";
            switch (w)
            {
                case 1:
                    s = "월요일";
                    break; //해당 case에 대한 더 이상의 문장은 없음

                case 2:
                    s = "화요일";
                    break;

                case 3:
                    s = "수요일";
                    break;

                case 4:
                    s = "목요일";
                    break;

                case 5:
                    s = "금요일";
                    break;

                case 6:
                    s = "토요일";
                    break;

                case 7:
                    s = "일요일";
                    break;

                default:   //위 case에 해당이 안될 때
                    s = "몰라요";
                    break;

            }

            Console.WriteLine(s);
        }
    }
}
