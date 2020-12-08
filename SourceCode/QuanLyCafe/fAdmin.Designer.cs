namespace QuanLyCafe
{
    partial class fAdmin
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fAdmin));
            this.USP_GetListBillByDateForReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QuanLyQuanCafe2DataSet5 = new QuanLyCafe.QuanLyQuanCafe2DataSet5();
            this.aCCOUNTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyQuanCafe2DataSet1 = new QuanLyCafe.QuanLyQuanCafe2DataSet1();
            this.fOODBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyQuanCafe2DataSet = new QuanLyCafe.QuanLyQuanCafe2DataSet();
            this.fOODTableAdapter = new QuanLyCafe.QuanLyQuanCafe2DataSetTableAdapters.FOODTableAdapter();
            this.aCCOUNTTableAdapter = new QuanLyCafe.QuanLyQuanCafe2DataSet1TableAdapters.ACCOUNTTableAdapter();
            this.quanLyQuanCafe2DataSet2 = new QuanLyCafe.QuanLyQuanCafe2DataSet2();
            this.fOODCATEGORYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fOODCATEGORYTableAdapter = new QuanLyCafe.QuanLyQuanCafe2DataSet2TableAdapters.FOODCATEGORYTableAdapter();
            this.quanLyQuanCafe2DataSet3 = new QuanLyCafe.QuanLyQuanCafe2DataSet3();
            this.fOODBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fOODTableAdapter1 = new QuanLyCafe.QuanLyQuanCafe2DataSet3TableAdapters.FOODTableAdapter();
            this.quanLyQuanCafe2DataSet4 = new QuanLyCafe.QuanLyQuanCafe2DataSet4();
            this.fOODBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.fOODTableAdapter2 = new QuanLyCafe.QuanLyQuanCafe2DataSet4TableAdapters.FOODTableAdapter();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.foodTableAdapter3 = new QuanLyCafe.QuanLyQuanCafe2DataSet3TableAdapters.FOODTableAdapter();
            this.USP_GetListBillByDateForReportTableAdapter = new QuanLyCafe.QuanLyQuanCafe2DataSet5TableAdapters.USP_GetListBillByDateForReportTableAdapter();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tbFoodCatetory = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.txbNameFoodCategory = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txbCategoryID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.dtgvCategory = new System.Windows.Forms.DataGridView();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnShow_Category = new DevComponents.DotNetBar.ButtonX();
            this.btnDelete_Category = new DevComponents.DotNetBar.ButtonX();
            this.btnAdd_Category = new DevComponents.DotNetBar.ButtonX();
            this.btnEdit_Category = new DevComponents.DotNetBar.ButtonX();
            this.tpFood = new System.Windows.Forms.TabPage();
            this.panel13 = new System.Windows.Forms.Panel();
            this.cbFoodCategory = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.txbFoodName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnSearch_Food = new DevComponents.DotNetBar.ButtonX();
            this.txbSearchFoodName = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.nmFoodPrice = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.txbFoodID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_Show_Food = new DevComponents.DotNetBar.ButtonX();
            this.btn_Edit_Food = new DevComponents.DotNetBar.ButtonX();
            this.btn_Delete_Food = new DevComponents.DotNetBar.ButtonX();
            this.btn_Add_Food = new DevComponents.DotNetBar.ButtonX();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtgvFood = new System.Windows.Forms.DataGridView();
            this.tpBill = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.dtpkToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpkFromDate = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgvBill = new System.Windows.Forms.DataGridView();
            this.tcAdmin = new System.Windows.Forms.TabControl();
            this.tpAccount = new System.Windows.Forms.TabPage();
            this.btnReset_PassWord = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.panel24 = new System.Windows.Forms.Panel();
            this.nmType = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.panel23 = new System.Windows.Forms.Panel();
            this.txbDisplayName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel22 = new System.Windows.Forms.Panel();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel21 = new System.Windows.Forms.Panel();
            this.dtgvAccount = new System.Windows.Forms.DataGridView();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.displayNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel20 = new System.Windows.Forms.Panel();
            this.btnAdd_Account = new DevComponents.DotNetBar.ButtonX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.btnEdit_Account = new DevComponents.DotNetBar.ButtonX();
            this.btnDelete_Account = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.USP_GetListBillByDateForReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyQuanCafe2DataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCCOUNTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyQuanCafe2DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fOODBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyQuanCafe2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyQuanCafe2DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fOODCATEGORYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyQuanCafe2DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fOODBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyQuanCafe2DataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fOODBindingSource2)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tbFoodCatetory.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCategory)).BeginInit();
            this.panel7.SuspendLayout();
            this.tpFood.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodPrice)).BeginInit();
            this.panel11.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFood)).BeginInit();
            this.tpBill.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).BeginInit();
            this.tcAdmin.SuspendLayout();
            this.tpAccount.SuspendLayout();
            this.panel24.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmType)).BeginInit();
            this.panel23.SuspendLayout();
            this.panel22.SuspendLayout();
            this.panel21.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).BeginInit();
            this.panel20.SuspendLayout();
            this.SuspendLayout();
            // 
            // USP_GetListBillByDateForReportBindingSource
            // 
            this.USP_GetListBillByDateForReportBindingSource.DataMember = "USP_GetListBillByDateForReport";
            this.USP_GetListBillByDateForReportBindingSource.DataSource = this.QuanLyQuanCafe2DataSet5;
            // 
            // QuanLyQuanCafe2DataSet5
            // 
            this.QuanLyQuanCafe2DataSet5.DataSetName = "QuanLyQuanCafe2DataSet5";
            this.QuanLyQuanCafe2DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aCCOUNTBindingSource
            // 
            this.aCCOUNTBindingSource.DataMember = "ACCOUNT";
            this.aCCOUNTBindingSource.DataSource = this.quanLyQuanCafe2DataSet1;
            // 
            // quanLyQuanCafe2DataSet1
            // 
            this.quanLyQuanCafe2DataSet1.DataSetName = "QuanLyQuanCafe2DataSet1";
            this.quanLyQuanCafe2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fOODBindingSource
            // 
            this.fOODBindingSource.DataMember = "FOOD";
            this.fOODBindingSource.DataSource = this.quanLyQuanCafe2DataSet;
            // 
            // quanLyQuanCafe2DataSet
            // 
            this.quanLyQuanCafe2DataSet.DataSetName = "QuanLyQuanCafe2DataSet";
            this.quanLyQuanCafe2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fOODTableAdapter
            // 
            this.fOODTableAdapter.ClearBeforeFill = true;
            // 
            // aCCOUNTTableAdapter
            // 
            this.aCCOUNTTableAdapter.ClearBeforeFill = true;
            // 
            // quanLyQuanCafe2DataSet2
            // 
            this.quanLyQuanCafe2DataSet2.DataSetName = "QuanLyQuanCafe2DataSet2";
            this.quanLyQuanCafe2DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fOODCATEGORYBindingSource
            // 
            this.fOODCATEGORYBindingSource.DataMember = "FOODCATEGORY";
            this.fOODCATEGORYBindingSource.DataSource = this.quanLyQuanCafe2DataSet2;
            // 
            // fOODCATEGORYTableAdapter
            // 
            this.fOODCATEGORYTableAdapter.ClearBeforeFill = true;
            // 
            // quanLyQuanCafe2DataSet3
            // 
            this.quanLyQuanCafe2DataSet3.DataSetName = "QuanLyQuanCafe2DataSet3";
            this.quanLyQuanCafe2DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fOODBindingSource1
            // 
            this.fOODBindingSource1.DataMember = "FOOD";
            this.fOODBindingSource1.DataSource = this.quanLyQuanCafe2DataSet3;
            // 
            // fOODTableAdapter1
            // 
            this.fOODTableAdapter1.ClearBeforeFill = true;
            // 
            // quanLyQuanCafe2DataSet4
            // 
            this.quanLyQuanCafe2DataSet4.DataSetName = "QuanLyQuanCafe2DataSet4";
            this.quanLyQuanCafe2DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fOODBindingSource2
            // 
            this.fOODBindingSource2.DataMember = "FOOD";
            this.fOODBindingSource2.DataSource = this.quanLyQuanCafe2DataSet4;
            // 
            // fOODTableAdapter2
            // 
            this.fOODTableAdapter2.ClearBeforeFill = true;
            // 
            // foodTableAdapter3
            // 
            this.foodTableAdapter3.ClearBeforeFill = true;
            // 
            // USP_GetListBillByDateForReportTableAdapter
            // 
            this.USP_GetListBillByDateForReportTableAdapter.ClearBeforeFill = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.reportViewer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(767, 400);
            this.tabPage1.TabIndex = 5;
            this.tabPage1.Text = "Report";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.USP_GetListBillByDateForReportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyCafe.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(7, 7);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(754, 387);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // tbFoodCatetory
            // 
            this.tbFoodCatetory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbFoodCatetory.BackgroundImage")));
            this.tbFoodCatetory.Controls.Add(this.label13);
            this.tbFoodCatetory.Controls.Add(this.panel10);
            this.tbFoodCatetory.Controls.Add(this.panel9);
            this.tbFoodCatetory.Controls.Add(this.panel8);
            this.tbFoodCatetory.Controls.Add(this.panel7);
            this.tbFoodCatetory.Location = new System.Drawing.Point(4, 22);
            this.tbFoodCatetory.Name = "tbFoodCatetory";
            this.tbFoodCatetory.Padding = new System.Windows.Forms.Padding(3);
            this.tbFoodCatetory.Size = new System.Drawing.Size(767, 400);
            this.tbFoodCatetory.TabIndex = 2;
            this.tbFoodCatetory.Text = "Danh mục";
            this.tbFoodCatetory.UseVisualStyleBackColor = true;
            this.tbFoodCatetory.Click += new System.EventHandler(this.tbFoodCatetory_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label13.Location = new System.Drawing.Point(514, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(189, 29);
            this.label13.TabIndex = 1;
            this.label13.Text = "-- DANH MỤC --";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.txbNameFoodCategory);
            this.panel10.Controls.Add(this.label6);
            this.panel10.Location = new System.Drawing.Point(442, 132);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(322, 50);
            this.panel10.TabIndex = 6;
            // 
            // txbNameFoodCategory
            // 
            this.txbNameFoodCategory.Location = new System.Drawing.Point(141, 19);
            this.txbNameFoodCategory.Name = "txbNameFoodCategory";
            this.txbNameFoodCategory.Size = new System.Drawing.Size(177, 20);
            this.txbNameFoodCategory.TabIndex = 9;
            this.txbNameFoodCategory.TextChanged += new System.EventHandler(this.txbNameFoodCategory_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(3, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "    Tên danh mục: ";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.txbCategoryID);
            this.panel9.Controls.Add(this.label5);
            this.panel9.Location = new System.Drawing.Point(442, 67);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(322, 50);
            this.panel9.TabIndex = 5;
            this.panel9.Paint += new System.Windows.Forms.PaintEventHandler(this.panel9_Paint);
            // 
            // txbCategoryID
            // 
            this.txbCategoryID.Location = new System.Drawing.Point(141, 20);
            this.txbCategoryID.Name = "txbCategoryID";
            this.txbCategoryID.ReadOnly = true;
            this.txbCategoryID.Size = new System.Drawing.Size(177, 20);
            this.txbCategoryID.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "ID: ";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.dtgvCategory);
            this.panel8.Location = new System.Drawing.Point(6, 68);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(430, 325);
            this.panel8.TabIndex = 4;
            // 
            // dtgvCategory
            // 
            this.dtgvCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvCategory.BackgroundColor = System.Drawing.Color.LemonChiffon;
            this.dtgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCategory.Location = new System.Drawing.Point(4, 3);
            this.dtgvCategory.Name = "dtgvCategory";
            this.dtgvCategory.Size = new System.Drawing.Size(424, 318);
            this.dtgvCategory.TabIndex = 0;
            this.dtgvCategory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvCategory_CellContentClick);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnShow_Category);
            this.panel7.Controls.Add(this.btnDelete_Category);
            this.panel7.Controls.Add(this.btnAdd_Category);
            this.panel7.Controls.Add(this.btnEdit_Category);
            this.panel7.Location = new System.Drawing.Point(6, 6);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(430, 55);
            this.panel7.TabIndex = 2;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // btnShow_Category
            // 
            this.btnShow_Category.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnShow_Category.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnShow_Category.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow_Category.Image = ((System.Drawing.Image)(resources.GetObject("btnShow_Category.Image")));
            this.btnShow_Category.Location = new System.Drawing.Point(339, 5);
            this.btnShow_Category.Name = "btnShow_Category";
            this.btnShow_Category.Size = new System.Drawing.Size(82, 48);
            this.btnShow_Category.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnShow_Category.Symbol = "";
            this.btnShow_Category.SymbolColor = System.Drawing.Color.OrangeRed;
            this.btnShow_Category.TabIndex = 10;
            this.btnShow_Category.Text = "Xem";
            this.btnShow_Category.TextColor = System.Drawing.Color.Black;
            // 
            // btnDelete_Category
            // 
            this.btnDelete_Category.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDelete_Category.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDelete_Category.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete_Category.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete_Category.Image")));
            this.btnDelete_Category.Location = new System.Drawing.Point(111, 4);
            this.btnDelete_Category.Name = "btnDelete_Category";
            this.btnDelete_Category.Size = new System.Drawing.Size(82, 48);
            this.btnDelete_Category.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDelete_Category.Symbol = "";
            this.btnDelete_Category.SymbolColor = System.Drawing.Color.OrangeRed;
            this.btnDelete_Category.TabIndex = 11;
            this.btnDelete_Category.Text = "Xóa";
            this.btnDelete_Category.TextColor = System.Drawing.Color.Black;
            this.btnDelete_Category.Click += new System.EventHandler(this.btnDelete_Category_Click);
            // 
            // btnAdd_Category
            // 
            this.btnAdd_Category.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAdd_Category.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAdd_Category.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd_Category.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd_Category.Image")));
            this.btnAdd_Category.Location = new System.Drawing.Point(3, 4);
            this.btnAdd_Category.Name = "btnAdd_Category";
            this.btnAdd_Category.Size = new System.Drawing.Size(82, 48);
            this.btnAdd_Category.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAdd_Category.Symbol = "";
            this.btnAdd_Category.SymbolColor = System.Drawing.Color.OrangeRed;
            this.btnAdd_Category.TabIndex = 7;
            this.btnAdd_Category.Text = "Thêm";
            this.btnAdd_Category.TextColor = System.Drawing.Color.Black;
            this.btnAdd_Category.Click += new System.EventHandler(this.btnAdd_Category_Click);
            // 
            // btnEdit_Category
            // 
            this.btnEdit_Category.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEdit_Category.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnEdit_Category.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit_Category.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit_Category.Image")));
            this.btnEdit_Category.Location = new System.Drawing.Point(224, 4);
            this.btnEdit_Category.Name = "btnEdit_Category";
            this.btnEdit_Category.Size = new System.Drawing.Size(82, 48);
            this.btnEdit_Category.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnEdit_Category.Symbol = "";
            this.btnEdit_Category.SymbolColor = System.Drawing.Color.OrangeRed;
            this.btnEdit_Category.TabIndex = 9;
            this.btnEdit_Category.Text = "Sửa";
            this.btnEdit_Category.TextColor = System.Drawing.Color.Black;
            this.btnEdit_Category.Click += new System.EventHandler(this.btnEdit_Category_Click);
            // 
            // tpFood
            // 
            this.tpFood.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tpFood.BackgroundImage")));
            this.tpFood.Controls.Add(this.panel13);
            this.tpFood.Controls.Add(this.panel12);
            this.tpFood.Controls.Add(this.panel6);
            this.tpFood.Controls.Add(this.panel5);
            this.tpFood.Controls.Add(this.panel4);
            this.tpFood.Controls.Add(this.panel3);
            this.tpFood.Location = new System.Drawing.Point(4, 22);
            this.tpFood.Name = "tpFood";
            this.tpFood.Padding = new System.Windows.Forms.Padding(3);
            this.tpFood.Size = new System.Drawing.Size(767, 400);
            this.tpFood.TabIndex = 1;
            this.tpFood.Text = "Thức ăn";
            this.tpFood.UseVisualStyleBackColor = true;
            this.tpFood.Click += new System.EventHandler(this.tpFood_Click);
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.cbFoodCategory);
            this.panel13.Controls.Add(this.label3);
            this.panel13.Location = new System.Drawing.Point(460, 180);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(301, 50);
            this.panel13.TabIndex = 2;
            // 
            // cbFoodCategory
            // 
            this.cbFoodCategory.FormattingEnabled = true;
            this.cbFoodCategory.Location = new System.Drawing.Point(114, 22);
            this.cbFoodCategory.Name = "cbFoodCategory";
            this.cbFoodCategory.Size = new System.Drawing.Size(184, 21);
            this.cbFoodCategory.TabIndex = 2;
            this.cbFoodCategory.SelectedIndexChanged += new System.EventHandler(this.cbFoodCategory_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(3, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "      Danh mục: ";
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.txbFoodName);
            this.panel12.Controls.Add(this.label2);
            this.panel12.Location = new System.Drawing.Point(460, 124);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(301, 50);
            this.panel12.TabIndex = 2;
            // 
            // txbFoodName
            // 
            this.txbFoodName.Location = new System.Drawing.Point(114, 20);
            this.txbFoodName.Name = "txbFoodName";
            this.txbFoodName.Size = new System.Drawing.Size(184, 20);
            this.txbFoodName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(3, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "     Tên món: ";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnSearch_Food);
            this.panel6.Controls.Add(this.txbSearchFoodName);
            this.panel6.Location = new System.Drawing.Point(460, 7);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(301, 55);
            this.panel6.TabIndex = 3;
            // 
            // btnSearch_Food
            // 
            this.btnSearch_Food.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSearch_Food.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSearch_Food.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch_Food.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch_Food.Image")));
            this.btnSearch_Food.Location = new System.Drawing.Point(223, 5);
            this.btnSearch_Food.Name = "btnSearch_Food";
            this.btnSearch_Food.Size = new System.Drawing.Size(75, 48);
            this.btnSearch_Food.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSearch_Food.Symbol = "";
            this.btnSearch_Food.SymbolColor = System.Drawing.Color.OrangeRed;
            this.btnSearch_Food.TabIndex = 3;
            this.btnSearch_Food.Text = "Tìm";
            this.btnSearch_Food.TextColor = System.Drawing.Color.Black;
            this.btnSearch_Food.Click += new System.EventHandler(this.btnSearch_Food_Click);
            // 
            // txbSearchFoodName
            // 
            this.txbSearchFoodName.Location = new System.Drawing.Point(6, 18);
            this.txbSearchFoodName.Name = "txbSearchFoodName";
            this.txbSearchFoodName.Size = new System.Drawing.Size(211, 20);
            this.txbSearchFoodName.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel14);
            this.panel5.Controls.Add(this.panel11);
            this.panel5.Location = new System.Drawing.Point(442, 68);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(319, 325);
            this.panel5.TabIndex = 2;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.nmFoodPrice);
            this.panel14.Controls.Add(this.label4);
            this.panel14.Location = new System.Drawing.Point(18, 168);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(301, 50);
            this.panel14.TabIndex = 2;
            // 
            // nmFoodPrice
            // 
            this.nmFoodPrice.Location = new System.Drawing.Point(114, 22);
            this.nmFoodPrice.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nmFoodPrice.Name = "nmFoodPrice";
            this.nmFoodPrice.Size = new System.Drawing.Size(184, 20);
            this.nmFoodPrice.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(3, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "      Giá: ";
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.txbFoodID);
            this.panel11.Controls.Add(this.label1);
            this.panel11.Location = new System.Drawing.Point(18, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(298, 50);
            this.panel11.TabIndex = 1;
            // 
            // txbFoodID
            // 
            this.txbFoodID.Location = new System.Drawing.Point(114, 20);
            this.txbFoodID.Name = "txbFoodID";
            this.txbFoodID.ReadOnly = true;
            this.txbFoodID.Size = new System.Drawing.Size(184, 20);
            this.txbFoodID.TabIndex = 1;
            this.txbFoodID.TextChanged += new System.EventHandler(this.txbFoodID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.ImageKey = "(none)";
            this.label1.Location = new System.Drawing.Point(3, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_Show_Food);
            this.panel4.Controls.Add(this.btn_Edit_Food);
            this.panel4.Controls.Add(this.btn_Delete_Food);
            this.panel4.Controls.Add(this.btn_Add_Food);
            this.panel4.Location = new System.Drawing.Point(6, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(430, 55);
            this.panel4.TabIndex = 1;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // btn_Show_Food
            // 
            this.btn_Show_Food.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Show_Food.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Show_Food.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Show_Food.Image = ((System.Drawing.Image)(resources.GetObject("btn_Show_Food.Image")));
            this.btn_Show_Food.Location = new System.Drawing.Point(339, 5);
            this.btn_Show_Food.Name = "btn_Show_Food";
            this.btn_Show_Food.Size = new System.Drawing.Size(82, 48);
            this.btn_Show_Food.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Show_Food.Symbol = "";
            this.btn_Show_Food.SymbolColor = System.Drawing.Color.OrangeRed;
            this.btn_Show_Food.TabIndex = 6;
            this.btn_Show_Food.Text = "Xem";
            this.btn_Show_Food.TextColor = System.Drawing.Color.Black;
            this.btn_Show_Food.Click += new System.EventHandler(this.btn_Show_Food_Click);
            // 
            // btn_Edit_Food
            // 
            this.btn_Edit_Food.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Edit_Food.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Edit_Food.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit_Food.Image = ((System.Drawing.Image)(resources.GetObject("btn_Edit_Food.Image")));
            this.btn_Edit_Food.Location = new System.Drawing.Point(224, 4);
            this.btn_Edit_Food.Name = "btn_Edit_Food";
            this.btn_Edit_Food.Size = new System.Drawing.Size(82, 48);
            this.btn_Edit_Food.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Edit_Food.Symbol = "";
            this.btn_Edit_Food.SymbolColor = System.Drawing.Color.OrangeRed;
            this.btn_Edit_Food.TabIndex = 5;
            this.btn_Edit_Food.Text = "Sửa";
            this.btn_Edit_Food.TextColor = System.Drawing.Color.Black;
            this.btn_Edit_Food.Click += new System.EventHandler(this.btn_Edit_Food_Click);
            // 
            // btn_Delete_Food
            // 
            this.btn_Delete_Food.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Delete_Food.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Delete_Food.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete_Food.Image = ((System.Drawing.Image)(resources.GetObject("btn_Delete_Food.Image")));
            this.btn_Delete_Food.Location = new System.Drawing.Point(111, 4);
            this.btn_Delete_Food.Name = "btn_Delete_Food";
            this.btn_Delete_Food.Size = new System.Drawing.Size(82, 48);
            this.btn_Delete_Food.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Delete_Food.Symbol = "";
            this.btn_Delete_Food.SymbolColor = System.Drawing.Color.OrangeRed;
            this.btn_Delete_Food.TabIndex = 3;
            this.btn_Delete_Food.Text = " Xóa";
            this.btn_Delete_Food.TextColor = System.Drawing.Color.Black;
            this.btn_Delete_Food.Click += new System.EventHandler(this.btn_Delete_Food_Click);
            // 
            // btn_Add_Food
            // 
            this.btn_Add_Food.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Add_Food.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Add_Food.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_Food.Image = ((System.Drawing.Image)(resources.GetObject("btn_Add_Food.Image")));
            this.btn_Add_Food.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Add_Food.Location = new System.Drawing.Point(3, 4);
            this.btn_Add_Food.Name = "btn_Add_Food";
            this.btn_Add_Food.Size = new System.Drawing.Size(82, 48);
            this.btn_Add_Food.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Add_Food.Symbol = "";
            this.btn_Add_Food.SymbolColor = System.Drawing.Color.OrangeRed;
            this.btn_Add_Food.TabIndex = 3;
            this.btn_Add_Food.Text = " Thêm";
            this.btn_Add_Food.TextColor = System.Drawing.Color.Black;
            this.btn_Add_Food.Click += new System.EventHandler(this.btn_Add_Food_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtgvFood);
            this.panel3.Location = new System.Drawing.Point(6, 68);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(430, 325);
            this.panel3.TabIndex = 0;
            // 
            // dtgvFood
            // 
            this.dtgvFood.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvFood.BackgroundColor = System.Drawing.Color.LemonChiffon;
            this.dtgvFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvFood.Location = new System.Drawing.Point(3, 4);
            this.dtgvFood.Name = "dtgvFood";
            this.dtgvFood.Size = new System.Drawing.Size(424, 318);
            this.dtgvFood.TabIndex = 0;
            this.dtgvFood.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvFood_CellContentClick);
            // 
            // tpBill
            // 
            this.tpBill.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tpBill.BackgroundImage")));
            this.tpBill.Controls.Add(this.panel2);
            this.tpBill.Controls.Add(this.panel1);
            this.tpBill.Location = new System.Drawing.Point(4, 22);
            this.tpBill.Name = "tpBill";
            this.tpBill.Padding = new System.Windows.Forms.Padding(3);
            this.tpBill.Size = new System.Drawing.Size(767, 400);
            this.tpBill.TabIndex = 0;
            this.tpBill.Text = "DoanhThu";
            this.tpBill.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.dtpkToDate);
            this.panel2.Controls.Add(this.dtpkFromDate);
            this.panel2.Location = new System.Drawing.Point(7, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(749, 25);
            this.panel2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(329, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 22);
            this.button1.TabIndex = 2;
            this.button1.Text = "Thống kê";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtpkToDate
            // 
            this.dtpkToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkToDate.Location = new System.Drawing.Point(616, 3);
            this.dtpkToDate.Name = "dtpkToDate";
            this.dtpkToDate.Size = new System.Drawing.Size(130, 20);
            this.dtpkToDate.TabIndex = 1;
            // 
            // dtpkFromDate
            // 
            this.dtpkFromDate.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.dtpkFromDate.CustomFormat = "dd.MM.yyyy";
            this.dtpkFromDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpkFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkFromDate.Location = new System.Drawing.Point(3, 2);
            this.dtpkFromDate.Name = "dtpkFromDate";
            this.dtpkFromDate.Size = new System.Drawing.Size(130, 20);
            this.dtpkFromDate.TabIndex = 0;
            this.dtpkFromDate.ValueChanged += new System.EventHandler(this.dtpkFromDate_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgvBill);
            this.panel1.Location = new System.Drawing.Point(6, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(755, 357);
            this.panel1.TabIndex = 0;
            // 
            // dtgvBill
            // 
            this.dtgvBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvBill.BackgroundColor = System.Drawing.Color.LemonChiffon;
            this.dtgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBill.Location = new System.Drawing.Point(1, 0);
            this.dtgvBill.Name = "dtgvBill";
            this.dtgvBill.Size = new System.Drawing.Size(749, 352);
            this.dtgvBill.TabIndex = 0;
            this.dtgvBill.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvBill_CellContentClick);
            // 
            // tcAdmin
            // 
            this.tcAdmin.Controls.Add(this.tpBill);
            this.tcAdmin.Controls.Add(this.tpFood);
            this.tcAdmin.Controls.Add(this.tbFoodCatetory);
            this.tcAdmin.Controls.Add(this.tpAccount);
            this.tcAdmin.Controls.Add(this.tabPage1);
            this.tcAdmin.Cursor = System.Windows.Forms.Cursors.Default;
            this.tcAdmin.Location = new System.Drawing.Point(13, 12);
            this.tcAdmin.Name = "tcAdmin";
            this.tcAdmin.SelectedIndex = 0;
            this.tcAdmin.Size = new System.Drawing.Size(775, 426);
            this.tcAdmin.TabIndex = 0;
            this.tcAdmin.SelectedIndexChanged += new System.EventHandler(this.tcAdmin_SelectedIndexChanged);
            // 
            // tpAccount
            // 
            this.tpAccount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tpAccount.BackgroundImage")));
            this.tpAccount.Controls.Add(this.btnReset_PassWord);
            this.tpAccount.Controls.Add(this.labelX1);
            this.tpAccount.Controls.Add(this.panel24);
            this.tpAccount.Controls.Add(this.panel23);
            this.tpAccount.Controls.Add(this.panel22);
            this.tpAccount.Controls.Add(this.panel21);
            this.tpAccount.Controls.Add(this.panel20);
            this.tpAccount.Location = new System.Drawing.Point(4, 22);
            this.tpAccount.Name = "tpAccount";
            this.tpAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tpAccount.Size = new System.Drawing.Size(767, 400);
            this.tpAccount.TabIndex = 4;
            this.tpAccount.Text = "Tài khoản";
            this.tpAccount.UseVisualStyleBackColor = true;
            // 
            // btnReset_PassWord
            // 
            this.btnReset_PassWord.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnReset_PassWord.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnReset_PassWord.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset_PassWord.Location = new System.Drawing.Point(669, 246);
            this.btnReset_PassWord.Name = "btnReset_PassWord";
            this.btnReset_PassWord.Size = new System.Drawing.Size(89, 48);
            this.btnReset_PassWord.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnReset_PassWord.Symbol = "";
            this.btnReset_PassWord.SymbolColor = System.Drawing.Color.OrangeRed;
            this.btnReset_PassWord.TabIndex = 11;
            this.btnReset_PassWord.Text = "Đổi mật khẩu";
            this.btnReset_PassWord.TextColor = System.Drawing.Color.Black;
            this.btnReset_PassWord.Click += new System.EventHandler(this.btnReset_PassWord_Click);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelX1.Location = new System.Drawing.Point(539, 23);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(205, 35);
            this.labelX1.TabIndex = 10;
            this.labelX1.Text = "--TÀI KHOẢN--";
            // 
            // panel24
            // 
            this.panel24.Controls.Add(this.nmType);
            this.panel24.Controls.Add(this.label12);
            this.panel24.Location = new System.Drawing.Point(445, 179);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(313, 50);
            this.panel24.TabIndex = 9;
            // 
            // nmType
            // 
            this.nmType.Location = new System.Drawing.Point(125, 23);
            this.nmType.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmType.Name = "nmType";
            this.nmType.Size = new System.Drawing.Size(120, 20);
            this.nmType.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(3, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 18);
            this.label12.TabIndex = 0;
            this.label12.Text = "Loại tài khoản:";
            // 
            // panel23
            // 
            this.panel23.Controls.Add(this.txbDisplayName);
            this.panel23.Controls.Add(this.label11);
            this.panel23.Location = new System.Drawing.Point(445, 123);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(313, 50);
            this.panel23.TabIndex = 8;
            // 
            // txbDisplayName
            // 
            this.txbDisplayName.Location = new System.Drawing.Point(125, 20);
            this.txbDisplayName.Name = "txbDisplayName";
            this.txbDisplayName.Size = new System.Drawing.Size(185, 20);
            this.txbDisplayName.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(3, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 18);
            this.label11.TabIndex = 0;
            this.label11.Text = "Tên hiển thị: ";
            // 
            // panel22
            // 
            this.panel22.Controls.Add(this.txtUserName);
            this.panel22.Controls.Add(this.label10);
            this.panel22.Location = new System.Drawing.Point(445, 67);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(313, 50);
            this.panel22.TabIndex = 7;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(122, 20);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(188, 20);
            this.txtUserName.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(3, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 18);
            this.label10.TabIndex = 0;
            this.label10.Text = "Tên tài khoản: ";
            // 
            // panel21
            // 
            this.panel21.Controls.Add(this.dtgvAccount);
            this.panel21.Location = new System.Drawing.Point(6, 67);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(433, 325);
            this.panel21.TabIndex = 6;
            // 
            // dtgvAccount
            // 
            this.dtgvAccount.AutoGenerateColumns = false;
            this.dtgvAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvAccount.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAccount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userNameDataGridViewTextBoxColumn,
            this.displayNameDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn});
            this.dtgvAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtgvAccount.DataSource = this.aCCOUNTBindingSource;
            this.dtgvAccount.Location = new System.Drawing.Point(4, 4);
            this.dtgvAccount.Name = "dtgvAccount";
            this.dtgvAccount.Size = new System.Drawing.Size(426, 318);
            this.dtgvAccount.TabIndex = 6;
            this.dtgvAccount.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvAccount_CellContentClick);
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "Tên đăng nhập";
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            // 
            // displayNameDataGridViewTextBoxColumn
            // 
            this.displayNameDataGridViewTextBoxColumn.DataPropertyName = "DisplayName";
            this.displayNameDataGridViewTextBoxColumn.HeaderText = "Tên hiển thị ";
            this.displayNameDataGridViewTextBoxColumn.Name = "displayNameDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Loại tài khoản";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // panel20
            // 
            this.panel20.Controls.Add(this.btnAdd_Account);
            this.panel20.Controls.Add(this.buttonX1);
            this.panel20.Controls.Add(this.btnEdit_Account);
            this.panel20.Controls.Add(this.btnDelete_Account);
            this.panel20.Location = new System.Drawing.Point(6, 6);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(430, 55);
            this.panel20.TabIndex = 4;
            // 
            // btnAdd_Account
            // 
            this.btnAdd_Account.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAdd_Account.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAdd_Account.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd_Account.Location = new System.Drawing.Point(3, 4);
            this.btnAdd_Account.Name = "btnAdd_Account";
            this.btnAdd_Account.Size = new System.Drawing.Size(75, 48);
            this.btnAdd_Account.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAdd_Account.Symbol = "";
            this.btnAdd_Account.SymbolColor = System.Drawing.Color.OrangeRed;
            this.btnAdd_Account.TabIndex = 10;
            this.btnAdd_Account.Text = "Thêm ";
            this.btnAdd_Account.Click += new System.EventHandler(this.btnAdd_Account_Click);
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX1.Location = new System.Drawing.Point(339, 5);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(75, 48);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.Symbol = "";
            this.buttonX1.SymbolColor = System.Drawing.Color.OrangeRed;
            this.buttonX1.TabIndex = 13;
            this.buttonX1.Text = "Xem";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // btnEdit_Account
            // 
            this.btnEdit_Account.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEdit_Account.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnEdit_Account.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit_Account.Location = new System.Drawing.Point(224, 4);
            this.btnEdit_Account.Name = "btnEdit_Account";
            this.btnEdit_Account.Size = new System.Drawing.Size(75, 48);
            this.btnEdit_Account.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnEdit_Account.Symbol = "";
            this.btnEdit_Account.SymbolColor = System.Drawing.Color.OrangeRed;
            this.btnEdit_Account.TabIndex = 12;
            this.btnEdit_Account.Text = "Sửa";
            this.btnEdit_Account.Click += new System.EventHandler(this.btnEdit_Account_Click);
            // 
            // btnDelete_Account
            // 
            this.btnDelete_Account.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDelete_Account.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDelete_Account.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete_Account.Location = new System.Drawing.Point(111, 4);
            this.btnDelete_Account.Name = "btnDelete_Account";
            this.btnDelete_Account.Size = new System.Drawing.Size(75, 48);
            this.btnDelete_Account.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDelete_Account.Symbol = "";
            this.btnDelete_Account.SymbolColor = System.Drawing.Color.OrangeRed;
            this.btnDelete_Account.TabIndex = 11;
            this.btnDelete_Account.Text = "Xóa";
            this.btnDelete_Account.Click += new System.EventHandler(this.btnDelete_Account_Click);
            // 
            // fAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 452);
            this.Controls.Add(this.tcAdmin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin - Quản lí ";
            this.Load += new System.EventHandler(this.fAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.USP_GetListBillByDateForReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyQuanCafe2DataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCCOUNTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyQuanCafe2DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fOODBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyQuanCafe2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyQuanCafe2DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fOODCATEGORYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyQuanCafe2DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fOODBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyQuanCafe2DataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fOODBindingSource2)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tbFoodCatetory.ResumeLayout(false);
            this.tbFoodCatetory.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCategory)).EndInit();
            this.panel7.ResumeLayout(false);
            this.tpFood.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodPrice)).EndInit();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFood)).EndInit();
            this.tpBill.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).EndInit();
            this.tcAdmin.ResumeLayout(false);
            this.tpAccount.ResumeLayout(false);
            this.panel24.ResumeLayout(false);
            this.panel24.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmType)).EndInit();
            this.panel23.ResumeLayout(false);
            this.panel23.PerformLayout();
            this.panel22.ResumeLayout(false);
            this.panel22.PerformLayout();
            this.panel21.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).EndInit();
            this.panel20.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private QuanLyQuanCafe2DataSet quanLyQuanCafe2DataSet;
        private System.Windows.Forms.BindingSource fOODBindingSource;
        private QuanLyQuanCafe2DataSetTableAdapters.FOODTableAdapter fOODTableAdapter;
        private QuanLyQuanCafe2DataSet1 quanLyQuanCafe2DataSet1;
        private System.Windows.Forms.BindingSource aCCOUNTBindingSource;
        private QuanLyQuanCafe2DataSet1TableAdapters.ACCOUNTTableAdapter aCCOUNTTableAdapter;
        private QuanLyQuanCafe2DataSet2 quanLyQuanCafe2DataSet2;
        private System.Windows.Forms.BindingSource fOODCATEGORYBindingSource;
        private QuanLyQuanCafe2DataSet2TableAdapters.FOODCATEGORYTableAdapter fOODCATEGORYTableAdapter;
        private QuanLyQuanCafe2DataSet3 quanLyQuanCafe2DataSet3;
        private System.Windows.Forms.BindingSource fOODBindingSource1;
        private QuanLyQuanCafe2DataSet3TableAdapters.FOODTableAdapter fOODTableAdapter1;
        private QuanLyQuanCafe2DataSet4 quanLyQuanCafe2DataSet4;
        private System.Windows.Forms.BindingSource fOODBindingSource2;
        private QuanLyQuanCafe2DataSet4TableAdapters.FOODTableAdapter fOODTableAdapter2;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private QuanLyQuanCafe2DataSet3TableAdapters.FOODTableAdapter foodTableAdapter3;
        private System.Windows.Forms.BindingSource USP_GetListBillByDateForReportBindingSource;
        private QuanLyQuanCafe2DataSet5 QuanLyQuanCafe2DataSet5;
        private QuanLyQuanCafe2DataSet5TableAdapters.USP_GetListBillByDateForReportTableAdapter USP_GetListBillByDateForReportTableAdapter;
        private System.Windows.Forms.TabPage tabPage1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.TabPage tbFoodCatetory;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox txbNameFoodCategory;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox txbCategoryID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.DataGridView dtgvCategory;
        private System.Windows.Forms.Panel panel7;
        private DevComponents.DotNetBar.ButtonX btnShow_Category;
        private DevComponents.DotNetBar.ButtonX btnDelete_Category;
        private DevComponents.DotNetBar.ButtonX btnAdd_Category;
        private DevComponents.DotNetBar.ButtonX btnEdit_Category;
        private System.Windows.Forms.TabPage tpFood;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.ComboBox cbFoodCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.TextBox txbFoodName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel6;
        private DevComponents.DotNetBar.ButtonX btnSearch_Food;
        private System.Windows.Forms.TextBox txbSearchFoodName;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.NumericUpDown nmFoodPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.TextBox txbFoodID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private DevComponents.DotNetBar.ButtonX btn_Show_Food;
        private DevComponents.DotNetBar.ButtonX btn_Edit_Food;
        private DevComponents.DotNetBar.ButtonX btn_Delete_Food;
        private DevComponents.DotNetBar.ButtonX btn_Add_Food;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dtgvFood;
        private System.Windows.Forms.TabPage tpBill;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtpkToDate;
        private System.Windows.Forms.DateTimePicker dtpkFromDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgvBill;
        private System.Windows.Forms.TabControl tcAdmin;
        private System.Windows.Forms.TabPage tpAccount;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.Panel panel24;
        private System.Windows.Forms.NumericUpDown nmType;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel23;
        private System.Windows.Forms.TextBox txbDisplayName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.DataGridView dtgvAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn displayNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel20;
        private DevComponents.DotNetBar.ButtonX btnAdd_Account;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.ButtonX btnEdit_Account;
        private DevComponents.DotNetBar.ButtonX btnDelete_Account;
        private DevComponents.DotNetBar.ButtonX btnReset_PassWord;
    }
}