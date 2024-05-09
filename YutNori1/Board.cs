using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YutNori
{
    public partial class Board : Form
    {
        Position[] positions = new Position[Position.N_POSITION];
        Mal[] mals = new Mal[Mal.N_MALS];
        public Board()
        {
            InitializeComponent();

            for (int i = 0; i < Position.N_POSITION; i++)
            {
                positions[i] = new Position();
                Controls.Add(positions[i]);
            }
            for (int i = 0; i < Mal.N_MALS; i++)
            {
                mals[i] = new Mal(i < (Mal.N_MALS/2) ? 1 : 2);
                Controls.Add(mals[i]);
                MoveMalToPosition(i, mals[i].player == 1 ? 29 : 30);
            }
            RepositionMal(29);
            RepositionMal(30);
        }

        public void MoveMalToPosition(int mal_index, int pos_index)
        {
            mals[mal_index].MoveXY(positions[pos_index].x, positions[pos_index].y);
            mals[mal_index].position_id = pos_index;
        }

        public void RepositionMal(int pos_index)
        {
            List<Mal> mals_in = new List<Mal>();
            foreach(Mal m in mals)
            {
                if (m.position_id != pos_index) continue;

                mals_in.Add(m);
            }

            int half = Mal.SIZE / 2;

            switch(mals_in.Count)
            {
                case 2:
                    mals_in[0].MoveXY(positions[pos_index].x - half, positions[pos_index].y);
                    mals_in[1].MoveXY(positions[pos_index].x + half, positions[pos_index].y);
                    break;

                case 3:
                    mals_in[0].MoveXY(positions[pos_index].x, positions[pos_index].y - half);
                    mals_in[1].MoveXY(positions[pos_index].x - half, positions[pos_index].y + half);
                    mals_in[2].MoveXY(positions[pos_index].x + half, positions[pos_index].y + half);
                    break;

                case 4:
                    mals_in[0].MoveXY(positions[pos_index].x - half, positions[pos_index].y - half);
                    mals_in[1].MoveXY(positions[pos_index].x + half, positions[pos_index].y - half);
                    mals_in[2].MoveXY(positions[pos_index].x - half, positions[pos_index].y + half);
                    mals_in[3].MoveXY(positions[pos_index].x + half, positions[pos_index].y + half);
                    break;
            }
        }

        private void Move(int mal_index, int n)
        {
            Mal m = mals[mal_index];
            for (int i = 0; i<n;i++)
            {
                int next_pos = (i == 0) ?
                    Position.NextStop(m.position_id) :
                    Position.NextGo(m.position_id);
                MoveMalToPosition(mal_index, next_pos);
                
            }
            
        }
        private void MoveTest(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            int n = int.Parse(b.Text);
            Move(0, n);
        }
    }
}
