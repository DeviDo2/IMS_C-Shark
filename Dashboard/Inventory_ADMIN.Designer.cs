namespace Dashboard_STAFF
{
    partial class Inventory_ADMIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventory_ADMIN));
            StockStatus = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            NumItem = new DataGridViewTextBoxColumn();
            Brand = new DataGridViewTextBoxColumn();
            item = new DataGridViewTextBoxColumn();
            Type = new DataGridViewTextBoxColumn();
            SerialNo = new DataGridViewTextBoxColumn();
            inventory_dataGridView = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            flowLayoutPanel3 = new FlowLayoutPanel();
            label2 = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            orgName_label = new Label();
            profile_pictureBox = new PictureBox();
            search_textBox = new TextBox();
            splitContainer1 = new SplitContainer();
            reports_btn = new Button();
            purchaseOrders_btn = new Button();
            salesReturns_btn = new Button();
            salesOrders_btn = new Button();
            itemGrp_btn = new Button();
            inventory_btn = new Button();
            home_btn = new Button();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            notify_pictureBox = new PictureBox();
            flowLayoutPanel4 = new FlowLayoutPanel();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)inventory_dataGridView).BeginInit();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)profile_pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)notify_pictureBox).BeginInit();
            flowLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // StockStatus
            // 
            StockStatus.HeaderText = "Stock Status";
            StockStatus.MinimumWidth = 6;
            StockStatus.Name = "StockStatus";
            StockStatus.ReadOnly = true;
            StockStatus.Width = 125;
            // 
            // Price
            // 
            Price.HeaderText = "Price";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            Price.ReadOnly = true;
            Price.Width = 125;
            // 
            // NumItem
            // 
            NumItem.HeaderText = "No. items";
            NumItem.MinimumWidth = 6;
            NumItem.Name = "NumItem";
            NumItem.ReadOnly = true;
            NumItem.Width = 125;
            // 
            // Brand
            // 
            Brand.HeaderText = "Brand";
            Brand.MinimumWidth = 6;
            Brand.Name = "Brand";
            Brand.ReadOnly = true;
            Brand.Width = 125;
            // 
            // item
            // 
            item.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            item.HeaderText = "Item Name";
            item.MinimumWidth = 6;
            item.Name = "item";
            item.ReadOnly = true;
            // 
            // Type
            // 
            Type.HeaderText = "Type";
            Type.MinimumWidth = 6;
            Type.Name = "Type";
            Type.ReadOnly = true;
            Type.Width = 125;
            // 
            // SerialNo
            // 
            SerialNo.HeaderText = "Serial No.";
            SerialNo.MinimumWidth = 6;
            SerialNo.Name = "SerialNo";
            SerialNo.ReadOnly = true;
            SerialNo.Width = 125;
            // 
            // inventory_dataGridView
            // 
            inventory_dataGridView.AllowUserToAddRows = false;
            inventory_dataGridView.AllowUserToDeleteRows = false;
            inventory_dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            inventory_dataGridView.BackgroundColor = Color.FromArgb(238, 226, 222);
            inventory_dataGridView.BorderStyle = BorderStyle.None;
            inventory_dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            inventory_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            inventory_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            inventory_dataGridView.Columns.AddRange(new DataGridViewColumn[] { SerialNo, Type, item, Brand, NumItem, Price, StockStatus });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(43, 42, 76);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            inventory_dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            inventory_dataGridView.Location = new Point(209, 241);
            inventory_dataGridView.Name = "inventory_dataGridView";
            inventory_dataGridView.ReadOnly = true;
            inventory_dataGridView.RowHeadersVisible = false;
            inventory_dataGridView.RowHeadersWidth = 51;
            inventory_dataGridView.ScrollBars = ScrollBars.Horizontal;
            inventory_dataGridView.Size = new Size(1034, 700);
            inventory_dataGridView.TabIndex = 8;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button1.Location = new Point(3, 10);
            button1.Margin = new Padding(3, 10, 40, 3);
            button1.Name = "button1";
            button1.Size = new Size(148, 61);
            button1.TabIndex = 0;
            button1.Text = "Export as PDF";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button2.Location = new Point(194, 10);
            button2.Margin = new Padding(3, 10, 3, 3);
            button2.Name = "button2";
            button2.Size = new Size(148, 61);
            button2.TabIndex = 1;
            button2.Text = "Export as CSV";
            button2.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel3.Controls.Add(button1);
            flowLayoutPanel3.Controls.Add(button2);
            flowLayoutPanel3.Location = new Point(840, 149);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(403, 86);
            flowLayoutPanel3.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(12, 118);
            label2.Name = "label2";
            label2.Size = new Size(114, 28);
            label2.TabIndex = 0;
            label2.Text = "SUMMARY";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(label3);
            flowLayoutPanel2.Controls.Add(label4);
            flowLayoutPanel2.Controls.Add(label5);
            flowLayoutPanel2.Controls.Add(label6);
            flowLayoutPanel2.Controls.Add(label7);
            flowLayoutPanel2.Controls.Add(label8);
            flowLayoutPanel2.Location = new Point(15, 149);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Padding = new Padding(0, 20, 0, 0);
            flowLayoutPanel2.Size = new Size(800, 86);
            flowLayoutPanel2.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 20);
            label3.Margin = new Padding(20, 0, 10, 0);
            label3.Name = "label3";
            label3.Size = new Size(122, 28);
            label3.TabIndex = 0;
            label3.Text = "Total items:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(152, 20);
            label4.Margin = new Padding(0, 0, 50, 0);
            label4.Name = "label4";
            label4.Size = new Size(24, 28);
            label4.TabIndex = 1;
            label4.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(246, 20);
            label5.Margin = new Padding(20, 0, 10, 0);
            label5.Name = "label5";
            label5.Size = new Size(135, 28);
            label5.TabIndex = 2;
            label5.Text = "Out of stock:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(391, 20);
            label6.Margin = new Padding(0, 0, 50, 0);
            label6.Name = "label6";
            label6.Size = new Size(24, 28);
            label6.TabIndex = 3;
            label6.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(485, 20);
            label7.Margin = new Padding(20, 0, 10, 0);
            label7.Name = "label7";
            label7.Size = new Size(112, 28);
            label7.TabIndex = 4;
            label7.Text = "Low stock:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(607, 20);
            label8.Margin = new Padding(0, 0, 50, 0);
            label8.Name = "label8";
            label8.Size = new Size(24, 28);
            label8.TabIndex = 5;
            label8.Text = "0";
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
            splitContainer1.Panel2.Controls.Add(inventory_dataGridView);
            splitContainer1.Panel2.Controls.Add(flowLayoutPanel3);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Panel2.Controls.Add(flowLayoutPanel2);
            splitContainer1.Panel2.Controls.Add(flowLayoutPanel1);
            splitContainer1.Panel2.Controls.Add(notify_pictureBox);
            splitContainer1.Panel2.Controls.Add(orgName_label);
            splitContainer1.Panel2.Controls.Add(profile_pictureBox);
            splitContainer1.Panel2.Controls.Add(search_textBox);
            splitContainer1.Panel2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            splitContainer1.Size = new Size(1582, 953);
            splitContainer1.SplitterDistance = 323;
            splitContainer1.TabIndex = 2;
            // 
            // reports_btn
            // 
            reports_btn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            reports_btn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            reports_btn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            reports_btn.Location = new Point(12, 377);
            reports_btn.Name = "reports_btn";
            reports_btn.Size = new Size(302, 36);
            reports_btn.TabIndex = 9;
            reports_btn.Text = "Reports";
            reports_btn.TextAlign = ContentAlignment.MiddleLeft;
            reports_btn.UseVisualStyleBackColor = true;
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
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(comboBox1);
            flowLayoutPanel1.Controls.Add(comboBox2);
            flowLayoutPanel1.Location = new Point(12, 68);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1231, 34);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            comboBox1.ForeColor = Color.FromArgb(43, 42, 76);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(3, 3);
            comboBox1.Margin = new Padding(3, 3, 40, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 0;
            comboBox1.Text = "SORT";
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            comboBox2.ForeColor = Color.FromArgb(43, 42, 76);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(197, 3);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 1;
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
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Controls.Add(button3);
            flowLayoutPanel4.Controls.Add(button4);
            flowLayoutPanel4.Controls.Add(button5);
            flowLayoutPanel4.Location = new Point(12, 250);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Padding = new Padding(20);
            flowLayoutPanel4.Size = new Size(191, 315);
            flowLayoutPanel4.TabIndex = 9;
            // 
            // button3
            // 
            button3.Location = new Point(23, 23);
            button3.Margin = new Padding(3, 3, 3, 18);
            button3.Name = "button3";
            button3.Size = new Size(142, 50);
            button3.TabIndex = 0;
            button3.Text = "Add Item";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(23, 94);
            button4.Margin = new Padding(3, 3, 3, 18);
            button4.Name = "button4";
            button4.Size = new Size(142, 50);
            button4.TabIndex = 1;
            button4.Text = " Edit Item";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(23, 165);
            button5.Margin = new Padding(3, 3, 3, 18);
            button5.Name = "button5";
            button5.Size = new Size(142, 50);
            button5.TabIndex = 2;
            button5.Text = "Delete Item";
            button5.UseVisualStyleBackColor = true;
            // 
            // Inventory_ADMIN
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(238, 226, 222);
            ClientSize = new Size(1582, 953);
            Controls.Add(splitContainer1);
            ForeColor = Color.FromArgb(43, 42, 76);
            Name = "Inventory_ADMIN";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventory_ADMIN";
            ((System.ComponentModel.ISupportInitialize)inventory_dataGridView).EndInit();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)profile_pictureBox).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)notify_pictureBox).EndInit();
            flowLayoutPanel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private DataGridViewTextBoxColumn StockStatus;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn NumItem;
        private DataGridViewTextBoxColumn Brand;
        private DataGridViewTextBoxColumn item;
        private DataGridViewTextBoxColumn Type;
        private DataGridViewTextBoxColumn SerialNo;
        private DataGridView inventory_dataGridView;
        private Button button1;
        private Button button2;
        private FlowLayoutPanel flowLayoutPanel3;
        private Label label2;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label orgName_label;
        private PictureBox profile_pictureBox;
        private TextBox search_textBox;
        private SplitContainer splitContainer1;
        private Button purchaseOrders_btn;
        private Button salesReturns_btn;
        private Button salesOrders_btn;
        private Button itemGrp_btn;
        private Button inventory_btn;
        private Button home_btn;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private PictureBox notify_pictureBox;
        private Button reports_btn;
        private FlowLayoutPanel flowLayoutPanel4;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}