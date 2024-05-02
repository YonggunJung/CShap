using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardWin
{
    public partial class Board : Form
    {
        private Deck deck;
        private Cards[] player = new Cards[2];

        public Board()
        {
            deck = new Deck(Controls);
            deck.Shuffle();
            for (int i = 0; i<player.Length; i++)
            {
                player[i] = new Cards(Controls, "선수", false);
                player[i].Location = new Point(0, 320+ 80*i);
            }

            player[0].setMe(true);
            
            
            InitializeComponent();
            
            //한번에 5장씩
            //for (int j = 0; j < 2; j++)
            //{
            //    for (int i = 0; i < 5; i++)
            //    {
            //        Card c = deck.TakeOut(0);
            //        player[j].PutIn(c);
            //    }
            //}

            // 한번에 한장씩
            for (int j = 0; j < 5; j++)
            {
                for (int i = 0; i < 2; i++)
                {
                    Card c = deck.TakeOut(0);
                    player[i].PutIn(c);
                }
            }




        }

        private void button1_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Click");
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < player.Length; i++)
            {
                player[i].SortByNumver();
                player[i].OpenAll();
            }

            result.Text = player[0].Result() + "/" + player[1].Result();

        }
    }
}
