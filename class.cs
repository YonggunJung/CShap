using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cat
{
    
    class Cat
    {
        public Cat()
        {
            Name = "baby";
            Color = "yello";

        }
        public Cat(string _Name, string _Color)
        {
            Name = _Name;
            Color = _Color;

        }

        // public , private : access modifier
        public string Name;
        public string Color;

        public void Meow()
        {
            Console.WriteLine("{0}: 야옹", Name);

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Cat horang = new Cat();
            Cat nabi = new Cat("나비", "노랑");

            horang.Meow();

            horang.Name = "호랑";
            //nabi.Name = "나비";

            nabi.Meow();
            horang.Meow();

            Cat cheese = nabi;
            cheese.Meow();
            cheese = horang;
            cheese.Meow();
        }
    }
}
