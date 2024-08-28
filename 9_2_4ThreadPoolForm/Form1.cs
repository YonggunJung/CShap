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

namespace _9_2_4ThreadPoolForm
{
    public partial class Form1 : Form
    {
        string thdCode = null; //생성된 스레드의 상태 정보를 저장하기 위한 변수
        delegate void CrossCall();  //Invoke() 전달인자로 사용할 델리게이트 CrossCall() 선언
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnThreadPool_Click(object sender, EventArgs e)
        {
            tbThreadState.Clear();
            tbThreadState.Text += "스레드풀 시작" + "\r\n";
            //스레드폴 메소드인 QueueUserWorkltem() 이용하여
            //10개의 레드를 생성하고 관리
            for (int i = 0; i < 10; i++)
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(ThreadFunction), i);
            }
            tbThreadState.Text += "스레드풀 종료" + "\r\n";
        }

        private void ThreadFunction(object obj)
        {
            //스레드 안에서 컨트롤에 접근하면 크로스 스레드 오류가 발생
            //Invoke()메소드 전달인자인 CrossCall() 델리게이트를 통해
            //가리키는 메소드 ThreadState를 호출
            tbThreadState.Invoke(new CrossCall(ThreadState));
            //생성한 스레드의 해시 코드 및 스레드의 상태표시
            thdCode = "스레드 식별 : " + Thread.CurrentThread.GetHashCode().ToString() +
                "스레드 상태 : " + Thread.CurrentThread.ThreadState.ToString() + "\r\n";
            Thread.Sleep(1000);
        }

        private void ThreadState()
        {
            //스레드 상태 정보를 저장한 문자열을 텍스트 박스에 표시
            tbThreadState.Text += thdCode;
        }
    }
}
