using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method2
{
    internal class Program
    {
        static int sum(int[] nums)
        {
            int s = 0;
            foreach (int n in nums)
            {
                s += n;
            }
            return s;

        }

        static double sum(double[] nums)
        {
            // 이건 오버로딩 overloading, 타입이 다르고 이름은 같아야함
            double s = 0;
            for (int i = 0; i<nums.Length; i++)
            {
                s += nums[i];
            }
            return s;
        }

        static double average(double[] nums)
        {
            //double s = sum(nums);
            //double avg = s/nums.Length;
            //return avg;

            //double avg = sum(nums) / nums.Length;

            return sum(nums) / nums.Length;
        }
        static double average(int[] nums)
        {
            //int s = sum(nums);
            //int avg = s/nums.Length;
            //return avg;

            //double avg = sum(nums) / nums.Length;

            return (double)sum(nums) / (double)nums.Length;
        }

        
        static int inputInt(string s)
        {
            //Console.Write(s + ":");
            //string line = Console.ReadLine();
            //int.Parse(line);

            return int.Parse(inputString(s));
        }

        static double inputDouble(string s)
        {
            //Console.Write(s + ":");
            //string line = Console.ReadLine();
            //int.Parse(line);

            return double.Parse(inputString(s));
        }

        static string inputString(string s)
        {
            Console.Write(s + ":");
            //string line = Console.ReadLine();

            return Console.ReadLine();
        }

        static void drawLine(int n, char c='*', bool new_line = true)
        {
            for (int i = 0; i<n; i++)
            {
                Console.Write(c);
            }
            if(new_line)
                Console.WriteLine();
        }
        // 단순 출력 함수는 void 쓴다
        static void triangleStar(int n)
        {
            for (int i = 1; i<=n; i++)
            {
                drawLine(i);
            }
        }

        static void triangleStar2(int n)
        {
            for (int i = n; i>=1; i--)
            {
                drawLine(i, '#');
            }
        }
        static void triangleStar3(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                drawLine(n-i, ' ', false);
                drawLine(i);
            }
        }

        static void splitNumber(int n)
        {
            char[] digit = new char[16];
            int i = digit.Length - 1; //마지막 인덱스
            if(n != 0)
            {
                for (; n != 0; n /= 10, i--)
                {
                    int k = n % 10;
                    digit[i] = (char)(k + 48);   // 이게 아스키 코드로 더해져서 문자 '0'아스키 코드에서 문자'k'의 코드를 더해준다.

                    //Console.WriteLine(k);
                }
                i++;
            }
            
            for (int k = i; k<digit.Length; k++)
            {
                Console.WriteLine(digit[k]);
            }
        }

        static int check369(int n)
        {
            int clap = 0;
            for (; n !=0; n/= 10)
            {
                int k = (n % 10);
                if (k == 3 || k == 6 || k == 9)
                {
                    clap++;
                }
            }

            return clap;
        }

        static int easy369(int n)
        {
            string s = n.ToString(); // 문자열로 변환
            int clap = 0;

            foreach( char c in s)
            {
                if (c == '3' || c == '6' || c == '9')
                {
                    clap++;
                }

            }

            return clap;
        }

        static void game369_slow()
        {
            for (int i = 1; i < 10000; i++)
            {
                int x = check369(i);
                if (x == 0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    drawLine(x, '짝', true);
                }
            }
        }

        static void game369()
        {
            for (int i = 1; i < 10000; i++)
            {
                int x = check369(i);
                if (x == 0)
                {
                    //Console.WriteLine(i);
                }
                else
                {
                    //drawLine(x, '짝', true);
                }
            }
            Console.WriteLine("끝");
            // 출력이 속도를 저하시킨다 그래서 출력을 잘해야 한다.
        }
        static void swap(ref int x, ref int y)
        {
            int tmp = x;
            x = y;
            y = tmp;
        }

        static void sum_and_average(int[] arr, out int sum, out double avg)
        {
            sum = 0;
            foreach (int i in arr)
            {
                sum += i;
            }
            
            avg = sum / (double)arr.Length;

        }

        static int Sum(params int[] arr)
        {
            int s = 0;
            foreach (int i in arr)
            {
                s += i;
            }
            return s;
        }

        static void printNames(string[] names)
        {
            foreach(string name in names)
            {
                Console.WriteLine(name);
            }
        }

        static void printNames2(params string[] names)
        {
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }

        static void printN(int n, params string[] names)  // params는 젤 뒤에 있어야 한다.
        {
            Console.WriteLine(n);
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }

        static void Main(string[] args)
        {

            printN(5, "홍길동", "김길순");
            printNames2(  "홍길동", "김길순" );  // params 사용
            printNames(new string[] { "홍길동", "김길순" });

            Console.WriteLine(Sum(1, 2, 3));

            int a = 3, b = 4;
            swap(ref a, ref b);
            Console.WriteLine(a);
            Console.WriteLine(b);

            int sum1;
            double avg1;
            int[] ar = new int[] { 1, 3, 4 };
            sum_and_average(ar, out sum1, out avg1);

            Console.WriteLine(sum1);
            Console.WriteLine(avg1);
            // out는 넘길 값이 여러개 있을때
            

            //game369();


            //for (int i = 0; i<=9; i++)
            //{
            //    char c = (char)(i + '0');
            //    Console.WriteLine(c);
            //}

            //int money = 2000000000;
            //int money2 = 2000000000;
            //money += money2;
                
            //Console.WriteLine(money);
            //short smoney = (short)money;
            //Console.WriteLine(smoney);




            //splitNumber(123450);


            //triangleStar(10);
            //triangleStar2(10);
            //triangleStar3(10);


            //int[] scores = { 90, 80, 70, 60 };
            //int total = sum(scores);
            //Console.WriteLine(total);

            //Console.WriteLine(sum(scores));
            //Console.WriteLine(sum(new int[] { 90, 80, 70, 60 }));  // 이 배열은 한번쓰고 없어진다
            //Console.WriteLine(sum(new double[] { 1.0, 1.2, 3.5 }));

            //Console.WriteLine(average(new int[] { 90, 80, 70, 60 }));  // 이 배열은 한번쓰고 없어진다
            //Console.WriteLine(average(new double[] { 1.0, 1.2, 3.5 }));

            //string name = inputString("이름");
            //int age = inputInt("나이");
            //double height = inputDouble("키");

            //Console.WriteLine("이름:{0} 나이:{1} 키:{2}", name, age, height);
        }
    }
}
