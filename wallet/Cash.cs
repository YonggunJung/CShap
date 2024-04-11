using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wallet
{
    internal class Cash
    {
        public Cash(int value, string front, string back)   //생성자
        {
            this.value = value;
            this.front = front;
            this.back = back;
        }

        public int GetValue()   // 캡슐화, getter
        {

            return value;
        }
        private int value;
        private string front;   //앞면
        private string back;    //뒷면
        //private string ext;    //기타정보

        public void Show(bool new_line = true)
        {
            Console.Write($"권종 : {value}, 앞면 : {front}, 뒷면 : {back}");
            if (new_line)
                Console.WriteLine();
        }
    }
}
