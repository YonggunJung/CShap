using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card
{
    internal class Cards
    {
        private List<Card> cards = new List<Card>();
        static Random rnd = new Random();

        public void PutIn(Card card)
        {
            cards.Add(card);
        }
        public Card TakeOut(int index)
        {
            if (index >=cards.Count)
                return null;

            Card c = cards[index];
            cards.RemoveAt(index);
            return c;
        }



        public void Shuffle()
        {
            int n = cards.Count;
            while (n > 1)
            {
                n--;
                int k = rnd.Next(n + 1);
                Card value = cards[k];
                cards[k] = cards[n];
                cards[n] = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("[ ");
            foreach(Card card in cards)
            {
                sb.Append(card.ToString()+" ");
            }
            sb.Append("]");
            return sb.ToString();
        }
    }
}
