using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wallet
{
    internal class Coin : Cash   // 상속 캐쉬클래스를 상속받는다.  
    {
        public Coin(int value, string front, string back, double size) 
            : base(value, front, back)  //이 Coin은 생성자 base는 Cash생성자
        {
            this.size = size;
        }
        private double size;  // 동전 지름
        public double GetSize()    // 캡슐화 외부에서 변경 불가 (read only)
        {

            return size;
        }
    }

    internal class Coin500 : Coin
    {
        public Coin500() : base(500, "학/오백원", "500/한국은행", 26.5)
        {

        }
    }
    internal class Coin100 : Coin
    {
        public Coin100() : base(100, "이순신/백원", "100/한국은행", 24.0)
        {

        }
    }
    internal class Coin50 : Coin
    {
        public Coin50() : base(50, "벼/오십원", "50/한국은행", 21.6)
        {

        }
    }
    internal class Coin10 : Coin
    {
        public Coin10() : base(10, "다보탑/십원", "10/한국은행", 22.8)
        {

        }
    }
}
