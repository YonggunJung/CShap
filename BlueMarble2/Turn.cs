using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlueMarble
{
    public partial class Turn : Form
    {
        
        Button[] Dices = new Button[2];
        static Random rnd = new Random();

        public int Player = 0;
        public int MooInDoRemain = 0;

        public bool IsDouble = false;
        public int MoveCount = 0;

        enum eState { Wait, Throw, End};

        eState state = eState.Wait;
        int ThrowCount = 0;

        public Turn()
        {
            InitializeComponent();
            Dices[0] = btnDice1;
            Dices[1] = btnDice2;

            
        }

        private void btnThrow_Click(object sender, EventArgs e)
        {
            state = eState.Throw;
            btnThrow.Enabled = false;
            timer1.Interval = 100;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (state == eState.Throw) 
            {
                

                int sum = 0;
                for (int i = 0; i < 2; i++)
                {
                    int dice = rnd.Next(1, 7);
                    sum += dice;
                    Dices[i].Text = dice.ToString();
                }

                if (++ThrowCount >= 10)
                {
                    MoveCount = sum;
                    IsDouble = (Dices[0].Text == Dices[1].Text);

                    lblResult.Text = $"{MoveCount}칸" + (IsDouble ? "[더블]" : "");
                    state = eState.End;
                    timer1.Interval = 2000;
                }

            }

            else if (state == eState.End)
            {
                this.Close();
            }

            

            
        }

        private void Turn_Load(object sender, EventArgs e)
        {
            //디스플레이는 여기서 하는게 맞다. 폼 로드할 떄
            lblPlayer.Text = $"플레이어 {Player + 1} 차례";
            lblMooInDo.Text = MooInDoRemain != 0 ? MooInDoRemain.ToString() + "회" : "아님";
        }
    }
}
