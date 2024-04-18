using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Card.Card;

namespace Card
{
    internal class Deck : Cards
    {
        public Deck()
        {
            for (Symbol s = Symbol.Heart; s <= Symbol.Spade; s++)
            {
                for (int i = 1; i <= 13; i++)
                {

                    PutIn(new Card(s, i));
                }
                
            }
            PutIn(new Card(Symbol.BlackJoker));
            PutIn(new Card(Symbol.ColorJoker));
        }
    }
}
