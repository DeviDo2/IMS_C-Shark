namespace Dashboard_STAFF
{
    partial class PurchaseOrders_ADMIN
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseOrders_ADMIN));
            comboBox2 = new ComboBox();
            notify_pictureBox = new PictureBox();
            orgName_label = new Label();
            search_textBox = new TextBox();
            purchaseOrders_dataGridView = new DataGridView();
            purchaseOrders_btn = new Button();
            salesReturns_btn = new Button();
            salesOrders_btn = new Button();
            itemGrp_btn = new Button();
            inventory_btn = new Button();
            home_btn = new Button();
            label1 = new Label();
            profile_pictureBox = new PictureBox();
            splitContainer1 = new SplitContainer();
            reports_btn = new Button();
            flowLayoutPanel4 = new FlowLayoutPanel();
            button3 = new Button();
            PurchaseID = new DataGridViewTextBoxColumn();
            item = new DataGridViewTextBoxColumn();
            Brand = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            TotalPrice = new DataGridViewTextBoxColumn();
            SupplierName = new DataGridViewTextBoxColumn();
            OrderStatus = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)notify_pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)purchaseOrders_dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)profile_pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            comboBox2.ForeColor = Color.FromArgb(43, 42, 76);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(12, 61);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 5;
            comboBox2.Text = "FILTER";
            // 
            // notify_pictureBox
            // 
            notify_pictureBox.BackColor = Color.Transparent;
            notify_pictureBox.Cursor = Cursors.Hand;
            notify_pictureBox.Image = Properties.Resources._565422;
            notify_pictureBox.Location = new Point(1049, 21);
            notify_pictureBox.Name = "notify_pictureBox";
            notify_pictureBox.Size = new Size(30, 30);
            notify_pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            notify_pictureBox.TabIndex = 4;
            notify_pictureBox.TabStop = false;
            // 
            // orgName_label
            // 
            orgName_label.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            orgName_label.AutoSize = true;
            orgName_label.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            orgName_label.Location = new Point(1090, 28);
            orgName_label.Name = "orgName_label";
            orgName_label.RightToLeft = RightToLeft.Yes;
            orgName_label.Size = new Size(85, 23);
            orgName_label.TabIndex = 2;
            orgName_label.Text = "C-SHARK";
            // 
            // search_textBox
            // 
            search_textBox.Font = new Font("Segoe UI", 9F);
            search_textBox.ForeColor = Color.FromArgb(43, 42, 76);
            search_textBox.Location = new Point(12, 12);
            search_textBox.Name = "search_textBox";
            search_textBox.PlaceholderText = "Search";
            search_textBox.Size = new Size(318, 27);
            search_textBox.TabIndex = 0;
            // 
            // purchaseOrders_dataGridView
            // 
            purchaseOrders_dataGridView.AllowUserToAddRows = false;
            purchaseOrders_dataGridView.AllowUserToDeleteRows = false;
            purchaseOrders_dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            purchaseOrders_dataGridView.BackgroundColor = Color.FromArgb(238, 226, 222);
            purchaseOrders_dataGridView.BorderStyle = BorderStyle.None;
            purchaseOrders_dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            purchaseOrders_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            purchaseOrders_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            purchaseOrders_dataGridView.Columns.AddRange(new DataGridViewColumn[] { PurchaseID, item, Brand, Quantity, TotalPrice, SupplierName, OrderStatus });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(43, 42, 76);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            purchaseOrders_dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            purchaseOrders_dataGridView.Location = new Point(183, 95);
            purchaseOrders_dataGridView.Name = "purchaseOrders_dataGridView";
            purchaseOrders_dataGridView.ReadOnly = true;
            purchaseOrders_dataGridView.RowHeadersVisible = false;
            purchaseOrders_dataGridView.RowHeadersWidth = 51;
            purchaseOrders_dataGridView.ScrollBars = ScrollBars.Horizontal;
            purchaseOrders_dataGridView.Size = new Size(1060, 835);
            purchaseOrders_dataGridView.TabIndex = 9;
            // 
            // purchaseOrders_btn
            // 
            purchaseOrders_btn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            purchaseOrders_btn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            purchaseOrders_btn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            purchaseOrders_btn.Location = new Point(12, 309);
            purchaseOrders_btn.Name = "purchaseOrders_btn";
            purchaseOrders_btn.Size = new Size(302, 36);
            purchaseOrders_btn.TabIndex = 6;
            purchaseOrders_btn.Text = "Purchase Orders";
            purchaseOrders_btn.TextAlign = ContentAlignment.MiddleLeft;
            purchaseOrders_btn.UseVisualStyleBackColor = true;
            // 
            // salesReturns_btn
            // 
            salesReturns_btn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            salesReturns_btn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            salesReturns_btn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            salesReturns_btn.Location = new Point(12, 267);
            salesReturns_btn.Name = "salesReturns_btn";
            salesReturns_btn.Size = new Size(302, 36);
            salesReturns_btn.TabIndex = 5;
            salesReturns_btn.Text = "Sales Returns";
            salesReturns_btn.TextAlign = ContentAlignment.MiddleLeft;
            salesReturns_btn.UseVisualStyleBackColor = true;
            // 
            // salesOrders_btn
            // 
            salesOrders_btn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            salesOrders_btn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            salesOrders_btn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            salesOrders_btn.Location = new Point(12, 225);
            salesOrders_btn.Name = "salesOrders_btn";
            salesOrders_btn.Size = new Size(302, 36);
            salesOrders_btn.TabIndex = 4;
            salesOrders_btn.Text = "Sales Orders";
            salesOrders_btn.TextAlign = ContentAlignment.MiddleLeft;
            salesOrders_btn.UseVisualStyleBackColor = true;
            // 
            // itemGrp_btn
            // 
            itemGrp_btn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            itemGrp_btn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            itemGrp_btn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            itemGrp_btn.Location = new Point(12, 158);
            itemGrp_btn.Name = "itemGrp_btn";
            itemGrp_btn.Size = new Size(302, 36);
            itemGrp_btn.TabIndex = 3;
            itemGrp_btn.Text = "Item Groups";
            itemGrp_btn.TextAlign = ContentAlignment.MiddleLeft;
            itemGrp_btn.UseVisualStyleBackColor = true;
            // 
            // inventory_btn
            // 
            inventory_btn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            inventory_btn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            inventory_btn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            inventory_btn.Location = new Point(12, 116);
            inventory_btn.Name = "inventory_btn";
            inventory_btn.Size = new Size(302, 36);
            inventory_btn.TabIndex = 2;
            inventory_btn.Text = "Inventory";
            inventory_btn.TextAlign = ContentAlignment.MiddleLeft;
            inventory_btn.UseVisualStyleBackColor = true;
            // 
            // home_btn
            // 
            home_btn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            home_btn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            home_btn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            home_btn.Location = new Point(12, 55);
            home_btn.Name = "home_btn";
            home_btn.Size = new Size(302, 36);
            home_btn.TabIndex = 1;
            home_btn.Text = "Home";
            home_btn.TextAlign = ContentAlignment.MiddleLeft;
            home_btn.UseVisualStyleBackColor = true;
            home_btn.Click += home_btn_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(302, 30);
            label1.TabIndex = 0;
            label1.Text = "INVENTORY MANAGEMENT";
            // 
            // profile_pictureBox
            // 
            profile_pictureBox.BorderStyle = BorderStyle.FixedSingle;
            profile_pictureBox.Image = (Image)resources.GetObject("profile_pictureBox.Image");
            profile_pictureBox.Location = new Point(1193, 12);
            profile_pictureBox.Margin = new Padding(15, 3, 3, 3);
            profile_pictureBox.Name = "profile_pictureBox";
            profile_pictureBox.Size = new Size(50, 50);
            profile_pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            profile_pictureBox.TabIndex = 1;
            profile_pictureBox.TabStop = false;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.FromArgb(43, 42, 76);
            splitContainer1.Panel1.Controls.Add(reports_btn);
            splitContainer1.Panel1.Controls.Add(purchaseOrders_btn);
            splitContainer1.Panel1.Controls.Add(salesReturns_btn);
            splitContainer1.Panel1.Controls.Add(salesOrders_btn);
            splitContainer1.Panel1.Controls.Add(itemGrp_btn);
            splitContainer1.Panel1.Controls.Add(inventory_btn);
            splitContainer1.Panel1.Controls.Add(home_btn);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(flowLayoutPanel4);
            splitContainer1.Panel2.Controls.Add(purchaseOrders_dataGridView);
            splitContainer1.Panel2.Controls.Add(comboBox2);
            splitContainer1.Panel2.Controls.Add(notify_pictureBox);
            splitContainer1.Panel2.Controls.Add(orgName_label);
            splitContainer1.Panel2.Controls.Add(profile_pictureBox);
            splitContainer1.Panel2.Controls.Add(search_textBox);
            splitContainer1.Panel2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            splitContainer1.Size = new Size(1582, 953);
            splitContainer1.SplitterDistance = 323;
            splitContainer1.TabIndex = 5;
            // 
            // reports_btn
            // 
            reports_btn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            reports_btn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            reports_btn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            reports_btn.Location = new Point(12, 380);
            reports_btn.Name = "reports_btn";
            reports_btn.Size = new Size(302, 36);
            reports_btn.TabIndex = 13;
            reports_btn.Text = "Reports";
            reports_btn.TextAlign = ContentAlignment.MiddleLeft;
            reports_btn.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Controls.Add(button3);
            flowLayoutPanel4.Location = new Point(12, 168);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Padding = new Padding(5);
            flowLayoutPanel4.Size = new Size(151, 177);
            flowLayoutPanel4.TabIndex = 10;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button3.Location = new Point(8, 8);
            button3.Margin = new Padding(3, 3, 3, 18);
            button3.Name = "button3";
            button3.Size = new Size(138, 80);
            button3.TabIndex = 0;
            button3.Text = "Review Requests";
            button3.UseVisualStyleBackColor = true;
            // 
            // PurchaseID
            // 
            PurchaseID.HeaderText = "ID";
            PurchaseID.MinimumWidth = 6;
            PurchaseID.Name = "PurchaseID";
            PurchaseID.ReadOnly = true;
            PurchaseID.Width = 50;
            // 
            // item
            // 
            item.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            item.HeaderText = "Item";
            item.MinimumWidth = 200;
            item.Name = "item";
            item.ReadOnly = true;
            // 
            // Brand
            // 
            Brand.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Brand.HeaderText = "Brand";
            Brand.MinimumWidth = 250;
            Brand.Name = "Brand";
            Brand.ReadOnly = true;
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Quantity";
            Quantity.MinimumWidth = 90;
            Quantity.Name = "Quantity";
            Quantity.ReadOnly = true;
            Quantity.Width = 90;
            // 
            // TotalPrice
            // 
            TotalPrice.HeaderText = "Total Price";
            TotalPrice.MinimumWidth = 90;
            TotalPrice.Name = "TotalPrice";
            TotalPrice.ReadOnly = true;
            TotalPrice.Width = 90;
            // 
            // SupplierName
            // 
            SupplierName.HeaderText = "Supplier";
            SupplierName.MinimumWidth = 6;
            SupplierName.Name = "SupplierName";
            SupplierName.ReadOnly = true;
            SupplierName.Width = 125;
            // 
            // OrderStatus
            // 
            OrderStatus.HeaderText = "Order Status";
            OrderStatus.MinimumWidth = 90;
            OrderStatus.Name = "OrderStatus";
            OrderStatus.ReadOnly = true;
            OrderStatus.Width = 125;
            // 
            // PurchaseOrders_ADMIN
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(238, 226, 222);
            ClientSize = new Size(1582, 953);
            Controls.Add(splitContainer1);
            ForeColor = Color.FromArgb(43, 42, 76);
            Name = "PurchaseOrders_ADMIN";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PurchaseOrders_ADMIN";
            ((System.ComponentModel.ISupportInitialize)notify_pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)purchaseOrders_dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)profile_pictureBox).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            flowLayoutPanel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBox2;
        private PictureBox notify_pictureBox;
        private Label orgName_label;
        private TextBox search_textBox;
        private DataGridView purchaseOrders_dataGridView;
        private Button purchaseOrders_btn;
        private Button salesReturns_btn;
        private Button salesOrders_btn;
        private Button itemGrp_btn;
        private Button inventory_btn;
        private Button home_btn;
        private Label label1;
        private PictureBox profile_pictureBox;
        private SplitContainer splitContainer1;
        private Button reports_btn;
        private FlowLayoutPanel flowLayoutPanel4;
        private Button button3;
        private DataGridViewTextBoxColumn PurchaseID;
        private DataGridViewTextBoxColumn item;
        private DataGridViewTextBoxColumn Brand;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn TotalPrice;
        private DataGridViewTextBoxColumn SupplierName;
        private DataGridViewTextBoxColumn OrderStatus;
    }
}