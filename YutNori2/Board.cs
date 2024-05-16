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

        List<Button> test_buttons = new List<Button>();
        public Board()
        {
            InitializeComponent();

            test_buttons.Add(button1);
            test_buttons.Add(button2);
            test_buttons.Add(button3);
            test_buttons.Add(button4);
            test_buttons.Add(button5);
            test_buttons.Add(button6);
            test_buttons.Add(btnYut);

            for (int i = 0; i < Position.N_POSITION; i++)
            {
                positions[i] = new Position();
                Controls.Add(positions[i]);
            }
            for (int i = 0; i < Mal.N_MALS; i++)
            {
                Mal m = new Mal(i < (Mal.N_MALS / 2) ? 1 : 2);  // 말 갯수 정하기
                mals[i] = m;
                m.Click += MalClick;
                Controls.Add(m);
                MoveMalToPosition(m, m.player == 1 ? 29 : 30);
            }
            RepositionMal(29, 1);   // 말 위치 조정
            RepositionMal(30, 2);   // 말 위치 조정
        }

        private void EnableTestButtons(bool enable)     //버튼 활성화 비활성화
        {
            foreach (Button button in test_buttons)
            {
                button.Enabled = enable;
            }
        }
        //public void MoveMalToPosition(int mal_index, int pos_index)
        //{
        //    mals[mal_index].MoveXY(positions[pos_index].x, positions[pos_index].y);
        //    mals[mal_index].position_id = pos_index;
        //}

        public void MoveMalToPosition(Mal m, int pos_index)
        {
            m.MoveXY(positions[pos_index].x, positions[pos_index].y);
            m.position_id = pos_index;
        }

        public List<Mal> FindPositionMals(int pos_index, int player)
        {
            // 같은 위치에 있는 말 조사함.
            List<Mal> mals_in = new List<Mal>();
            foreach (Mal m in mals)     
            {
                if (m.position_id != pos_index) continue;
                if (m.player != player) continue;
                mals_in.Add(m);
            }
            return mals_in;
        }

        public void RepositionMal(int pos_index, int player)
        {
            List<Mal> mals_in = FindPositionMals(pos_index, player);

            int half = Mal.SIZE / 2;

            switch(mals_in.Count)
            {
                case 1:
                    mals_in[0].MoveXY(positions[pos_index].x, positions[pos_index].y);
                    break;

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

        //Mal moving_mal;
        int moving_count;
        int moving_i;
        int moving_mal_index;
        int selected_mal_index;
        int prev_position;
        List<Mal> mals_with ;

        private void Move(int mal_index, int n)
        {
            moving_mal_index = mal_index;
            Mal  moving_mal = mals[moving_mal_index];

            prev_position = moving_mal.position_id;
            if (prev_position >= 31) return;
            mals_with = FindPositionMals(prev_position, moving_mal.player);

            if (prev_position == 29 || prev_position == 30)
            {
                mals_with.Clear();
                mals_with.Add(moving_mal);
            }

            moving_count = n;
            moving_i = 0;
            

            EnableTestButtons(false);
            timer1.Start();
      
        }
        private void MoveTest(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            int n = int.Parse(b.Text);
            Move(selected_mal_index, n);
        }

        private void MalClick(object sender, EventArgs e)
        {
            Mal b = (Mal)sender;
            int p = b.player;
            for(int i = 0; i<mals.Length; i++)
            {
                Mal m = mals[i];
                if (m == b)
                {
                    m.Select(true);
                    selected_mal_index = i;
                }
                else
                {
                    m.Select(false);
                }
            }
            //foreach (Mal m in mals)
            //{
            //    //if (m.player != p) continue;
            //    m.Select(b == m);
            //}
            //selected_mal_index = b.Select(true);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // 이동
            Mal moving_mal = mals[moving_mal_index];
            int pos = moving_mal.position_id;
            int next_pos;

            //if (pos == 29 || pos == 30)
            //{
            //    mals_with.Clear();
            //    mals_with.Add(moving_mal);
            //}

            if (moving_count < 0) // 뒷도
            {
                next_pos = Position.BackDo(pos);
            }
            else
            {
                next_pos = (moving_i == 0) ?
                Position.NextStop(pos) :
                Position.NextGo(pos, prev_position);
            }

            prev_position = pos;    // 이거 위치가 중요

            if (next_pos == 31 && moving_mal.player == 2)
            {
                next_pos = 32;
            }

            foreach(Mal m in mals_with)
            {
                MoveMalToPosition(m, next_pos);

            }

            //MoveMalToPosition(moving_mal_index, next_pos);
            RepositionMal(next_pos, moving_mal.player);

            RepositionMal(prev_position, moving_mal.player);
            bool jap = false;
            if (++moving_i>=moving_count || next_pos >= 31)
            {
                List<Mal> enemy = FindPositionMals(next_pos, moving_mal.player == 1 ? 2 : 1);

                if(enemy.Count > 0)
                {
                    foreach(Mal m in enemy)
                    {
                        MoveMalToPosition(m, moving_mal.player == 1 ? 30 : 29);
                    }

                    RepositionMal(next_pos, moving_mal.player);
                    RepositionMal(29, 1);
                    RepositionMal(30, 2);
                    jap = true;
                    
                }

                timer1.Stop();      // 도착
                EnableTestButtons(true);
                if (jap) MessageBox.Show("잡아쬬~, 함더!");
            }
        }

        string[] yut_pattern = { "[000]", "[   ]", "[xxx]" };
        string[] yut_name = { "모", "도", "개", "걸", "윷", "뒷도" };
        int[] yut_go_count = { 5, 1, 2, 3, 4, -1 };
        
        Random random = new Random();
        private void btnYut_Click(object sender, EventArgs e)
        {
            int[] yuts = new int[4];
            int sum = 0;        //뒤집어진 갯수
            string str_yut = "";
            for(int i = 0; i < yuts.Length; i++)
            {
                int r = random.Next(2);
                sum += r;
                yuts[i] = r;
                if (i == 0 && r == 1) r = 2;

                str_yut += yut_pattern[r];
            }

            lblYut.Text = str_yut;
            if (sum == 1 && yuts[0] == 1) sum = 5;  // 뒷도 해주기
            lblGo.Text = yut_name[sum];

            Move(selected_mal_index, yut_go_count[sum]);
        }
    }
}
