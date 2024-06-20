using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueMarble
{
    public class Bank   //은행
    {

        private int TOTAL_MONEY = 10000;    //만원단위
        private int money;

        public Bank() { }

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
