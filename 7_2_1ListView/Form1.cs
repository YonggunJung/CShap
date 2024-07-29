using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7_2_1ListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "" || tbPhone.Text == "" || tbOrg.Text == "")
                MessageBox.Show("입력하지 않은 곳을 채워주세요.");
            else
            {
                // 텍스트 박스로 입력 받은 값을 배열로 만들어주고
                string[] strArray = new string[] { tbName.Text, tbPhone.Text, tbOrg.Text };
                ListViewItem lvt = new ListViewItem(strArray); // 배열로 리스트를 만들어준다.
                listView1.Items.Add(lvt);   //리스트 뷰에 리스트를 더해준다.
                // 텍스트 박스를 초기화 해준다.
                tbName.Clear();
                tbPhone.Clear();
                tbOrg.Clear();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            // 선택 한 곳의 인덱스를 찾는다.
            int selectedIndex = listView1.FocusedItem.Index;
            listView1.Items.RemoveAt(selectedIndex);    //알아낸 인덱스로 지움.
        }
    }
}
