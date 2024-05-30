using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueMarble
{
    public class Bank   //은행
    {
        public static Bank theBank = null;

        private int TOTAL_MONEY = 10000;    //만원단위
        private int money;
        private Player[] players;

        private Bank() { } // 밖에서는 만들지마 은행
        public static void CreateBank()
        {
            if (theBank != null)    // 이중객체 생성 금지
                return;
            theBank = new Bank();   //은행 만들기
        }

        public void GiveToPlayer(Player p, int amount)
        {
            money -= amount;
            p.Take(amount);
        }

        public void TakeFromPlayer(Player p, int amount)
        {
            int m = p.Give(amount);
            money += amount;
        }
    }
}
