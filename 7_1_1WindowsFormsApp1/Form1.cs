using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnEvent_click(object sender, EventArgs e)
        {
            MessageBox.Show("버튼을 클릭하였습니다.");
        }

        private void btnEvent_Click_1(object sender, EventArgs e)
        {
            string strOrder = "";
            if (ckbSoon.Checked) strOrder += ckbSoon.Text + "\n";
            if (ckbPasta.Checked) strOrder += ckbPasta.Text + "\n";
            if (ckbSteak.Checked) strOrder += ckbSteak.Text + "\n";
            if (ckbTang.Checked) strOrder += ckbTang.Text + "\n";
            lblOrder.Text = strOrder + "메뉴를 요청하였습니다.";
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (radioAgree.Checked) MessageBox.Show("개인정보 동의 하셨습니다.");
            else MessageBox.Show("개인정보 동의 안했습니다.");
        }

        private void BtnReceipt_Click(object sender, EventArgs e)
        {
            string strText = textBox1.Text + "\n라고 요구 사항이 접수 됨";
            MessageBox.Show(strText);
        }
        //private void CbPay_selectedIndexChanged(object sender, EventArgs e)
        //{
        //    lbArea.Items.Clear();
        //    if(cbPay.SelectedIndex == 0)
        //    {
        //        lbArea.Items.Add("일시불");
        //        lbArea.Items.Add("3개월 할부");
        //        lbArea.Items.Add("6개월 할부");
        //        lbArea.Items.Add("몸빵");
        //    }
        //    else if (cbPay.SelectedIndex == 1)
        //    {
        //        lbArea.Items.Add("넘혜브넹");
        //        lbArea.Items.Add("겨브넹");
        //        lbArea.Items.Add("시난넹");
        //    }
        //    else if (cbPay.SelectedIndex == 2)
        //    {
        //        lbArea.Items.Add("N포인트");
        //        lbArea.Items.Add("파워포인트");
        //        lbArea.Items.Add("레이저포인트");
        //    }
            
        //} 이거 안되서 다시함

        private void CbPay_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbArea.Items.Clear();
            if(cbPay.SelectedIndex == 0)
            {
                lbArea.Items.Add("일시불");
                lbArea.Items.Add("3개월 고통");
                lbArea.Items.Add("6개월 고통");
            }
            else if (cbPay.SelectedIndex == 1)
            {
                lbArea.Items.Add("넘혜브넹");
                lbArea.Items.Add("겨브넹");
                lbArea.Items.Add("시난넹");
            }
            else if (cbPay.SelectedIndex == 2)
            {
                lbArea.Items.Add("N포인트");
                lbArea.Items.Add("파워포인트");
                lbArea.Items.Add("레이저포인트");
            }
            else if (cbPay.SelectedIndex == 3)
            {
                lbArea.Items.Add("현금 박치기");
                lbArea.Items.Add("현금 북치기");
                lbArea.Items.Add("현금 감사요");
            }
        }
        private void btnPay_click(object sender, EventArgs e)
        {
            string strText = cbPay.Text + "(으)로" + lbArea.Text + "결제방법을" + "\n선택하셨습니다.";
            MessageBox.Show(strText);
        }
    }
}
