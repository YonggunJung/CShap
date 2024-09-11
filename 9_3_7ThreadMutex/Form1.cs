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

namespace _9_3_7ThreadMutex
{
    public partial class Form1 : Form
    {
        private string thdCode;
        private delegate void CrossCall();
        private int money;
        //뮤텍스 객체 생성 new Mutex(생성스레드의 소유권, 뮤텍스 이름)
        private static Mutex mtx = new Mutex(false, "mtxObj");
        public Form1()
        {
            InitializeComponent();
            thdCode = null;
            money = 10000;
        }

        private void BtnThreadMutex_Click(object sender, EventArgs e)
        {
            tbThreadState.Clear();
            ThreadStart ts1 = new ThreadStart(ThreadTeller);
            ThreadStart ts2 = new ThreadStart(ThreadTeller);
            ThreadStart ts3 = new ThreadStart(ThreadTeller);
            Thread mobileBanking = new Thread(ts1);
            Thread internetBanking = new Thread(ts2);
            Thread teleBanking = new Thread(ts3);

            mobileBanking.Start();
            internetBanking.Start();
            teleBanking.Start();
        }

        private void ThreadTeller()
        {
            int task = 0;

            mtx.WaitOne();      //하나의 자원을 이용할 수 있는때까지 대기하라는 신호
            while (task < 5)
            {
                money += 1000;
                tbThreadState.Invoke(new CrossCall(ThreadState));
                thdCode = "뱅킹고유번호 " + Thread.CurrentThread.GetHashCode() +
                    ": 입금잔액 : " + money + "원" + "\r\n";
                Thread.Sleep(100);
                task++;
            }
            mtx.ReleaseMutex(); //잠금 해제, 다음 스레드가 공유자원 사용
        }
        private void ThreadState()
        {
            tbThreadState.Text += thdCode;
        }
    }
}
