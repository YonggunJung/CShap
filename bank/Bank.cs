using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static bank.Account;

namespace bank
{
    internal class Bank
    {
        string name;
        List<BankTeller> tellers = new List<BankTeller>();
        List<Client> clients = new List<Client>();
        List<Account> accounts = new List<Account>();

        public Bank(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {

            return $"{name}: 직원({tellers.Count}), 고객({clients.Count}), 계좌({accounts.Count})";
        }

        public Client createClient(string name, string jumin, string address, string phone)
        {
            Client cli = findClient(jumin);
            if (cli != null)        // 기존에 존재하는 경우
            {
                cli.setPhone(phone);
                cli.setAddress(address);
                return cli;
            }
                
            cli = new Client(name, jumin, address, phone);
            clients.Add(cli);
            return cli;
        }

        public int createAccount(string jumin, int password)
        {
            Client cli = findClient(jumin);
            if (cli == null)
                return -1;

            Account acc = new Account(cli.getId(), password);
            accounts.Add(acc);
            return acc.getNumber();
        }



        public Client findClient(string jumin)
        {
            foreach (Client client in clients)
            {
                if (client.getJumin() == jumin)
                    return client;
            }
            return null; // 못찾음
        }

        public BankTeller findTeller(int id)
        {
            foreach (BankTeller t in tellers)
            {
                if (t.getId() == id)
                    return t;
            }
            return null; // 못찾으면
        }

        private Account findAccount(int number)
        {
            foreach (Account a in accounts)
            {
                if (a.getNumber() == number)
                    return a;
            }
            return null; // 못찾으면
        }

        public bool deposit(int number, int m)
        {
            Account acc = findAccount(number);   //안되는거 보내는거
            if (acc == null) return false;

            acc.deposit(m);

            return true;  // 성공
        }

        public eWithdrawCode withdraw(int number, int password, int m)
        {
            Account acc = findAccount(number);   //안되는거 보내는거
            if (acc == null) return eWithdrawCode.Number;

            return acc.withdraw(m, password);  // 성공
        }

        public eWithdrawCode transfer(int my_number, int password, int m, int your_number)
        {
            Account acc = findAccount(my_number);   //안되는거 보내는거
            if (acc == null) return eWithdrawCode.Number;

            Account acc2 = findAccount(your_number);   //안되는거 보내는거
            if (acc2 == null) return eWithdrawCode.Number;

            eWithdrawCode c = acc.withdraw(m, password);
            if(acc.withdraw(m, password) != eWithdrawCode.OK)
                return c;

            acc2.deposit(m);

            return eWithdrawCode.OK;  // 성공


        }

        public eWithdrawCode getBalance(int number, int password, out int balance)
        {
            balance = 0;
            Account acc = findAccount(number);   //안되는거 보내는거
            if (acc == null) return eWithdrawCode.Number;

            int b = acc.getBalance(password);
            if (b < 0)
                return eWithdrawCode.Password;

            balance = b;

            return eWithdrawCode.OK;  // 성공
        }

        

    }
}
