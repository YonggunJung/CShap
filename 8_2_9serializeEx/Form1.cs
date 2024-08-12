using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
//BinaryFormatter 클래스를 사용하기 위해 사용하는 네임스페이스
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8_2_9serializeEx
{
    public partial class Form1 : Form
    {
        private ArrayList arrlist;
        public Form1()
        {
            InitializeComponent();
            arrlist = new ArrayList();  //리스트 생성
        }

        private void BtnSerialize_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"C:\Users\admin\Desktop\C#과제\serialize.bin",
                FileMode.Create);       // FileStream 생성모드로 생성
            Person p = new Person(tbName.Text, tbMobile.Text, tbEmali.Text, tbAddress.Text);

            arrlist.Add(p);     //리스트에 Person객체q 더하기

            BinaryFormatter bf = new BinaryFormatter();     //직렬화 객체 생성
            bf.Serialize(fs, arrlist);  //arrlist를 직렬화
            fs.Close();
            arrlist.Clear();
        }

        private void BtnDeserialize_Click(object sender, EventArgs e)
        {
            tbResult.Text = "";
            FileStream fs = new FileStream(@"C:\Users\admin\Desktop\C#과제\Serialize.bin", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();     //역직렬화 객체 생성
            arrlist = (ArrayList)bf.Deserialize(fs);    //fs를 역직렬화 후 리스트화해서 저장

            foreach(Person p in arrlist)
            {
                tbResult.Text += p.GetName() + "\n" +
                    p.GetMobile() + "\n" +
                    p.GetEmail() + "\n" +
                    p.GetAddress() + "\n";
            }
            fs.Close();
        }
    }
    [Serializable]      //Person 클래스를 직렬화하겠다는 의미
    class Person 
    {
        string name;
        string mobile;
        string email;
        [NonSerialized]     //address만 역직렬화하겠다는 의미
        string address;

        public Person(string aName, string aMobile, string aEmail, string aAddress)
        {
            name = aName;
            mobile = aMobile;
            email = aEmail;
            address = aAddress;
        }

        public string GetName() { return name; }
        public string GetMobile() { return mobile; }
        public string GetEmail() { return email; }
        public string GetAddress() { return address; }
    }

}
