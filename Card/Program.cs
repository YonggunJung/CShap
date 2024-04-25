using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Card.Card;

namespace Card
{
    internal class Program
    {
        //static Random random = new Random();
        //static int Dice()
        //{
        //    int r = random.Next();
        //    int d = (r % 6) + 1; // 0~5 6개
        //    return d;
        //}

        //static bool Yut()
        //{
        //    int r = random.Next();
        //    return (r % 2) == 0;
        //}

        //static string[] Yutnori = {"모", "도", "개", "걸", "윷" };

        //static void throwYut()
        //{
        //    int c = 0;
        //    for (int i = 0; i < 4; i++)
        //    {
        //        bool y = Yut();
        //        Console.Write(y ? "X" : "O");
        //        if (y)
        //            c++;
        //    }
        //    Console.WriteLine(Yutnori[c]);
        //}

        static void Main(string[] args)
        {
            Deck deck = new Deck();
            deck.Shuffle();

            // 배열 만들기
            Cards[] players = new Cards[3];
            // 배열안의 요소객체를 만들어 주는 것 
            for(int i = 0; i<players.Length; i++)
            {
                players[i] = new Cards("선수" + (i+1));
            }

            for (int j = 0; j<5;j++)
            {
                for (int i = 0; i < players.Length; i++)
                {
                    Card c = deck.TakeOut(0);
                    players[i].PutIn(c);
                }
            }
            players[0].OpenAll();
            players[1].OpenAll();
            players[2].OpenAll();


            foreach (Cards s in players)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine(deck);

            //Console.WriteLine(deck);

            Random random = new Random();

            //int r = random.Next();   // 무작위 정수값이 나온다.
            //Console.WriteLine(r);

            //int d1 = Dice();
            //int d2 = Dice();
            //Console.WriteLine($"{d1} {d2}");

            //throwYut();

        }
    }
}
