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

namespace _8_2_7BinaryIO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnWrite_Click(object sender, EventArgs e)
        {
            // FileStream 클래스로 파일스트림 객체 생성, 쓰기 파일 생성 
            FileStream fs = new FileStream(@"C:\Users\admin\Desktop\C#과제\binaryio.bin", FileMode.Create, FileAccess.Write);
            //쓰기 모드 이진파일 객체 생성,
            //BinaryWriter클래스 생성자의 전달인자로 파일스트림 객체를 전다
            //이걸로 fs를 전달인자로 파일스트림 객체를 전달한다는거 같음
            BinaryWriter bw = new BinaryWriter(fs, Encoding.UTF8);
            bw.Write(tbText.Text);  //문자열을 이진 파일 객체에 저장
            fs.Close();
        }

        private void BtnRead_Click(object sender, EventArgs e)
        {
            tbText.Text = "";
            //Open으로 무조건 파일을 생성??
            FileStream fs = new FileStream(@"C:\Users\admin\Desktop\C#과제\binaryio.bin", FileMode.Open, FileAccess.Read);
            //이걸로 fs를 전달인자로 파일스트림 객체를 전달한다는거 같음
            BinaryReader br = new BinaryReader(fs, Encoding.UTF8);
            //스트림의 데이터를 파일 스트림 객체를 통해 문자열로 읽어 와서 텍스트 박스에 출력
            tbText.Text = br.ReadString();
            fs.Close();
        }
    }
}
