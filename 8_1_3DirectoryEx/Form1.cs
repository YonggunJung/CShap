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

namespace _8_1_3DirectoryEx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnDirList_Click(object sender, EventArgs e)
        {
            lbDir.Items.Clear(); // 깨끗하게 초기화
            //디렉토리의 GetDirectories( )로 지정 디렉토리 목록을 가져옴
            //Environment.System Di rectory는
            //우리가 설치한 윈도우 시스템의 System32 디렉터리를 가리킨다
            //apaths 배열에 System32 내부의 폴더 목록이 문자열 형태로 저장
            string[] apaths = Directory.GetDirectories(Environment.SystemDirectory);

            foreach(string dirPath in apaths)
            {
                //lbDir여기에 추가
                lbDir.Items.Add(dirPath);
            }
        }

        private void BtnFileList_Click(object sender, EventArgs e)
        {
            lbFiles.Items.Clear();
            //Directory의 메소드인 GetFiles()로 지정한 경로의 파일 목록을 가져옴
            //첫 번째 전달인자는 접근할 디렉터리고.
            //두 번째 전달인자는 필터링할 확장자이다.
            //exe 확장자인 파일만 가져와서 afiles 배열에 저장
            string[] afiles = Directory.GetFiles(Environment.SystemDirectory, "*.exe");

            foreach (string file in afiles)
            {
                //lbFiles 여기에 추가
                lbFiles.Items.Add(file);
            }
        }
    }
}
