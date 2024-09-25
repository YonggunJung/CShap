using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_2_4CommonDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            // 열기 대화 상자가 모달 형태로 출력
            //대화 상자 안에서 파일 1개 선택후 열기버튼을 누르면
            // 해당 파일 경로와 이름이 텍스트 박스에 출력
            if (ofd.ShowDialog() == DialogResult.OK)
                Textbox1.Text = ofd.FileName + "파일을 엽니다.";
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            sfd.Filter = "All File(*.*) | (*.*)";
            //저장 대화 상자가 모달 형태로 출력
            //대화 상자에 파일 이름 입력후 저장 버튼을 누루면
            //해당 파일 경로와 이름을 텍스트 박스에 출력
            if (sfd.ShowDialog() == DialogResult.OK)
                Textbox1.Text = sfd.FileName + "파일 저장!";
        }

        private void BtnFont_Click(object sender, EventArgs e)
        {
            // 폰트 적용
            if (fd.ShowDialog() == DialogResult.OK)
                Textbox1.Font = fd.Font;
        }

        private void BtnColor_Click(object sender, EventArgs e)
        {
            //색상 적용
            if (cd.ShowDialog() == DialogResult.OK)
                Textbox1.ForeColor = cd.Color;
        }
    }
}
