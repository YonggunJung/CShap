using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] subjects = new string[3] { "국어", "영어", "수학" };
            Console.WriteLine("학생 수 :");
            string s = Console.ReadLine();
            int num = int.Parse(s);
            string[] names = new string[num];  // 이름 배열정의하고 이름 배열의 길이는 num만큼이다
            int[,] scores = new int[num, subjects.Length];   // 점수 2차원 배열을 정의하고 크기는 num, subjects.Length까지다

            for (int i = 0; i<num; i++)
            {
                // 학생들 이름 넣고 names 배열에 넣기
                Console.Write("{0}번째 학생", i+1);   
                s = Console.ReadLine();             // 학생들 이름 적는 것
                names[i] = s;

                for (int j = 0; j<subjects.Length; j++)
                {
                    // 과목 별 점수를 넣어준다.
                    Console.Write("{0}", subjects[j]);
                    s = Console.ReadLine();             // 점수 넣어 주는 것
                    scores[i, j] = int.Parse(s);
                }
            }

            // 학생별 합계와 평균구하기
            for (int i = 0; i < num; i++)
            {   
                // 합계 변수 만들어 주기
                Console.Write(names[i] + " ");  // 이건 보기 좋게 출력
                int sum = 0;

                for (int j = 0; j<subjects.Length; j++)
                {
                    // 점수들 더해주기 
                    Console.Write(scores[i, j] + " ");  
                    sum += scores[i, j];
                }
                Console.Write(sum + " ");  
                Console.WriteLine("{0:N3}", sum / (double)subjects.Length);   // 평균을 이름에 맞게 나오게 하기
            }



        }

        static void 문자배열12(string[] args)
        {

            string plain_text = "Hello World";

            StringBuilder sb = new StringBuilder();

            foreach (char c in plain_text)
            {
                char new_char = c;
                if (char.IsLetter(c))
                {
                    
                    new_char+= (char)3;
                    if (!char.IsLetter(new_char))
                    {
                        new_char -= (char)26;

                    }
                }
                sb.Append(new_char);
            }
            Console.WriteLine(sb.ToString());
        }
        static void 문자배열11(string[] args)
        {
            string s = "Hello, World";
            string result = string.Empty;

            for (int i = 0; i < s.Length; i++)
            {
                char t = s[i];
                if (char.IsUpper(t))  // 대문자니?
                {
                    t = char.ToLower(t);
                }
                else if (char.IsLower(t))  // 소문자니?
                {
                    t = char.ToUpper(t);
                }
                result += t;
            }
            Console.WriteLine(result);
        }

        static void 문자배열10(string[] args)
        {
            string s = "Hello, World";
            string result = string.Empty;
            
            for (int i = 0; i<s.Length; i++)
            {
                char t = s[i];
                if (t >='A'&& t <= 'Z')  // 대문자니?
                {
                    t += (char)32;
                }
                else if(t >= 'a' && t <= 'z')  // 소문자니?
                {
                    t -= (char)32;
                }
                result += t;
            }
            Console.WriteLine(result);


        }
        static void 배열2차원9(string[] args)
        {
            string s;
            string[] subjects = { "국어", "영어", "수학" };

            Console.Write("학생수 : ");
            s = Console.ReadLine();
            int num = int.Parse(s);



            string[] names = new string[num];
            int[,] scores = new int[num, subjects.Length];


            for (int i = 0; i < scores.GetLength(0); i++)
            {
                Console.Write("이름 : ");
                s = Console.ReadLine();
                names[i] = s;

                for (int j = 0; j< scores.GetLength(1); j++)
                {
                    Console.Write("{0} : ", subjects[j]);
                    s = Console.ReadLine();
                    scores[i, j] = int.Parse(s);
                }

                

            }
            for (int i = 0; i < num; i++)
            {
                Console.Write(names[i] + " ");
                int sum = 0;
                for (int j = 0; j< subjects.Length; j++)
                {
                    Console.Write(scores[i, j] + " ");
                    sum += scores[i, j];

                }
                Console.Write((double)sum+" ");
                Console.WriteLine("{0:N3}",(double)sum / (double)subjects.Length);
            }




        }


        static void 배열2차원8(string[] args)
        {
            string s;

            Console.Write("학생수 : ");
            s = Console.ReadLine();
            int num = int.Parse(s);

            string[] names = new string[num];
            int[,] scores = new int[num, 2];
            // scores[?, 0] : 국어
            // scores[?, 1] : 영어

            for (int i = 0; i<num; i++)
            {
                Console.Write("이름 : ");
                s = Console.ReadLine();
                names[i] = s;

                Console.Write("국어 : ");
                s = Console.ReadLine();
                scores[i, 0] = int.Parse(s);

                Console.Write("영어 : ");
                s = Console.ReadLine();
                scores[i, 1] = int.Parse(s);
            }
            for (int i = 0; i < num; i++)
            {
                double a = (scores[i, 0] + scores[i, 1]) / 2.0;
                Console.WriteLine(
                    names[i] + " " +
                    scores[i, 0] + " " +
                    scores[i, 1] + " " + 
                    a
                    );
            }


            

        }

        static void 배열2차원7(string[] args)
        {
            //int[,] arr = new int[2, 3];
            //arr[0, 1] = 3;
            //arr[1, 0] = 4;
            //arr[1, 2] = 6;
            int[,] arr = { { 1, 2, 3, 7 }, { 4, 5, 6, 8 } };


            for (int i = 0; i<arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j]+" ");
                }
                Console.WriteLine();
            }
        }

        static void 배열예제6(string[] args)
        {
            string[] menu = { "짜장면", "짬뽕", "볶음밥" };

            foreach (string m in menu)
            {
                Console.WriteLine(m);
            }
        }
        static void 배열예제5(string[] args)
        {
            // 변수는 본인이 속한 블록이 끝날때 소멸한다.
            int[] score = new int[3];
            //foreach는 값을 넣을때는 못쓴다
            for (int i = 0; i<score.Length; i++)
            {
                string s;
                Console.Write("score[{0}]=", i);
                s = Console.ReadLine();
                int n = int.Parse(s);
                score[i] = n;
            }

            int sum = 0;
            foreach (int s in score)
            {
                sum += s;

            }
            Console.WriteLine("합계:" + sum);

            double aver = (double)sum / score.Length;
            Console.WriteLine("평균 :" + aver);
            //Console.WriteLine("평균{0, 3} :" , aver);


            

        }
        static void 배열예제4(string[] args)
        {
            int[] score = { 70, 80, 90 };
            int sum = 0;
            for (int i = 0; i < score.Length; i++)
            {
                sum += score[i];
                Console.WriteLine(sum);
            }
            Console.WriteLine(sum);
        }

        static void 배열기본예제3(string[] args)
        {
            int[] score1 = new int[3] { 1, 2, 3 };
            int[] score2 = new int[] { 1, 2, 3 };
            int[] score3 = { 1, 2, 3 };

            foreach(int s in score1)
            {
                Console.WriteLine(s);
            }

        }
        static void 배열기본예제2(string[] args)
        {
            int[] score = new int[3];
            score[0] = 70;
            score[1] = 75;
            score[2] = 80;
            score[3] = 85;
            score[4] = 90;

            for (int i = 0; i<score.Length; i++)
            {
                Console.WriteLine(score[i]);
            }


        }
        static void 배열기본예제(string[] args)
        {
            int[] arr = new int[3];
            arr[0] = 1;
            //arr[1] = 2;  없는 값을 넣으면 0값이 된다.
            arr[2] = 3;

            Console.WriteLine(arr[1]);


        }
    }
}
