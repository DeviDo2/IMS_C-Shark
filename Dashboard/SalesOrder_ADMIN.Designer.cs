namespace Dashboard_STAFF
{
    partial class SalesOrder_ADMIN
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesOrder_ADMIN));
            salesOrder_dataGridView = new DataGridView();
            comboBox2 = new ComboBox();
            notify_pictureBox = new PictureBox();
            purchaseOrders_btn = new Button();
            salesReturns_btn = new Button();
            salesOrders_btn = new Button();
            itemGrp_btn = new Button();
            inventory_btn = new Button();
            home_btn = new Button();
            splitContainer1 = new SplitContainer();
            label1 = new Label();
            orgName_label = new Label();
            profile_pictureBox = new PictureBox();
            search_textBox = new TextBox();
            reports_btn = new Button();
            flowLayoutPanel4 = new FlowLayoutPanel();
            button3 = new Button();
            button5 = new Button();
            SalesID = new DataGridViewTextBoxColumn();
            item = new DataGridViewTextBoxColumn();
            Brand = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Receiver = new DataGridViewTextBoxColumn();
            OrderStatus = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)salesOrder_dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)notify_pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)profile_pictureBox).BeginInit();
            flowLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // salesOrder_dataGridView
            // 
            salesOrder_dataGridView.AllowUserToAddRows = false;
            salesOrder_dataGridView.AllowUserToDeleteRows = false;
            salesOrder_dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            salesOrder_dataGridView.BackgroundColor = Color.FromArgb(238, 226, 222);
            salesOrder_dataGridView.BorderStyle = BorderStyle.None;
            salesOrder_dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            salesOrder_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            salesOrder_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            salesOrder_dataGridView.Columns.AddRange(new DataGridViewColumn[] { SalesID, item, Brand, Quantity, Price, Receiver, OrderStatus, Date });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(43, 42, 76);
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            salesOrder_dataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            salesOrder_dataGridView.Location = new Point(209, 106);
            salesOrder_dataGridView.Name = "salesOrder_dataGridView";
            salesOrder_dataGridView.ReadOnly = true;
            salesOrder_dataGridView.RowHeadersVisible = false;
            salesOrder_dataGridView.RowHeadersWidth = 51;
            salesOrder_dataGridView.ScrollBars = ScrollBars.Horizontal;
            salesOrder_dataGridView.Size = new Size(1034, 835);
            salesOrder_dataGridView.TabIndex = 9;
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
            splitContainer1.Panel2.Controls.Add(salesOrder_dataGridView);
            splitContainer1.Panel2.Controls.Add(comboBox2);
            splitContainer1.Panel2.Controls.Add(notify_pictureBox);
            splitContainer1.Panel2.Controls.Add(orgName_label);
            splitContainer1.Panel2.Controls.Add(profile_pictureBox);
            splitContainer1.Panel2.Controls.Add(search_textBox);
            splitContainer1.Panel2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            splitContainer1.Size = new Size(1582, 953);
            splitContainer1.SplitterDistance = 323;
            splitContainer1.TabIndex = 3;
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
            // profile_pictureBox
            // 
            profile_pictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
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
            // reports_btn
            // 
            reports_btn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            reports_btn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            reports_btn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            reports_btn.Location = new Point(12, 376);
            reports_btn.Name = "reports_btn";
            reports_btn.Size = new Size(302, 36);
            reports_btn.TabIndex = 11;
            reports_btn.Text = "Reports";
            reports_btn.TextAlign = ContentAlignment.MiddleLeft;
            reports_btn.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Controls.Add(button3);
            flowLayoutPanel4.Controls.Add(button5);
            flowLayoutPanel4.Location = new Point(12, 158);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Padding = new Padding(20);
            flowLayoutPanel4.Size = new Size(191, 230);
            flowLayoutPanel4.TabIndex = 10;
            // 
            // button3
            // 
            button3.Location = new Point(23, 23);
            button3.Margin = new Padding(3, 3, 3, 18);
            button3.Name = "button3";
            button3.Size = new Size(142, 50);
            button3.TabIndex = 0;
            button3.Text = "Add Order";
            button3.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(23, 94);
            button5.Margin = new Padding(3, 3, 3, 18);
            button5.Name = "button5";
            button5.Size = new Size(142, 50);
            button5.TabIndex = 2;
            button5.Text = "Delete Order";
            button5.UseVisualStyleBackColor = true;
            // 
            // SalesID
            // 
            SalesID.HeaderText = "ID";
            SalesID.MinimumWidth = 6;
            SalesID.Name = "SalesID";
            SalesID.ReadOnly = true;
            SalesID.Width = 50;
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
            Brand.HeaderText = "Brand";
            Brand.MinimumWidth = 200;
            Brand.Name = "Brand";
            Brand.ReadOnly = true;
            Brand.Width = 200;
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Quantity";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            Quantity.ReadOnly = true;
            Quantity.Width = 90;
            // 
            // Price
            // 
            Price.HeaderText = "Price";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            Price.ReadOnly = true;
            Price.Width = 70;
            // 
            // Receiver
            // 
            Receiver.HeaderText = "Receiver";
            Receiver.MinimumWidth = 6;
            Receiver.Name = "Receiver";
            Receiver.ReadOnly = true;
            Receiver.Width = 125;
            // 
            // OrderStatus
            // 
            OrderStatus.HeaderText = "Order Status";
            OrderStatus.MinimumWidth = 6;
            OrderStatus.Name = "OrderStatus";
            OrderStatus.ReadOnly = true;
            OrderStatus.Width = 125;
            // 
            // Date
            // 
            Date.HeaderText = "Date";
            Date.MinimumWidth = 6;
            Date.Name = "Date";
            Date.ReadOnly = true;
            Date.Width = 125;
            // 
            // SalesOrder_ADMIN
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(238, 226, 222);
            ClientSize = new Size(1582, 953);
            Controls.Add(splitContainer1);
            ForeColor = Color.FromArgb(43, 42, 76);
            Name = "SalesOrder_ADMIN";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SalesOrder_ADMIN";
            ((System.ComponentModel.ISupportInitialize)salesOrder_dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)notify_pictureBox).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)profile_pictureBox).EndInit();
            flowLayoutPanel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private DataGridView salesOrder_dataGridView;
        private ComboBox comboBox2;
        private PictureBox notify_pictureBox;
        private Button purchaseOrders_btn;
        private Button salesReturns_btn;
        private Button salesOrders_btn;
        private Button itemGrp_btn;
        private Button inventory_btn;
        private Button home_btn;
        private SplitContainer splitContainer1;
        private Label label1;
        private Label orgName_label;
        private PictureBox profile_pictureBox;
        private TextBox search_textBox;
        private Button reports_btn;
        private FlowLayoutPanel flowLayoutPanel4;
        private Button button3;
        private Button button5;
        private DataGridViewTextBoxColumn SalesID;
        private DataGridViewTextBoxColumn item;
        private DataGridViewTextBoxColumn Brand;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Receiver;
        private DataGridViewTextBoxColumn OrderStatus;
        private DataGridViewTextBoxColumn Date;
    }
}