using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlueMarble
{
    public class Global
    {
        public static Player[] players;
        public static Bank bank;
        public static Player social_fund;

        public static bool PlayerToBank(Player from, int money)
        {
            if (money > from.getMoney())
            {
                MessageBox.Show("잔액부족!");
                return false;
            }

            bank.TakeFromPlayer(from, money);

            return true;
        }

        public static bool PlayerToBank(int index, int money)
        {
            return PlayerToBank(players[index], money);
        }

        public static bool BankToPlayer(Player to, int money)
        {
            bank.GiveToPlayer(to, money);
            return true;
        }

        public static bool BankToPlayer(int index, int money)
        {
            return BankToPlayer(players[index], money);
        }

        public static bool PlayerToPlayer(Player from_p, Player to_p, int money)
        {

            if (from_p.getMoney() < money)
            {
                MessageBox.Show("잔액부족!");
                return false;
            }

            from_p.Give(money);
            to_p.Take(money);

            return true;
        }

        public static bool PlayerToPlayer(int from, int to, int money)
        {
            return PlayerToPlayer(players[from], players[to], money);
        }

        public static bool GiveSocialFund(int from,  int money)
        {
            return PlayerToPlayer(players[from], social_fund, money);
        }

        public static bool TakeSocialFund(int to)
        {
            return PlayerToPlayer(social_fund, players[to], social_fund.getMoney());
        }

    }
}
