using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueMarble
{
    public class RealEstate     //부동산
    {
        public enum eKind { Hotel, Building, Condo };    // 열거형
        public readonly eKind kind;     // eKind에 대한 변수
        public readonly int cost;   // 환불값?
        public readonly int pay;    // 지불료?
        private int number=0;       // 건물의 갯수

        public RealEstate(eKind kind, int cost, int pay) 
        {
            this.kind = kind;
            this.cost = cost;
            this.pay = pay;
        }

        public int GetNumber()
        {
            return number;      //건물 갯수 리턴
        }

        public int GetTotalPay()
        {
            return number * pay;    // 건물 갯수 만큼 지불
        }

        public int GetTotalCost()   //환불
        {
            return number * cost;
        }

        public int Build()
        {
            return ++number;    //건물 갯수 추가
        }
    }
}
