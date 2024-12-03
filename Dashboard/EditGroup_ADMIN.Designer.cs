namespace Dashboard_STAFF
{
    partial class EditGroup_ADMIN
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            button3 = new Button();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label4 = new Label();
            comboBox2 = new ComboBox();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(textBox1);
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(textBox2);
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(comboBox1);
            flowLayoutPanel1.Controls.Add(label4);
            flowLayoutPanel1.Controls.Add(comboBox2);
            flowLayoutPanel1.Controls.Add(button3);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(33, 24);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(20);
            flowLayoutPanel1.Size = new Size(515, 522);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(23, 20);
            label1.Name = "label1";
            label1.Size = new Size(161, 20);
            label1.TabIndex = 2;
            label1.Text = "Group Name (Brand):";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 9F);
            textBox1.Location = new Point(23, 43);
            textBox1.Margin = new Padding(3, 3, 3, 20);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(233, 27);
            textBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(23, 90);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 4;
            label2.Text = "Description:";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 9F);
            textBox2.Location = new Point(23, 113);
            textBox2.Margin = new Padding(3, 3, 3, 20);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(466, 114);
            textBox2.TabIndex = 5;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button3.ForeColor = Color.FromArgb(43, 42, 76);
            button3.Location = new Point(23, 412);
            button3.Name = "button3";
            button3.Size = new Size(231, 29);
            button3.TabIndex = 14;
            button3.Text = "SUBMIT";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(23, 247);
            label3.Name = "label3";
            label3.Size = new Size(101, 20);
            label3.TabIndex = 6;
            label3.Text = "Choose Item:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(23, 270);
            comboBox1.Margin = new Padding(3, 3, 3, 40);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(400, 28);
            comboBox1.TabIndex = 7;
            comboBox1.Text = "item name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(23, 338);
            label4.Name = "label4";
            label4.Size = new Size(170, 20);
            label4.TabIndex = 8;
            label4.Text = "Choose Group (Brand):";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(23, 361);
            comboBox2.Margin = new Padding(3, 3, 3, 20);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(400, 28);
            comboBox2.TabIndex = 9;
            comboBox2.Text = "group name";
            // 
            // EditGroup_ADMIN
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(43, 42, 76);
            ClientSize = new Size(580, 577);
            Controls.Add(flowLayoutPanel1);
            ForeColor = Color.FromArgb(43, 42, 76);
            Name = "EditGroup_ADMIN";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditGroup_ADMIN";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Button button3;
        private Label label3;
        private ComboBox comboBox1;
        private Label label4;
        private ComboBox comboBox2;
    }
}