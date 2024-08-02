using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7_2_3WebBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // 검색도 가능.
        private void BtnGo_Click(object sender, EventArgs e)
        {
            //텍스트 박스의 문자를  네비게이트 메소드로 전달
            webBrowser1.Navigate(this.tbAddress.Text);
        }

        private void WebBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            // 로딩 완료시 발생
            MessageBox.Show("웹 사이트 로딩 완료.");
        }

        private void TbAddress_KeyDown(object sender, KeyEventArgs e)// 키 이벤트 처리
        {
            // 입력키가 엔터키일 경우 텍스트 박스에 입력한 주소로 이동 처리
            if (e.KeyCode == Keys.Enter)
                webBrowser1.Navigate(this.tbAddress.Text);
        }
    }
}
