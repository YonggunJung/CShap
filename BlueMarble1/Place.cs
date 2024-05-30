using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlueMarble
{
    public class Place : Button     //칸
    {
        enum ePosition { bottom, left, top, right, edge }

        private ePosition pos;

        const int LONG_SIDE = 140;      // 칸의 긴 쪽
        const int SHORT_SIDE = 70;      // 칸의 짧은 쪽
        const int TOTAL_SIDE = LONG_SIDE * 2 + SHORT_SIDE * 9;
        public const int N_PLACES = 40; //칸 수

        public readonly int x, y;   //칸 그릴 시작 좌표
        public readonly int w, h;   // 칸의 가로 세로
        public readonly int center_x, center_y;

        public readonly string name;
        public readonly string eng_name;
        public readonly int price;
        public readonly int pay;
        public readonly bool can_buy;

        public Place(int id, string name="", string eng_name="", int price=0, int pay = 0, bool can_buy=true)
        {
            this.name = name;           // 이름
            this.eng_name = eng_name;   // 영어 이름
            this.price = price;         // 땅 값
            this.pay = pay;             // 통행료
            this.can_buy = can_buy;     // 땅을 살수 있나 없나?

            if (price != 0)
                Text = $"{name}\n{price}만원";
            else
                Text = name;

            // id 별로 위치 정함 --> 그리기
            if (id % 10 == 0)
                pos = ePosition.edge;
            else pos = (ePosition)(id / 10);

            w = h = LONG_SIDE;
            switch (pos)
            {
                case ePosition.bottom:
                    w = SHORT_SIDE;
                    y = TOTAL_SIDE - LONG_SIDE;
                    x = TOTAL_SIDE - LONG_SIDE - SHORT_SIDE * (id%10);
                    break;
                case ePosition.top:
                    w = SHORT_SIDE;
                    y = 0;
                    x = 0 + LONG_SIDE + SHORT_SIDE * (id % 10 - 1);
                    break;
                case ePosition.left:
                    h = SHORT_SIDE;
                    x = 0;
                    y = TOTAL_SIDE - LONG_SIDE - SHORT_SIDE * (id % 10);
                    break;
                case ePosition.right:
                    h = SHORT_SIDE;
                    x = TOTAL_SIDE - LONG_SIDE;
                    y = 0 + LONG_SIDE + SHORT_SIDE * (id % 10 - 1);
                    break;
                case ePosition.edge:
                    x = (id == 10 || id == 20)? 0 :TOTAL_SIDE - LONG_SIDE;
                    y = (id == 20 || id == 30)? 0 :TOTAL_SIDE - LONG_SIDE;
                    break;
            }
            center_x = x + w / 2;
            center_y = y + h / 2;

            this.Size = new System.Drawing.Size(w, h);
            this.Location = new System.Drawing.Point(x, y);
        }   //class Place
    }
}
