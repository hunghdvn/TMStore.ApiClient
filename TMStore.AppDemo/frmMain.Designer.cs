
namespace TMStore.AppDemo
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Node1");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Node2");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Node3");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Node0", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Node5");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Node6");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Node7");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Node4", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7});
            this.label1 = new System.Windows.Forms.Label();
            this.txtBaseUrl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.grvStores = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isHeadDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.keySearchDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isOnlineDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsStores = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLoadStore = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.productIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsProduct = new System.Windows.Forms.BindingSource(this.components);
            this.panel6 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lbSoTrang = new System.Windows.Forms.Label();
            this.lbTrangHT = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.imageURLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.externalSKUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productOptionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsProductOption = new System.Windows.Forms.BindingSource(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tvNhapKho = new System.Windows.Forms.TreeView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtOption = new System.Windows.Forms.TextBox();
            this.txtRfid = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtLicenseDate = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNoteNK = new System.Windows.Forms.TextBox();
            this.txtGateNK = new System.Windows.Forms.TextBox();
            this.txtStoreCodeNK = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.txtRfidXK = new System.Windows.Forms.RichTextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.txtGateXK = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtNoteXK = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStoreDestinationXK = new System.Windows.Forms.TextBox();
            this.txtStoreCodeXK = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fromStoreCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toStoreCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exportTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsGoodsMaster = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsDeliveryNoteIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inputPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productOptionIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiveQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productOptionNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsExportDetail = new System.Windows.Forms.BindingSource(this.components);
            this.panel7 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.txtStoreCodeGoods = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.imageURLDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.externalSKUDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productOptionIdDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsAdjustment = new System.Windows.Forms.BindingSource(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.txtStoreCodeAdjustment = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.productOptionIDDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.externalSKUDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productCodeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIdDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsTid = new System.Windows.Forms.BindingSource(this.components);
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtProductCodeTid = new System.Windows.Forms.TextBox();
            this.txtOptionIdTid = new System.Windows.Forms.TextBox();
            this.txtExternalTid = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtStoreCodeTid = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView8 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsCheckBalanceWare = new System.Windows.Forms.BindingSource(this.components);
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.txtNoteCheckBalanceWare = new System.Windows.Forms.TextBox();
            this.txtProductOptionIdWare = new System.Windows.Forms.TextBox();
            this.txtStoreCodeWare = new System.Windows.Forms.TextBox();
            this.txtChipCodeWare = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView7 = new System.Windows.Forms.DataGridView();
            this.sumDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productOptionIdDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsCheckBalanceProduct = new System.Windows.Forms.BindingSource(this.components);
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.txtNoteProduct = new System.Windows.Forms.TextBox();
            this.txtProductOptionIdConfirm = new System.Windows.Forms.TextBox();
            this.txtStoreCodeProduct = new System.Windows.Forms.TextBox();
            this.txtChipCodeProduct = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button10 = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.txtNoteConfirmExport = new System.Windows.Forms.TextBox();
            this.txtInternalDeliveryId = new System.Windows.Forms.TextBox();
            this.txtRfidConfirmExport = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.lbExpTime = new System.Windows.Forms.Label();
            this.bsMatHang = new System.Windows.Forms.BindingSource(this.components);
            this.bsChungLoai = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvStores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsStores)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProduct)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProductOption)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsGoodsMaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsExportDetail)).BeginInit();
            this.panel7.SuspendLayout();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAdjustment)).BeginInit();
            this.panel8.SuspendLayout();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTid)).BeginInit();
            this.panel9.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCheckBalanceWare)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCheckBalanceProduct)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsMatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsChungLoai)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Base url";
            // 
            // txtBaseUrl
            // 
            this.txtBaseUrl.Location = new System.Drawing.Point(76, 12);
            this.txtBaseUrl.Name = "txtBaseUrl";
            this.txtBaseUrl.Size = new System.Drawing.Size(170, 20);
            this.txtBaseUrl.TabIndex = 1;
            this.txtBaseUrl.Text = "http://103.249.103.82:12323/";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(297, 12);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(151, 20);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.Text = "trinhthang219@gmail.com";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(457, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(529, 12);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(92, 20);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Text = "fm1234";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(631, 10);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(80, 23);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Controls.Add(this.tabPage8);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 44);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1211, 655);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.grvStores);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1203, 629);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Danh sách kho";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // grvStores
            // 
            this.grvStores.AllowUserToAddRows = false;
            this.grvStores.AllowUserToDeleteRows = false;
            this.grvStores.AutoGenerateColumns = false;
            this.grvStores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvStores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvStores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.isHeadDataGridViewCheckBoxColumn,
            this.keySearchDataGridViewTextBoxColumn,
            this.isOnlineDataGridViewCheckBoxColumn,
            this.codeDataGridViewTextBoxColumn});
            this.grvStores.DataSource = this.bsStores;
            this.grvStores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvStores.Location = new System.Drawing.Point(3, 53);
            this.grvStores.Name = "grvStores";
            this.grvStores.ReadOnly = true;
            this.grvStores.RowHeadersVisible = false;
            this.grvStores.Size = new System.Drawing.Size(1197, 573);
            this.grvStores.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isHeadDataGridViewCheckBoxColumn
            // 
            this.isHeadDataGridViewCheckBoxColumn.DataPropertyName = "isHead";
            this.isHeadDataGridViewCheckBoxColumn.HeaderText = "isHead";
            this.isHeadDataGridViewCheckBoxColumn.Name = "isHeadDataGridViewCheckBoxColumn";
            this.isHeadDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // keySearchDataGridViewTextBoxColumn
            // 
            this.keySearchDataGridViewTextBoxColumn.DataPropertyName = "keySearch";
            this.keySearchDataGridViewTextBoxColumn.HeaderText = "keySearch";
            this.keySearchDataGridViewTextBoxColumn.Name = "keySearchDataGridViewTextBoxColumn";
            this.keySearchDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isOnlineDataGridViewCheckBoxColumn
            // 
            this.isOnlineDataGridViewCheckBoxColumn.DataPropertyName = "isOnline";
            this.isOnlineDataGridViewCheckBoxColumn.HeaderText = "isOnline";
            this.isOnlineDataGridViewCheckBoxColumn.Name = "isOnlineDataGridViewCheckBoxColumn";
            this.isOnlineDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "code";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsStores
            // 
            this.bsStores.DataSource = typeof(TMStore.ApiClient.Models.StoresModel);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnLoadStore);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1197, 50);
            this.panel2.TabIndex = 1;
            // 
            // btnLoadStore
            // 
            this.btnLoadStore.Location = new System.Drawing.Point(11, 13);
            this.btnLoadStore.Name = "btnLoadStore";
            this.btnLoadStore.Size = new System.Drawing.Size(136, 23);
            this.btnLoadStore.TabIndex = 0;
            this.btnLoadStore.Text = "Lấy danh sách kho";
            this.btnLoadStore.UseVisualStyleBackColor = true;
            this.btnLoadStore.Click += new System.EventHandler(this.btnLoadStore_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.splitContainer1);
            this.tabPage3.Controls.Add(this.panel5);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1203, 629);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Danh sách sản phẩm";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 59);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView3);
            this.splitContainer1.Panel1.Controls.Add(this.panel6);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView4);
            this.splitContainer1.Size = new System.Drawing.Size(1197, 567);
            this.splitContainer1.SplitterDistance = 588;
            this.splitContainer1.TabIndex = 3;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AllowUserToResizeRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn1,
            this.codeDataGridViewTextBoxColumn1});
            this.dataGridView3.DataSource = this.bsProduct;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(0, 56);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(588, 511);
            this.dataGridView3.TabIndex = 0;
            this.dataGridView3.SelectionChanged += new System.EventHandler(this.dataGridView3_SelectionChanged);
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            this.productIdDataGridViewTextBoxColumn.DataPropertyName = "productId";
            this.productIdDataGridViewTextBoxColumn.HeaderText = "productId";
            this.productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            this.productIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // codeDataGridViewTextBoxColumn1
            // 
            this.codeDataGridViewTextBoxColumn1.DataPropertyName = "code";
            this.codeDataGridViewTextBoxColumn1.HeaderText = "code";
            this.codeDataGridViewTextBoxColumn1.Name = "codeDataGridViewTextBoxColumn1";
            this.codeDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // bsProduct
            // 
            this.bsProduct.DataSource = typeof(TMStore.ApiClient.Models.ProductItemModel);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.button4);
            this.panel6.Controls.Add(this.button3);
            this.panel6.Controls.Add(this.lbSoTrang);
            this.panel6.Controls.Add(this.lbTrangHT);
            this.panel6.Controls.Add(this.label11);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(588, 56);
            this.panel6.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(290, 14);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(78, 23);
            this.button4.TabIndex = 1;
            this.button4.Text = "Lùi";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(424, 14);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(78, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "Tiếp";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lbSoTrang
            // 
            this.lbSoTrang.AutoSize = true;
            this.lbSoTrang.Location = new System.Drawing.Point(75, 19);
            this.lbSoTrang.Name = "lbSoTrang";
            this.lbSoTrang.Size = new System.Drawing.Size(0, 13);
            this.lbSoTrang.TabIndex = 0;
            // 
            // lbTrangHT
            // 
            this.lbTrangHT.AutoSize = true;
            this.lbTrangHT.Location = new System.Drawing.Point(183, 19);
            this.lbTrangHT.Name = "lbTrangHT";
            this.lbTrangHT.Size = new System.Drawing.Size(0, 13);
            this.lbTrangHT.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(26, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Số trang:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(139, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Trang:";
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.AllowUserToResizeRows = false;
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imageURLDataGridViewTextBoxColumn,
            this.externalSKUDataGridViewTextBoxColumn,
            this.sumDataGridViewTextBoxColumn,
            this.productOptionIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn2});
            this.dataGridView4.DataSource = this.bsProductOption;
            this.dataGridView4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView4.Enabled = false;
            this.dataGridView4.Location = new System.Drawing.Point(0, 0);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.RowHeadersVisible = false;
            this.dataGridView4.Size = new System.Drawing.Size(605, 567);
            this.dataGridView4.TabIndex = 0;
            // 
            // imageURLDataGridViewTextBoxColumn
            // 
            this.imageURLDataGridViewTextBoxColumn.DataPropertyName = "imageURL";
            this.imageURLDataGridViewTextBoxColumn.HeaderText = "imageURL";
            this.imageURLDataGridViewTextBoxColumn.Name = "imageURLDataGridViewTextBoxColumn";
            this.imageURLDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // externalSKUDataGridViewTextBoxColumn
            // 
            this.externalSKUDataGridViewTextBoxColumn.DataPropertyName = "externalSKU";
            this.externalSKUDataGridViewTextBoxColumn.HeaderText = "externalSKU";
            this.externalSKUDataGridViewTextBoxColumn.Name = "externalSKUDataGridViewTextBoxColumn";
            this.externalSKUDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sumDataGridViewTextBoxColumn
            // 
            this.sumDataGridViewTextBoxColumn.DataPropertyName = "sum";
            this.sumDataGridViewTextBoxColumn.HeaderText = "sum";
            this.sumDataGridViewTextBoxColumn.Name = "sumDataGridViewTextBoxColumn";
            this.sumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productOptionIDDataGridViewTextBoxColumn
            // 
            this.productOptionIDDataGridViewTextBoxColumn.DataPropertyName = "productOptionId";
            this.productOptionIDDataGridViewTextBoxColumn.HeaderText = "productOptionId";
            this.productOptionIDDataGridViewTextBoxColumn.Name = "productOptionIDDataGridViewTextBoxColumn";
            this.productOptionIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn2
            // 
            this.nameDataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn2.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn2.Name = "nameDataGridViewTextBoxColumn2";
            this.nameDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // bsProductOption
            // 
            this.bsProductOption.DataSource = typeof(TMStore.ApiClient.Models.ProductOptionModel);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.numericUpDown1);
            this.panel5.Controls.Add(this.button2);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1197, 56);
            this.panel5.TabIndex = 2;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(88, 19);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(41, 20);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(313, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Lấy danh sách sản phẩm";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Số sp/trang:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tvNhapKho);
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1203, 629);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Nhập kho";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tvNhapKho
            // 
            this.tvNhapKho.AllowDrop = true;
            this.tvNhapKho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvNhapKho.Location = new System.Drawing.Point(3, 205);
            this.tvNhapKho.Name = "tvNhapKho";
            treeNode1.Name = "Node1";
            treeNode1.Text = "Node1";
            treeNode2.Name = "Node2";
            treeNode2.Text = "Node2";
            treeNode3.Name = "Node3";
            treeNode3.Text = "Node3";
            treeNode4.Name = "Node0";
            treeNode4.Text = "Node0";
            treeNode5.Name = "Node5";
            treeNode5.Text = "Node5";
            treeNode6.Name = "Node6";
            treeNode6.Text = "Node6";
            treeNode7.Name = "Node7";
            treeNode7.Text = "Node7";
            treeNode8.Name = "Node4";
            treeNode8.Text = "Node4";
            this.tvNhapKho.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode8});
            this.tvNhapKho.Size = new System.Drawing.Size(1197, 421);
            this.tvNhapKho.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button5);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.txtOption);
            this.panel4.Controls.Add(this.txtRfid);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(3, 128);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1197, 77);
            this.panel4.TabIndex = 4;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(648, 35);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(97, 23);
            this.button5.TabIndex = 3;
            this.button5.Text = "Thêm";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "ProductOption";
            // 
            // txtOption
            // 
            this.txtOption.Location = new System.Drawing.Point(116, 11);
            this.txtOption.Name = "txtOption";
            this.txtOption.Size = new System.Drawing.Size(261, 20);
            this.txtOption.TabIndex = 9;
            // 
            // txtRfid
            // 
            this.txtRfid.Location = new System.Drawing.Point(116, 37);
            this.txtRfid.Name = "txtRfid";
            this.txtRfid.Size = new System.Drawing.Size(261, 20);
            this.txtRfid.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(32, 40);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "RFID sp";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtLicenseDate);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtNoteNK);
            this.panel3.Controls.Add(this.txtGateNK);
            this.panel3.Controls.Add(this.txtStoreCodeNK);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1197, 125);
            this.panel3.TabIndex = 3;
            // 
            // dtLicenseDate
            // 
            this.dtLicenseDate.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtLicenseDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtLicenseDate.Location = new System.Drawing.Point(130, 88);
            this.dtLicenseDate.Name = "dtLicenseDate";
            this.dtLicenseDate.Size = new System.Drawing.Size(200, 20);
            this.dtLicenseDate.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(874, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Nhập kho";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(21, 92);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "LicenseDate";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(23, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 13);
            this.label14.TabIndex = 5;
            this.label14.Text = "StoreCode";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Note";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(392, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Gate";
            // 
            // txtNoteNK
            // 
            this.txtNoteNK.Location = new System.Drawing.Point(130, 39);
            this.txtNoteNK.Multiline = true;
            this.txtNoteNK.Name = "txtNoteNK";
            this.txtNoteNK.Size = new System.Drawing.Size(500, 43);
            this.txtNoteNK.TabIndex = 8;
            // 
            // txtGateNK
            // 
            this.txtGateNK.Location = new System.Drawing.Point(460, 13);
            this.txtGateNK.Name = "txtGateNK";
            this.txtGateNK.Size = new System.Drawing.Size(170, 20);
            this.txtGateNK.TabIndex = 9;
            // 
            // txtStoreCodeNK
            // 
            this.txtStoreCodeNK.Location = new System.Drawing.Point(130, 13);
            this.txtStoreCodeNK.Name = "txtStoreCodeNK";
            this.txtStoreCodeNK.Size = new System.Drawing.Size(170, 20);
            this.txtStoreCodeNK.TabIndex = 10;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.txtRfidXK);
            this.tabPage4.Controls.Add(this.button6);
            this.tabPage4.Controls.Add(this.label17);
            this.tabPage4.Controls.Add(this.txtGateXK);
            this.tabPage4.Controls.Add(this.label18);
            this.tabPage4.Controls.Add(this.label16);
            this.tabPage4.Controls.Add(this.txtNoteXK);
            this.tabPage4.Controls.Add(this.label15);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.txtStoreDestinationXK);
            this.tabPage4.Controls.Add(this.txtStoreCodeXK);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1203, 629);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Xuất kho";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // txtRfidXK
            // 
            this.txtRfidXK.Location = new System.Drawing.Point(131, 94);
            this.txtRfidXK.Name = "txtRfidXK";
            this.txtRfidXK.Size = new System.Drawing.Size(757, 279);
            this.txtRfidXK.TabIndex = 18;
            this.txtRfidXK.Text = "";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(791, 449);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(97, 23);
            this.button6.TabIndex = 17;
            this.button6.Text = "Xuất kho";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(650, 22);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(30, 13);
            this.label17.TabIndex = 15;
            this.label17.Text = "Gate";
            // 
            // txtGateXK
            // 
            this.txtGateXK.Location = new System.Drawing.Point(718, 19);
            this.txtGateXK.Name = "txtGateXK";
            this.txtGateXK.Size = new System.Drawing.Size(170, 20);
            this.txtGateXK.TabIndex = 16;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(22, 97);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(26, 13);
            this.label18.TabIndex = 13;
            this.label18.Text = "rfids";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(22, 48);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(30, 13);
            this.label16.TabIndex = 13;
            this.label16.Text = "Note";
            // 
            // txtNoteXK
            // 
            this.txtNoteXK.Location = new System.Drawing.Point(131, 45);
            this.txtNoteXK.Multiline = true;
            this.txtNoteXK.Name = "txtNoteXK";
            this.txtNoteXK.Size = new System.Drawing.Size(757, 43);
            this.txtNoteXK.TabIndex = 14;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(340, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 13);
            this.label15.TabIndex = 11;
            this.label15.Text = "Mã kho đích";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Mã kho xuất";
            // 
            // txtStoreDestinationXK
            // 
            this.txtStoreDestinationXK.Location = new System.Drawing.Point(447, 19);
            this.txtStoreDestinationXK.Name = "txtStoreDestinationXK";
            this.txtStoreDestinationXK.Size = new System.Drawing.Size(170, 20);
            this.txtStoreDestinationXK.TabIndex = 12;
            // 
            // txtStoreCodeXK
            // 
            this.txtStoreCodeXK.Location = new System.Drawing.Point(131, 16);
            this.txtStoreCodeXK.Name = "txtStoreCodeXK";
            this.txtStoreCodeXK.Size = new System.Drawing.Size(170, 20);
            this.txtStoreCodeXK.TabIndex = 12;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.splitContainer2);
            this.tabPage5.Controls.Add(this.panel7);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1203, 629);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Tìm kiếm phiếu xuất kho";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 53);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dataGridView2);
            this.splitContainer2.Size = new System.Drawing.Size(1197, 573);
            this.splitContainer2.SplitterDistance = 206;
            this.splitContainer2.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.noteDataGridViewTextBoxColumn,
            this.fromStoreCodeDataGridViewTextBoxColumn,
            this.toStoreCodeDataGridViewTextBoxColumn,
            this.exportTypeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bsGoodsMaster;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1197, 206);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "note";
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            this.noteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fromStoreCodeDataGridViewTextBoxColumn
            // 
            this.fromStoreCodeDataGridViewTextBoxColumn.DataPropertyName = "fromStoreCode";
            this.fromStoreCodeDataGridViewTextBoxColumn.HeaderText = "fromStoreCode";
            this.fromStoreCodeDataGridViewTextBoxColumn.Name = "fromStoreCodeDataGridViewTextBoxColumn";
            this.fromStoreCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // toStoreCodeDataGridViewTextBoxColumn
            // 
            this.toStoreCodeDataGridViewTextBoxColumn.DataPropertyName = "toStoreCode";
            this.toStoreCodeDataGridViewTextBoxColumn.HeaderText = "toStoreCode";
            this.toStoreCodeDataGridViewTextBoxColumn.Name = "toStoreCodeDataGridViewTextBoxColumn";
            this.toStoreCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // exportTypeDataGridViewTextBoxColumn
            // 
            this.exportTypeDataGridViewTextBoxColumn.DataPropertyName = "exportType";
            this.exportTypeDataGridViewTextBoxColumn.HeaderText = "exportType";
            this.exportTypeDataGridViewTextBoxColumn.Name = "exportTypeDataGridViewTextBoxColumn";
            this.exportTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsGoodsMaster
            // 
            this.bsGoodsMaster.DataSource = typeof(TMStore.ApiClient.Models.GoodsDeliveryNoteModel);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn2,
            this.goodsDeliveryNoteIdDataGridViewTextBoxColumn,
            this.inputPriceDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.productOptionIdDataGridViewTextBoxColumn1,
            this.barcodeDataGridViewTextBoxColumn,
            this.receiveQuantityDataGridViewTextBoxColumn,
            this.salePriceDataGridViewTextBoxColumn,
            this.productCodeDataGridViewTextBoxColumn,
            this.productIdDataGridViewTextBoxColumn1,
            this.productNameDataGridViewTextBoxColumn,
            this.productOptionNameDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.bsExportDetail;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(1197, 363);
            this.dataGridView2.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn2
            // 
            this.idDataGridViewTextBoxColumn2.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn2.HeaderText = "id";
            this.idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            this.idDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // goodsDeliveryNoteIdDataGridViewTextBoxColumn
            // 
            this.goodsDeliveryNoteIdDataGridViewTextBoxColumn.DataPropertyName = "goodsDeliveryNoteId";
            this.goodsDeliveryNoteIdDataGridViewTextBoxColumn.HeaderText = "goodsDeliveryNoteId";
            this.goodsDeliveryNoteIdDataGridViewTextBoxColumn.Name = "goodsDeliveryNoteIdDataGridViewTextBoxColumn";
            this.goodsDeliveryNoteIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inputPriceDataGridViewTextBoxColumn
            // 
            this.inputPriceDataGridViewTextBoxColumn.DataPropertyName = "inputPrice";
            this.inputPriceDataGridViewTextBoxColumn.HeaderText = "inputPrice";
            this.inputPriceDataGridViewTextBoxColumn.Name = "inputPriceDataGridViewTextBoxColumn";
            this.inputPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productOptionIdDataGridViewTextBoxColumn1
            // 
            this.productOptionIdDataGridViewTextBoxColumn1.DataPropertyName = "productOptionId";
            this.productOptionIdDataGridViewTextBoxColumn1.HeaderText = "productOptionId";
            this.productOptionIdDataGridViewTextBoxColumn1.Name = "productOptionIdDataGridViewTextBoxColumn1";
            this.productOptionIdDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // barcodeDataGridViewTextBoxColumn
            // 
            this.barcodeDataGridViewTextBoxColumn.DataPropertyName = "barcode";
            this.barcodeDataGridViewTextBoxColumn.HeaderText = "barcode";
            this.barcodeDataGridViewTextBoxColumn.Name = "barcodeDataGridViewTextBoxColumn";
            this.barcodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // receiveQuantityDataGridViewTextBoxColumn
            // 
            this.receiveQuantityDataGridViewTextBoxColumn.DataPropertyName = "receiveQuantity";
            this.receiveQuantityDataGridViewTextBoxColumn.HeaderText = "receiveQuantity";
            this.receiveQuantityDataGridViewTextBoxColumn.Name = "receiveQuantityDataGridViewTextBoxColumn";
            this.receiveQuantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salePriceDataGridViewTextBoxColumn
            // 
            this.salePriceDataGridViewTextBoxColumn.DataPropertyName = "salePrice";
            this.salePriceDataGridViewTextBoxColumn.HeaderText = "salePrice";
            this.salePriceDataGridViewTextBoxColumn.Name = "salePriceDataGridViewTextBoxColumn";
            this.salePriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productCodeDataGridViewTextBoxColumn
            // 
            this.productCodeDataGridViewTextBoxColumn.DataPropertyName = "productCode";
            this.productCodeDataGridViewTextBoxColumn.HeaderText = "productCode";
            this.productCodeDataGridViewTextBoxColumn.Name = "productCodeDataGridViewTextBoxColumn";
            this.productCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productIdDataGridViewTextBoxColumn1
            // 
            this.productIdDataGridViewTextBoxColumn1.DataPropertyName = "productId";
            this.productIdDataGridViewTextBoxColumn1.HeaderText = "productId";
            this.productIdDataGridViewTextBoxColumn1.Name = "productIdDataGridViewTextBoxColumn1";
            this.productIdDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "productName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "productName";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productOptionNameDataGridViewTextBoxColumn
            // 
            this.productOptionNameDataGridViewTextBoxColumn.DataPropertyName = "productOptionName";
            this.productOptionNameDataGridViewTextBoxColumn.HeaderText = "productOptionName";
            this.productOptionNameDataGridViewTextBoxColumn.Name = "productOptionNameDataGridViewTextBoxColumn";
            this.productOptionNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsExportDetail
            // 
            this.bsExportDetail.DataSource = typeof(TMStore.ApiClient.Models.ExportDetailModel);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label19);
            this.panel7.Controls.Add(this.txtStoreCodeGoods);
            this.panel7.Controls.Add(this.button7);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(3, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1197, 50);
            this.panel7.TabIndex = 2;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(28, 19);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(57, 13);
            this.label19.TabIndex = 11;
            this.label19.Text = "StoreCode";
            // 
            // txtStoreCodeGoods
            // 
            this.txtStoreCodeGoods.Location = new System.Drawing.Point(135, 16);
            this.txtStoreCodeGoods.Name = "txtStoreCodeGoods";
            this.txtStoreCodeGoods.Size = new System.Drawing.Size(170, 20);
            this.txtStoreCodeGoods.TabIndex = 12;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(328, 14);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(136, 23);
            this.button7.TabIndex = 0;
            this.button7.Text = "Tìm phiếu xuất kho";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.splitContainer3);
            this.tabPage6.Controls.Add(this.panel8);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(1203, 629);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "InventoryAdjustment";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(3, 53);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.dataGridView5);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.richTextBox1);
            this.splitContainer3.Size = new System.Drawing.Size(1197, 573);
            this.splitContainer3.SplitterDistance = 956;
            this.splitContainer3.TabIndex = 5;
            // 
            // dataGridView5
            // 
            this.dataGridView5.AllowUserToAddRows = false;
            this.dataGridView5.AllowUserToDeleteRows = false;
            this.dataGridView5.AllowUserToResizeRows = false;
            this.dataGridView5.AutoGenerateColumns = false;
            this.dataGridView5.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imageURLDataGridViewTextBoxColumn1,
            this.externalSKUDataGridViewTextBoxColumn1,
            this.sumDataGridViewTextBoxColumn1,
            this.productOptionIdDataGridViewTextBoxColumn2});
            this.dataGridView5.DataSource = this.bsAdjustment;
            this.dataGridView5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView5.Location = new System.Drawing.Point(0, 0);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.ReadOnly = true;
            this.dataGridView5.RowHeadersVisible = false;
            this.dataGridView5.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView5.Size = new System.Drawing.Size(956, 573);
            this.dataGridView5.TabIndex = 4;
            this.dataGridView5.SelectionChanged += new System.EventHandler(this.dataGridView5_SelectionChanged);
            // 
            // imageURLDataGridViewTextBoxColumn1
            // 
            this.imageURLDataGridViewTextBoxColumn1.DataPropertyName = "imageURL";
            this.imageURLDataGridViewTextBoxColumn1.HeaderText = "imageURL";
            this.imageURLDataGridViewTextBoxColumn1.Name = "imageURLDataGridViewTextBoxColumn1";
            this.imageURLDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // externalSKUDataGridViewTextBoxColumn1
            // 
            this.externalSKUDataGridViewTextBoxColumn1.DataPropertyName = "externalSKU";
            this.externalSKUDataGridViewTextBoxColumn1.HeaderText = "externalSKU";
            this.externalSKUDataGridViewTextBoxColumn1.Name = "externalSKUDataGridViewTextBoxColumn1";
            this.externalSKUDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // sumDataGridViewTextBoxColumn1
            // 
            this.sumDataGridViewTextBoxColumn1.DataPropertyName = "sum";
            this.sumDataGridViewTextBoxColumn1.HeaderText = "sum";
            this.sumDataGridViewTextBoxColumn1.Name = "sumDataGridViewTextBoxColumn1";
            this.sumDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // productOptionIdDataGridViewTextBoxColumn2
            // 
            this.productOptionIdDataGridViewTextBoxColumn2.DataPropertyName = "productOptionId";
            this.productOptionIdDataGridViewTextBoxColumn2.HeaderText = "productOptionId";
            this.productOptionIdDataGridViewTextBoxColumn2.Name = "productOptionIdDataGridViewTextBoxColumn2";
            this.productOptionIdDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // bsAdjustment
            // 
            this.bsAdjustment.DataSource = typeof(TMStore.ApiClient.Models.ProductOptionModel);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(237, 573);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label20);
            this.panel8.Controls.Add(this.txtStoreCodeAdjustment);
            this.panel8.Controls.Add(this.button8);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(3, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1197, 50);
            this.panel8.TabIndex = 3;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(28, 19);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(57, 13);
            this.label20.TabIndex = 11;
            this.label20.Text = "StoreCode";
            // 
            // txtStoreCodeAdjustment
            // 
            this.txtStoreCodeAdjustment.Location = new System.Drawing.Point(135, 16);
            this.txtStoreCodeAdjustment.Name = "txtStoreCodeAdjustment";
            this.txtStoreCodeAdjustment.Size = new System.Drawing.Size(170, 20);
            this.txtStoreCodeAdjustment.TabIndex = 12;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(328, 14);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(136, 23);
            this.button8.TabIndex = 0;
            this.button8.Text = "Tìm sản phẩm trong kho";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.splitContainer4);
            this.tabPage7.Controls.Add(this.panel9);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(1203, 629);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Tid";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(3, 85);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.dataGridView6);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.richTextBox2);
            this.splitContainer4.Size = new System.Drawing.Size(1197, 541);
            this.splitContainer4.SplitterDistance = 956;
            this.splitContainer4.TabIndex = 6;
            // 
            // dataGridView6
            // 
            this.dataGridView6.AllowUserToAddRows = false;
            this.dataGridView6.AllowUserToDeleteRows = false;
            this.dataGridView6.AllowUserToResizeRows = false;
            this.dataGridView6.AutoGenerateColumns = false;
            this.dataGridView6.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productOptionIDDataGridViewTextBoxColumn3,
            this.externalSKUDataGridViewTextBoxColumn2,
            this.productCodeDataGridViewTextBoxColumn1,
            this.productIdDataGridViewTextBoxColumn2});
            this.dataGridView6.DataSource = this.bsTid;
            this.dataGridView6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView6.Location = new System.Drawing.Point(0, 0);
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.ReadOnly = true;
            this.dataGridView6.RowHeadersVisible = false;
            this.dataGridView6.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView6.Size = new System.Drawing.Size(956, 541);
            this.dataGridView6.TabIndex = 4;
            this.dataGridView6.SelectionChanged += new System.EventHandler(this.dataGridView6_SelectionChanged);
            // 
            // productOptionIDDataGridViewTextBoxColumn3
            // 
            this.productOptionIDDataGridViewTextBoxColumn3.DataPropertyName = "productOptionID";
            this.productOptionIDDataGridViewTextBoxColumn3.HeaderText = "productOptionID";
            this.productOptionIDDataGridViewTextBoxColumn3.Name = "productOptionIDDataGridViewTextBoxColumn3";
            this.productOptionIDDataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // externalSKUDataGridViewTextBoxColumn2
            // 
            this.externalSKUDataGridViewTextBoxColumn2.DataPropertyName = "externalSKU";
            this.externalSKUDataGridViewTextBoxColumn2.HeaderText = "externalSKU";
            this.externalSKUDataGridViewTextBoxColumn2.Name = "externalSKUDataGridViewTextBoxColumn2";
            this.externalSKUDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // productCodeDataGridViewTextBoxColumn1
            // 
            this.productCodeDataGridViewTextBoxColumn1.DataPropertyName = "productCode";
            this.productCodeDataGridViewTextBoxColumn1.HeaderText = "productCode";
            this.productCodeDataGridViewTextBoxColumn1.Name = "productCodeDataGridViewTextBoxColumn1";
            this.productCodeDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // productIdDataGridViewTextBoxColumn2
            // 
            this.productIdDataGridViewTextBoxColumn2.DataPropertyName = "productId";
            this.productIdDataGridViewTextBoxColumn2.HeaderText = "productId";
            this.productIdDataGridViewTextBoxColumn2.Name = "productIdDataGridViewTextBoxColumn2";
            this.productIdDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // bsTid
            // 
            this.bsTid.DataSource = typeof(TMStore.ApiClient.Models.TidProductModel);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox2.Location = new System.Drawing.Point(0, 0);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(237, 541);
            this.richTextBox2.TabIndex = 0;
            this.richTextBox2.Text = "";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.radioButton2);
            this.panel9.Controls.Add(this.radioButton1);
            this.panel9.Controls.Add(this.label24);
            this.panel9.Controls.Add(this.label23);
            this.panel9.Controls.Add(this.label22);
            this.panel9.Controls.Add(this.txtProductCodeTid);
            this.panel9.Controls.Add(this.txtOptionIdTid);
            this.panel9.Controls.Add(this.txtExternalTid);
            this.panel9.Controls.Add(this.label21);
            this.panel9.Controls.Add(this.txtStoreCodeTid);
            this.panel9.Controls.Add(this.button9);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(3, 3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1197, 82);
            this.panel9.TabIndex = 4;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(611, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(106, 17);
            this.radioButton2.TabIndex = 13;
            this.radioButton2.Text = "GetTidByProduct";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(418, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(137, 17);
            this.radioButton1.TabIndex = 13;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "GetTidByProductOption";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(624, 45);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(72, 13);
            this.label24.TabIndex = 11;
            this.label24.Text = "Product Code";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(311, 45);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(86, 13);
            this.label23.TabIndex = 11;
            this.label23.Text = "product option id";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(20, 45);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(64, 13);
            this.label22.TabIndex = 11;
            this.label22.Text = "ExternalSku";
            // 
            // txtProductCodeTid
            // 
            this.txtProductCodeTid.Location = new System.Drawing.Point(731, 42);
            this.txtProductCodeTid.Name = "txtProductCodeTid";
            this.txtProductCodeTid.ReadOnly = true;
            this.txtProductCodeTid.Size = new System.Drawing.Size(170, 20);
            this.txtProductCodeTid.TabIndex = 12;
            // 
            // txtOptionIdTid
            // 
            this.txtOptionIdTid.Location = new System.Drawing.Point(418, 42);
            this.txtOptionIdTid.Name = "txtOptionIdTid";
            this.txtOptionIdTid.Size = new System.Drawing.Size(170, 20);
            this.txtOptionIdTid.TabIndex = 12;
            // 
            // txtExternalTid
            // 
            this.txtExternalTid.Location = new System.Drawing.Point(127, 42);
            this.txtExternalTid.Name = "txtExternalTid";
            this.txtExternalTid.Size = new System.Drawing.Size(170, 20);
            this.txtExternalTid.TabIndex = 12;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(20, 19);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(57, 13);
            this.label21.TabIndex = 11;
            this.label21.Text = "StoreCode";
            // 
            // txtStoreCodeTid
            // 
            this.txtStoreCodeTid.Location = new System.Drawing.Point(127, 16);
            this.txtStoreCodeTid.Name = "txtStoreCodeTid";
            this.txtStoreCodeTid.Size = new System.Drawing.Size(170, 20);
            this.txtStoreCodeTid.TabIndex = 12;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(996, 40);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(136, 23);
            this.button9.TabIndex = 0;
            this.button9.Text = "Tìm sản phẩm trong kho";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.groupBox3);
            this.tabPage8.Controls.Add(this.groupBox2);
            this.tabPage8.Controls.Add(this.groupBox1);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(1203, 629);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "Kiểm kho";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView8);
            this.groupBox3.Controls.Add(this.button13);
            this.groupBox3.Controls.Add(this.button14);
            this.groupBox3.Controls.Add(this.label34);
            this.groupBox3.Controls.Add(this.label35);
            this.groupBox3.Controls.Add(this.label36);
            this.groupBox3.Controls.Add(this.label37);
            this.groupBox3.Controls.Add(this.label38);
            this.groupBox3.Controls.Add(this.txtNoteCheckBalanceWare);
            this.groupBox3.Controls.Add(this.txtProductOptionIdWare);
            this.groupBox3.Controls.Add(this.txtStoreCodeWare);
            this.groupBox3.Controls.Add(this.txtChipCodeWare);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(3, 369);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1197, 240);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tạo phiếu kiểm toàn bộ kho";
            // 
            // dataGridView8
            // 
            this.dataGridView8.AllowUserToAddRows = false;
            this.dataGridView8.AllowUserToDeleteRows = false;
            this.dataGridView8.AutoGenerateColumns = false;
            this.dataGridView8.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView8.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataGridView8.DataSource = this.bsCheckBalanceWare;
            this.dataGridView8.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView8.Location = new System.Drawing.Point(645, 16);
            this.dataGridView8.Name = "dataGridView8";
            this.dataGridView8.ReadOnly = true;
            this.dataGridView8.RowHeadersVisible = false;
            this.dataGridView8.Size = new System.Drawing.Size(549, 221);
            this.dataGridView8.TabIndex = 23;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "sum";
            this.dataGridViewTextBoxColumn1.HeaderText = "sum";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "productOptionId";
            this.dataGridViewTextBoxColumn2.HeaderText = "productOptionId";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // bsCheckBalanceWare
            // 
            this.bsCheckBalanceWare.DataSource = typeof(TMStore.ApiClient.Models.ProductOptionModel);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(409, 183);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(119, 23);
            this.button13.TabIndex = 16;
            this.button13.Text = "Thêm chi tiết";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(453, 19);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(75, 23);
            this.button14.TabIndex = 16;
            this.button14.Text = "Xác nhận";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.ForeColor = System.Drawing.Color.Red;
            this.label34.Location = new System.Drawing.Point(147, 156);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(325, 13);
            this.label34.TabIndex = 22;
            this.label34.Text = "Nhập các chip code cách nhau dấu phẩy: IDCHIP001, IDCHIP002";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(18, 51);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(28, 13);
            this.label35.TabIndex = 16;
            this.label35.Text = "note";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(43, 110);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(83, 13);
            this.label36.TabIndex = 17;
            this.label36.Text = "productOptionId";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(18, 22);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(57, 13);
            this.label37.TabIndex = 17;
            this.label37.Text = "StoreCode";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(43, 136);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(55, 13);
            this.label38.TabIndex = 18;
            this.label38.Text = "Chip code";
            // 
            // txtNoteCheckBalanceWare
            // 
            this.txtNoteCheckBalanceWare.Location = new System.Drawing.Point(125, 48);
            this.txtNoteCheckBalanceWare.Name = "txtNoteCheckBalanceWare";
            this.txtNoteCheckBalanceWare.Size = new System.Drawing.Size(387, 20);
            this.txtNoteCheckBalanceWare.TabIndex = 19;
            // 
            // txtProductOptionIdWare
            // 
            this.txtProductOptionIdWare.Location = new System.Drawing.Point(150, 107);
            this.txtProductOptionIdWare.Name = "txtProductOptionIdWare";
            this.txtProductOptionIdWare.Size = new System.Drawing.Size(387, 20);
            this.txtProductOptionIdWare.TabIndex = 20;
            // 
            // txtStoreCodeWare
            // 
            this.txtStoreCodeWare.Location = new System.Drawing.Point(125, 19);
            this.txtStoreCodeWare.Name = "txtStoreCodeWare";
            this.txtStoreCodeWare.Size = new System.Drawing.Size(249, 20);
            this.txtStoreCodeWare.TabIndex = 20;
            // 
            // txtChipCodeWare
            // 
            this.txtChipCodeWare.Location = new System.Drawing.Point(150, 133);
            this.txtChipCodeWare.Name = "txtChipCodeWare";
            this.txtChipCodeWare.Size = new System.Drawing.Size(387, 20);
            this.txtChipCodeWare.TabIndex = 21;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView7);
            this.groupBox2.Controls.Add(this.button12);
            this.groupBox2.Controls.Add(this.button11);
            this.groupBox2.Controls.Add(this.label29);
            this.groupBox2.Controls.Add(this.label30);
            this.groupBox2.Controls.Add(this.label33);
            this.groupBox2.Controls.Add(this.label31);
            this.groupBox2.Controls.Add(this.label32);
            this.groupBox2.Controls.Add(this.txtNoteProduct);
            this.groupBox2.Controls.Add(this.txtProductOptionIdConfirm);
            this.groupBox2.Controls.Add(this.txtStoreCodeProduct);
            this.groupBox2.Controls.Add(this.txtChipCodeProduct);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(3, 129);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1197, 240);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tạo phiếu kiểm theo sản phẩm";
            // 
            // dataGridView7
            // 
            this.dataGridView7.AllowUserToAddRows = false;
            this.dataGridView7.AllowUserToDeleteRows = false;
            this.dataGridView7.AutoGenerateColumns = false;
            this.dataGridView7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView7.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sumDataGridViewTextBoxColumn2,
            this.productOptionIdDataGridViewTextBoxColumn4});
            this.dataGridView7.DataSource = this.bsCheckBalanceProduct;
            this.dataGridView7.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView7.Location = new System.Drawing.Point(645, 16);
            this.dataGridView7.Name = "dataGridView7";
            this.dataGridView7.ReadOnly = true;
            this.dataGridView7.RowHeadersVisible = false;
            this.dataGridView7.Size = new System.Drawing.Size(549, 221);
            this.dataGridView7.TabIndex = 23;
            // 
            // sumDataGridViewTextBoxColumn2
            // 
            this.sumDataGridViewTextBoxColumn2.DataPropertyName = "sum";
            this.sumDataGridViewTextBoxColumn2.HeaderText = "sum";
            this.sumDataGridViewTextBoxColumn2.Name = "sumDataGridViewTextBoxColumn2";
            this.sumDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // productOptionIdDataGridViewTextBoxColumn4
            // 
            this.productOptionIdDataGridViewTextBoxColumn4.DataPropertyName = "productOptionId";
            this.productOptionIdDataGridViewTextBoxColumn4.HeaderText = "productOptionId";
            this.productOptionIdDataGridViewTextBoxColumn4.Name = "productOptionIdDataGridViewTextBoxColumn4";
            this.productOptionIdDataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // bsCheckBalanceProduct
            // 
            this.bsCheckBalanceProduct.DataSource = typeof(TMStore.ApiClient.Models.ProductOptionModel);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(409, 183);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(119, 23);
            this.button12.TabIndex = 16;
            this.button12.Text = "Thêm chi tiết";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(453, 19);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 23);
            this.button11.TabIndex = 16;
            this.button11.Text = "Xác nhận";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.Red;
            this.label29.Location = new System.Drawing.Point(147, 145);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(325, 13);
            this.label29.TabIndex = 22;
            this.label29.Text = "Nhập các chip code cách nhau dấu phẩy: IDCHIP001, IDCHIP002";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(18, 48);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(28, 13);
            this.label30.TabIndex = 16;
            this.label30.Text = "note";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(43, 99);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(83, 13);
            this.label33.TabIndex = 17;
            this.label33.Text = "productOptionId";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(18, 22);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(57, 13);
            this.label31.TabIndex = 17;
            this.label31.Text = "StoreCode";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(43, 125);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(55, 13);
            this.label32.TabIndex = 18;
            this.label32.Text = "Chip code";
            // 
            // txtNoteProduct
            // 
            this.txtNoteProduct.Location = new System.Drawing.Point(125, 45);
            this.txtNoteProduct.Name = "txtNoteProduct";
            this.txtNoteProduct.Size = new System.Drawing.Size(387, 20);
            this.txtNoteProduct.TabIndex = 19;
            // 
            // txtProductOptionIdConfirm
            // 
            this.txtProductOptionIdConfirm.Location = new System.Drawing.Point(150, 96);
            this.txtProductOptionIdConfirm.Name = "txtProductOptionIdConfirm";
            this.txtProductOptionIdConfirm.Size = new System.Drawing.Size(387, 20);
            this.txtProductOptionIdConfirm.TabIndex = 20;
            // 
            // txtStoreCodeProduct
            // 
            this.txtStoreCodeProduct.Location = new System.Drawing.Point(125, 19);
            this.txtStoreCodeProduct.Name = "txtStoreCodeProduct";
            this.txtStoreCodeProduct.Size = new System.Drawing.Size(249, 20);
            this.txtStoreCodeProduct.TabIndex = 20;
            // 
            // txtChipCodeProduct
            // 
            this.txtChipCodeProduct.Location = new System.Drawing.Point(150, 122);
            this.txtChipCodeProduct.Name = "txtChipCodeProduct";
            this.txtChipCodeProduct.Size = new System.Drawing.Size(387, 20);
            this.txtChipCodeProduct.TabIndex = 21;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button10);
            this.groupBox1.Controls.Add(this.label27);
            this.groupBox1.Controls.Add(this.label28);
            this.groupBox1.Controls.Add(this.label26);
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Controls.Add(this.txtNoteConfirmExport);
            this.groupBox1.Controls.Add(this.txtInternalDeliveryId);
            this.groupBox1.Controls.Add(this.txtRfidConfirmExport);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1197, 126);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Xác nhận nhập kho ở điểm bán lẻ";
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(1061, 94);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 16;
            this.button10.Text = "Xác nhận";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.Red;
            this.label27.Location = new System.Drawing.Point(132, 50);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(292, 13);
            this.label27.TabIndex = 15;
            this.label27.Text = "Nhập các rfid cách nhau dấu phẩy: IDCHIP001, IDCHIP002";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(28, 99);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(28, 13);
            this.label28.TabIndex = 13;
            this.label28.Text = "note";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(28, 73);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(90, 13);
            this.label26.TabIndex = 13;
            this.label26.Text = "internalDeliveryID";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(28, 30);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(21, 13);
            this.label25.TabIndex = 13;
            this.label25.Text = "rfid";
            // 
            // txtNoteConfirmExport
            // 
            this.txtNoteConfirmExport.Location = new System.Drawing.Point(135, 96);
            this.txtNoteConfirmExport.Name = "txtNoteConfirmExport";
            this.txtNoteConfirmExport.Size = new System.Drawing.Size(900, 20);
            this.txtNoteConfirmExport.TabIndex = 14;
            // 
            // txtInternalDeliveryId
            // 
            this.txtInternalDeliveryId.Location = new System.Drawing.Point(135, 70);
            this.txtInternalDeliveryId.Name = "txtInternalDeliveryId";
            this.txtInternalDeliveryId.Size = new System.Drawing.Size(900, 20);
            this.txtInternalDeliveryId.TabIndex = 14;
            // 
            // txtRfidConfirmExport
            // 
            this.txtRfidConfirmExport.Location = new System.Drawing.Point(135, 27);
            this.txtRfidConfirmExport.Name = "txtRfidConfirmExport";
            this.txtRfidConfirmExport.Size = new System.Drawing.Size(900, 20);
            this.txtRfidConfirmExport.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.lbExpTime);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtBaseUrl);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1211, 44);
            this.panel1.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(794, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Expire time";
            // 
            // lbExpTime
            // 
            this.lbExpTime.AutoSize = true;
            this.lbExpTime.Location = new System.Drawing.Point(858, 15);
            this.lbExpTime.Name = "lbExpTime";
            this.lbExpTime.Size = new System.Drawing.Size(10, 13);
            this.lbExpTime.TabIndex = 0;
            this.lbExpTime.Text = ".";
            // 
            // bsMatHang
            // 
            this.bsMatHang.DataSource = typeof(TMStore.ApiClient.Models.ProductItemModel);
            // 
            // bsChungLoai
            // 
            this.bsChungLoai.DataSource = typeof(TMStore.ApiClient.Models.ProductOptionModel);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 699);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvStores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsStores)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProduct)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProductOption)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsGoodsMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsExportDetail)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAdjustment)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTid)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.tabPage8.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCheckBalanceWare)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCheckBalanceProduct)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsMatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsChungLoai)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBaseUrl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbExpTime;
        private System.Windows.Forms.DataGridView grvStores;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isHeadDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn keySearchDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isOnlineDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsStores;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLoadStore;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNoteNK;
        private System.Windows.Forms.TextBox txtGateNK;
        private System.Windows.Forms.TextBox txtStoreCodeNK;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource bsProduct;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lbTrangHT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbSoTrang;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.BindingSource bsProductOption;
        private System.Windows.Forms.DataGridViewTextBoxColumn imageURLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn externalSKUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productOptionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.BindingSource bsChungLoai;
        private System.Windows.Forms.BindingSource bsMatHang;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txtRfid;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtOption;
        private System.Windows.Forms.DateTimePicker dtLicenseDate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TreeView tvNhapKho;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtGateXK;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtNoteXK;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStoreDestinationXK;
        private System.Windows.Forms.TextBox txtStoreCodeXK;
        private System.Windows.Forms.RichTextBox txtRfidXK;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fromStoreCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toStoreCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn exportTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsGoodsMaster;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsDeliveryNoteIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inputPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productOptionIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receiveQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productOptionNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsExportDetail;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtStoreCodeGoods;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtStoreCodeAdjustment;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.BindingSource bsAdjustment;
        private System.Windows.Forms.DataGridViewTextBoxColumn imageURLDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn externalSKUDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productOptionIdDataGridViewTextBoxColumn2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.DataGridView dataGridView6;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtProductCodeTid;
        private System.Windows.Forms.TextBox txtOptionIdTid;
        private System.Windows.Forms.TextBox txtExternalTid;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtStoreCodeTid;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.DataGridViewTextBoxColumn productOptionIDDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn externalSKUDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCodeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource bsTid;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtInternalDeliveryId;
        private System.Windows.Forms.TextBox txtRfidConfirmExport;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txtNoteConfirmExport;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView7;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox txtNoteProduct;
        private System.Windows.Forms.TextBox txtProductOptionIdConfirm;
        private System.Windows.Forms.TextBox txtStoreCodeProduct;
        private System.Windows.Forms.TextBox txtChipCodeProduct;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource bsCheckBalanceProduct;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.TextBox txtNoteCheckBalanceWare;
        private System.Windows.Forms.TextBox txtProductOptionIdWare;
        private System.Windows.Forms.TextBox txtStoreCodeWare;
        private System.Windows.Forms.TextBox txtChipCodeWare;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn productOptionIdDataGridViewTextBoxColumn4;
        private System.Windows.Forms.BindingSource bsCheckBalanceWare;
    }
}

