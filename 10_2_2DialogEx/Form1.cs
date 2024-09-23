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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnModal_Click(object sender, EventArgs e)
        {
            //ModalForm 객체를 생성한 후 ShowDialog( ) 메소드를 통해 모달 대화상자를 생성
            ModalForm modal = new ModalForm();
            modal.ShowDialog();
        }

        private void BtnModaless_Click(object sender, EventArgs e)
        {
            ModalessForm modaless = new ModalessForm(); //객체 생성
            //텍스트박스에 입력한 텍스트를 ModalessForm 의 변수인 str에 전달
            modaless.str = textBox1.Text;
            modaless.Show();    //객체 보기
        }
    }
}
