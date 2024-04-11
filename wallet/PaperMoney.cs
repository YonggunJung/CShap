using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wallet
{
    internal class PaperMoney : Cash
    {
        private string serial_number;
        public PaperMoney(int value, string front, string back)
            : base(value, front, back)
        {
            serial_number = GenSerial(); // 자체 생산
        }

        // 클래스가 공유하는 변수 (static변수 설명)
        // 변수는 딱 하나만 생김/객체마다 만들어지는게 아니다 (일련번호 같은건 이렇게)
        private static char serial_first = 'A';
        private static char serial_second = 'A';
        private static int number = 1;
        private static char serial_last = 'A';

        private string GenSerial()
        {
            string s = $"{serial_first}{serial_second} {number,7:0000000} {serial_last}";
            if (++serial_last > 'Z')
            {
                serial_last = 'A';
                if (++number > 9999999)
                {
                    number = 1;
                    if (++serial_second > 'Z')
                    {
                        serial_second = 'A';
                        if (++serial_first > 'Z')
                        {
                            serial_first = 'A';
                        }
                    }
                }
            }
            //Console.WriteLine($"{256,7:0000000}");
            return s;
        }

        public void Show()
        {
            base.Show(false); //Cash
            Console.WriteLine($", 일련번호 : {serial_number}");
        }

    }

    internal class PaperMoney1000 : PaperMoney
    {
        public PaperMoney1000() : base(1000, "퇴계이황", "계상정거도")
        {

        }
    }
    internal class PaperMoney5000 : PaperMoney
    {
        public PaperMoney5000() : base(5000, "율곡이이", "ㅇ")
        {

        }
    }
    internal class PaperMoney10000 : PaperMoney
    {
        public PaperMoney10000() : base(10000, "세종대왕", "해시계")
        {

        }
    }
    internal class PaperMoney50000 : PaperMoney
    {
        public PaperMoney50000() : base(50000, "신사임당", "신사")
        {

        }
    }
}
