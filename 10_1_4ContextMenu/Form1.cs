using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_1_4ContextMenu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void ToolStripCopy_Click(object sender, EventArgs e)
        {
            lblResult.Text = "복사 완료";
        }
        private void ToolStripPaste_Click(object sender, EventArgs e)
        {
            lblResult.Text = "붙여넣기 완료";
        }

        private void ToolStripCut_Click(object sender, EventArgs e)
        {
            lblResult.Text = "잘라내기 완료";
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                //이벤트는 마우스 위치에서 발생함
                Point p = e.Location;
                //contextMenuStrip1를 보여줘라 p에서
                contextMenuStrip1.Show(this, p);
            }
        }
    }
}
