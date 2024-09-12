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

namespace _9_3_8ProcessMutex
{
    public partial class Form1 : Form
    {
        private static bool mtxSuccess; //시스템에 지정된 뮤텍스가 있는지 체크하는거
        private Mutex mtx = new Mutex(false, "mtxObj", out mtxSuccess); //뮤텍스 생성
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //만약 mtxSuccess가 false이면 뮤텍스가 이미 있다고 판단, 현재 프로세스 종료
            if (!mtxSuccess)
            {
                MessageBox.Show("이미 실행 중입니다.");
                Application.Exit();
            }
            //mtx.ReleaseMutex();
        }
    }
}
