using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace CardWin
{
    internal class Cards : Button
    {
        public Cards(Control.ControlCollection controls, string name="no name", bool stacked = false) 
        {
            this.stacked = stacked;
            this.name = name;
            InitButton(name, 0, 0);
            controls.Add(this);
        }

        public void InitButton(string txt, int x, int y)
        {
            this.Location = new System.Drawing.Point(x, y);
            this.Name = "Cards";
            this.Size = new System.Drawing.Size(Card.WIDTH, Card.HEIGHT);
            this.TabIndex = 0;
            this.TabStop = false;
            this.Text = txt;
            this.UseVisualStyleBackColor = true;
        }

        private string name;
        private bool stacked = true;
        private bool its_me = false;

        private List<Card> cards = new List<Card>();
        static Random rnd = new Random();

        public void setMe(bool me)
        {
            this.its_me = me;
        }

        public bool getMe()
        {
            return this.its_me;
        }

        public void setName(string name)
        {
            this.name = name;
        }
        public string getName() { return this.name; }

        public void PutIn(Card card)
        {
            
            cards.Add(card);

            if (its_me)
            {
                card.Turn(true);
            }

            if (stacked)
            {
                card.Visible = false;
            }
            else
            {
                card.Visible = true;
                Point point = this.Location;
                point.X += Card.WIDTH * cards.Count;
                card.Location = point;
            }
            

            
        }

        public Card TakeOut(int index)
        {
            if (index >=cards.Count)
                return null;

            Card c = cards[index];
            cards.RemoveAt(index);

            if(stacked)
            {
                c.Visible = true;
            }
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

        public void SortByNumver()
        {
            // rand 멤버 변수 기준으로 정렬
            cards.Sort(new Comparison<Card>((n1, n2) => (n2.getNumber() < n1.getNumber()) ? 1 : -1));
            Point point = this.Location;
            foreach (Card card in cards)
            {
                
                point.X += Card.WIDTH;
                card.Location = point;
            }
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

        private string PairCheck()
        {
            int[] cnt = new int[14];
            foreach(Card card in cards)
            {
                cnt[card.getNumber()]++;
            }
            string result = "";
            for (int i = 1; i<=13; i++)
            {
                if(cnt[i]>1)
                {
                    result += $"{cnt[i]}:{i}";
                }
            }
            return result;
        }

        public string Result()
        {

            return PairCheck();
        }
    }
}
