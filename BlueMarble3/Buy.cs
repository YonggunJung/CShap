using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlueMarble
{
    public partial class Buy : Form
    {
        private City _city;
        private Player _player;
        int condo_cost;
        int building_cost;
        int hotel_cost;
        public Buy(City city, Player player)
        {
            _city = city;
            _player = player;
            InitializeComponent();

            int money = player.getMoney();
            lblCity.Text = city.name;
            lblCity.Text = $"플래이어 {player.player+1}";
            lblPlayerMoney.Text = money.ToString();

            lblCityCost.Text = $"{city.price}만원";
            lblCityPay.Text = $"{city.pay}만원";

            condo_cost = city.real_estates[(int)RealEstate.eKind.Condo].cost;
            building_cost = city.real_estates[(int)RealEstate.eKind.Building].cost;
            hotel_cost = city.real_estates[(int)RealEstate.eKind.Hotel].cost;

            lblCondoCost.Text = $"{condo_cost}만원";
            lblBuildingCost.Text = $"{building_cost}만원";
            lblHotelCost.Text = $"{hotel_cost}만원";

            lblCondoPay.Text = $"{city.real_estates[(int)RealEstate.eKind.Condo].pay}만원";
            lblBuildingPay.Text = $"{city.real_estates[(int)RealEstate.eKind.Building].pay}만원";
            lblHotelPay.Text = $"{city.real_estates[(int)RealEstate.eKind.Hotel].pay}만원";

            lblCityCost.Text = "0";
            lblBalance.Text = money.ToString();

            if (city.GetOwner() < 0 && money >= city.price)   // 주인이 없니?
            {
                rbLand.Enabled = true;
                rbLand.Checked = true;
            }
            else if (city.GetOwner() == player.player)
            {
                rbCondo.Enabled = money >= condo_cost;
                rbBuilding.Enabled = money >= building_cost;
                rbHotel.Enabled = money >= hotel_cost;

                bool can_buy = rbCondo.Enabled || rbBuilding.Enabled || rbHotel.Enabled;
                if (!can_buy)
                {
                    lblTrade.Text = "구매불가";
                    lblTrade.ForeColor = Color.Red;
                }
            }
            else
            {
                lblTrade.Text = "구매불가";
                lblTrade.ForeColor = Color.Red;
                
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SelectRealEstate(object sender, EventArgs e)
        {
            int cost = 0;
            if (rbLand.Checked)
            {
                lblTrade.Text = "대지료";
                cost = _city.price;
            }
            else if (rbCondo.Checked)
            {
                lblTrade.Text = "별장";
                cost = condo_cost;
            }
            else if (rbBuilding.Checked)
            {
                lblTrade.Text = "빌딩";
                cost = building_cost;
            }
            else if (rbHotel.Checked)
            {
                lblTrade.Text = "호텔";
                cost = hotel_cost;

            }
            else
            {
                return;
            }
            int balance = _player.getMoney() - cost;
            lblTradeCost.Text = cost.ToString();
            lblBalance.Text = balance.ToString();
            btnBuy.Enabled = (balance >= 0);
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("정말 구매하시겠습니까?", "구매", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            if (rbLand.Checked)
            {
                Global.PlayerToBank(_player, _city.price);
                _city.SetOwner(_player.player);

                MessageBox.Show("대지를 구매했습니다.");
                Close();
            }
            else if (rbCondo.Checked)
            {

            }
            else if (rbBuilding.Checked)
            {

            }
            else if (rbHotel.Checked)
            {

            }

        }
    }
}
