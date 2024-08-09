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

namespace _8_2_3SteamEx
{
    public partial class Form1 : Form
    {
        byte[] data;
        public Form1()
        {
            InitializeComponent();
            data = new byte[26];
        }

        private void BtnWrite_Click(object sender, EventArgs e)
        {
            //fs.txt 파일을 Create 모드로 설정하였으므로 무조건 생성
            // 접근 권한은 Write 로 파일에 쓸수있다
            FileStream fs = new FileStream(@"d:\fs.txt", FileMode.Create, FileAccess.Write);
            
            for(int i = 0; i < 26; i++)
            {
                data[i] = (byte)(65 + i);   //byte가 char다 라고 생각 하면 편하긴한데 다르긴 함.
            }

            fs.Write(data, 0, data.Length); //A부터 Z까지 저장
            fs.Close();
            MessageBox.Show("파일에 데이터를 기록했습니다.");
        }

        private void BtnRead_Click(object sender, EventArgs e)
        {
            try
            {
                //Open 모드로 설정하였으므로 파일을 읽기 모드로 개방하고,
                //접근 권한은 Read이므로 파일의 데이터를 읽어 올 수 있다
                FileStream fs = new FileStream(@"d:\fs.txt", FileMode.Open, FileAccess.Read);

                fs.Read(data, 0, data.Length);
                fs.Close();

                string result = "";
                for(int i = 0; i < data.Length; i++)
                {
                    result += data[i].ToString() + ", "; 
                }
                tbRead.Text = result.ToString();
            }
            catch(FileNotFoundException)
            {
                MessageBox.Show("파일을 찾을 수가 없네여.");
            }
        }
    }
}
