using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9_2_2ThreadStateForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Thread thd;
        private string strState;
        //Invoke( ）의 전달인자로 사용할 델리게이트 CrossCall()을 선언
        delegate void CrossCall();
        private void BtnThreadState_Click(object sender, EventArgs e)
        {
            thd = new Thread(new ThreadStart(ThreadFunction));
            tbThreadState.Text += "스레드 식별 : " + thd.GetHashCode() + "\r\n";
            tbThreadState.Text += "스레드 상태 : " + thd.ThreadState + "\r\n";
            thd.Start();
            tbThreadState.Text += "스레드 상태 : " + thd.ThreadState + "\r\n";
        }
        private void ThreadFunction()
        {
            int count = 0;
            while (count < 100)
            {
                //스레드 안에서 트롤에 접근하면 크로스 스레드 오류가 발생
                //|nvoke( ) 메소드의 전달인자인 CrossCall() 델리게이트를 통해
                //가리키는 메소드 ThreadState를 호출
                tbThreadState.Invoke(new CrossCall(ThreadState));
                //스레드의 상태를 1 초마다 텍스트 박스에출력
                count++;
                Thread.Sleep(1000);
                tbThreadState.Text += "스레드 상태: " + thd.ThreadState + "\r\n";
            }
        }

        private void ThreadState()
        {
            //스레드의 상태를 문자열로 저장한 변수 strState를 텍스트 박스에 출력
            tbThreadState.Text += strState;
        }

        private void BtnSuspend_Click(object sender, EventArgs e)
        {
            thd.Suspend();
            tbThreadState.Text += "스레드 상태 : " + thd.ThreadState + "\r\n";
        }

        private void BtnResume_Click(object sender, EventArgs e)
        {
            thd.Resume();
            tbThreadState.Text += "스레드 상태 :" + thd.ThreadState + "\r\n";
        }
    }
}
