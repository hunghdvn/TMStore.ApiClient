using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMStore.ApiClient.Clients;
using TMStore.ApiClient.Helpers;

namespace TMStore.AppDemo
{
    public partial class frmMain : Form
    {
        private IAuthClient authClient = new AuthClient();

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                //Đẩy url của trang cung cấp api xuống ApiClient
                ClientHelper.SetBaseUrl(txtBaseUrl.Text);
                //Đăng nhập để lấy token
                var isLogin = authClient.Login(txtEmail.Text, txtPassword.Text);
                if (isLogin)
                {
                    MessageBox.Show("Đăng nhập thành công");
                }
                lbExpTime.Text = TokenHelper.GetExpireTime().ToString("dd/MM/yyyy HH:mm:ss");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLoadStore_Click(object sender, EventArgs e)
        {

        }
    }
}
