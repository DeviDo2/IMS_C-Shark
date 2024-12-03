namespace Dashboard_STAFF
{
    partial class AddOrder_ADMIN
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
            label7 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox4 = new TextBox();
            button3 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            numericUpDown2 = new NumericUpDown();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label7.Location = new Point(40, 26);
            label7.Name = "label7";
            label7.Size = new Size(222, 46);
            label7.TabIndex = 20;
            label7.Text = "NEW ORDER";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(28, 10);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 0;
            label1.Text = "Item name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(28, 81);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 2;
            label2.Text = "Brand:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(28, 152);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 4;
            label3.Text = "Quantity:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(28, 222);
            label4.Name = "label4";
            label4.Size = new Size(128, 20);
            label4.TabIndex = 6;
            label4.Text = "Receiver's Name:";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 9F);
            textBox4.Location = new Point(28, 245);
            textBox4.Margin = new Padding(3, 3, 3, 20);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(446, 27);
            textBox4.TabIndex = 7;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button3.ForeColor = Color.FromArgb(43, 42, 76);
            button3.Location = new Point(40, 465);
            button3.Name = "button3";
            button3.Size = new Size(231, 29);
            button3.TabIndex = 19;
            button3.Text = "SUBMIT";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(comboBox1);
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(comboBox2);
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(numericUpDown2);
            flowLayoutPanel1.Controls.Add(label4);
            flowLayoutPanel1.Controls.Add(textBox4);
            flowLayoutPanel1.Controls.Add(label5);
            flowLayoutPanel1.Controls.Add(dateTimePicker1);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Font = new Font("Segoe UI", 9F);
            flowLayoutPanel1.Location = new Point(12, 75);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(25, 10, 25, 3);
            flowLayoutPanel1.Size = new Size(524, 369);
            flowLayoutPanel1.TabIndex = 15;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(28, 33);
            comboBox1.Margin = new Padding(3, 3, 3, 20);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(446, 28);
            comboBox1.TabIndex = 8;
            comboBox1.Text = "item name";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(28, 104);
            comboBox2.Margin = new Padding(3, 3, 3, 20);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(446, 28);
            comboBox2.TabIndex = 9;
            comboBox2.Text = "brand name";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(28, 175);
            numericUpDown2.Margin = new Padding(3, 3, 40, 20);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(96, 27);
            numericUpDown2.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(28, 315);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 11;
            dateTimePicker1.Value = new DateTime(2024, 12, 3, 21, 38, 19, 0);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(28, 292);
            label5.Name = "label5";
            label5.Size = new Size(108, 20);
            label5.TabIndex = 12;
            label5.Text = "Delivery Date:";
            // 
            // AddOrder_ADMIN
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(43, 42, 76);
            ClientSize = new Size(553, 532);
            Controls.Add(label7);
            Controls.Add(button3);
            Controls.Add(flowLayoutPanel1);
            Font = new Font("Segoe UI", 10F);
            ForeColor = Color.White;
            Name = "AddOrder_ADMIN";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddOrder_ADMIN";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox4;
        private Button button3;
        private FlowLayoutPanel flowLayoutPanel1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private NumericUpDown numericUpDown2;
        private Label label5;
        private DateTimePicker dateTimePicker1;
    }
}