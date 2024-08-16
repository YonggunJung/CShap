using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _9_1_5ThreadCreate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Main( ) 메소드 자체가 하나의 주 스레드이므로 시작 메시지를 출력한다. 
            Console.WriteLine("주 스레드 시작");
            //델리게이트 ThreadStart를 사용하여 ThreadFunction( ) 메소드를 위임
            ThreadStart ts = new ThreadStart(ThreadFunction);   
            Thread thd = new Thread(ts);    //스레드 객체 선언 및 생성
            thd.Start();    //스레드 시작
            Console.WriteLine("스레드 시작" + thd.ThreadState);  //시작과 상태 속성 알려줌
            Console.WriteLine("주 스레드 종료");  // 종료를 알려줌
        }
        
        public static void ThreadFunction()
        {
            //스레드 동작 메세지 10회 출력
            int count = 0;
            while(count < 10)
            {
                count++;
                Console.WriteLine("쓰레드 작업중...");
            }
        }
    }
}
