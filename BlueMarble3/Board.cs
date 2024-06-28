using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlueMarble
{
    public partial class Board : Form   // 보드
    {
        enum eGameState { Ready, Player1, Player2, Player3, Player4, End }
        eGameState game_state = eGameState.Ready;

        Player moving_player = null;
        int moving_countdown = 0;
        bool is_double = false;

        Place[] places = new Place[Place.N_PLACES];         //칸을 담을 배열 -> 40칸
        Player[] players = new Player[Player.N_PLAYERS];    // 선수 배열 ->4명 설정

        const int START_MONEY = 100;    // 시작 돈


        string[] place_names =  // 칸 이름
        {
            "출발", "타이베이", "황금열쇠", "베이징", "마닐라", "제주", "싱가포르", "황금열쇠", "카이로", "이스탄불", "무인도",
            "아테네", "황금열쇠", "코펜하겐", "스톡홀름", "콩코드여객기", "베른", "황금열쇠", "베를린", "오타와", "사회복지기금획득",
            "부에노스아이레스", "황금열쇠", "상파울로", "시드니", "부산", "하와이", "리스본", "퀸엘리자베스호", "마드리드", "우주여행",
            "도쿄", "컬럼버스호", "파리", "로마", "황금열쇠", "런던", "뉴욕", "사회복지기금기부", "서울"
        };

        int[] place_prices =    // 땅 값(만원 단위)
        {
            0, 5, 0, 8, 8, 20, 10, 0, 10, 12, 0,
            14, 0, 16, 16, 20, 18, 0, 18, 20, 0,
            22, 0, 24, 24, 50, 26, 26, 30, 28, 0,
            30, 45, 32, 32, 0, 35, 35, 15, 100, 
        };

        bool[] can_buy =    // 땅 값(만원 단위)
        {
            false, true, false, true, true, true, true, false, true, true, false,
            true, false, true, true, true, true, false, true, true, false,
            true, false, true, true, true, true, true, true, true, false,
            true, true, true, true, false, true, true, false, true,
        };

        public Board()
        {
            InitializeComponent();

            btnStart.Enabled = true;
            btnEnd.Enabled = false;

            Global.bank = new Bank();  //은행 만들기

            //place 만들기
            for(int i = 0;i<places.Length; i++) // Place[] places 이거 길이 만큼 반복
            {
                Place p = null;

                if (can_buy[i])
                    // class Place를 p로 객체 생성
                    p = new City(i, place_names[i], price: place_prices[i]);
                else
                    p = new Place(i, place_names[i], price: place_prices[i]);

                
                
                places[i] = p;      // Place[] places의 i번째 칸을 p로 채움
                //p.Text = i.ToString();
                Controls.Add(p);        // 버튼을 추가해서 화면에 띄워주는거
            }

            for (int i = 0; i < players.Length; i++)
            {
                // class Player를 p로 객체 생성
                Player p = new Player(i);   // 플레이어를 i로 생성(0, 1, 2, 3)
                // 플레이어 생성과 동시에 시작 돈을 준다.
                Global.BankToPlayer(p, START_MONEY);
                
                players[i] = p;
                //p.Text = i.ToString();
                Controls.Add(p);        // 버튼을 추가해서 화면에 띄워주는거
                MovePlayerToPlace(p, 0);    //Player p가 0번째 인덱스로 간다.
            }
            // 글로벌 플레이어랑 안에 있는 플레이어랑 같다
            Global.players = players;

            {
                Player p = new Player(-1);
                p.Text = "사회복지기금";
                Controls.Add(p);
                p.Size = new Size(100, 50);
                p.MoveXY(300, 300);
            }
            
        }

        private void NewGame()
        {
            // 뱅크/플레이어 돈 리셋
            // 사회복지기금 돈 리셋
            // 땅 리셋
            //플레이어 위치 리셋
        }

        public void MovePlayerToPlace(Player p, int pos_index)
        {
            //Player p가 pos_index의 중앙에 위치하게 한다.
            //하지만 말의 시작 위치가 중앙이라 Player안에서 조정해줌
            p.MoveXY(places[pos_index].center_x, places[pos_index].center_y);
            p.place_id = pos_index;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (game_state != eGameState.Ready) return;
            game_state = eGameState.Player1;

            btnStart.Enabled = false;
            btnEnd.Enabled = true;
            NewGame();
            game_state = eGameState.Player1;

            turn();
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            // 턴이 있을 경우에만 종료 가능
            if (!(game_state >= eGameState.Player1 &&  game_state <= eGameState.Player4)) return;
            game_state = eGameState.End;

            btnStart.Enabled = true;
            btnEnd.Enabled = false;
        }

        private void turn()
        {
            if (!(game_state >= eGameState.Player1 && game_state <= eGameState.Player4)) return;
            if (game_state == eGameState.End)
            {
                MessageBox.Show("게임 종료");
                return;
            }

            //턴 동작
            is_double = false;
            int p_id = game_state - eGameState.Player1;
            Turn t = new Turn();
            t.Player = p_id;
            
            //is_double = true;

            t.ShowDialog();
            is_double = t.IsDouble;

            moving_player = players[p_id];
            moving_countdown = t.MoveCount;
            timer_moving.Interval = 250;
            timer_moving.Start();

        }

        private void next_turn()
        {
            // 다음턴으로 넘기기
            int bankrupt_cnt = 0;
            for (int i = 0; i < 4; i++)
            {
                if (++game_state > eGameState.Player4)
                    game_state = eGameState.Player1;

                int p_idx = game_state - eGameState.Player1;
                if (!players[p_idx].is_bankrupt) break;
                bankrupt_cnt++;
            }
            if (bankrupt_cnt >= 3) game_state = eGameState.End;

        }

        private void timer_moving_Tick(object sender, EventArgs e)
        {
            int next = (moving_player.place_id + 1) % 40;
            MovePlayerToPlace(moving_player, next);

            if (next == 0)  //출발
            {
                //MessageBox.Show("10만원 지급");
                Global.BankToPlayer(moving_player, 10);
                Messaging msg = new Messaging("10만원 지급");
                msg.Show();
            }

            if(--moving_countdown <= 0) //도착
            {
                timer_moving.Stop();

                // 사야됨
                // places[next] is City 이거는 Class의 Type을 물어보는거
                if (places[next] is City)
                {
                    City c = places[next] as City;
                    int city_owner = c.GetOwner();
                    if (city_owner == moving_player.player || city_owner < 0)
                    {
                        Buy buy = new Buy(c, moving_player);
                        buy.ShowDialog();
                    }
                    else      //주인이 내(moving_player)가 아니면
                    {
                        Global.PlayerToPlayer(moving_player.player, city_owner, c.GetTotalPay());

                        MessageBox.Show($"플레이어{city_owner + 1}에게 {c.GetTotalPay()}를 지불하였습니다.");
                    }
                }
                
                
                if (!is_double)
                {
                    next_turn();
                }
                else
                {
                    Console.WriteLine("***");
                }
                
                turn();
            }
        }
    }
}
