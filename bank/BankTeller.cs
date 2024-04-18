using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    internal class BankTeller: User
    {
        protected int id;         //직원 ID
        
        private string branch;   //지점
        private string position;   //직급

        private static int next_id = 1000000;     // 직원 id 발행용
        public BankTeller(string name, string jumin, string address, string phone, string branch, string position = "사원")
            :base(name, jumin, address, phone)
        {
            this.id = genId();
            this.branch = branch;
            this.position = position;

        }

        

        private static int genId()
        {
            int ret = next_id;   //ret는 리턴 값 의미하는 변수
            next_id++;
            return ret;
        }

        
        public void setBranch(string branch)
        {
            this.branch = branch;
        }
        public string getBranch()
        {
            return this.branch;
        }

        public void setPosition(string position)
        {
            this.position = position;
        }
        public string getPosition()
        {
            return this.position;
        }
    }

    
    
}
