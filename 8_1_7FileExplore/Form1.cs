using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//리스트뷰 속성에서 뷰를 디테일로, 스몰이미지리스트를 이미지리스트로
namespace _8_1_7FileExplore
{
    public partial class Form1 : Form
    {
        public DirectoryInfo dirInfo;   //디렉터리 정보를 가져오기 위한 Directorylnfo 객체
        public DirectoryInfo[] dirSubInfo;  //하위 디렉터리 정보를 가져오기 워한 Directorylnfo 객체
        public int dirCount; //디렉터리 개수를 저장하기 위한 정수형 변수
        public Form1()
        {
            InitializeComponent();
            dirCount = 0;   // 디렉터리 갯수 초기화
        }

        private void ToolStripOpen_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();    // 열기 공통 대화상자 보여주기
            //열기 공통 대화상자에서 선택한 파일을 Directorylnfo 클래스 생성자의 전달인자로 객체생성
            dirInfo = new DirectoryInfo(openFileDialog.FileName);
            dirInfo = dirInfo.Parent; //선택한 파일이 속한 디렉터리를 현 디렉터리로 설정
            dirSubInfo = dirInfo.GetDirectories();  //하위 디렉터리구하기
            dirCount = dirSubInfo.Length + 1;   //[ .. l 디렉터리를 위해 하위 디렉터리의 개수를 1 만큼 더 증가

            listView.Items.Clear();
            //리스트 뷰의 첫 번째 컬럼에[..] 디렉터리를 추가. 인덱스가 0인 이미지를 로딩
            ListViewItem item = new ListViewItem("..", 0);
            item.SubItems.Add("");
            item.SubItems.Add("");
            item.SubItems.Add("");
            listView.Items.Add(item);   //리스트뷰 아이템스에 아이템 추가

            //리스트 뷰에 하위 디렉터리 보를 foreach 반복문을통해 가져옴
            foreach (DirectoryInfo d in dirSubInfo)
            {
                //반복하면서 리스트 뷰에 하위 디렉터리를 추가
                item = new ListViewItem(d.Name.ToString(), 0);
                item.SubItems.Add(d.Attributes.ToString());
                item.SubItems.Add("");
                item.SubItems.Add(d.CreationTime.ToString());
                listView.Items.Add(item);
            }

            //배열 객체를 생성하고, 겟파일즈로 파일 정보 가져오기
            FileInfo[] files = dirInfo.GetFiles();
            foreach(FileInfo f in files)
            {
                item = new ListViewItem(f.Name.ToString(), 1);
                item.SubItems.Add(f.Attributes.ToString());
                item.SubItems.Add(f.Length.ToString());
                item.SubItems.Add(f.CreationTime.ToString());
                listView.Items.Add(item);
            }
        }

        private void ListView_Click(object sender, EventArgs e)
        {
            int index = listView.FocusedItem.Index;     //리스트박스에서 선택한 아이템의 인덱스
            //인덱스가 디렉터리 개수보다 크거나 같다는 것은 파일을 선택했다는 의미
            if (index < dirCount)   
            {
                MessageBox.Show("파일을 선택했습니다.");
                return;
            }
            //인덱스가 이 아니라는 것은 [ .. ] 디렉터리를 선택하지 않은 경우
            //선택한 하위 디렉터리를 현재의 디렉터리로 변경
            if (index != 0) dirInfo = dirSubInfo[index - 1];
            else       //[ .. ] 디렉터리를 선택한 경우
            {
                if (dirInfo.Parent == null)     //헌재 디렉터리가 루트 디렉터리인지 확인
                {
                    MessageBox.Show("루트 디렉터리입니다.");
                    return;
                }
                //루트 디렉터리가 아니라면 부모 디렉터리를 현재의 디렉터리로 변경
                dirInfo = dirInfo.Parent;
            }
            //기존의 리스트 뷰 내용을 지우고. [ .. ] 디렉터리 추가
            listView.Items.Clear();
            ListViewItem item = new ListViewItem("..", 0);
            item.SubItems.Add("");
            item.SubItems.Add("");
            item.SubItems.Add("");
            listView.Items.Add(item);

            dirSubInfo = dirInfo.GetDirectories();  //하위 디렉터리구하기
            dirCount = dirSubInfo.Length + 1;   //[ .. l 디렉터리를 위해 하위 디렉터리의 갯수 1증가
            //리스트 뷰에 하위 디렉터리 정보를 foreach 반복문으로 가져오기
            foreach (DirectoryInfo d in dirSubInfo)
            {
                //하위 디렉터리 추가
                item = new ListViewItem(d.Name.ToString(), 0);
                item.SubItems.Add(d.Attributes.ToString());
                item.SubItems.Add("");
                item.SubItems.Add(d.CreationTime.ToString());
                listView.Items.Add(item);
            }
            //GetFiles( ) 메소드로 파일 정보 가져오기
            FileInfo[] files = dirInfo.GetFiles();
            foreach (FileInfo f in files)
            {
                //파일 정보들 반복해서 가져오기
                item = new ListViewItem(f.Name.ToString(), 1);
                item.SubItems.Add(f.Attributes.ToString());
                item.SubItems.Add(f.Length.ToString());
                item.SubItems.Add(f.CreationTime.ToString());
                listView.Items.Add(item);
            }
        }
    }
}
