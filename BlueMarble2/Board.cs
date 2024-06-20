using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlueMarble
{
    public partial class Board : Form   // 보드
    {
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
        public Board()
        {
            InitializeComponent();

            Global.bank = new Bank();  //은행 만들기

            for(int i = 0;i<places.Length; i++) // Place[] places 이거 길이 만큼 반복
            {
                // class Place를 p로 객체 생성
                Place p = new Place(i, place_names[i], price: place_prices[i]);
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
                p.Text = i.ToString();
                Controls.Add(p);        // 버튼을 추가해서 화면에 띄워주는거
                MovePlayerToPlace(p, 0);    //Player p가 0번째 인덱스로 간다.
            }
            Global.players = players;

            {
                Player p = new Player(-1);
                p.Text = "사회복지기금";
                Controls.Add(p);
                p.Size = new Size(100, 50);
                p.MoveXY(300, 300);
            }
            
        }
        public void MovePlayerToPlace(Player p, int pos_index)
        {
            //Player p가 pos_index의 중앙에 위치하게 한다.
            //하지만 말의 시작 위치가 중앙이라 Player안에서 조정해줌
            p.MoveXY(places[pos_index].center_x, places[pos_index].center_y);
            p.place_id = pos_index;
        }



        
    }
}
