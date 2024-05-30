using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlueMarble
{
    public class Player : Button    // 선수
    {
        public int place_id;            // 땅 위치
        public readonly int player;     // 선수 구별
        public readonly string name;    // 선수 이름

        private int money = 0;          // 선수가 가진 돈

        public const int SIZE = 20;     // 말 크기 정할 사이즈
        public const int N_PLAYERS = 4; // 선수 수
        

        public Player(int player)
        {
            this.player = player;
            Location = new System.Drawing.Point(0, 0);
            Size = new System.Drawing.Size(SIZE, SIZE);
            Text = player.ToString();
        }

        public void MoveXY(int x, int y)        // 선수 위치 이동
        {
            int half = SIZE / 2;
            Location = new System.Drawing.Point(x - half, y- half);

            BringToFront();     // 말 위치가 칸보다 위에 있게 하는거
        }

        public int getMoney()   // 돈 갖기 시작 돈인듯?
        {
            return money;
        }

        public int Give(int amount)     // 돈 내기 
        {
            if(money < amount)
                amount = money;
            money -= amount;
            return amount;
        }

        public void Take(int amount)    // 돈 받기
        {
            money += amount;

        }
    } //class Player
}
