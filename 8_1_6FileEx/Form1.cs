using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _8_1_6FileEx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnFileCopy_Click(object sender, EventArgs e)
        {
            string path = @"D:\C#과제.txt";     //경로 문자열 저장

            try
            {
                if (File.Exists(path))  //path가 존재하면
                {
                    File.Copy(path, @"D:\C#과제_복사.txt");   // 복사한다.
                    lbFileInfo.Items.Clear();
                    lbFileInfo.Items.Add("복사 완료");
                }
            }
            catch (Exception)   // 예외가 발생하면
            {
                lbFileInfo.Items.Clear();
                lbFileInfo.Items.Add("이미 있는 파일");
            }
        }

        private void BtnFileInfo_Click(object sender, EventArgs e)
        {
            FileInfo fInfo = new FileInfo(@"D:\C#과제.txt");    //FileInfo객체 생성
            if (fInfo.Exists)   //fInfo가 존재하면
            {
                lbFileInfo.Items.Clear();
                lbFileInfo.Items.Add("폴더 이름 :" + fInfo.Directory);
                lbFileInfo.Items.Add("파일 이름 :" + fInfo.Name);
                lbFileInfo.Items.Add("확장자 :" + fInfo.Extension);
                lbFileInfo.Items.Add("생성일 :" + fInfo.CreationTime);
                lbFileInfo.Items.Add("파일크기 :" + fInfo.Length);
            }
        }
    }
}
