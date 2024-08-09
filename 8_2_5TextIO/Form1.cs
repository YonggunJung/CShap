using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8_2_5TextIO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnWrite_Click(object sender, EventArgs e)
        {
            //쓰기 스트림 객체를 생성
            StreamWriter sw = new StreamWriter(@"d:\textio.txt");
            sw.Write(tbText.Text);  //textbox에 입력한 문자열을 sw 전달
            sw.Close();
            MessageBox.Show("텍스트가 파일에 저장되었습니다.");
        }

        private void BtnRead_Click(object sender, EventArgs e)
        {
            char[] buf = new char[1024];
            int retCnt = 0;
            //읽기 스트림 객체를 생성
            StreamReader sr = new StreamReader(@"d:\textio.txt");
            tbText.Text = "";
            for(; ; )   //이건 무한 반복이란다.
            {
                //한번에 1024byte만큼씩 읽고,
                //buf데이터를 retCnt 갯수만큼 string객체로 변환하여 텍스트박스에 출력
                retCnt = sr.Read(buf, 0, 1024);
                if (retCnt < 1024) break;
            }
            sr.Close();
        }
    }
}
