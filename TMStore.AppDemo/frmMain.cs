using System;
using System.Windows.Forms;
using TMStore.ApiClient.Clients;
using TMStore.ApiClient.Helpers;

namespace TMStore.AppDemo
{
    public partial class frmMain : Form
    {
        private readonly IAuthClient authClient;
        private readonly IStoresClient storesClient;
        private readonly IProductClient productClient;

        public frmMain()
        {
            InitializeComponent();
            authClient = new AuthClient(); ;
            storesClient = new StoresClient();
            productClient = new ProductClient();
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
            try
            {
                var lstStores = storesClient.GetListStores();
                bsStores.DataSource = lstStores;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var pageSize = numericUpDown1.Value;
                var result = productClient.GetListProduct("", 0, 0, 0, 1, (int)pageSize);
                bsProduct.DataSource = result.items;
                lbSoTrang.Text = result.totalPage.ToString();
                lbTrangHT.Text = result.page.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
