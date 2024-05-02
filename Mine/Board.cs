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
        Cell[,] map = new Cell[10, 10];

        public Board()
        {
            InitializeComponent();
            for (int i = 0; i<10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    map[i, j] = new Cell(Controls, i, j);
                    map[i, j].Click += new System.EventHandler(this.cell_Click);
                }
            }
            NewGame();
        }

        private int CountMines(int c, int r)
        {
            int count = 0;
            for(int i =Math.Max(c-1, 0); i <= Math.Min(c + 1, 9); i++)
            {
                for (int j = Math.Max(r - 1, 0); j <= Math.Min(r + 1, 9); j++)
                {
                    if (map[i, j].hidden_text == "*") count++;
                }
            }
            return count;
        }

        private void OpenMines(int c, int r)
        {
            
            for (int i = Math.Max(c - 1, 0); i <= Math.Min(c + 1, 9); i++)
            {
                for (int j = Math.Max(r - 1, 0); j <= Math.Min(r + 1, 9); j++)
                {
                    if (map[i, j].Text != "") continue;

                    map[i, j].Text = map[i, j].hidden_text;
                    if (map[i, j].hidden_text == ".")
                    {
                        OpenMines(i, j);
                    }
                }
            }
        }

        private void GameOver()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    map[i, j].Text = map[i, j].hidden_text;
                }
            }
        }

        private void NewGame()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    map[i, j].hidden_text = "";
                }
            }

                    // 지뢰 심기
                    const int NUM_MINES = 15;
            Random rnd = new Random();
            for (int i = 0; i< NUM_MINES; i++)
            {
                int c = rnd.Next(10);
                int r = rnd.Next(10);
                if(map[c, r].hidden_text == "*")
                {
                    i--;
                    continue;
                }
                map[c, r].hidden_text = "*";
                //map[c, r].Text = "*";  //디버깅용
            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (map[i, j].hidden_text == "*") continue;
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

        private void cell_Click(object sender, EventArgs e)
        {
            Cell c = (Cell)sender;

            c.Text = c.hidden_text;
            if(c.hidden_text == "*")
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
