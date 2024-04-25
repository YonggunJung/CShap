using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card
{
    internal class Cards
    {
        public Cards(string name="no name") 
        {
            this.name = name;
        }

        private string name;

        private List<Card> cards = new List<Card>();
        static Random rnd = new Random();

        public void setName(string name)
        {
            this.name = name;
        }
        public string getName() { return this.name; }

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
            //Random rnd = new Random();
            // rand 멤버 변수에 랜덤값 뿌리기
            foreach (Card card in cards)
            {
                card.rand = rnd.Next();
            }
            // rand 멤버 변수 기준으로 정렬
            cards.Sort(new Comparison<Card>((n1, n2) => (n2.rand > n1.rand)? 1 : -1));
        }

        public void _Shuffle()
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

        public void OpenAll()
        {
            foreach (Card card in cards)
            {
                card.Turn(true);
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder($"{this.name}:[ ");
            foreach(Card card in cards)
            {
                sb.Append(card.ToString()+" ");
            }
            sb.Append("]");
            sb.Append($"({cards.Count})]");
            return sb.ToString();
        }
    }
}
