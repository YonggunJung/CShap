using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    internal class Account
    {
        public enum eWithdrawCode { OK, LowBalance, Password, Number }

        private int number;             // 계좌번호
        private int client_id;          //고객아이디
        private int balance;            // 잔고
        private int password;           // 비번
        private double interest_rate;  // 이율

        private static int next_number = 1110000000;     // 계좌번호 발행용

        public Account(int client_id, int password, double interest_rate = 1.0)
        {
            this.number = genNumber();
            this.client_id = client_id;
            this.balance = balance = 0;
            this.password = password % 10000;
            this.interest_rate = interest_rate;
        }

        public int getNumber() {  return number; }
        public int getClientId() { return client_id; }
        public int getBalance(int password) 
        {
            if (password != this.password)
                return -1;
            return balance;
        }
        public double getInterestRate() { return interest_rate; }

        public void deposit(int m)
        {
            balance += m;
        }
        public eWithdrawCode withdraw(int m, int password)
        {
            if (this.password != password)
                return eWithdrawCode.Password;
            if(this.balance <= m)
                return eWithdrawCode.LowBalance;

            this.balance -= m;
            return eWithdrawCode.OK;
        }


        private static int genNumber()
        {
            int ret = next_number;   //ret는 리턴 값 의미하는 변수
            next_number++;
            return ret;
        }
    }

}
