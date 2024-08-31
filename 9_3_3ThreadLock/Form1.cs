using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9_3_3ThreadLock
{
    public partial class Form1 : Form
    {
        private string thdCode;     // 상태정보 저장변수
        private delegate void CrossCall();  //Invoke() 전달인자로 사용할 델리게이트 CrossCall()
        private int money;                 // 스레드 간의 공유 자원으로 입금 잔액 값 저장
        private object lockObject = new object();   // lock문엥 사용할 객체 생성
        public Form1()
        {
            InitializeComponent();
            thdCode = null;
            money = 10000;  //초기값
        }

        private void BtnThreadLock_Click(object sender, EventArgs e)
        {
            tbThreadState.Clear();
            //델리게이트로 ThreadTeller()를 스레드메소드로 등록 후 스레드 객체 생성
            ThreadStart ts1 = new ThreadStart(ThreadTeller);
            ThreadStart ts2 = new ThreadStart(ThreadTeller);
            ThreadStart ts3 = new ThreadStart(ThreadTeller);
            Thread mobileBanking = new Thread(ts1);
            Thread internetBanking = new Thread(ts2);
            Thread teleBanking = new Thread(ts3);

            //스레드 동작
            mobileBanking.Start();
            internetBanking.Start();
            teleBanking.Start();
        }

        private void ThreadTeller()
        {
            int task = 0;
            //스레드 동기화
            // lockObject를 전달, 객체가 유효하면 lock문에 의해 잠김
            lock (lockObject)
            {
                //task가 5보다 클때 까지 반복, task는 스레드 1개의 작업 단위
                // 여기서는 3개중 1개 뱅킹만 작업 중
                while(task < 5)
                {
                    money += 1000;  //1개의 스레드가 반복할때마다 천원씩
                    //델리게이트로 ThreadState 호출
                    tbThreadState.Invoke(new CrossCall(ThreadState));
                    //고유번호 인식, 스레드 해시코드, 잔액 표시
                    thdCode = "뱅킹고유번호 " + Thread.CurrentThread.GetHashCode() +
                        ": 입금잔액 : " + money + "원" + "\r\n";
                    Thread.Sleep(1000);
                    task++;
                }
            }
        }

        private void ThreadState()
        {
            //문자열을 텍스트 박스에 표시
            tbThreadState.Text += thdCode;
        }
    }
}
