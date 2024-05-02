using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace CardWin
{
    public enum Symbol { Heart, Diamond, Clover, Spade, BlackJoker, ColorJoker }

    internal class Card : Button
    {
        public const int WIDTH = 40;
        public const int HEIGHT = 60;

        public int rand = 0;   // shuffle용
        private Symbol symbol;
        private int number;
        private string card;
        private static string mark = "♥◆♣♠ ";
        private static string[] numbers = {"", "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
        private bool open = false;
        public Card(Symbol symbol, int number)  // 조커외 용 생성자
        {
            this.symbol = symbol;
            this.number = number;
            this.card = mark[(int)symbol].ToString() + numbers[number];
            InitButton(this.ToString(), 0, 0);
        }
        public Card(Symbol symbol)   // 조커용 생성자
        {
            this.symbol = symbol;
            this.number = 0;
            if (symbol == Symbol.BlackJoker)
                this.card = "Joker";
            else if (symbol == Symbol.ColorJoker)

                this.card = "Joker";

                
            InitButton(this.ToString(), 0, 0);
        }

        public void InitButton(string txt, int x, int y)
        {
            this.Location = new System.Drawing.Point(x, y);
            this.Name = "Card";
            this.Size = new System.Drawing.Size(WIDTH, HEIGHT);
            this.TabIndex = 0;
            this.TabStop = false;
            this.Text = txt;
            this.UseVisualStyleBackColor = true;
            if(symbol == Symbol.Heart || symbol == Symbol.Diamond || symbol == Symbol.ColorJoker)
            {
                this.ForeColor = System.Drawing.Color.Red;
            }
            this.Click += new System.EventHandler(this.card_Click);
        }

        private void card_Click(object sender, EventArgs e)
        {
            return;
            //open = !open;
            //this.Text = this.ToString();  // 카드 뒤집기
            Turn(!open);
            //MessageBox.Show("Click");
        }
        public int getNumber()
        {
            return number;
        }

        public Symbol getSymbol()
        {
            return symbol;
        }

        public void Turn(bool open)
        {
            this.open = open;
            this.Text = this.ToString();
        }

        public bool IsOpen() { return open; }

        public override string ToString()
        {
            return open ? this.card : "";
        }
    }
}
