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

namespace _10_3_3MessageAlarm
{
    public partial class Form1 : Form
    {
        //메시지 알림 창을 출력할 시작점 x, y 좌표를 저장할 변수
        private int x;
        private int y;
        private int h = 0;      //메시지 알림 창이 아래에서 위로 올라올 때의 y 좌표의 간격
        private MsgForm msg;    //MsgAlarm 의 객체를 선언
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnMsg_Click(object sender, EventArgs e)
        {
            //Screen.PrimaryScreen.Bounds.Width로 스크린 너비를 구하고
            //창의 가로 길이 250만큼 빼서 시작위치 x값 지정
            x = Screen.PrimaryScreen.Bounds.Width - 250;
            y = Screen.PrimaryScreen.Bounds.Height;
            msg = new MsgForm(); //메시지 알림 창의 객체 생성
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            // 200보다크면 메시지 알림창이 완벽하게 나왔다는 뜻. 그래서 초기화
            if (h > 200)
            {
                h = 0;
                timer1.Stop();
                Thread.Sleep(1000);
                msg.Close();
            }

            // 메시지창 출력 변화는 y축에만 있으므로 y-h를 해줌.
            // h값이 증가하면 알림창이 화면에 점점 드러나서 interval(100)만큼
            //y축으로 10픽셀씩 올라옴
            else
            {
                msg.Location = new Point(x, y - h);
                msg.Show();
                h += 10;
            }
        }
    }
}
