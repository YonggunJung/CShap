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
        static Random random = new Random();
        static int Dice()
        {
            int r = random.Next();
            int d = (r % 6) + 1; // 0~5 6개
            return d;
        }

        static bool Yut()
        {
            int r = random.Next();
            return (r % 2) == 0;
        }

        static string[] Yutnori = {"모", "도", "개", "걸", "윷" };

        static void throwYut()
        {
            int c = 0;
            for (int i = 0; i < 4; i++)
            {
                bool y = Yut();
                Console.Write(y ? "X" : "O");
                if (y)
                    c++;
            }
            Console.WriteLine(Yutnori[c]);
        }

        static void Main(string[] args)
        {
            Deck deck = new Deck();
            deck.Shuffle();

            Console.WriteLine(deck);

            Random random = new Random();

            //int r = random.Next();   // 무작위 정수값이 나온다.
            //Console.WriteLine(r);

            //int d1 = Dice();
            //int d2 = Dice();
            //Console.WriteLine($"{d1} {d2}");

            throwYut();





        }
    }
}
