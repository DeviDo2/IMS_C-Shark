namespace Dashboard_STAFF
{
    partial class CreateGroup_ADMIN
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
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(textBox1);
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(textBox2);
            flowLayoutPanel1.Controls.Add(button3);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(35, 25);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(20);
            flowLayoutPanel1.Size = new Size(515, 314);
            flowLayoutPanel1.TabIndex = 0;
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
            textBox1.TextChanged += textBox1_TextChanged;
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
            button3.Location = new Point(23, 250);
            button3.Name = "button3";
            button3.Size = new Size(231, 29);
            button3.TabIndex = 14;
            button3.Text = "SUBMIT";
            button3.UseVisualStyleBackColor = true;
            // 
            // CreateGroup_ADMIN
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 42, 76);
            ClientSize = new Size(580, 363);
            Controls.Add(flowLayoutPanel1);
            Name = "CreateGroup_ADMIN";
            Text = "CreateGroup_ADMIN";
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
    }
}