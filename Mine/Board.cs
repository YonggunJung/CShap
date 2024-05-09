using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mine
{
    public partial class Board : Form
    {
        private int cols, rows;
        private int MAX_COLS = 20, MAX_ROWS = 20;
        Cell[,] map;     // 10 x 10 셀 생성
        public static int MenuHeight;

        public Board()      //보드 생성자
        {
            InitializeComponent();      //디자이너단에서 정의된 From컴포넌트들을 호출할 때 사용
            MenuHeight = menuStrip1.Height;

            map = new Cell[MAX_COLS, MAX_ROWS];

            for (int i = 0; i< MAX_COLS; i++)
            {
                for (int j = 0; j < MAX_ROWS; j++)
                {
                    map[i, j] = new Cell(Controls, i, j);
                    map[i, j].Click += new System.EventHandler(this.cell_Click);
                    map[i, j].MouseUp += new System.Windows.Forms.MouseEventHandler(this.cell_MouseUp);
                }
            }
            NewGame();
        }

        private int CountMines(int c, int r)        //
        {
            int count = 0;
            for(int i =Math.Max(c-1, 0); i <= Math.Min(c + 1, cols - 1); i++)
            {
                for (int j = Math.Max(r - 1, 0); j <= Math.Min(r + 1, rows - 1); j++)
                {
                    if (map[i, j].HasMine()) count++;
                }
            }
            return count;
        }
        
        private void OpenMines(int c, int r)
        {

            for (int i = Math.Max(c - 1, 0); i <= Math.Min(c + 1, cols - 1); i++)
            {
                for (int j = Math.Max(r - 1, 0); j <= Math.Min(r + 1, rows - 1); j++)
                {
                    if (map[i, j].Text != "")
                        continue;
                    //map[i, j].Text = map[i, j].hidden_text; // 이걸 함수 하나 만들어서 아래걸로
                    map[i, j].Open();

                    if (map[i, j].hidden_text == ".")
                    {
                        OpenMines(i, j);
                    }
                }
            }

        }

        private void GameOver()
        {
            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    map[i, j].Open();
                }
            }
        }

        private void NewGame(int cs = 10, int rs = 10, int mines = 15)
        {
            cols = cs;
            rows = rs;

            Size = new Size(cols * Cell.W+30, rows * Cell. W+menuStrip1.Size.Height +50);

            for (int i = 0; i < MAX_COLS; i++)
            {
                for (int j = 0; j < MAX_ROWS; j++)
                {
                    map[i, j].Visible =( i < cs && j < rs);
                    map[i,j].Text = map[i, j].hidden_text = "";
                }
            }

            // 지뢰 심기
            //const int NUM_MINES = 15;
            Random rnd = new Random();
            for (int i = 0; i< mines; i++)
            {
                int c = rnd.Next(cols);
                int r = rnd.Next(rows);
                if(map[c, r].HasMine())
                {
                    i--;
                    continue;
                }
                map[c, r].hidden_text = "*";
                //map[c, r].Text = "*";  //디버깅용
            }

            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    if (map[i, j].HasMine()) continue;
                    int cnt = CountMines(i, j);
                    if(cnt > 0)
                    {
                        map[i, j].hidden_text = cnt.ToString();
                        //map[i, j].Text = cnt.ToString();  //디버깅용
                    }
                    else
                    {
                        map[i, j].hidden_text = ".";
                    }
                }
            }
        }

        private void cell_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right)
                return;     //오른쪽 버튼만 남는다

            Cell c = (Cell)sender;
            c.MakeFlag();
            //MessageBox.Show("MouseUp");
        }

        private void eToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("게임을 새로 시작하겠습니까?",
                "질문", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            Application.Exit();
        }

        private void _10x10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("게임을 새로 시작하겠습니까?",
                "새 게임: 10x10", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            NewGame(10, 10, 15);
        }

        private void _20x20ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("게임을 새로 시작하겠습니까?",
                "새 게임: 10x10", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            NewGame(20, 20, 60);
        }

        private void cell_Click(object sender, EventArgs e)
        {
            Cell c = (Cell)sender;

            c.Text = c.hidden_text;
            if(c.HasMine())
            {
                GameOver();
                MessageBox.Show("게임 오버");
            }
            else if(c.hidden_text == ".")
            {
                // 숫자 나올때 까지 쫙~ 펼쳐줘야함
                OpenMines(c.c, c.r);
            }
            //MessageBox.Show($"{c.r}, {c.c}");
        }
    }
}
