using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueMarble
{
    public class City : Place    //도시
    {
        const int NO_OWNER = -1;    //땅 주인이 없으면

        private int owner = NO_OWNER;   //??
        public readonly bool can_build;     //건물 지을수 있는지 없는지
        public RealEstate[] real_estates = null;

        private int total_pay = 0;      // 총 지불 금액
        private int total_refund = 0;   //환불 받을 돈

        public City(int id, string name = "", string eng_name = "", int price = 0, int pay = 0, bool can_build = true) 
            :base(id, name, eng_name, price, pay, true)
        {
            this.can_build = can_build;
            if(can_build)
            {
                real_estates = new RealEstate[3];
                for (int i = 0; i < real_estates.Length; i++)
                {
                    real_estates[i] = new RealEstate((RealEstate.eKind)i, 100 - i * 20, 10 - i * 2); //금액 변경
                }
            }
        }

        public void Refund()
        {
            if (owner == NO_OWNER) return;

            // total_refund 송금 할 차례 ->원 주인 에게

            SetOwner(NO_OWNER);
        }

        void CalculateTotalPay()
        {
            if(owner == NO_OWNER)   //주인이 없으면
            {
                total_pay = 0;
                total_refund = 0;
                return;
            }

            {
                int sum = pay; //주인이 있으면 일단 지불료에서
                for (int i = 0; i < real_estates.Length; i++)
                {
                    sum += real_estates[i].GetTotalPay();   // 지불료의 건물 갯수만큼 더해줌
                }
                total_pay = sum;
            }
            {
                int sum = price;    // 땅값?
                for (int i = 0; i < real_estates.Length; i++)
                {
                    sum += real_estates[i].GetTotalPay();
                }
                total_refund = sum;
            }
        }

        public void SetOwner(int player_id)
        {
            owner = player_id;
            //지금 결제하는거 맞음?
            CalculateTotalPay();
        }

        public int GetOwner()
        {
            return owner;
        }

        public void Build(RealEstate.eKind kind)
        {
            int i = (int)kind;
            real_estates[i].Build();
            CalculateTotalPay();
        }
    }
}
