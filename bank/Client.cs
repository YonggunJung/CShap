using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    internal class Client : User
    {
        private int grade;      //신용 등급

        private static int next_id = 100000000;     // 고객 id 발행용

        public Client(string name, string jumin, string address, string phone, int grade = 5)
            :base(name, jumin, address, phone)
        {

            this.id = genId();
            this.grade = grade;
        }

        private static int genId()
        {
            int ret = next_id;   //ret는 리턴 값 의미하는 변수
            next_id++;
            return ret;
        }

    }
}
