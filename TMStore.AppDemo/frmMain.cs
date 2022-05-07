using System;
using System.Windows.Forms;
using TMStore.ApiClient.Clients;
using TMStore.ApiClient.Helpers;
using TMStore.ApiClient.Models;

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
            if (lbTrangHT.Text.IsEmpty())
            {
                return;
            }
            var page = int.Parse(lbTrangHT.Text);
            if (page <= 1)
            {
                return;
            }

            var pageSize = numericUpDown1.Value;
            var result = productClient.GetListProduct("", 0, 0, 0, page - 1, (int)pageSize);
            bsProduct.DataSource = result.items;
            lbSoTrang.Text = result.totalPage.ToString();
            lbTrangHT.Text = result.page.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (lbTrangHT.Text.IsEmpty())
            {
                return;
            }
            var page = int.Parse(lbTrangHT.Text);
            var totalPage = int.Parse(lbSoTrang.Text);
            if (page >= totalPage)
            {
                return;
            }

            var pageSize = numericUpDown1.Value;
            var result = productClient.GetListProduct("", 0, 0, 0, page + 1, (int)pageSize);
            bsProduct.DataSource = result.items;
            lbSoTrang.Text = result.totalPage.ToString();
            lbTrangHT.Text = result.page.ToString();
        }

        private void dataGridView3_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView3.SelectedRows.Count > 0)
                {
                    var selected = dataGridView3.SelectedRows[0].DataBoundItem as ProductItemModel;
                    if (selected == null)
                        return;
                    bsProductOption.DataSource = selected.options;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
