using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace _9_1_3ThreadInfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnThreadInfo_Click(object sender, EventArgs e)
        {
            //Thread 클래스를 이용하여 객체를 선언하되,
            //CurrentThread를 통해 헌재 주 스레드 객체를 얻어온다
            Thread th = Thread.CurrentThread;
            th.Name = "threadInfo";     //스레드 이름 설정
            //스레드 해시코드 출력. 해시코드는 객체 식별하는 하나의 정수 값
            tbThreadInfo.Text += "HashCode : " + th.GetHashCode() + "\r\n";
            tbThreadInfo.Text += "스레드 이름 :" + th.Name + "\r\n";
            tbThreadInfo.Text += "스레드 우선순위 :" + th.Priority + "\r\n";
            tbThreadInfo.Text += "스레드 상태 :" + th.ThreadState + "\r\n";
        }
    }
}
