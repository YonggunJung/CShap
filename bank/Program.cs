using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Client c= new Client(/*"홍길동", "123456-1234567", "부산", "010-1234-5678"*/);
            //User u= new User("홍길동", "123456-1234567", "부산", "010-1234-5678");  //protected라서 생성 안됨
            BankTeller t = new BankTeller("홍길동", "123456-1234567", "부산", "010-1234-5678", "폴리텍");
            Bank b = new Bank("폴리텍은행");

            b.createClient("홍길동", "123456-1234567", "부산", "010-1234-5678");
            int num = b.createAccount("123456-1234567", 1234);

            b.createClient("홍길순", "123456-2234567", "부산", "010-1234-5679");
            int num2 = b.createAccount("123456-2234567", 1234);

            b.deposit(num, 10000);
            int bal;
            if (b.getBalance(num, 1233, out bal) == Account.eWithdrawCode.OK)
            {
                Console.WriteLine(bal);
            }

            if (b.getBalance(num, 1234, out bal) == Account.eWithdrawCode.OK)
            {
                Console.WriteLine(bal);
            }

            if (b.withdraw(num, 1234, 1000) == Account.eWithdrawCode.OK)
            {
                if (b.getBalance(num, 1234, out bal) == Account.eWithdrawCode.OK)
                {
                    Console.WriteLine(bal);
                }
            }

            if (b.transfer(num, 1234, 500, num2) == Account.eWithdrawCode.OK)
            {
                if (b.getBalance(num, 1234, out bal) == Account.eWithdrawCode.OK)
                {
                    Console.WriteLine(bal);
                }
                if (b.getBalance(num2, 1234, out bal) == Account.eWithdrawCode.OK)
                {
                    Console.WriteLine(bal);
                }
            }



            Console.WriteLine(b);
        }
      
    }
}
