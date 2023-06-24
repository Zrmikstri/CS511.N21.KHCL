namespace MoMo
{
    partial class History
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(History));
            panel5 = new Panel();
            textBox3 = new TextBox();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            panel1 = new Panel();
            radioButton6 = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel5
            // 
            panel5.BackColor = Color.Transparent;
            panel5.BackgroundImage = (Image)resources.GetObject("panel5.BackgroundImage");
            panel5.BackgroundImageLayout = ImageLayout.Stretch;
            panel5.Controls.Add(textBox3);
            panel5.Controls.Add(iconButton3);
            panel5.Location = new Point(7, 80);
            panel5.Name = "panel5";
            panel5.Size = new Size(383, 52);
            panel5.TabIndex = 14;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            textBox3.Location = new Point(53, 12);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Nhập tên, SĐT người nhận";
            textBox3.Size = new Size(290, 24);
            textBox3.TabIndex = 2;
            // 
            // iconButton3
            // 
            iconButton3.BackColor = Color.Transparent;
            iconButton3.FlatAppearance.BorderSize = 0;
            iconButton3.FlatStyle = FlatStyle.Flat;
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            iconButton3.IconColor = Color.Black;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.IconSize = 30;
            iconButton3.Location = new Point(11, 5);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(34, 40);
            iconButton3.TabIndex = 1;
            iconButton3.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.Location = new Point(0, 189);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(453, 712);
            flowLayoutPanel1.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(101, 9);
            label1.Name = "label1";
            label1.Size = new Size(277, 46);
            label1.TabIndex = 1;
            label1.Text = "Lịch sử giao dịch";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(219, 45, 139);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(453, 75);
            panel2.TabIndex = 13;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(397, 80);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 41);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(391, 120);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 17;
            label2.Text = "Bộ lọc";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(radioButton6);
            panel1.Controls.Add(radioButton5);
            panel1.Controls.Add(radioButton4);
            panel1.Controls.Add(radioButton3);
            panel1.Controls.Add(radioButton2);
            panel1.Controls.Add(radioButton1);
            panel1.Location = new Point(0, 138);
            panel1.Name = "panel1";
            panel1.Size = new Size(453, 51);
            panel1.TabIndex = 18;
            // 
            // radioButton6
            // 
            radioButton6.Appearance = Appearance.Button;
            radioButton6.AutoSize = true;
            radioButton6.BackColor = Color.White;
            radioButton6.BackgroundImageLayout = ImageLayout.Stretch;
            radioButton6.FlatAppearance.BorderColor = Color.Black;
            radioButton6.FlatStyle = FlatStyle.Flat;
            radioButton6.ForeColor = Color.Black;
            radioButton6.Location = new Point(644, 9);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(158, 32);
            radioButton6.TabIndex = 27;
            radioButton6.TabStop = true;
            radioButton6.Text = "Giao dịch ngân hàng";
            radioButton6.UseVisualStyleBackColor = false;
            radioButton6.Click += radioButton_Click;
            // 
            // radioButton5
            // 
            radioButton5.Appearance = Appearance.Button;
            radioButton5.AutoSize = true;
            radioButton5.BackColor = Color.White;
            radioButton5.BackgroundImageLayout = ImageLayout.Stretch;
            radioButton5.FlatAppearance.BorderColor = Color.Black;
            radioButton5.FlatStyle = FlatStyle.Flat;
            radioButton5.ForeColor = Color.Black;
            radioButton5.Location = new Point(470, 9);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(154, 32);
            radioButton5.TabIndex = 26;
            radioButton5.TabStop = true;
            radioButton5.Text = "Thanh toán hoá đơn";
            radioButton5.UseVisualStyleBackColor = false;
            radioButton5.Click += radioButton_Click;
            // 
            // radioButton4
            // 
            radioButton4.Appearance = Appearance.Button;
            radioButton4.AutoSize = true;
            radioButton4.BackColor = Color.White;
            radioButton4.BackgroundImageLayout = ImageLayout.Stretch;
            radioButton4.FlatAppearance.BorderColor = Color.Black;
            radioButton4.FlatStyle = FlatStyle.Flat;
            radioButton4.ForeColor = Color.Black;
            radioButton4.Location = new Point(303, 9);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(149, 32);
            radioButton4.TabIndex = 25;
            radioButton4.TabStop = true;
            radioButton4.Text = "Nạp tiền điện thoại";
            radioButton4.UseVisualStyleBackColor = false;
            radioButton4.Click += radioButton_Click;
            // 
            // radioButton3
            // 
            radioButton3.Appearance = Appearance.Button;
            radioButton3.AutoSize = true;
            radioButton3.BackColor = Color.White;
            radioButton3.BackgroundImageLayout = ImageLayout.Stretch;
            radioButton3.FlatAppearance.BorderColor = Color.Black;
            radioButton3.FlatStyle = FlatStyle.Flat;
            radioButton3.ForeColor = Color.Black;
            radioButton3.Location = new Point(197, 9);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(85, 32);
            radioButton3.TabIndex = 24;
            radioButton3.TabStop = true;
            radioButton3.Text = "Nhận tiền";
            radioButton3.UseVisualStyleBackColor = false;
            radioButton3.Click += radioButton_Click;
            // 
            // radioButton2
            // 
            radioButton2.Appearance = Appearance.Button;
            radioButton2.AutoSize = true;
            radioButton2.BackColor = Color.White;
            radioButton2.BackgroundImageLayout = ImageLayout.Stretch;
            radioButton2.FlatAppearance.BorderColor = Color.Black;
            radioButton2.FlatStyle = FlatStyle.Flat;
            radioButton2.ForeColor = Color.Black;
            radioButton2.Location = new Point(78, 9);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(98, 32);
            radioButton2.TabIndex = 23;
            radioButton2.TabStop = true;
            radioButton2.Text = "Chuyển tiền";
            radioButton2.UseVisualStyleBackColor = false;
            radioButton2.Click += radioButton_Click;
            // 
            // radioButton1
            // 
            radioButton1.Appearance = Appearance.Button;
            radioButton1.AutoSize = true;
            radioButton1.BackColor = Color.White;
            radioButton1.BackgroundImageLayout = ImageLayout.Stretch;
            radioButton1.FlatAppearance.BorderColor = Color.FromArgb(219, 45, 139);
            radioButton1.FlatStyle = FlatStyle.Flat;
            radioButton1.ForeColor = Color.FromArgb(219, 45, 139);
            radioButton1.Location = new Point(2, 9);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(61, 32);
            radioButton1.TabIndex = 22;
            radioButton1.TabStop = true;
            radioButton1.Text = "Tất cả";
            radioButton1.UseVisualStyleBackColor = false;
            radioButton1.Click += radioButton_Click;
            // 
            // History
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 901);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(panel5);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "History";
            Text = "History";
            Load += History_Load;
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel5;
        private TextBox textBox3;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label2;
        private Panel panel1;
        private RadioButton radioButton5;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private RadioButton radioButton6;
    }
}