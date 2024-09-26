using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_3_2Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Interval = 1000; //1초마다 타이머 작동
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            //DateTime 구조체는 시간 정보가 있는 라이브러리
            lblClock.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
