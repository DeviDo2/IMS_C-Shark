namespace Dashboard_STAFF
{
    partial class AddtoGroup_ADMIN
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
            comboBox1 = new ComboBox();
            label2 = new Label();
            comboBox2 = new ComboBox();
            button3 = new Button();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(comboBox1);
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(comboBox2);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(12, 12);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(20);
            flowLayoutPanel1.Size = new Size(459, 215);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 20);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 0;
            label1.Text = "Choose Item:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(23, 43);
            comboBox1.Margin = new Padding(3, 3, 3, 40);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(400, 28);
            comboBox1.TabIndex = 1;
            comboBox1.Text = "item name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 118);
            label2.Name = "label2";
            label2.Size = new Size(170, 20);
            label2.TabIndex = 2;
            label2.Text = "Choose Group (Brand):";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(23, 141);
            comboBox2.Margin = new Padding(3, 3, 3, 20);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(400, 28);
            comboBox2.TabIndex = 3;
            comboBox2.Text = "group name";
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button3.ForeColor = Color.FromArgb(43, 42, 76);
            button3.Location = new Point(35, 255);
            button3.Name = "button3";
            button3.Size = new Size(231, 29);
            button3.TabIndex = 15;
            button3.Text = "INSERT";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // AddtoGroup_ADMIN
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(43, 42, 76);
            ClientSize = new Size(483, 319);
            Controls.Add(button3);
            Controls.Add(flowLayoutPanel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ForeColor = Color.White;
            Name = "AddtoGroup_ADMIN";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddtoGroup_ADMIN";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private ComboBox comboBox1;
        private Label label2;
        private ComboBox comboBox2;
        private Button button3;
    }
}