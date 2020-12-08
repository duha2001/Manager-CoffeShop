namespace QuanLyCafe
{
    partial class fTableManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fTableManager));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinPhầmMềmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tácGiảPhầnMềmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thanhToánToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmMónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chuyểnBànToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lvsBill = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSwitch_Table = new DevComponents.DotNetBar.ButtonX();
            this.btnCheck_Out = new DevComponents.DotNetBar.ButtonX();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.cbSwitchTable = new System.Windows.Forms.ComboBox();
            this.nmDisCount = new System.Windows.Forms.NumericUpDown();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnAdd_Food = new DevComponents.DotNetBar.ButtonX();
            this.nmFoodCount = new System.Windows.Forms.NumericUpDown();
            this.cbFood = new System.Windows.Forms.ComboBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.flowTable = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmDisCount)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodCount)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip1.BackgroundImage")));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.thôngTinTàiKhoảnToolStripMenuItem,
            this.thôngTinPhầmMềmToolStripMenuItem,
            this.chứcNăngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.BackColor = System.Drawing.Color.Moccasin;
            this.adminToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("adminToolStripMenuItem.Image")));
            this.adminToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.BackColor = System.Drawing.Color.Khaki;
            this.thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.thôngTinTàiKhoảnToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thôngTinTàiKhoảnToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("thôngTinTàiKhoảnToolStripMenuItem.Image")));
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(142, 20);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            this.thôngTinTàiKhoảnToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // thôngTinCáToolStripMenuItem
            // 
            this.thôngTinCáToolStripMenuItem.BackColor = System.Drawing.Color.Goldenrod;
            this.thôngTinCáToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("thôngTinCáToolStripMenuItem.Image")));
            this.thôngTinCáToolStripMenuItem.Name = "thôngTinCáToolStripMenuItem";
            this.thôngTinCáToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.thôngTinCáToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.thôngTinCáToolStripMenuItem.Text = "Thông tin cá nhân";
            this.thôngTinCáToolStripMenuItem.Click += new System.EventHandler(this.thôngTinCáToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.BackColor = System.Drawing.Color.Bisque;
            this.đăngXuấtToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("đăngXuấtToolStripMenuItem.Image")));
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất ";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // thôngTinPhầmMềmToolStripMenuItem
            // 
            this.thôngTinPhầmMềmToolStripMenuItem.BackColor = System.Drawing.Color.YellowGreen;
            this.thôngTinPhầmMềmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tácGiảPhầnMềmToolStripMenuItem});
            this.thôngTinPhầmMềmToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thôngTinPhầmMềmToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("thôngTinPhầmMềmToolStripMenuItem.Image")));
            this.thôngTinPhầmMềmToolStripMenuItem.Name = "thôngTinPhầmMềmToolStripMenuItem";
            this.thôngTinPhầmMềmToolStripMenuItem.Size = new System.Drawing.Size(156, 20);
            this.thôngTinPhầmMềmToolStripMenuItem.Text = "Thông Tin Phầm Mềm";
            this.thôngTinPhầmMềmToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // tácGiảPhầnMềmToolStripMenuItem
            // 
            this.tácGiảPhầnMềmToolStripMenuItem.BackColor = System.Drawing.Color.PaleVioletRed;
            this.tácGiảPhầnMềmToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("tácGiảPhầnMềmToolStripMenuItem.Image")));
            this.tácGiảPhầnMềmToolStripMenuItem.Name = "tácGiảPhầnMềmToolStripMenuItem";
            this.tácGiảPhầnMềmToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.tácGiảPhầnMềmToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.tácGiảPhầnMềmToolStripMenuItem.Text = "Tác giả phần mềm";
            this.tácGiảPhầnMềmToolStripMenuItem.Click += new System.EventHandler(this.tácGiảPhầnMềmToolStripMenuItem_Click);
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.BackColor = System.Drawing.Color.Aquamarine;
            this.chứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thanhToánToolStripMenuItem,
            this.thêmMónToolStripMenuItem,
            this.chuyểnBànToolStripMenuItem});
            this.chứcNăngToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chứcNăngToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("chứcNăngToolStripMenuItem.Image")));
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.chứcNăngToolStripMenuItem.Text = "Chức năng";
            this.chứcNăngToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // thanhToánToolStripMenuItem
            // 
            this.thanhToánToolStripMenuItem.BackColor = System.Drawing.Color.HotPink;
            this.thanhToánToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("thanhToánToolStripMenuItem.Image")));
            this.thanhToánToolStripMenuItem.Name = "thanhToánToolStripMenuItem";
            this.thanhToánToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F12;
            this.thanhToánToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.thanhToánToolStripMenuItem.Text = "Thanh Toán";
            this.thanhToánToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.thanhToánToolStripMenuItem.Click += new System.EventHandler(this.thanhToánToolStripMenuItem_Click);
            // 
            // thêmMónToolStripMenuItem
            // 
            this.thêmMónToolStripMenuItem.BackColor = System.Drawing.Color.Thistle;
            this.thêmMónToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("thêmMónToolStripMenuItem.Image")));
            this.thêmMónToolStripMenuItem.Name = "thêmMónToolStripMenuItem";
            this.thêmMónToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F11;
            this.thêmMónToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.thêmMónToolStripMenuItem.Text = "Thêm món";
            this.thêmMónToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.thêmMónToolStripMenuItem.Click += new System.EventHandler(this.thêmMónToolStripMenuItem_Click);
            // 
            // chuyểnBànToolStripMenuItem
            // 
            this.chuyểnBànToolStripMenuItem.BackColor = System.Drawing.Color.Violet;
            this.chuyểnBànToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("chuyểnBànToolStripMenuItem.Image")));
            this.chuyểnBànToolStripMenuItem.Name = "chuyểnBànToolStripMenuItem";
            this.chuyểnBànToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F10;
            this.chuyểnBànToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.chuyểnBànToolStripMenuItem.Text = "Chuyển bàn ";
            this.chuyểnBànToolStripMenuItem.Click += new System.EventHandler(this.chuyểnBànToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lvsBill);
            this.panel2.Location = new System.Drawing.Point(408, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(380, 279);
            this.panel2.TabIndex = 0;
            // 
            // lvsBill
            // 
            this.lvsBill.BackColor = System.Drawing.SystemColors.Info;
            this.lvsBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvsBill.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvsBill.GridLines = true;
            this.lvsBill.HideSelection = false;
            this.lvsBill.Location = new System.Drawing.Point(3, 3);
            this.lvsBill.Name = "lvsBill";
            this.lvsBill.Size = new System.Drawing.Size(374, 273);
            this.lvsBill.TabIndex = 0;
            this.lvsBill.UseCompatibleStateImageBehavior = false;
            this.lvsBill.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên món";
            this.columnHeader1.Width = 141;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số lượng";
            this.columnHeader2.Width = 76;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn giá ";
            this.columnHeader3.Width = 72;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành tiền ";
            this.columnHeader4.Width = 172;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Controls.Add(this.btnSwitch_Table);
            this.panel3.Controls.Add(this.btnCheck_Out);
            this.panel3.Controls.Add(this.txtTotalPrice);
            this.panel3.Controls.Add(this.cbSwitchTable);
            this.panel3.Controls.Add(this.nmDisCount);
            this.panel3.Location = new System.Drawing.Point(405, 367);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(383, 60);
            this.panel3.TabIndex = 2;
            // 
            // btnSwitch_Table
            // 
            this.btnSwitch_Table.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSwitch_Table.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSwitch_Table.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSwitch_Table.Image = ((System.Drawing.Image)(resources.GetObject("btnSwitch_Table.Image")));
            this.btnSwitch_Table.Location = new System.Drawing.Point(4, 1);
            this.btnSwitch_Table.Name = "btnSwitch_Table";
            this.btnSwitch_Table.Size = new System.Drawing.Size(84, 32);
            this.btnSwitch_Table.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSwitch_Table.TabIndex = 0;
            this.btnSwitch_Table.Text = "Chuyển bàn";
            this.btnSwitch_Table.TextColor = System.Drawing.Color.Black;
            this.btnSwitch_Table.Click += new System.EventHandler(this.btnSwitch_Table_Click);
            // 
            // btnCheck_Out
            // 
            this.btnCheck_Out.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCheck_Out.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCheck_Out.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck_Out.Image = ((System.Drawing.Image)(resources.GetObject("btnCheck_Out.Image")));
            this.btnCheck_Out.Location = new System.Drawing.Point(282, 3);
            this.btnCheck_Out.Name = "btnCheck_Out";
            this.btnCheck_Out.Size = new System.Drawing.Size(98, 48);
            this.btnCheck_Out.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCheck_Out.TabIndex = 0;
            this.btnCheck_Out.Text = "Thanh Toán";
            this.btnCheck_Out.Click += new System.EventHandler(this.btnCheck_Out_Click);
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPrice.ForeColor = System.Drawing.Color.OrangeRed;
            this.txtTotalPrice.Location = new System.Drawing.Point(138, 3);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(141, 25);
            this.txtTotalPrice.TabIndex = 8;
            this.txtTotalPrice.Text = "0";
            this.txtTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbSwitchTable
            // 
            this.cbSwitchTable.BackColor = System.Drawing.SystemColors.Info;
            this.cbSwitchTable.FormattingEnabled = true;
            this.cbSwitchTable.Location = new System.Drawing.Point(4, 36);
            this.cbSwitchTable.Name = "cbSwitchTable";
            this.cbSwitchTable.Size = new System.Drawing.Size(84, 21);
            this.cbSwitchTable.TabIndex = 7;
            this.cbSwitchTable.SelectedIndexChanged += new System.EventHandler(this.cbSwitchTable_SelectedIndexChanged);
            // 
            // nmDisCount
            // 
            this.nmDisCount.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nmDisCount.Location = new System.Drawing.Point(213, 30);
            this.nmDisCount.Name = "nmDisCount";
            this.nmDisCount.Size = new System.Drawing.Size(66, 20);
            this.nmDisCount.TabIndex = 5;
            this.nmDisCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.Controls.Add(this.btnAdd_Food);
            this.panel4.Controls.Add(this.nmFoodCount);
            this.panel4.Controls.Add(this.cbFood);
            this.panel4.Controls.Add(this.cbCategory);
            this.panel4.Location = new System.Drawing.Point(408, 27);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(380, 55);
            this.panel4.TabIndex = 3;
            // 
            // btnAdd_Food
            // 
            this.btnAdd_Food.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAdd_Food.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAdd_Food.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd_Food.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd_Food.Image")));
            this.btnAdd_Food.Location = new System.Drawing.Point(224, 4);
            this.btnAdd_Food.Name = "btnAdd_Food";
            this.btnAdd_Food.Size = new System.Drawing.Size(108, 48);
            this.btnAdd_Food.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAdd_Food.Symbol = "";
            this.btnAdd_Food.SymbolColor = System.Drawing.Color.OrangeRed;
            this.btnAdd_Food.SymbolSize = 20F;
            this.btnAdd_Food.TabIndex = 0;
            this.btnAdd_Food.Text = "Thêm món";
            this.btnAdd_Food.TextColor = System.Drawing.Color.Black;
            this.btnAdd_Food.Click += new System.EventHandler(this.btnAdd_Food_Click);
            // 
            // nmFoodCount
            // 
            this.nmFoodCount.Location = new System.Drawing.Point(338, 18);
            this.nmFoodCount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nmFoodCount.Name = "nmFoodCount";
            this.nmFoodCount.Size = new System.Drawing.Size(36, 20);
            this.nmFoodCount.TabIndex = 3;
            this.nmFoodCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbFood
            // 
            this.cbFood.BackColor = System.Drawing.SystemColors.Info;
            this.cbFood.FormattingEnabled = true;
            this.cbFood.Location = new System.Drawing.Point(4, 31);
            this.cbFood.Name = "cbFood";
            this.cbFood.Size = new System.Drawing.Size(214, 21);
            this.cbFood.TabIndex = 1;
            // 
            // cbCategory
            // 
            this.cbCategory.BackColor = System.Drawing.SystemColors.Info;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(4, 4);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(214, 21);
            this.cbCategory.TabIndex = 0;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
            // 
            // flowTable
            // 
            this.flowTable.AutoScroll = true;
            this.flowTable.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.flowTable.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("flowTable.BackgroundImage")));
            this.flowTable.Location = new System.Drawing.Point(10, 27);
            this.flowTable.Name = "flowTable";
            this.flowTable.Size = new System.Drawing.Size(392, 400);
            this.flowTable.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 434);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Info;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(10, 447);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(310, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Copyright Trường Đại Học Sư Phạm TPHCM";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // fTableManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 476);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowTable);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fTableManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần Mềm Quản Lí Cafe";
            this.Load += new System.EventHandler(this.fTableManager_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmDisCount)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.NumericUpDown nmFoodCount;
        private System.Windows.Forms.ComboBox cbFood;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.ListView lvsBill;
        private System.Windows.Forms.FlowLayoutPanel flowTable;
        private System.Windows.Forms.ComboBox cbSwitchTable;
        private System.Windows.Forms.NumericUpDown nmDisCount;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem thôngTinPhầmMềmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tácGiảPhầnMềmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thanhToánToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmMónToolStripMenuItem;
        private DevComponents.DotNetBar.ButtonX btnAdd_Food;
        private DevComponents.DotNetBar.ButtonX btnCheck_Out;
        private DevComponents.DotNetBar.ButtonX btnSwitch_Table;
        private System.Windows.Forms.ToolStripMenuItem chuyểnBànToolStripMenuItem;
    }
}