using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YutNori
{
    internal class Mal : Button
    {
        public int position_id;
        public readonly int player;
        public const int SIZE = 20;
        public const int N_MALS = 8;

        public Mal(int player)
        {
            this.player = player;
            Location = new System.Drawing.Point(0, 0);
            Name = "";
            Size = new System.Drawing.Size(SIZE, SIZE);
            TabIndex = 0;
            Text = player.ToString();
            UseVisualStyleBackColor = true;
        }

        public void MoveXY(int x, int y)
        {
            int half = SIZE / 2;
            Location = new System.Drawing.Point(x - half, y- half);

            BringToFront();
        }
    }
}
