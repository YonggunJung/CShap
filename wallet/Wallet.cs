using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wallet
{
    internal class Wallet
    {
        List<PaperMoney> paper_money_list = new List<PaperMoney>();
        List<Coin> coin_list = new List<Coin>();

        public Wallet()
        {

        }
        public void PutIn(Cash c)
        {
            if (c is Coin)
            {
                coin_list.Add((Coin)c);
            }
            if (c is PaperMoney)
            {
                paper_money_list.Add((PaperMoney)c);
            }
        }

        public Cash TakeOut(int v)
        {
            for (int i = 0; i < coin_list.Count; i++)
            {
                Coin coin = coin_list[i];
                if (coin.GetValue() == v)
                {//같은거 찾았을때
                    coin_list.RemoveAt(i);
                    return coin;
                }
            }

            for (int i = 0; i < paper_money_list.Count; i++)
            {
                PaperMoney m = paper_money_list[i];
                if (m.GetValue() == v)
                {//같은거 찾았을때
                    paper_money_list.RemoveAt(i);
                    return m;
                }
            }
            return null;  // 없을 때
        }

        public int Count(int v)
        {
            int cnt = 0;
            for (int i = 0; i < coin_list.Count; i++)
            {
                Coin coin = coin_list[i];
                if (coin.GetValue() == v)
                {
                    cnt++;
                }
            }

            for (int i = 0; i < paper_money_list.Count; i++)
            {
                PaperMoney m = paper_money_list[i];
                if (m.GetValue() == v)
                {
                    cnt++;
                }
            }
            return cnt;
        }

        public int Total()
        {
            int t = 0;
            foreach (PaperMoney m in paper_money_list)
            {
                t += m.GetValue();
            }
            foreach (Coin c in coin_list)
            {
                t += c.GetValue();
            }

            return t;
        }

        public void Show()
        {
            int t = Total();
            Console.WriteLine($"총액 : {t}원");

            if (t == 0)
            {
                return;     //여기서 끝
            }

            if (paper_money_list.Count > 0)
            {
                Console.WriteLine("====지폐====");
                foreach (PaperMoney m in paper_money_list)
                {
                    m.Show();
                }
            }

            if (coin_list.Count > 0)
            {
                Console.WriteLine("====동전====");
                foreach (Coin c in coin_list)
                {
                    c.Show();
                }
            }
        }
    }
}
