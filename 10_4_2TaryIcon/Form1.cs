using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_4_2TaryIcon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Cancel이라는 속성은 폼을 닫을건데 취소하냐?
            //취소한다가 폼을 안닫는 다는거
            // 실제로 폼을 종료 안하고 트레이 아이콘으로 전환해서 true로 설정
            e.Cancel = true;
            this.Visible = false;       // 메인폼 안보이게 설정
            this.trayIcon.Visible = true;   // 트레이 아이콘 보이게 설정
        }

        private void ToolStripOpen_Click(object sender, EventArgs e)
        {
            //열기 누르면 폼이 보이고, 트레이아이콘이 안보이게 설정
            this.Visible = true;
            this.trayIcon.Visible = false;
        }

        private void ToolStripClose_Click(object sender, EventArgs e)
        {
            // 종료 누르면 즉시 종료
            // Dispose는 더이상 사용되지 않는 자원들 즉시 반납하게하는 메소드
            this.Dispose();
            Application.Exit();     //종료
        }

        private void TrayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // 더블클릭을 해도 폼이 화면에 보이고 드레이 아이콘이 안보이게 설정
            this.Visible = true;
            this.trayIcon.Visible = false;
        }
    }
}
