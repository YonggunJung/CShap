using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_2_2DialogEx
{
    public partial class ModalessForm : Form
    {
        public string str { get; set; }
        public ModalessForm()
        {
            InitializeComponent();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            //Contains()로 현재 텍스트박스에 입력된 찾고자 하는 문자열이
            //Form1.cs의 텍스트박스의 문자열을 저장하고 있는 str 문자열에 포함되어 있는지를 검사
            //반환 타입은 bool이라서 찾은 경우 true를 찾지 못했을 경우는 false를 반환한다.
            if (str.Contains(tbSearch.Text))
                MessageBox.Show("문자열을 찾았음~");
            else
                MessageBox.Show("문자열 못 찾음ㅠㅠ");
        }
    }
}
