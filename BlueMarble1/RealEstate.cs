using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueMarble
{
    public class RealEstate     //부동산
    {
        public enum eKind { Hotel, Condo, Buliding};
        public readonly eKind kind;
        public readonly int cost;
        public readonly int pay;
        private int number=0;

        public RealEstate(eKind kind, int cost, int pay) 
        {
            this.kind = kind;
            this.cost = cost;
            this.pay = pay;
        }

        public int GetNumber()
        {
            return number;
        }

        public int GetTotalPay()
        {
            return number * pay;
        }

        public int GetTotalCost()   //환불
        {
            return number * cost;
        }

        public int Build()
        {
            return ++number;
        }
    }
}
