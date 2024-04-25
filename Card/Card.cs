using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card
{
    public enum Symbol { Heart, Diamond, Clover, Spade, BlackJoker, ColorJoker }

    internal class Card
    {
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
        }
        public Card(Symbol symbol)   // 조커용 생성자
        {
            this.symbol = symbol;
            this.number = 0;
            if (symbol == Symbol.BlackJoker)
                this.card = "BlackJoker";
            else if (symbol == Symbol.ColorJoker)
                this.card = "ColorJoker";
        }

        public void Turn(bool open)
        {
            this.open = open;
        }

        public bool IsOpen() { return open; }

        public override string ToString()
        {
            return open ? this.card : "##";
        }
    }
}
