using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 五張撲克牌
{
    public partial class frmPicTest : Form
    {
        public frmPicTest()
        {
            InitializeComponent();
        }

        #region 自定義方法
        private Image GetImage(string name)
        {
            return (Image)Properties.Resources.ResourceManager.GetObject(name) as Image;
        }

        private Image GetImage(int number)
        {
            return GetImage($"pic{number}");
        }
        #endregion

        #region 事件處理程序
        private void btnTest_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int r = rand.Next(1, 53);
            this.picTest.Image = GetImage(r);
            this.lblTest.Text = $"{r}";
        }
        #endregion
    }
}
