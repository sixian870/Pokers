using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 五張撲克牌
{
    public partial class frmPoker : Form
    {
        PictureBox[] pic = new PictureBox[5];
        int[] allPoker = new int[52];
        int[] playerPoker = new int[5];

        long totalFunds = 1000000;
        long currentBet = 0;

        public frmPoker()
        {
            InitializeComponent();
            InitializePoker();

            btnDealCard.Enabled = false;
            btnChangeCard.Enabled = false;
            btnCheck.Enabled = false;
            txtTotalFunds.Text = totalFunds.ToString();
        }

        #region 自定義方法

        private void InitializePoker()
        {
            for (int i = 0; i < 5; i++)
            {
                pic[i] = new PictureBox();
                pic[i].Image = GetImage("back");
                pic[i].Name = "pic" + i;
                pic[i].SizeMode = PictureBoxSizeMode.AutoSize;
                pic[i].Top = 30;
                pic[i].Left = 10 + ((pic[i].Width + 10) * i);
                pic[i].Visible = true;
                pic[i].Enabled = false;
                pic[i].Tag = "back";
                this.grpPoker.Controls.Add(pic[i]);
                pic[i].Click += Pic_Click;
            }
        }

        private Image GetImage(string name)
        {
            return (Image)Properties.Resources.ResourceManager.GetObject(name) as Image;
        }

        private Image GetImage(int number)
        {
            return GetImage($"pic{number}");
        }

        private void Shuffle()
        {
            Random rand = new Random();
            for (int i = 0; i < allPoker.Length; i++)
            {
                int r = rand.Next(allPoker.Length);
                int temp = allPoker[r];
                allPoker[r] = allPoker[0];
                allPoker[0] = temp;
            }
        }

        private void ResetTableToBack()
        {
            for (int i = 0; i < pic.Length; i++)
            {
                pic[i].Image = GetImage("back");
                pic[i].Tag = "back";
                pic[i].Enabled = false;
            }
        }
        #endregion

        #region 事件處理程序

        private void btnBet_Click(object sender, EventArgs e)
        {
            if (txtTotalFunds.ReadOnly == false)
            {
                string rawTotal = txtTotalFunds.Text.Replace(",", "").Trim();

                if (long.TryParse(rawTotal, out long initialFunds) && initialFunds > 0)
                {
                    totalFunds = initialFunds;
                }
                else
                {
                    MessageBox.Show("請輸入有效的初始總資金，必須為正整數！", "總資金錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            string rawBet = txtBet.Text.Replace(",", "").Trim();

            if (long.TryParse(rawBet, out currentBet) && currentBet > 0)
            {
                if (currentBet <= totalFunds)
                {
                    txtTotalFunds.ReadOnly = true; // 正式鎖定總資金

                    totalFunds -= currentBet; // 扣錢
                    txtTotalFunds.Text = totalFunds.ToString("N0"); // 顯示漂亮的千分位格式

                    lblResult.BackColor = Color.White;
                    ResetTableToBack(); // 將牌翻回牌背

                    btnBet.Enabled = false;
                    btnDealCard.Enabled = true;
                    lblResult.Text = "押注成功，請按發牌！";
                }
                else
                {
                    MessageBox.Show("總資金不足，請重新輸入押注金額！", "押注金額錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("請輸入正確的押注金額，必須為正整數！", "押注金額錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Pic_Click(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            int index = int.Parse(pic.Name.Replace("pic", ""));
            int cardNum = playerPoker[index];
            if(pic.Tag.ToString() == "back")
            {
                pic.Tag = "front";
                pic.Image = GetImage(cardNum);
            }
            else
            {
                pic.Tag = "back";
                pic.Image = GetImage("back");
            }

        }

        private async void btnDealCard_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < pic.Length; i++)
            {
                pic[i].Image = GetImage("back");
            }
            for (int i = 0; i < allPoker.Length; i++)
            {
                allPoker[i] = i;
            }

            Shuffle();
            await Task.Delay(500);

            for (int i = 0; i < 5; i++)
            {
                pic[i].Image = GetImage("pic" + (allPoker[i] + 1));
                playerPoker[i] = allPoker[i];
                pic[i].Enabled = true;
                pic[i].Tag = "front";
            }

            btnDealCard.Enabled = false; // 發完牌就不能再發
            btnChangeCard.Enabled = true; // 開放換牌
            lblResult.Text = "請點擊想換的牌，然後按 [換牌]";
        }

        private void btnChangeCard_Click(object sender, EventArgs e)
        {
            int cardIndex = 5;
            for (int i = 0; i < pic.Length; i++)
            {
                if (pic[i].Tag.ToString() == "back")
                {
                    playerPoker[i] = allPoker[cardIndex];
                    pic[i].Image = GetImage(playerPoker[i] + 1);
                    pic[i].Tag = "front";
                    cardIndex++;
                }
                pic[i].Enabled = false; // 換完牌鎖定圖片點擊
            }

            btnChangeCard.Enabled = false;
            btnCheck.Enabled = true; // 開放判斷牌型
            lblResult.Text = "請點擊 [判斷牌型]";
        }

        #endregion

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string[] colorList = { "梅花", "方塊", "黑桃", "紅心" };
            string[] pointList = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
            int[] pokerColor = new int[5];
            int[] pokerPoint = new int[5];

            for(int i = 0; i < 5; i++)
            {
                pokerColor[i] = playerPoker[i] % 4;
                pokerPoint[i] = playerPoker[i] / 4;
            }

            #region 測試花色點數是否正確
            //=========================================================================
            //string result = "";
            //for(int i = 0; i < playerPoker.Length; i++)
            //{
            //    int iColor = playerPoker[i];
            //    int iPoint = playerPoker[i];
            //    result += $"{colorList[pokerColor[i]]} {pointList[pokerPoint[i]]}\n";
            //    this.lblResult.Text = result;
            //}
            //=========================================================================
            #endregion

            int[] colorCount = new int[4];
            int[] pointCount = new int[13];

            for (int i = 0; i < 5; i++)
            {
                int color = pokerColor[i];
                int point = pokerPoint[i];
                colorCount[color]++;
                pointCount[point]++;
            }

            Array.Sort(colorCount, colorList);
            Array.Reverse(colorCount);
            Array.Reverse(colorList);
            Array.Sort(pointCount, pointList);
            Array.Reverse(pointCount);
            Array.Reverse(pointList);

            bool isFlush = (colorCount[0] == 5);
            bool isSingle = (pointCount[0] == 1 && pointCount[1] == 1 && pointCount[2] == 1 && pointCount[3] == 1 && pointCount[4] == 1);
            bool isDiffFour = (pokerPoint.Max() - pokerPoint.Min() == 4);
            bool isRoyal = pokerPoint.Contains(0) && pokerPoint.Contains(9) && pokerPoint.Contains(10) && pokerPoint.Contains(11) && pokerPoint.Contains(12);
            bool isRoyalisFlush = isFlush && isRoyal;
            bool isStraightFlush = isFlush && isSingle && isDiffFour;
            bool isStraight = isSingle && (isDiffFour || isRoyal);
            bool isFourOfAKind = (pointCount[0] == 4);
            bool isFullHouse = (pointCount[0] == 3 && pointCount[1] == 2);
            bool isThreeOfAKind = (pointCount[0] == 3 && pointCount[1] == 1);
            bool isTwoPair = (pointCount[0] == 2 && pointCount[1] == 2);
            bool isOnePair = (pointCount[0] == 2 && pointCount[1] == 1);

            string result = "";
            int multiplier = 0;
            if (isRoyalisFlush) { result = $"{colorList[0]} 同花大順"; multiplier = 250; }
            else if (isStraightFlush) { result = $"{colorList[0]} 同花順"; multiplier = 50; }
            else if (isFourOfAKind) { result = $"{pointList[0]}鐵支"; multiplier = 25; }
            else if (isFullHouse) { result = $"{pointList[0]}三張{pointList[1]}兩張葫蘆"; multiplier = 9; }
            else if (isFlush) { result = $"{colorList[0]}同花"; multiplier = 6; }
            else if (isStraight) { result = "順子"; multiplier = 4; }
            else if (isThreeOfAKind) { result = $"{pointList[0]}三條"; multiplier = 3; }
            else if (isTwoPair) { result = $"{pointList[0]},{pointList[1]}兩對"; multiplier = 2; }
            else if (isOnePair) { result = $"{pointList[0]}一對"; multiplier = 1; }
            else { result = "雜牌"; multiplier = 0; }

            long winnings = currentBet * multiplier;
            totalFunds += winnings;
            txtTotalFunds.Text = totalFunds.ToString("N0");

            long netProfit = winnings - currentBet;

            if (netProfit > 0)
            {
                lblResult.BackColor = Color.FromArgb(255, 204, 203);
                lblResult.Text = $"{result}！贏得 {winnings:N0}，淨賺 {netProfit:N0} 元！";
            }
            else if (netProfit == 0)
            {
                lblResult.BackColor = Color.FromArgb(200, 240, 200);
                lblResult.Text = $"{result}！不賺不賠，平安下莊。";
            }
            else
            {
                lblResult.BackColor = Color.FromArgb(210, 210, 210);
                lblResult.Text = $"{result}！虧損了 {Math.Abs(netProfit):N0} 元。";
            }

            btnCheck.Enabled = false;
            btnBet.Enabled = true;

            if (totalFunds <= 0)
            {
                MessageBox.Show("您已經破產了！莊家看你可憐，再借你 1,000,000 元重新開始！", "遊戲結束", MessageBoxButtons.OK, MessageBoxIcon.Information);
                totalFunds = 1000000;
                txtTotalFunds.Text = totalFunds.ToString("N0");
                txtTotalFunds.ReadOnly = false; // 破產後解鎖總資金，讓他可以重新設定
                lblResult.Text = " ";
                lblResult.BackColor = Color.White;
            }
        }
    }
}