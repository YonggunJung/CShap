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
            // 학생수, 과목수, 이름, 과목, 점수,가 필요
            // 학생수, 과목수는 정수
            // 이름과 과목은 1차원 문자배열
            // 점수는 2차원 정수배열
            Console.Write("학생 수 : ");
            string s = Console.ReadLine();
            int num = int.Parse(s);  // 학생 수 정의
            Console.Write("과목 수 : ");
            s = Console.ReadLine();
            int snum = int.Parse(s);  // 과목 수 정의

            string[] names = new string[num];     // 학생명 배열 정의
            string[] subjects = new string[snum];    // 과목명 배열 정의
            int[,] scores = new int[num, snum];     // 점수 배열 정의

            for (int i = 0; i<num; i++)
            {
                Console.Write("{0}번째 학생 : ", i + 1);
                s = Console.ReadLine();   // 학생명 정의
                names[i] = s;       // 학생명 배열에 값 삽입

                for (int j = 0; j<snum; j++)
                {
                    Console.Write("과목{0} : ", j + 1);
                    s = Console.ReadLine();     // 과목명 정의
                    subjects[j] = s;            // 과목명 배열에 값 삽입

                    Console.Write("{0}점수 : ", subjects[j]);
                    s = Console.ReadLine();             // 점수 정의
                    scores[i, j] = int.Parse(s);        //  점수 배열에 값 삽입
                }
            }

            for (int i = 0; i<names.Length; i++)
            {
                Console.Write("{0}"+ " ", names[i]);
                int sum = 0;   // 총점 변수에 값 초기화

                for (int j = 0; j<subjects.Length; j++)
                {
                    Console.Write("{0}" + " ", scores[i, j]);
                    sum += scores[i, j];        // 총점에 값 하나하나 더 해주기
                }
                Console.Write(sum + " ");  // 총점 값 확인
                Console.WriteLine("{0:N3}", (double)sum / (double)subjects.Length);   //  평균확인
            }
            

        }
        static void 학생수평균구하기(string[] args)
        {
            string[] subjects = new string[3]
            {
                "국어", "영어", "수학"
            };  // 과목 설정
            Console.WriteLine("학생 수 : ");
            string s = Console.ReadLine();  // 학생수 설정
            int num = int.Parse(s);  // 학생 수 정수화
            string[] names = new string[num]; //이름 배열 정의
            int[,] scores = new int[num, subjects.Length];
            for (int i  = 0; i<num; i++)
            {
                Console.Write("{0}번째 학생", i + 1);
                s = Console.ReadLine();
                names[i] = s;

                for (int j = 0; j<subjects.Length; j++)
                {
                    Console.Write("{0}", subjects[j]);
                    s = Console.ReadLine();
                    scores[i, j] = int.Parse(s);
                }
            }
            // 학생별 합계와 평균구하기
            for (int i = 0; i<names.Length; i++)
            {
                Console.Write("{0}" + " ", names[i]);
                int sum = 0;

                for (int j = 0; j<subjects.Length; j++)
                {
                    Console.Write(scores[i, j] + " ");
                    sum += scores[i, j];
                }
                Console.WriteLine(sum);
                Console.WriteLine("{0:N3}", (double)sum / (double)subjects.Length);
            }

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
