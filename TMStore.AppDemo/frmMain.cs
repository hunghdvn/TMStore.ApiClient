using System;
using System.Collections.Generic;
using System.Linq;
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
        private readonly IInventoryClient inventoryClient;
        private readonly IGoodsDeliveryNoteClient goodsDeliveryNoteClient;
        private readonly IInventoryAdjustmentClient inventoryAdjustmentClient;

        public frmMain()
        {
            InitializeComponent();
            authClient = new AuthClient(); ;
            storesClient = new StoresClient();
            productClient = new ProductClient();
            inventoryClient = new InventoryClient();
            goodsDeliveryNoteClient = new GoodsDeliveryNoteClient();
            inventoryAdjustmentClient = new InventoryAdjustmentClient();
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
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private List<ProductModel> products = null;

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtOption.Text.IsEmpty())
                {
                    MessageBox.Show("Thiếu option id");
                    return;
                }
                if (txtRfid.Text.IsEmpty())
                {
                    MessageBox.Show("Thiếu RFID");
                    return;
                }
                if (products.IsEmpty())
                {
                    products = new List<ProductModel>();
                }
                int optionId = int.Parse(txtOption.Text);
                var product = products.FirstOrDefault(s => s.productOptionId == optionId);
                if (product == null)
                {
                    product = new ProductModel
                    {
                        printQuantity = 1,
                        productOptionId = optionId,
                        rfids = new List<string> { txtRfid.Text.Trim() }
                    };
                    products.Add(product);
                }
                else
                {
                    product.rfids.Add(txtRfid.Text.Trim());
                    product.printQuantity += 1;
                }
                ShowDataNhapKho();
                txtRfid.Text = "";
                txtRfid.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ShowDataNhapKho()
        {
            tvNhapKho.Nodes.Clear();
            var lstOptionId = products.Select(s => s.productOptionId).ToList();
            foreach (var item in lstOptionId)
            {
                var childNode = new TreeNode();
                childNode.Text = item.ToString();
                var rfIds = products.FirstOrDefault(s => s.productOptionId == item).rfids;
                foreach (var rfid in rfIds)
                {
                    childNode.Nodes.Add(rfid);
                }
                tvNhapKho.Nodes.Add(childNode);
            }
            tvNhapKho.ExpandAll();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var result = inventoryClient.NhapKho(txtStoreCodeNK.Text.Trim(), txtGateNK.Text.Trim(), txtNoteNK.Text.Trim(), dtLicenseDate.Value, products);
                MessageBox.Show("Đã nhập kho");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtRfidXK.Text.IsEmpty())
                {
                    MessageBox.Show("Chưa nhập Rfid");
                    return;
                }
                var lstRfids = txtRfidXK.Text.Split('\n').ToList();
                var result = inventoryClient.XuatKho(txtStoreCodeXK.Text.Trim(), txtStoreDestinationXK.Text.Trim(), txtNoteXK.Text.Trim(), txtGateXK.Text.Trim(), lstRfids);
                MessageBox.Show("Đã xuất kho");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtStoreCodeGoods.Text.IsEmpty())
                {
                    MessageBox.Show("Chưa nhập StoreCode");
                    return;
                }
                var result = goodsDeliveryNoteClient.GetListByStoreCode(txtStoreCodeGoods.Text.Trim());
                bsGoodsMaster.DataSource = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    var selected = dataGridView1.SelectedRows[0].DataBoundItem as GoodsDeliveryNoteModel;
                    if (selected == null)
                        return;
                    bsExportDetail.DataSource = selected.exportDetails;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtStoreCodeAdjustment.Text.IsEmpty())
                {
                    MessageBox.Show("Chưa nhập StoreCode");
                    return;
                }
                var result = inventoryAdjustmentClient.GetListByStoreCode(txtStoreCodeAdjustment.Text.Trim());
                bsAdjustment.DataSource = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView5_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView5.SelectedRows.Count > 0)
                {
                    var selected = dataGridView5.SelectedRows[0].DataBoundItem as ProductOptionModel;
                    if (selected == null)
                        return;
                    var lstChipCode = selected.chipCode;
                    richTextBox1.Text = "";
                    foreach (var chip in lstChipCode)
                    {
                        richTextBox1.Text += chip + "\r\n";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
