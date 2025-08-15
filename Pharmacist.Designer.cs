namespace PharmasyApplication
{
    partial class Pharmacist
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pharmacist));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new PharmasyApplication.DataSet1();
            this.providersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getItemsInStockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.simpleItemsInStockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getExpiredItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.batchesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.providersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.itemsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.addArrive = new System.Data.SqlClient.SqlCommand();
            this.itemsTableAdapter = new PharmasyApplication.DataSet1TableAdapters.ItemsTableAdapter();
            this.providersTableAdapter = new PharmasyApplication.DataSet1TableAdapters.ProvidersTableAdapter();
            this.fKArrivesProvidersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.arrivesTableAdapter = new PharmasyApplication.DataSet1TableAdapters.ArrivesTableAdapter();
            this.addExpense = new System.Data.SqlClient.SqlCommand();
            this.categoriesTableAdapter = new PharmasyApplication.DataSet1TableAdapters.CategoriesTableAdapter();
            this.getItemsInStockTableAdapter = new PharmasyApplication.DataSet1TableAdapters.getItemsInStockTableAdapter();
            this.simpleItemsInStockTableAdapter = new PharmasyApplication.DataSet1TableAdapters.SimpleItemsInStockTableAdapter();
            this.batchesTableAdapter = new PharmasyApplication.DataSet1TableAdapters.BatchesTableAdapter();
            this.WriteOffBatch = new System.Data.SqlClient.SqlCommand();
            this.WriteOffAllExpiredItems = new System.Data.SqlClient.SqlCommand();
            this.getExpiredItemsTableAdapter = new PharmasyApplication.DataSet1TableAdapters.getExpiredItemsTableAdapter();
            this.getProvidersItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getProvidersItemsTableAdapter = new PharmasyApplication.DataSet1TableAdapters.getProvidersItemsTableAdapter();
            this.providerItemsInStockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batchDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productionDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expirationDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel15 = new System.Windows.Forms.TableLayoutPanel();
            this.dateTimePickerWriteOff = new System.Windows.Forms.DateTimePicker();
            this.comboBoxWriteOffBatch = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonWriteOffAllExpiredItems = new System.Windows.Forms.Button();
            this.buttonWriteOffBatch = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batchDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchasePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonCreateExpense = new System.Windows.Forms.Button();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerExpense = new System.Windows.Forms.DateTimePicker();
            this.textBoxExQuantity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxExItemName = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxExPrice = new System.Windows.Forms.TextBox();
            this.labelPriceExpense = new System.Windows.Forms.Label();
            this.stockItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ButtonDiscountSalePrice = new System.Windows.Forms.Button();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBoxExItemFilterCollection = new System.Windows.Forms.ComboBox();
            this.buttonExpItemFilter = new System.Windows.Forms.Button();
            this.comboBoxCategoryFilterCollection = new System.Windows.Forms.ComboBox();
            this.buttonExCategoryFilter = new System.Windows.Forms.Button();
            this.buttonExClearFilter = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bindingNavigator2 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewItemsInStock = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonAddArrive = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxSalePriceArrive = new System.Windows.Forms.TextBox();
            this.labelOrderDate = new System.Windows.Forms.Label();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.labelItem = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxItemName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelProvider = new System.Windows.Forms.Label();
            this.comboBoxProvider = new System.Windows.Forms.ComboBox();
            this.dateTimePickerOrder = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel13 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel14 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonProviderFilter = new System.Windows.Forms.Button();
            this.buttonNameFilter = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Batch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchasePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.providerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpirationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salePriceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.providersItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.createArriveBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControlArrives = new System.Windows.Forms.TabControl();
            this.getPrice = new System.Data.SqlClient.SqlCommand();
            this.providersItemsTableAdapter = new PharmasyApplication.DataSet1TableAdapters.ProvidersItemsTableAdapter();
            this.stockItemsTableAdapter = new PharmasyApplication.DataSet1TableAdapters.StockItemsTableAdapter();
            this.createArriveTableAdapter = new PharmasyApplication.DataSet1TableAdapters.createArriveTableAdapter();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.providersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getItemsInStockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleItemsInStockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getExpiredItemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.batchesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.providersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKArrivesProvidersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getProvidersItemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.providerItemsInStockBindingSource)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel15.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockItemsBindingSource)).BeginInit();
            this.tableLayoutPanel11.SuspendLayout();
            this.tableLayoutPanel12.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).BeginInit();
            this.bindingNavigator2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItemsInStock)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel13.SuspendLayout();
            this.tableLayoutPanel14.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.providersItemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.createArriveBindingSource)).BeginInit();
            this.tabControlArrives.SuspendLayout();
            this.SuspendLayout();
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "Items";
            this.itemsBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // providersBindingSource
            // 
            this.providersBindingSource.DataMember = "Providers";
            this.providersBindingSource.DataSource = this.dataSet1;
            // 
            // itemsBindingSource2
            // 
            this.itemsBindingSource2.DataMember = "Items";
            this.itemsBindingSource2.DataSource = this.dataSet1;
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "Categories";
            this.categoriesBindingSource.DataSource = this.dataSet1;
            // 
            // getItemsInStockBindingSource
            // 
            this.getItemsInStockBindingSource.DataMember = "getItemsInStock";
            this.getItemsInStockBindingSource.DataSource = this.dataSet1;
            // 
            // simpleItemsInStockBindingSource
            // 
            this.simpleItemsInStockBindingSource.DataMember = "SimpleItemsInStock";
            this.simpleItemsInStockBindingSource.DataSource = this.dataSet1;
            // 
            // getExpiredItemsBindingSource
            // 
            this.getExpiredItemsBindingSource.DataMember = "getExpiredItems";
            this.getExpiredItemsBindingSource.DataSource = this.dataSet1;
            // 
            // providersBindingSource1
            // 
            this.providersBindingSource1.DataMember = "Providers";
            this.providersBindingSource1.DataSource = this.dataSet1;
            // 
            // itemsBindingSource1
            // 
            this.itemsBindingSource1.DataMember = "Items";
            this.itemsBindingSource1.DataSource = this.dataSet1;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=localhost;Initial Catalog=PharmacyDB;Persist Security Info=True;User " +
    "ID=sa;Password=73590332417PoL;Encrypt=True;TrustServerCertificate=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // addArrive
            // 
            this.addArrive.CommandText = "createArrive";
            this.addArrive.CommandType = System.Data.CommandType.StoredProcedure;
            this.addArrive.Connection = this.sqlConnection1;
            this.addArrive.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@orderDate", System.Data.SqlDbType.DateTime),
            new System.Data.SqlClient.SqlParameter("@item", System.Data.SqlDbType.VarChar, 200),
            new System.Data.SqlClient.SqlParameter("@provider", System.Data.SqlDbType.VarChar, 200),
            new System.Data.SqlClient.SqlParameter("@quantity", System.Data.SqlDbType.Int),
            new System.Data.SqlClient.SqlParameter("@salePrice", System.Data.SqlDbType.Decimal),
            new System.Data.SqlClient.SqlParameter("@message", System.Data.SqlDbType.VarChar, 5000, System.Data.ParameterDirection.Output, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, "-"),
            new System.Data.SqlClient.SqlParameter("@cost", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Output, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // itemsTableAdapter
            // 
            this.itemsTableAdapter.ClearBeforeFill = true;
            // 
            // providersTableAdapter
            // 
            this.providersTableAdapter.ClearBeforeFill = true;
            // 
            // fKArrivesProvidersBindingSource
            // 
            this.fKArrivesProvidersBindingSource.DataMember = "FK_Arrives_Providers";
            this.fKArrivesProvidersBindingSource.DataSource = this.providersBindingSource;
            // 
            // arrivesTableAdapter
            // 
            this.arrivesTableAdapter.ClearBeforeFill = true;
            // 
            // addExpense
            // 
            this.addExpense.CommandText = "saleItem";
            this.addExpense.CommandType = System.Data.CommandType.StoredProcedure;
            this.addExpense.Connection = this.sqlConnection1;
            this.addExpense.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@date", System.Data.SqlDbType.DateTime),
            new System.Data.SqlClient.SqlParameter("@item", System.Data.SqlDbType.VarChar, 200),
            new System.Data.SqlClient.SqlParameter("@discount", System.Data.SqlDbType.Int, 2),
            new System.Data.SqlClient.SqlParameter("@quantity", System.Data.SqlDbType.Int),
            new System.Data.SqlClient.SqlParameter("@message", System.Data.SqlDbType.VarChar, 5000, System.Data.ParameterDirection.Output, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // getItemsInStockTableAdapter
            // 
            this.getItemsInStockTableAdapter.ClearBeforeFill = true;
            // 
            // simpleItemsInStockTableAdapter
            // 
            this.simpleItemsInStockTableAdapter.ClearBeforeFill = true;
            // 
            // batchesTableAdapter
            // 
            this.batchesTableAdapter.ClearBeforeFill = true;
            // 
            // WriteOffBatch
            // 
            this.WriteOffBatch.CommandText = "WriteOffItems";
            this.WriteOffBatch.CommandType = System.Data.CommandType.StoredProcedure;
            this.WriteOffBatch.Connection = this.sqlConnection1;
            this.WriteOffBatch.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@date", System.Data.SqlDbType.DateTime),
            new System.Data.SqlClient.SqlParameter("@batchNumber", System.Data.SqlDbType.Int)});
            // 
            // WriteOffAllExpiredItems
            // 
            this.WriteOffAllExpiredItems.CommandText = "writeOffAllExpiredItems";
            this.WriteOffAllExpiredItems.CommandType = System.Data.CommandType.StoredProcedure;
            this.WriteOffAllExpiredItems.Connection = this.sqlConnection1;
            // 
            // getExpiredItemsTableAdapter
            // 
            this.getExpiredItemsTableAdapter.ClearBeforeFill = true;
            // 
            // getProvidersItemsBindingSource
            // 
            this.getProvidersItemsBindingSource.DataMember = "getProvidersItems";
            this.getProvidersItemsBindingSource.DataSource = this.dataSet1;
            // 
            // getProvidersItemsTableAdapter
            // 
            this.getProvidersItemsTableAdapter.ClearBeforeFill = true;
            // 
            // providerItemsInStockBindingSource
            // 
            this.providerItemsInStockBindingSource.DataMember = "ProviderItemsInStock";
            this.providerItemsInStockBindingSource.DataSource = this.dataSet1;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.tableLayoutPanel5);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage4.Size = new System.Drawing.Size(626, 355);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Списание товаров";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.18575F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.81425F));
            this.tableLayoutPanel5.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 351F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(622, 351);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView4);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(245, 2);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(375, 347);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Просроченные товары";
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView4.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView4.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn1,
            this.batchDataGridViewTextBoxColumn1,
            this.quantityDataGridViewTextBoxColumn1,
            this.productionDateDataGridViewTextBoxColumn1,
            this.expirationDateDataGridViewTextBoxColumn1});
            this.dataGridView4.DataSource = this.getExpiredItemsBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView4.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView4.Location = new System.Drawing.Point(2, 15);
            this.dataGridView4.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.RowHeadersWidth = 62;
            this.dataGridView4.RowTemplate.Height = 28;
            this.dataGridView4.Size = new System.Drawing.Size(371, 330);
            this.dataGridView4.TabIndex = 0;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Наименование";
            this.nameDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // batchDataGridViewTextBoxColumn1
            // 
            this.batchDataGridViewTextBoxColumn1.DataPropertyName = "batch";
            this.batchDataGridViewTextBoxColumn1.HeaderText = "Номер партии";
            this.batchDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.batchDataGridViewTextBoxColumn1.Name = "batchDataGridViewTextBoxColumn1";
            this.batchDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn1
            // 
            this.quantityDataGridViewTextBoxColumn1.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn1.HeaderText = "Количество";
            this.quantityDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.quantityDataGridViewTextBoxColumn1.Name = "quantityDataGridViewTextBoxColumn1";
            this.quantityDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // productionDateDataGridViewTextBoxColumn1
            // 
            this.productionDateDataGridViewTextBoxColumn1.DataPropertyName = "ProductionDate";
            this.productionDateDataGridViewTextBoxColumn1.HeaderText = "Дата производства";
            this.productionDateDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.productionDateDataGridViewTextBoxColumn1.Name = "productionDateDataGridViewTextBoxColumn1";
            this.productionDateDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // expirationDateDataGridViewTextBoxColumn1
            // 
            this.expirationDateDataGridViewTextBoxColumn1.DataPropertyName = "ExpirationDate";
            this.expirationDateDataGridViewTextBoxColumn1.HeaderText = "Годен до";
            this.expirationDateDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.expirationDateDataGridViewTextBoxColumn1.Name = "expirationDateDataGridViewTextBoxColumn1";
            this.expirationDateDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel15, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.buttonWriteOffAllExpiredItems, 0, 3);
            this.tableLayoutPanel6.Controls.Add(this.buttonWriteOffBatch, 0, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 4;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.52761F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.47239F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(239, 347);
            this.tableLayoutPanel6.TabIndex = 1;
            // 
            // tableLayoutPanel15
            // 
            this.tableLayoutPanel15.ColumnCount = 2;
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.42373F));
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.57627F));
            this.tableLayoutPanel15.Controls.Add(this.dateTimePickerWriteOff, 1, 0);
            this.tableLayoutPanel15.Controls.Add(this.comboBoxWriteOffBatch, 1, 1);
            this.tableLayoutPanel15.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel15.Controls.Add(this.label8, 0, 1);
            this.tableLayoutPanel15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel15.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel15.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel15.Name = "tableLayoutPanel15";
            this.tableLayoutPanel15.RowCount = 3;
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 127F));
            this.tableLayoutPanel15.Size = new System.Drawing.Size(235, 228);
            this.tableLayoutPanel15.TabIndex = 2;
            // 
            // dateTimePickerWriteOff
            // 
            this.dateTimePickerWriteOff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePickerWriteOff.Location = new System.Drawing.Point(108, 2);
            this.dateTimePickerWriteOff.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerWriteOff.Name = "dateTimePickerWriteOff";
            this.dateTimePickerWriteOff.Size = new System.Drawing.Size(125, 20);
            this.dateTimePickerWriteOff.TabIndex = 0;
            // 
            // comboBoxWriteOffBatch
            // 
            this.comboBoxWriteOffBatch.DataSource = this.batchesBindingSource;
            this.comboBoxWriteOffBatch.DisplayMember = "batchNumber";
            this.comboBoxWriteOffBatch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxWriteOffBatch.FormattingEnabled = true;
            this.comboBoxWriteOffBatch.Location = new System.Drawing.Point(108, 28);
            this.comboBoxWriteOffBatch.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxWriteOffBatch.Name = "comboBoxWriteOffBatch";
            this.comboBoxWriteOffBatch.Size = new System.Drawing.Size(125, 21);
            this.comboBoxWriteOffBatch.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(2, 0);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 26);
            this.label7.TabIndex = 2;
            this.label7.Text = "Дата списания";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(2, 26);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 26);
            this.label8.TabIndex = 3;
            this.label8.Text = "Списываемая партия";
            // 
            // buttonWriteOffAllExpiredItems
            // 
            this.buttonWriteOffAllExpiredItems.Location = new System.Drawing.Point(2, 306);
            this.buttonWriteOffAllExpiredItems.Margin = new System.Windows.Forms.Padding(2);
            this.buttonWriteOffAllExpiredItems.Name = "buttonWriteOffAllExpiredItems";
            this.buttonWriteOffAllExpiredItems.Size = new System.Drawing.Size(196, 38);
            this.buttonWriteOffAllExpiredItems.TabIndex = 3;
            this.buttonWriteOffAllExpiredItems.Text = "Списать все просроченные товары";
            this.buttonWriteOffAllExpiredItems.UseVisualStyleBackColor = true;
            this.buttonWriteOffAllExpiredItems.Click += new System.EventHandler(this.buttonWriteOffAllExpiredItems_Click);
            // 
            // buttonWriteOffBatch
            // 
            this.buttonWriteOffBatch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonWriteOffBatch.Location = new System.Drawing.Point(2, 234);
            this.buttonWriteOffBatch.Margin = new System.Windows.Forms.Padding(2);
            this.buttonWriteOffBatch.Name = "buttonWriteOffBatch";
            this.buttonWriteOffBatch.Size = new System.Drawing.Size(235, 59);
            this.buttonWriteOffBatch.TabIndex = 4;
            this.buttonWriteOffBatch.Text = "Списать партию";
            this.buttonWriteOffBatch.UseVisualStyleBackColor = true;
            this.buttonWriteOffBatch.Click += new System.EventHandler(this.buttonWriteOffBatch_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(626, 355);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Товары в наличии";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.bindingNavigator1);
            this.groupBox4.Controls.Add(this.dataGridView2);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(2, 2);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(622, 351);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Наличие";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolStripButton1});
            this.bindingNavigator1.Location = new System.Drawing.Point(2, 318);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(618, 31);
            this.bindingNavigator1.TabIndex = 3;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(35, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::PharmasyApplication.Properties.Resources.update;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn2,
            this.batchDataGridViewTextBoxColumn2,
            this.purchasePriceDataGridViewTextBoxColumn,
            this.salePriceDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn2});
            this.dataGridView2.DataSource = this.simpleItemsInStockBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(2, 15);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(618, 334);
            this.dataGridView2.TabIndex = 2;
            // 
            // nameDataGridViewTextBoxColumn2
            // 
            this.nameDataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn2.HeaderText = "Наименование";
            this.nameDataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn2.Name = "nameDataGridViewTextBoxColumn2";
            this.nameDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // batchDataGridViewTextBoxColumn2
            // 
            this.batchDataGridViewTextBoxColumn2.DataPropertyName = "batch";
            this.batchDataGridViewTextBoxColumn2.HeaderText = "№ партии";
            this.batchDataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.batchDataGridViewTextBoxColumn2.Name = "batchDataGridViewTextBoxColumn2";
            this.batchDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // purchasePriceDataGridViewTextBoxColumn
            // 
            this.purchasePriceDataGridViewTextBoxColumn.DataPropertyName = "purchasePrice";
            this.purchasePriceDataGridViewTextBoxColumn.HeaderText = "Закупочная цена";
            this.purchasePriceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.purchasePriceDataGridViewTextBoxColumn.Name = "purchasePriceDataGridViewTextBoxColumn";
            this.purchasePriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salePriceDataGridViewTextBoxColumn
            // 
            this.salePriceDataGridViewTextBoxColumn.DataPropertyName = "salePrice";
            this.salePriceDataGridViewTextBoxColumn.HeaderText = "Цена продажи";
            this.salePriceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.salePriceDataGridViewTextBoxColumn.Name = "salePriceDataGridViewTextBoxColumn";
            this.salePriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn2
            // 
            this.quantityDataGridViewTextBoxColumn2.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn2.HeaderText = "Количество";
            this.quantityDataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.quantityDataGridViewTextBoxColumn2.Name = "quantityDataGridViewTextBoxColumn2";
            this.quantityDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(2, 2);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(622, 351);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.tableLayoutPanel9);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(626, 355);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Продажи";
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 2;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Controls.Add(this.tableLayoutPanel10, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.tableLayoutPanel11, 1, 0);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel9.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 351F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(622, 351);
            this.tableLayoutPanel9.TabIndex = 7;
            this.tableLayoutPanel9.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel9_Paint);
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 1;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableLayoutPanel10.Controls.Add(this.buttonCreateExpense, 0, 1);
            this.tableLayoutPanel10.Controls.Add(this.tableLayoutPanel7, 0, 0);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel10.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 2;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.80247F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.19753F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(307, 347);
            this.tableLayoutPanel10.TabIndex = 0;
            // 
            // buttonCreateExpense
            // 
            this.buttonCreateExpense.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCreateExpense.Location = new System.Drawing.Point(2, 265);
            this.buttonCreateExpense.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCreateExpense.Name = "buttonCreateExpense";
            this.buttonCreateExpense.Size = new System.Drawing.Size(303, 80);
            this.buttonCreateExpense.TabIndex = 4;
            this.buttonCreateExpense.Text = "Создать продажу";
            this.buttonCreateExpense.UseVisualStyleBackColor = true;
            this.buttonCreateExpense.Click += new System.EventHandler(this.buttonCreateExpense_Click);
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.69554F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.30446F));
            this.tableLayoutPanel7.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.dateTimePickerExpense, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.textBoxExQuantity, 1, 2);
            this.tableLayoutPanel7.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel7.Controls.Add(this.comboBoxExItemName, 1, 1);
            this.tableLayoutPanel7.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel7.Controls.Add(this.label9, 0, 4);
            this.tableLayoutPanel7.Controls.Add(this.textBoxExPrice, 1, 3);
            this.tableLayoutPanel7.Controls.Add(this.labelPriceExpense, 1, 4);
            this.tableLayoutPanel7.Controls.Add(this.ButtonDiscountSalePrice, 1, 5);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 6;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 7F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(303, 259);
            this.tableLayoutPanel7.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дата продажи";
            // 
            // dateTimePickerExpense
            // 
            this.dateTimePickerExpense.Location = new System.Drawing.Point(110, 2);
            this.dateTimePickerExpense.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerExpense.Name = "dateTimePickerExpense";
            this.dateTimePickerExpense.Size = new System.Drawing.Size(125, 20);
            this.dateTimePickerExpense.TabIndex = 2;
            // 
            // textBoxExQuantity
            // 
            this.textBoxExQuantity.Location = new System.Drawing.Point(110, 54);
            this.textBoxExQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxExQuantity.Name = "textBoxExQuantity";
            this.textBoxExQuantity.Size = new System.Drawing.Size(125, 20);
            this.textBoxExQuantity.TabIndex = 3;
            this.textBoxExQuantity.Text = "0";
            this.textBoxExQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxExQuantity_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Наименование";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 78);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Скидка (%)";
            // 
            // comboBoxExItemName
            // 
            this.comboBoxExItemName.DataSource = this.itemsBindingSource;
            this.comboBoxExItemName.DisplayMember = "Name";
            this.comboBoxExItemName.FormattingEnabled = true;
            this.comboBoxExItemName.Location = new System.Drawing.Point(110, 28);
            this.comboBoxExItemName.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxExItemName.Name = "comboBoxExItemName";
            this.comboBoxExItemName.Size = new System.Drawing.Size(125, 21);
            this.comboBoxExItemName.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 52);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Количество";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(2, 101);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Цена";
            // 
            // textBoxExPrice
            // 
            this.textBoxExPrice.Location = new System.Drawing.Point(110, 80);
            this.textBoxExPrice.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxExPrice.Name = "textBoxExPrice";
            this.textBoxExPrice.Size = new System.Drawing.Size(125, 20);
            this.textBoxExPrice.TabIndex = 3;
            this.textBoxExPrice.Text = "0";
            this.textBoxExPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxExPrice_KeyPress);
            // 
            // labelPriceExpense
            // 
            this.labelPriceExpense.AutoSize = true;
            this.labelPriceExpense.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stockItemsBindingSource, "salePrice", true));
            this.labelPriceExpense.Location = new System.Drawing.Point(110, 101);
            this.labelPriceExpense.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPriceExpense.Name = "labelPriceExpense";
            this.labelPriceExpense.Size = new System.Drawing.Size(28, 13);
            this.labelPriceExpense.TabIndex = 0;
            this.labelPriceExpense.Text = "0,00";
            // 
            // stockItemsBindingSource
            // 
            this.stockItemsBindingSource.DataMember = "StockItems";
            this.stockItemsBindingSource.DataSource = this.dataSet1;
            // 
            // ButtonDiscountSalePrice
            // 
            this.ButtonDiscountSalePrice.Location = new System.Drawing.Point(110, 125);
            this.ButtonDiscountSalePrice.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonDiscountSalePrice.Name = "ButtonDiscountSalePrice";
            this.ButtonDiscountSalePrice.Size = new System.Drawing.Size(123, 41);
            this.ButtonDiscountSalePrice.TabIndex = 4;
            this.ButtonDiscountSalePrice.Text = "Расчитать стоимость";
            this.ButtonDiscountSalePrice.UseVisualStyleBackColor = true;
            this.ButtonDiscountSalePrice.Click += new System.EventHandler(this.ButtonDiscountSalePrice_Click);
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.ColumnCount = 1;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableLayoutPanel11.Controls.Add(this.tableLayoutPanel12, 0, 1);
            this.tableLayoutPanel11.Controls.Add(this.groupBox3, 0, 0);
            this.tableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel11.Location = new System.Drawing.Point(313, 2);
            this.tableLayoutPanel11.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 2;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(307, 347);
            this.tableLayoutPanel11.TabIndex = 1;
            // 
            // tableLayoutPanel12
            // 
            this.tableLayoutPanel12.ColumnCount = 1;
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableLayoutPanel12.Controls.Add(this.tableLayoutPanel8, 0, 0);
            this.tableLayoutPanel12.Controls.Add(this.buttonExClearFilter, 0, 1);
            this.tableLayoutPanel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel12.Location = new System.Drawing.Point(2, 175);
            this.tableLayoutPanel12.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            this.tableLayoutPanel12.RowCount = 2;
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.86802F));
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.13198F));
            this.tableLayoutPanel12.Size = new System.Drawing.Size(303, 170);
            this.tableLayoutPanel12.TabIndex = 2;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Controls.Add(this.comboBoxExItemFilterCollection, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.buttonExpItemFilter, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.comboBoxCategoryFilterCollection, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.buttonExCategoryFilter, 1, 1);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 2;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(299, 94);
            this.tableLayoutPanel8.TabIndex = 1;
            // 
            // comboBoxExItemFilterCollection
            // 
            this.comboBoxExItemFilterCollection.DataSource = this.itemsBindingSource2;
            this.comboBoxExItemFilterCollection.DisplayMember = "Name";
            this.comboBoxExItemFilterCollection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxExItemFilterCollection.FormattingEnabled = true;
            this.comboBoxExItemFilterCollection.Location = new System.Drawing.Point(2, 2);
            this.comboBoxExItemFilterCollection.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxExItemFilterCollection.Name = "comboBoxExItemFilterCollection";
            this.comboBoxExItemFilterCollection.Size = new System.Drawing.Size(145, 21);
            this.comboBoxExItemFilterCollection.TabIndex = 3;
            // 
            // buttonExpItemFilter
            // 
            this.buttonExpItemFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonExpItemFilter.Location = new System.Drawing.Point(151, 2);
            this.buttonExpItemFilter.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExpItemFilter.Name = "buttonExpItemFilter";
            this.buttonExpItemFilter.Size = new System.Drawing.Size(146, 43);
            this.buttonExpItemFilter.TabIndex = 1;
            this.buttonExpItemFilter.Text = "Поиск по товару";
            this.buttonExpItemFilter.UseVisualStyleBackColor = true;
            this.buttonExpItemFilter.Click += new System.EventHandler(this.buttonExpItemFilter_Click);
            // 
            // comboBoxCategoryFilterCollection
            // 
            this.comboBoxCategoryFilterCollection.DataSource = this.categoriesBindingSource;
            this.comboBoxCategoryFilterCollection.DisplayMember = "CategoryName";
            this.comboBoxCategoryFilterCollection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxCategoryFilterCollection.FormattingEnabled = true;
            this.comboBoxCategoryFilterCollection.Location = new System.Drawing.Point(2, 49);
            this.comboBoxCategoryFilterCollection.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxCategoryFilterCollection.Name = "comboBoxCategoryFilterCollection";
            this.comboBoxCategoryFilterCollection.Size = new System.Drawing.Size(145, 21);
            this.comboBoxCategoryFilterCollection.TabIndex = 4;
            // 
            // buttonExCategoryFilter
            // 
            this.buttonExCategoryFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonExCategoryFilter.Location = new System.Drawing.Point(151, 49);
            this.buttonExCategoryFilter.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExCategoryFilter.Name = "buttonExCategoryFilter";
            this.buttonExCategoryFilter.Size = new System.Drawing.Size(146, 43);
            this.buttonExCategoryFilter.TabIndex = 5;
            this.buttonExCategoryFilter.Text = "Поиск по категории";
            this.buttonExCategoryFilter.UseVisualStyleBackColor = true;
            this.buttonExCategoryFilter.Click += new System.EventHandler(this.buttonExCategoryFilter_Click);
            // 
            // buttonExClearFilter
            // 
            this.buttonExClearFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonExClearFilter.Location = new System.Drawing.Point(2, 100);
            this.buttonExClearFilter.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExClearFilter.Name = "buttonExClearFilter";
            this.buttonExClearFilter.Size = new System.Drawing.Size(299, 68);
            this.buttonExClearFilter.TabIndex = 2;
            this.buttonExClearFilter.Text = "Сбросить фильтры";
            this.buttonExClearFilter.UseVisualStyleBackColor = true;
            this.buttonExClearFilter.Click += new System.EventHandler(this.buttonExClearFilter_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bindingNavigator2);
            this.groupBox3.Controls.Add(this.dataGridViewItemsInStock);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(2, 2);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(303, 169);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Товары в наличии";
            // 
            // bindingNavigator2
            // 
            this.bindingNavigator2.AddNewItem = null;
            this.bindingNavigator2.CountItem = this.bindingNavigatorCountItem1;
            this.bindingNavigator2.DeleteItem = null;
            this.bindingNavigator2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigator2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.bindingNavigator2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem1,
            this.bindingNavigatorMovePreviousItem1,
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator4,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorMoveLastItem1,
            this.bindingNavigatorSeparator5,
            this.toolStripButton2});
            this.bindingNavigator2.Location = new System.Drawing.Point(2, 136);
            this.bindingNavigator2.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
            this.bindingNavigator2.MoveLastItem = this.bindingNavigatorMoveLastItem1;
            this.bindingNavigator2.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.bindingNavigator2.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.bindingNavigator2.Name = "bindingNavigator2";
            this.bindingNavigator2.PositionItem = this.bindingNavigatorPositionItem1;
            this.bindingNavigator2.Size = new System.Drawing.Size(299, 31);
            this.bindingNavigator2.TabIndex = 3;
            this.bindingNavigator2.Text = "bindingNavigator2";
            // 
            // bindingNavigatorCountItem1
            // 
            this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem1";
            this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(35, 28);
            this.bindingNavigatorCountItem1.Text = "of {0}";
            this.bindingNavigatorCountItem1.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem1
            // 
            this.bindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem1.Image")));
            this.bindingNavigatorMoveFirstItem1.Name = "bindingNavigatorMoveFirstItem1";
            this.bindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem1.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveFirstItem1.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem1
            // 
            this.bindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem1.Image")));
            this.bindingNavigatorMovePreviousItem1.Name = "bindingNavigatorMovePreviousItem1";
            this.bindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem1.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMovePreviousItem1.Text = "Move previous";
            // 
            // bindingNavigatorSeparator3
            // 
            this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator3";
            this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem1
            // 
            this.bindingNavigatorPositionItem1.AccessibleName = "Position";
            this.bindingNavigatorPositionItem1.AutoSize = false;
            this.bindingNavigatorPositionItem1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem1.Name = "bindingNavigatorPositionItem1";
            this.bindingNavigatorPositionItem1.Size = new System.Drawing.Size(35, 23);
            this.bindingNavigatorPositionItem1.Text = "0";
            this.bindingNavigatorPositionItem1.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator4
            // 
            this.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator4";
            this.bindingNavigatorSeparator4.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem1
            // 
            this.bindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem1.Image")));
            this.bindingNavigatorMoveNextItem1.Name = "bindingNavigatorMoveNextItem1";
            this.bindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem1.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveNextItem1.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem1
            // 
            this.bindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem1.Image")));
            this.bindingNavigatorMoveLastItem1.Name = "bindingNavigatorMoveLastItem1";
            this.bindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem1.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveLastItem1.Text = "Move last";
            // 
            // bindingNavigatorSeparator5
            // 
            this.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator5";
            this.bindingNavigatorSeparator5.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::PharmasyApplication.Properties.Resources.update;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // dataGridViewItemsInStock
            // 
            this.dataGridViewItemsInStock.AllowUserToAddRows = false;
            this.dataGridViewItemsInStock.AllowUserToDeleteRows = false;
            this.dataGridViewItemsInStock.AutoGenerateColumns = false;
            this.dataGridViewItemsInStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewItemsInStock.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewItemsInStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewItemsInStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItemsInStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.quantity,
            this.salePrice});
            this.dataGridViewItemsInStock.DataSource = this.stockItemsBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewItemsInStock.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewItemsInStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewItemsInStock.GridColor = System.Drawing.Color.White;
            this.dataGridViewItemsInStock.Location = new System.Drawing.Point(2, 15);
            this.dataGridViewItemsInStock.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewItemsInStock.Name = "dataGridViewItemsInStock";
            this.dataGridViewItemsInStock.ReadOnly = true;
            this.dataGridViewItemsInStock.RowHeadersWidth = 62;
            this.dataGridViewItemsInStock.RowTemplate.Height = 28;
            this.dataGridViewItemsInStock.Size = new System.Drawing.Size(299, 152);
            this.dataGridViewItemsInStock.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(626, 355);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Заказы";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.76845F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.23155F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 351F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(622, 351);
            this.tableLayoutPanel1.TabIndex = 6;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableLayoutPanel2.Controls.Add(this.buttonAddArrive, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.53086F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.46914F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(224, 347);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // buttonAddArrive
            // 
            this.buttonAddArrive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAddArrive.Location = new System.Drawing.Point(2, 271);
            this.buttonAddArrive.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddArrive.Name = "buttonAddArrive";
            this.buttonAddArrive.Size = new System.Drawing.Size(220, 74);
            this.buttonAddArrive.TabIndex = 4;
            this.buttonAddArrive.Text = "Создать заказ";
            this.buttonAddArrive.UseVisualStyleBackColor = true;
            this.buttonAddArrive.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.textBoxSalePriceArrive, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.labelOrderDate, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.textBoxQuantity, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.labelItem, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.comboBoxItemName, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.labelProvider, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.comboBoxProvider, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.dateTimePickerOrder, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 6;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(220, 265);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // textBoxSalePriceArrive
            // 
            this.textBoxSalePriceArrive.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxSalePriceArrive.Location = new System.Drawing.Point(112, 118);
            this.textBoxSalePriceArrive.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSalePriceArrive.Name = "textBoxSalePriceArrive";
            this.textBoxSalePriceArrive.Size = new System.Drawing.Size(106, 20);
            this.textBoxSalePriceArrive.TabIndex = 4;
            this.textBoxSalePriceArrive.Text = "0,00";
            this.textBoxSalePriceArrive.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSalePriceArrive_KeyPress);
            // 
            // labelOrderDate
            // 
            this.labelOrderDate.AutoSize = true;
            this.labelOrderDate.Location = new System.Drawing.Point(2, 0);
            this.labelOrderDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOrderDate.Name = "labelOrderDate";
            this.labelOrderDate.Size = new System.Drawing.Size(72, 13);
            this.labelOrderDate.TabIndex = 0;
            this.labelOrderDate.Text = "Дата заказа";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxQuantity.Location = new System.Drawing.Point(112, 89);
            this.textBoxQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(106, 20);
            this.textBoxQuantity.TabIndex = 3;
            this.textBoxQuantity.Text = "1";
            this.textBoxQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxQuantity_KeyPress);
            // 
            // labelItem
            // 
            this.labelItem.AutoSize = true;
            this.labelItem.Location = new System.Drawing.Point(2, 29);
            this.labelItem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelItem.Name = "labelItem";
            this.labelItem.Size = new System.Drawing.Size(83, 13);
            this.labelItem.TabIndex = 0;
            this.labelItem.Text = "Наименование";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 116);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Цена продажи";
            // 
            // comboBoxItemName
            // 
            this.comboBoxItemName.DataSource = this.itemsBindingSource;
            this.comboBoxItemName.DisplayMember = "Name";
            this.comboBoxItemName.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBoxItemName.FormattingEnabled = true;
            this.comboBoxItemName.Location = new System.Drawing.Point(112, 31);
            this.comboBoxItemName.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxItemName.Name = "comboBoxItemName";
            this.comboBoxItemName.Size = new System.Drawing.Size(106, 21);
            this.comboBoxItemName.TabIndex = 1;
            this.comboBoxItemName.SelectedValueChanged += new System.EventHandler(this.comboBoxItemName_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Количество";
            // 
            // labelProvider
            // 
            this.labelProvider.AutoSize = true;
            this.labelProvider.Location = new System.Drawing.Point(2, 58);
            this.labelProvider.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelProvider.Name = "labelProvider";
            this.labelProvider.Size = new System.Drawing.Size(65, 13);
            this.labelProvider.TabIndex = 0;
            this.labelProvider.Text = "Поставщик";
            // 
            // comboBoxProvider
            // 
            this.comboBoxProvider.DataSource = this.providersBindingSource;
            this.comboBoxProvider.DisplayMember = "Name";
            this.comboBoxProvider.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBoxProvider.FormattingEnabled = true;
            this.comboBoxProvider.Location = new System.Drawing.Point(112, 60);
            this.comboBoxProvider.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxProvider.Name = "comboBoxProvider";
            this.comboBoxProvider.Size = new System.Drawing.Size(106, 21);
            this.comboBoxProvider.TabIndex = 1;
            // 
            // dateTimePickerOrder
            // 
            this.dateTimePickerOrder.Location = new System.Drawing.Point(112, 2);
            this.dateTimePickerOrder.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerOrder.Name = "dateTimePickerOrder";
            this.dateTimePickerOrder.Size = new System.Drawing.Size(88, 20);
            this.dateTimePickerOrder.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel13, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(230, 2);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.5679F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.4321F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(390, 347);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // tableLayoutPanel13
            // 
            this.tableLayoutPanel13.ColumnCount = 1;
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel13.Controls.Add(this.tableLayoutPanel14, 0, 0);
            this.tableLayoutPanel13.Controls.Add(this.button3, 0, 1);
            this.tableLayoutPanel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel13.Location = new System.Drawing.Point(2, 191);
            this.tableLayoutPanel13.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel13.Name = "tableLayoutPanel13";
            this.tableLayoutPanel13.RowCount = 2;
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel13.Size = new System.Drawing.Size(386, 154);
            this.tableLayoutPanel13.TabIndex = 4;
            // 
            // tableLayoutPanel14
            // 
            this.tableLayoutPanel14.ColumnCount = 2;
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel14.Controls.Add(this.textBox1, 0, 0);
            this.tableLayoutPanel14.Controls.Add(this.buttonProviderFilter, 1, 0);
            this.tableLayoutPanel14.Controls.Add(this.buttonNameFilter, 1, 1);
            this.tableLayoutPanel14.Controls.Add(this.textBox2, 0, 1);
            this.tableLayoutPanel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel14.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel14.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel14.Name = "tableLayoutPanel14";
            this.tableLayoutPanel14.RowCount = 2;
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel14.Size = new System.Drawing.Size(382, 64);
            this.tableLayoutPanel14.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Location = new System.Drawing.Point(21, 7);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(186, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "-";
            // 
            // buttonProviderFilter
            // 
            this.buttonProviderFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonProviderFilter.Location = new System.Drawing.Point(231, 2);
            this.buttonProviderFilter.Margin = new System.Windows.Forms.Padding(2);
            this.buttonProviderFilter.Name = "buttonProviderFilter";
            this.buttonProviderFilter.Size = new System.Drawing.Size(149, 30);
            this.buttonProviderFilter.TabIndex = 0;
            this.buttonProviderFilter.Text = "Поиск по поставщику";
            this.buttonProviderFilter.UseVisualStyleBackColor = true;
            this.buttonProviderFilter.Click += new System.EventHandler(this.buttonProviderFilter_Click);
            // 
            // buttonNameFilter
            // 
            this.buttonNameFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonNameFilter.Location = new System.Drawing.Point(231, 36);
            this.buttonNameFilter.Margin = new System.Windows.Forms.Padding(2);
            this.buttonNameFilter.Name = "buttonNameFilter";
            this.buttonNameFilter.Size = new System.Drawing.Size(149, 27);
            this.buttonNameFilter.TabIndex = 1;
            this.buttonNameFilter.Text = "Поиск по товару";
            this.buttonNameFilter.UseVisualStyleBackColor = true;
            this.buttonNameFilter.Click += new System.EventHandler(this.buttonNameFilter_Click);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.Location = new System.Drawing.Point(21, 39);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(186, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "-";
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button3.Location = new System.Drawing.Point(79, 70);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(227, 28);
            this.button3.TabIndex = 2;
            this.button3.Text = "Сбросить фильтры";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonClearFilter_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(386, 185);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Остатки товаров у поставщика";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Batch,
            this.PurchasePrice,
            this.providerDataGridViewTextBoxColumn,
            this.ProductionDate,
            this.ExpirationDate,
            this.Remain,
            this.salePriceDataGridViewTextBoxColumn1});
            this.dataGridView3.DataSource = this.providersItemsBindingSource;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView3.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.GridColor = System.Drawing.Color.White;
            this.dataGridView3.Location = new System.Drawing.Point(2, 15);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersWidth = 62;
            this.dataGridView3.RowTemplate.Height = 28;
            this.dataGridView3.Size = new System.Drawing.Size(382, 168);
            this.dataGridView3.TabIndex = 8;
            // 
            // Name
            // 
            this.Name.DataPropertyName = "Name";
            this.Name.HeaderText = "Наименование";
            this.Name.MinimumWidth = 8;
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // Batch
            // 
            this.Batch.DataPropertyName = "Batch";
            this.Batch.HeaderText = "№ партии";
            this.Batch.MinimumWidth = 8;
            this.Batch.Name = "Batch";
            this.Batch.ReadOnly = true;
            // 
            // PurchasePrice
            // 
            this.PurchasePrice.DataPropertyName = "PurchasePrice";
            this.PurchasePrice.HeaderText = "Цена продажи";
            this.PurchasePrice.MinimumWidth = 8;
            this.PurchasePrice.Name = "PurchasePrice";
            this.PurchasePrice.ReadOnly = true;
            // 
            // providerDataGridViewTextBoxColumn
            // 
            this.providerDataGridViewTextBoxColumn.DataPropertyName = "Provider";
            this.providerDataGridViewTextBoxColumn.HeaderText = "Поставщик";
            this.providerDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.providerDataGridViewTextBoxColumn.Name = "providerDataGridViewTextBoxColumn";
            this.providerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ProductionDate
            // 
            this.ProductionDate.DataPropertyName = "ProductionDate";
            this.ProductionDate.HeaderText = "Дата производства";
            this.ProductionDate.MinimumWidth = 8;
            this.ProductionDate.Name = "ProductionDate";
            this.ProductionDate.ReadOnly = true;
            // 
            // ExpirationDate
            // 
            this.ExpirationDate.DataPropertyName = "ExpirationDate";
            this.ExpirationDate.HeaderText = "Годен до";
            this.ExpirationDate.MinimumWidth = 8;
            this.ExpirationDate.Name = "ExpirationDate";
            this.ExpirationDate.ReadOnly = true;
            // 
            // Remain
            // 
            this.Remain.DataPropertyName = "Remain";
            this.Remain.HeaderText = "Остаток";
            this.Remain.MinimumWidth = 8;
            this.Remain.Name = "Remain";
            this.Remain.ReadOnly = true;
            // 
            // salePriceDataGridViewTextBoxColumn1
            // 
            this.salePriceDataGridViewTextBoxColumn1.DataPropertyName = "SalePrice";
            this.salePriceDataGridViewTextBoxColumn1.HeaderText = "Себестоимость";
            this.salePriceDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.salePriceDataGridViewTextBoxColumn1.Name = "salePriceDataGridViewTextBoxColumn1";
            this.salePriceDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // providersItemsBindingSource
            // 
            this.providersItemsBindingSource.DataMember = "ProvidersItems";
            this.providersItemsBindingSource.DataSource = this.dataSet1;
            // 
            // createArriveBindingSource
            // 
            this.createArriveBindingSource.DataMember = "createArrive";
            this.createArriveBindingSource.DataSource = this.dataSet1;
            // 
            // tabControlArrives
            // 
            this.tabControlArrives.Controls.Add(this.tabPage1);
            this.tabControlArrives.Controls.Add(this.tabPage2);
            this.tabControlArrives.Controls.Add(this.tabPage3);
            this.tabControlArrives.Controls.Add(this.tabPage4);
            this.tabControlArrives.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlArrives.Location = new System.Drawing.Point(0, 0);
            this.tabControlArrives.Margin = new System.Windows.Forms.Padding(2);
            this.tabControlArrives.Name = "tabControlArrives";
            this.tabControlArrives.SelectedIndex = 0;
            this.tabControlArrives.Size = new System.Drawing.Size(634, 381);
            this.tabControlArrives.TabIndex = 0;
            // 
            // getPrice
            // 
            this.getPrice.CommandText = "getPrice";
            this.getPrice.CommandType = System.Data.CommandType.StoredProcedure;
            this.getPrice.Connection = this.sqlConnection1;
            this.getPrice.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@provider", System.Data.SqlDbType.NVarChar, 200),
            new System.Data.SqlClient.SqlParameter("@itemName", System.Data.SqlDbType.NVarChar, 200),
            new System.Data.SqlClient.SqlParameter("@price", System.Data.SqlDbType.Decimal, 18, System.Data.ParameterDirection.Output, false, ((byte)(0)), ((byte)(2)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // providersItemsTableAdapter
            // 
            this.providersItemsTableAdapter.ClearBeforeFill = true;
            // 
            // stockItemsTableAdapter
            // 
            this.stockItemsTableAdapter.ClearBeforeFill = true;
            // 
            // createArriveTableAdapter
            // 
            this.createArriveTableAdapter.ClearBeforeFill = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Name";
            this.Column1.HeaderText = "Наименование";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.DataPropertyName = "quantity";
            this.quantity.HeaderText = "Количество";
            this.quantity.MinimumWidth = 8;
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // salePrice
            // 
            this.salePrice.DataPropertyName = "salePrice";
            this.salePrice.HeaderText = "Цена";
            this.salePrice.MinimumWidth = 8;
            this.salePrice.Name = "salePrice";
            this.salePrice.ReadOnly = true;
            // 
            // Pharmacist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(634, 381);
            this.Controls.Add(this.tabControlArrives);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            //this.Name = "Pharmacist";
            this.Text = "Аптекарь";
            this.Load += new System.EventHandler(this.Pharmacist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.providersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getItemsInStockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleItemsInStockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getExpiredItemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.batchesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.providersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKArrivesProvidersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getProvidersItemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.providerItemsInStockBindingSource)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel15.ResumeLayout(false);
            this.tableLayoutPanel15.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockItemsBindingSource)).EndInit();
            this.tableLayoutPanel11.ResumeLayout(false);
            this.tableLayoutPanel12.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).EndInit();
            this.bindingNavigator2.ResumeLayout(false);
            this.bindingNavigator2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItemsInStock)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel13.ResumeLayout(false);
            this.tableLayoutPanel14.ResumeLayout(false);
            this.tableLayoutPanel14.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.providersItemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.createArriveBindingSource)).EndInit();
            this.tabControlArrives.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand addArrive;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private DataSet1TableAdapters.ItemsTableAdapter itemsTableAdapter;
        private System.Windows.Forms.BindingSource providersBindingSource;
        private DataSet1TableAdapters.ProvidersTableAdapter providersTableAdapter;
        private System.Windows.Forms.BindingSource fKArrivesProvidersBindingSource;
        private DataSet1TableAdapters.ArrivesTableAdapter arrivesTableAdapter;
        private System.Windows.Forms.BindingSource providersBindingSource1;
        private System.Windows.Forms.BindingSource itemsBindingSource1;
        private System.Data.SqlClient.SqlCommand addExpense;
        private System.Windows.Forms.BindingSource itemsBindingSource2;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private DataSet1TableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        private System.Windows.Forms.BindingSource getItemsInStockBindingSource;
        private DataSet1TableAdapters.getItemsInStockTableAdapter getItemsInStockTableAdapter;
        private System.Windows.Forms.BindingSource simpleItemsInStockBindingSource;
        private DataSet1TableAdapters.SimpleItemsInStockTableAdapter simpleItemsInStockTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr2DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource batchesBindingSource;
        private DataSet1TableAdapters.BatchesTableAdapter batchesTableAdapter;
        private System.Data.SqlClient.SqlCommand WriteOffBatch;
        private System.Data.SqlClient.SqlCommand WriteOffAllExpiredItems;
        private System.Windows.Forms.BindingSource getExpiredItemsBindingSource;
        private DataSet1TableAdapters.getExpiredItemsTableAdapter getExpiredItemsTableAdapter;
        private System.Windows.Forms.BindingSource getProvidersItemsBindingSource;
        private DataSet1TableAdapters.getProvidersItemsTableAdapter getProvidersItemsTableAdapter;
        private System.Windows.Forms.BindingSource providerItemsInStockBindingSource;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel15;
        private System.Windows.Forms.DateTimePicker dateTimePickerWriteOff;
        private System.Windows.Forms.ComboBox comboBoxWriteOffBatch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonWriteOffAllExpiredItems;
        private System.Windows.Forms.Button buttonWriteOffBatch;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.Button buttonCreateExpense;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxExPrice;
        private System.Windows.Forms.DateTimePicker dateTimePickerExpense;
        private System.Windows.Forms.TextBox textBoxExQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxExItemName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel12;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.ComboBox comboBoxExItemFilterCollection;
        private System.Windows.Forms.Button buttonExpItemFilter;
        private System.Windows.Forms.ComboBox comboBoxCategoryFilterCollection;
        private System.Windows.Forms.Button buttonExCategoryFilter;
        private System.Windows.Forms.Button buttonExClearFilter;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridViewItemsInStock;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button buttonAddArrive;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label labelOrderDate;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.Label labelItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxItemName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelProvider;
        private System.Windows.Forms.ComboBox comboBoxProvider;
        private System.Windows.Forms.DateTimePicker dateTimePickerOrder;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel13;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel14;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonProviderFilter;
        private System.Windows.Forms.Button buttonNameFilter;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TabControl tabControlArrives;
        private System.Data.SqlClient.SqlCommand getPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn batchDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productionDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn expirationDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBoxSalePriceArrive;
        private System.Windows.Forms.BindingSource providersItemsBindingSource;
        private DataSet1TableAdapters.ProvidersItemsTableAdapter providersItemsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Batch;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchasePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn providerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductionDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpirationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remain;
        private System.Windows.Forms.DataGridViewTextBoxColumn salePriceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn batchDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchasePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource stockItemsBindingSource;
        private DataSet1TableAdapters.StockItemsTableAdapter stockItemsTableAdapter;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelPriceExpense;
        private System.Windows.Forms.Button ButtonDiscountSalePrice;
        private System.Windows.Forms.BindingNavigator bindingNavigator2;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.BindingSource createArriveBindingSource;
        private DataSet1TableAdapters.createArriveTableAdapter createArriveTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn salePrice;
    }
}