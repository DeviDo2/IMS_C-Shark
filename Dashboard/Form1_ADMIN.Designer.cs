namespace Dashboard_STAFF
{
    partial class Form1_ADMIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1_ADMIN));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            percentHand_label = new Label();
            profile_pictureBox = new PictureBox();
            groupBox2 = new GroupBox();
            lowItems_dataGridView = new DataGridView();
            lowItems = new DataGridViewTextBoxColumn();
            itemAmount = new DataGridViewTextBoxColumn();
            groupBox3 = new GroupBox();
            requests_dataGridView = new DataGridView();
            percentReceived_label = new Label();
            groupBox4 = new GroupBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            topItem_tableLayoutPanel = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            topItemName_label = new Label();
            comboBox1 = new ComboBox();
            orgName_label = new Label();
            search_textBox = new TextBox();
            quantityReceived_progressBar = new ProgressBar();
            splitContainer1 = new SplitContainer();
            purchaseOrders_btn = new Button();
            salesReturns_btn = new Button();
            salesOrders_btn = new Button();
            itemGrp_btn = new Button();
            inventory_btn = new Button();
            home_btn = new Button();
            label1 = new Label();
            notify_pictureBox = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            salesAct_groupBox = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            label3 = new Label();
            label2 = new Label();
            totalShipped_label = new Label();
            totalRestocked_label = new Label();
            groupBox1 = new GroupBox();
            quantityHand_progressBar = new ProgressBar();
            label5 = new Label();
            label4 = new Label();
            reports_btn = new Button();
            requestedItem = new DataGridViewTextBoxColumn();
            StaffName = new DataGridViewTextBoxColumn();
            requestStatus = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)profile_pictureBox).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lowItems_dataGridView).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)requests_dataGridView).BeginInit();
            groupBox4.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            topItem_tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)notify_pictureBox).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            salesAct_groupBox.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // percentHand_label
            // 
            percentHand_label.AutoSize = true;
            percentHand_label.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            percentHand_label.Location = new Point(287, 65);
            percentHand_label.Name = "percentHand_label";
            percentHand_label.Size = new Size(35, 23);
            percentHand_label.TabIndex = 4;
            percentHand_label.Text = "0%";
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
            // groupBox2
            // 
            groupBox2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox2.Controls.Add(lowItems_dataGridView);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox2.Location = new Point(3, 182);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(536, 269);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Items Low in Stock";
            // 
            // lowItems_dataGridView
            // 
            lowItems_dataGridView.AllowUserToAddRows = false;
            lowItems_dataGridView.AllowUserToDeleteRows = false;
            lowItems_dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lowItems_dataGridView.BackgroundColor = Color.FromArgb(238, 226, 222);
            lowItems_dataGridView.BorderStyle = BorderStyle.None;
            lowItems_dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            lowItems_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            lowItems_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            lowItems_dataGridView.Columns.AddRange(new DataGridViewColumn[] { lowItems, itemAmount });
            lowItems_dataGridView.Location = new Point(6, 33);
            lowItems_dataGridView.Name = "lowItems_dataGridView";
            lowItems_dataGridView.ReadOnly = true;
            lowItems_dataGridView.RowHeadersVisible = false;
            lowItems_dataGridView.RowHeadersWidth = 51;
            lowItems_dataGridView.ScrollBars = ScrollBars.Horizontal;
            lowItems_dataGridView.Size = new Size(524, 230);
            lowItems_dataGridView.TabIndex = 0;
            // 
            // lowItems
            // 
            lowItems.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            lowItems.HeaderText = "Item Name";
            lowItems.MinimumWidth = 6;
            lowItems.Name = "lowItems";
            lowItems.ReadOnly = true;
            // 
            // itemAmount
            // 
            itemAmount.HeaderText = "Amount";
            itemAmount.MinimumWidth = 6;
            itemAmount.Name = "itemAmount";
            itemAmount.ReadOnly = true;
            itemAmount.Width = 125;
            // 
            // groupBox3
            // 
            groupBox3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox3.Controls.Add(requests_dataGridView);
            groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox3.Location = new Point(545, 182);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(673, 269);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Restock Requests";
            // 
            // requests_dataGridView
            // 
            requests_dataGridView.AllowUserToAddRows = false;
            requests_dataGridView.AllowUserToDeleteRows = false;
            requests_dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            requests_dataGridView.BackgroundColor = Color.FromArgb(238, 226, 222);
            requests_dataGridView.BorderStyle = BorderStyle.None;
            requests_dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            requests_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            requests_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            requests_dataGridView.Columns.AddRange(new DataGridViewColumn[] { requestedItem, StaffName, requestStatus });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(43, 42, 76);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            requests_dataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            requests_dataGridView.Location = new Point(6, 33);
            requests_dataGridView.Name = "requests_dataGridView";
            requests_dataGridView.ReadOnly = true;
            requests_dataGridView.RowHeadersVisible = false;
            requests_dataGridView.RowHeadersWidth = 51;
            requests_dataGridView.ScrollBars = ScrollBars.Horizontal;
            requests_dataGridView.Size = new Size(661, 230);
            requests_dataGridView.TabIndex = 1;
            // 
            // percentReceived_label
            // 
            percentReceived_label.AutoSize = true;
            percentReceived_label.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            percentReceived_label.Location = new Point(287, 112);
            percentReceived_label.Name = "percentReceived_label";
            percentReceived_label.Size = new Size(35, 23);
            percentReceived_label.TabIndex = 5;
            percentReceived_label.Text = "0%";
            // 
            // groupBox4
            // 
            groupBox4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox4.Controls.Add(flowLayoutPanel2);
            groupBox4.Controls.Add(comboBox1);
            groupBox4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox4.Location = new Point(3, 457);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1215, 416);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Top Selling Items";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel2.AutoScroll = true;
            flowLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel2.Controls.Add(topItem_tableLayoutPanel);
            flowLayoutPanel2.Location = new Point(179, 45);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(2045, 365);
            flowLayoutPanel2.TabIndex = 1;
            flowLayoutPanel2.WrapContents = false;
            // 
            // topItem_tableLayoutPanel
            // 
            topItem_tableLayoutPanel.ColumnCount = 1;
            topItem_tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            topItem_tableLayoutPanel.Controls.Add(pictureBox1, 0, 0);
            topItem_tableLayoutPanel.Controls.Add(topItemName_label, 0, 1);
            topItem_tableLayoutPanel.Location = new Point(3, 3);
            topItem_tableLayoutPanel.Name = "topItem_tableLayoutPanel";
            topItem_tableLayoutPanel.RowCount = 2;
            topItem_tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 81.76796F));
            topItem_tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 18.2320442F));
            topItem_tableLayoutPanel.Size = new Size(298, 324);
            topItem_tableLayoutPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(292, 258);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // topItemName_label
            // 
            topItemName_label.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            topItemName_label.AutoSize = true;
            topItemName_label.Location = new Point(3, 264);
            topItemName_label.Name = "topItemName_label";
            topItemName_label.Size = new Size(292, 60);
            topItemName_label.TabIndex = 1;
            topItemName_label.Text = "Item Name";
            topItemName_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 9F);
            comboBox1.ForeColor = Color.FromArgb(43, 42, 76);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(6, 45);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 0;
            comboBox1.Text = "This Month";
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
            search_textBox.ForeColor = Color.FromArgb(43, 42, 76);
            search_textBox.Location = new Point(12, 12);
            search_textBox.Name = "search_textBox";
            search_textBox.PlaceholderText = "Search";
            search_textBox.Size = new Size(318, 27);
            search_textBox.TabIndex = 0;
            // 
            // quantityReceived_progressBar
            // 
            quantityReceived_progressBar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            quantityReceived_progressBar.Location = new Point(328, 112);
            quantityReceived_progressBar.Name = "quantityReceived_progressBar";
            quantityReceived_progressBar.Size = new Size(1176, 23);
            quantityReceived_progressBar.TabIndex = 3;
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
            splitContainer1.Panel2.Controls.Add(notify_pictureBox);
            splitContainer1.Panel2.Controls.Add(flowLayoutPanel1);
            splitContainer1.Panel2.Controls.Add(orgName_label);
            splitContainer1.Panel2.Controls.Add(profile_pictureBox);
            splitContainer1.Panel2.Controls.Add(search_textBox);
            splitContainer1.Size = new Size(1582, 953);
            splitContainer1.SplitterDistance = 323;
            splitContainer1.TabIndex = 1;
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
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(salesAct_groupBox);
            flowLayoutPanel1.Controls.Add(groupBox1);
            flowLayoutPanel1.Controls.Add(groupBox2);
            flowLayoutPanel1.Controls.Add(groupBox3);
            flowLayoutPanel1.Controls.Add(groupBox4);
            flowLayoutPanel1.Location = new Point(12, 68);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1231, 873);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // salesAct_groupBox
            // 
            salesAct_groupBox.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            salesAct_groupBox.Controls.Add(tableLayoutPanel1);
            salesAct_groupBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            salesAct_groupBox.Location = new Point(3, 3);
            salesAct_groupBox.Name = "salesAct_groupBox";
            salesAct_groupBox.Size = new Size(351, 173);
            salesAct_groupBox.TabIndex = 0;
            salesAct_groupBox.TabStop = false;
            salesAct_groupBox.Text = "Sales Activity";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label3, 1, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(totalShipped_label, 0, 0);
            tableLayoutPanel1.Controls.Add(totalRestocked_label, 1, 0);
            tableLayoutPanel1.Location = new Point(6, 33);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(339, 134);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(173, 68);
            label3.Name = "label3";
            label3.Size = new Size(161, 64);
            label3.TabIndex = 3;
            label3.Text = "To be Restocked";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(5, 68);
            label2.Name = "label2";
            label2.Size = new Size(160, 64);
            label2.TabIndex = 2;
            label2.Text = "To be Shipped";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // totalShipped_label
            // 
            totalShipped_label.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            totalShipped_label.AutoSize = true;
            totalShipped_label.Location = new Point(5, 2);
            totalShipped_label.Name = "totalShipped_label";
            totalShipped_label.Size = new Size(160, 64);
            totalShipped_label.TabIndex = 0;
            totalShipped_label.Text = "000";
            totalShipped_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // totalRestocked_label
            // 
            totalRestocked_label.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            totalRestocked_label.AutoSize = true;
            totalRestocked_label.Location = new Point(173, 2);
            totalRestocked_label.Name = "totalRestocked_label";
            totalRestocked_label.Size = new Size(161, 64);
            totalRestocked_label.TabIndex = 1;
            totalRestocked_label.Text = "000";
            totalRestocked_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox1.Controls.Add(percentReceived_label);
            groupBox1.Controls.Add(percentHand_label);
            groupBox1.Controls.Add(quantityReceived_progressBar);
            groupBox1.Controls.Add(quantityHand_progressBar);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox1.Location = new Point(360, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(858, 173);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Inventory Summary";
            // 
            // quantityHand_progressBar
            // 
            quantityHand_progressBar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            quantityHand_progressBar.Location = new Point(328, 65);
            quantityHand_progressBar.Name = "quantityHand_progressBar";
            quantityHand_progressBar.Size = new Size(1176, 23);
            quantityHand_progressBar.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label5.Location = new Point(16, 112);
            label5.Name = "label5";
            label5.Size = new Size(203, 23);
            label5.TabIndex = 1;
            label5.Text = "Quantity to be Received";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.Location = new Point(16, 65);
            label4.Name = "label4";
            label4.Size = new Size(148, 23);
            label4.TabIndex = 0;
            label4.Text = "Quantity in Hand";
            // 
            // reports_btn
            // 
            reports_btn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            reports_btn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            reports_btn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            reports_btn.Location = new Point(12, 379);
            reports_btn.Name = "reports_btn";
            reports_btn.Size = new Size(302, 36);
            reports_btn.TabIndex = 8;
            reports_btn.Text = "Reports";
            reports_btn.TextAlign = ContentAlignment.MiddleLeft;
            reports_btn.UseVisualStyleBackColor = true;
            // 
            // requestedItem
            // 
            requestedItem.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            requestedItem.HeaderText = "Item Name";
            requestedItem.MinimumWidth = 6;
            requestedItem.Name = "requestedItem";
            requestedItem.ReadOnly = true;
            // 
            // StaffName
            // 
            StaffName.HeaderText = "Staff Name";
            StaffName.MinimumWidth = 6;
            StaffName.Name = "StaffName";
            StaffName.ReadOnly = true;
            StaffName.Width = 230;
            // 
            // requestStatus
            // 
            requestStatus.HeaderText = "Status";
            requestStatus.MinimumWidth = 6;
            requestStatus.Name = "requestStatus";
            requestStatus.ReadOnly = true;
            // 
            // Form1_ADMIN
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(238, 226, 222);
            ClientSize = new Size(1582, 953);
            Controls.Add(splitContainer1);
            ForeColor = Color.FromArgb(43, 42, 76);
            Name = "Form1_ADMIN";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1_ADMIN";
            ((System.ComponentModel.ISupportInitialize)profile_pictureBox).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)lowItems_dataGridView).EndInit();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)requests_dataGridView).EndInit();
            groupBox4.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            topItem_tableLayoutPanel.ResumeLayout(false);
            topItem_tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)notify_pictureBox).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            salesAct_groupBox.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label percentHand_label;
        private PictureBox profile_pictureBox;
        private GroupBox groupBox2;
        private DataGridView lowItems_dataGridView;
        private DataGridViewTextBoxColumn lowItems;
        private DataGridViewTextBoxColumn itemAmount;
        private GroupBox groupBox3;
        private DataGridView requests_dataGridView;
        private Label percentReceived_label;
        private GroupBox groupBox4;
        private FlowLayoutPanel flowLayoutPanel2;
        private TableLayoutPanel topItem_tableLayoutPanel;
        private PictureBox pictureBox1;
        private Label topItemName_label;
        private ComboBox comboBox1;
        private Label orgName_label;
        private TextBox search_textBox;
        private ProgressBar quantityReceived_progressBar;
        private SplitContainer splitContainer1;
        private Button purchaseOrders_btn;
        private Button salesReturns_btn;
        private Button salesOrders_btn;
        private Button itemGrp_btn;
        private Button inventory_btn;
        private Button home_btn;
        private Label label1;
        private PictureBox notify_pictureBox;
        private FlowLayoutPanel flowLayoutPanel1;
        private GroupBox salesAct_groupBox;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label3;
        private Label label2;
        private Label totalShipped_label;
        private Label totalRestocked_label;
        private GroupBox groupBox1;
        private ProgressBar quantityHand_progressBar;
        private Label label5;
        private Label label4;
        private Button reports_btn;
        private DataGridViewTextBoxColumn requestedItem;
        private DataGridViewTextBoxColumn StaffName;
        private DataGridViewTextBoxColumn requestStatus;
    }
}