using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlueMarble
{
    internal static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Application.Run(new Board());
            //Turn t = new Turn();
            //t.Player = 2;
            //Application.Run(t);
            City city = new City(1, "서울", "Seoul", 100, 50, true);
            //city.SetOwner(0);
            Player player = new Player(0);
            player.Take(100);
            Buy b = new Buy(city, player);
            Application.Run(b);
        }
    }
}
