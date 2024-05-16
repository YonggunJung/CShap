using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YutNori
{
    internal class Position : Button        // 컨트롤 . 으로 윈폼을 임포트 해준다.
    {
        public const int N_POSITION = 33;    // 칸
        public const int X_MARGIN = 60;    
        public const int Y_MARGIN = 60;    
        public readonly int id;
        private static int next_id = 0;

        public readonly int x;
        public readonly int y;

        private static int[] _x = new int[N_POSITION]
        {// 0    1    2    3    4    5    6    7    8    9
            600, 600, 600, 600, 600, 600, 480, 360, 240, 120,
            0, 0, 0, 0, 0, 0, 120, 240, 360, 480,
            100, 200, 300, 400, 500, 500, 400, 200, 100, 720, 840, 720, 840
        };
        private static int[] _y = new int[N_POSITION]
        {// 0    1    2    3    4    5  6  7  8  9
            600, 480, 360, 240, 120, 0, 0, 0, 0, 0,
            0, 120, 240, 360, 480, 600, 600, 600, 600, 600,
            100, 200, 300, 400, 500, 100, 200, 400, 500, 600, 600, 480, 480
        };
        private static int[] _size = new int[N_POSITION]
        {// 0   1   2   3   4   5   6   7   8   9
            80, 60, 60, 60, 60, 80, 60, 60, 60, 60,
            80, 60, 60, 60, 60, 80, 60, 60, 60, 60,
            60, 60, 100, 60, 60, 60, 60, 60, 60, 100, 100, 100, 100
        };



        // 가는중 다음 위치
        private static int[] _next_go = new int[N_POSITION]
        {// 0   1   2   3   4   5   6   7   8   9
             31,  2,  3,  4,  5,  6,  7,  8,  9, 10,
            11, 12, 13, 14, 15, 16, 17, 18, 19,  0,
            21, 22, 23, 24,  0, 26, 22, 28, 15 , 1, 1, 31, 32
        };
        // 정지해서 다음위치
        private static int[] _next_stop = new int[N_POSITION]
        {// 0   1   2   3   4   5   6   7   8   9
            31,  2,  3,  4,  5,  25,  7,  8,  9, 10,
            20, 12, 13, 14, 15, 16, 17, 18, 19,  0,
            21, 22, 23, 24,  0, 26, 22, 28, 15, 1, 1, 31, 32
        };
        // 백도하는 위치
        private static int[] _back_do = new int[N_POSITION]
        {//  0   1   2   3   4   5   6   7   8   9
            19,  0,  1,  2,  3,  4,  5,  6,  7,  8,
             9, 10, 11, 12, 13, 14, 15, 16, 17,  18,
            10, 20, 21, 22,  23, 5, 25, 22, 27, 29, 30, 31, 32
        };

        public Position()
        {
            id = next_id++;
            int half = _size[id] / 2;
            x = X_MARGIN + _x[id];
            y = Y_MARGIN + _y[id];
            Location = new System.Drawing.Point(x - half, y - half);
            Name = "";
            Size = new System.Drawing.Size(_size[id], _size[id]);
            TabIndex = 0;
            Text = id.ToString();
            UseVisualStyleBackColor = true;
        }

        public static int NextGo(int current, int prev = -1)
        {
            if (current == 22 && prev == 26) 
                return 27;

            return _next_go[current];
        }

        public static int NextStop(int current)
        {
            return _next_stop[current];
        }

        public static int BackDo(int current)
        {
            return _back_do[current];
        }
    }
}
