using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace wallet
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Wallet mom_w = new Wallet();



            for(int i = 0; i < 2; i++)
            {
                PaperMoney1000 p = new PaperMoney1000();
                mom_w.PutIn(p);
            }
            mom_w.Show();

            Wallet child_w = new Wallet();


            for (int i = 0; i < 3; i++)
            {
                Cash m = mom_w.TakeOut(1000);
                if (child_w != null)
                {
                    child_w.PutIn(m);
                }
            }
            Console.WriteLine("엄마지갑");
            mom_w.Show();
            Console.WriteLine("자녀지갑");
            child_w.Show();


            //PaperMoney1000 p = new PaperMoney1000();
            //p.Show();
            ////Console.WriteLine($"{256,-7:0000000}");    //256을 7자리에 넣어라 우측정렬, -7은 왼쪽 정렬

            //PaperMoney1000 p2 = new PaperMoney1000();
            //p2.Show();
            //for (int i = 0; i<100; i++)
            //{
            //    Console.WriteLine(p.GenSerial());
            //}


        }
    }
}
