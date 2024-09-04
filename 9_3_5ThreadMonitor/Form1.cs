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

namespace _9_3_5ThreadMonitor
{
    public partial class Form1 : Form
    {
        private string thdCode;
        private delegate void CrossCall();
        private int money;
        private object lockObject = new object();
        public Form1()
        {
            InitializeComponent();
            thdCode = null;
            money = 10000;
        }

        private void BtnThreadMonitor_Click(object sender, EventArgs e)
        {
            tbThreadState.Clear();
            ThreadStart ts1 = new ThreadStart(ThreadTeller);
            ThreadStart ts2 = new ThreadStart(ThreadTeller);
            ThreadStart ts3 = new ThreadStart(ThreadTeller);
            Thread MobileBanking = new Thread(ts1);
            Thread internetBanking = new Thread(ts2);
            Thread teleBanking = new Thread(ts3);

            MobileBanking.Start();
            internetBanking.Start();
            teleBanking.Start();
        }

        private void ThreadTeller()
        {
            int task = 0;
            //임계 영역 블록 시작, 1개의 스레드만 블록 안으로 진입
            Monitor.Enter(lockObject);

            while(task < 5)
            {
                money += 1000;
                tbThreadState.Invoke(new CrossCall(ThreadState));
                thdCode = "뱅킹고유번호 " + Thread.CurrentThread.GetHashCode() +
                    ": 입금잔액 : " + money + "원" + "\r\n";
                Thread.Sleep(100);
                task++;
            }
            Monitor.Exit(lockObject);   //임계 영역 잠금 해제
        }
        private void ThreadState()
        {
            tbThreadState.Text += thdCode;
        }
    }
}
