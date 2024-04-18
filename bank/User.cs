using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    internal class User
    {
        protected int id;
        private string name;
        private string jumin;   //주민번호
        private string address; //주소
        private string phone;   //연락처

        protected User(string name, string jumin, string address, string phone)
        {
            this.id = -1;
            this.name = name;
            this.jumin = jumin;
            this.address = address;
            this.phone = phone;
        }

        public int getId()
        {
            return this.id;
        }

        public string getName()
        {
            return this.name;
        }

        public string getJumin()
        {
            return this.jumin;
        }

        public void setAddress(string address)
        {
            this.address = address;
        }
        public string getAddress()
        {
            return this.address;
        }

        public void setPhone(string phone)
        {
            this.phone = phone;
        }

        public string getPhone()
        {
            return this.phone;
        }
    }
}
