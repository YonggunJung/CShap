using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CardWin.Card;

namespace CardWin
{
    internal class Deck : Cards
    {
        public Deck(Control.ControlCollection controls): base(controls, "deck", true)
        {
            Card c;
            for (Symbol s = Symbol.Heart; s <= Symbol.Spade; s++)
            {
                for (int i = 1; i <= 13; i++)
                {
                    PutIn(c = new Card(s, i));
                    controls.Add(c);
                    //c.Location = new System.Drawing.Point(40*i, 60*(int)s);
                    c.Visible = false;
                    
                }
                
            }
            PutIn(c = new Card(Symbol.BlackJoker));
            controls.Add(c);
            c.Location = new System.Drawing.Point(1*40, 60*4);
            c.Visible = false;

            PutIn(c = new Card(Symbol.ColorJoker));
            controls.Add(c);
            c.Location = new System.Drawing.Point(2*40, 60 * 4);
            c.Visible = false;
        }

        
    }
}
