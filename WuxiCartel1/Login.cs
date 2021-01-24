using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WuxiCartel1
{
    public partial class Login : Form
    {
        public Login()
        {
            this.InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //判断：1.用户名是否可以被找到；
            //2.用户名与密码是否匹配；
            //3.根据权限去对应的页面
            //PurchaseHomeForm f = new PurchaseHomeForm();
            this.Hide();
            //f.ShowDialog();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //退出程序
        }
    }
}
