namespace MoMo
{
    partial class PayBillDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PayBillDetail));
            panel2 = new Panel();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            label13 = new Label();
            label5 = new Label();
            panel4 = new Panel();
            textBox1 = new TextBox();
            label2 = new Label();
            panel3 = new Panel();
            label4 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            panel10 = new Panel();
            pictureBox5 = new PictureBox();
            panel5 = new Panel();
            label14 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label6 = new Label();
            label7 = new Label();
            label15 = new Label();
            panel6 = new Panel();
            textBox2 = new TextBox();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(219, 45, 139);
            panel2.Controls.Add(iconButton2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(iconButton1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(399, 75);
            panel2.TabIndex = 3;
            // 
            // iconButton2
            // 
            iconButton2.BackColor = Color.FromArgb(219, 45, 139);
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            iconButton2.IconColor = Color.White;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.Location = new Point(344, 6);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(65, 62);
            iconButton2.TabIndex = 2;
            iconButton2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(128, 11);
            label1.Name = "label1";
            label1.Size = new Size(154, 46);
            label1.TabIndex = 1;
            label1.Text = "Hoá đơn";
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.FromArgb(219, 45, 139);
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(6, 6);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(55, 62);
            iconButton1.TabIndex = 0;
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(label15);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(6, 180);
            panel1.Name = "panel1";
            panel1.Size = new Size(385, 241);
            panel1.TabIndex = 4;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = Color.Red;
            label13.Location = new Point(21, 128);
            label13.Name = "label13";
            label13.Size = new Size(58, 20);
            label13.TabIndex = 6;
            label13.Text = "label13";
            label13.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 53);
            label5.Name = "label5";
            label5.Size = new Size(109, 20);
            label5.TabIndex = 1;
            label5.Text = "Mã khách hàng";
            // 
            // panel4
            // 
            panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panel4.BackgroundImageLayout = ImageLayout.Stretch;
            panel4.Controls.Add(textBox1);
            panel4.Location = new Point(8, 64);
            panel4.Name = "panel4";
            panel4.Size = new Size(367, 61);
            panel4.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(13, 14);
            textBox1.MaxLength = 12;
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Nhập mã khách hàng";
            textBox1.Size = new Size(337, 34);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 10);
            label2.Name = "label2";
            label2.Size = new Size(219, 28);
            label2.TabIndex = 0;
            label2.Text = "Thông tin khách hàng";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(224, 224, 224);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(pictureBox1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 75);
            panel3.Name = "panel3";
            panel3.Size = new Size(399, 99);
            panel3.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(118, 62);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 2;
            label4.Text = "label4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(116, 15);
            label3.Name = "label3";
            label3.Size = new Size(66, 28);
            label3.TabIndex = 1;
            label3.Text = "label3";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(9, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(84, 77);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel10
            // 
            panel10.BackColor = Color.White;
            panel10.Controls.Add(pictureBox5);
            panel10.Dock = DockStyle.Bottom;
            panel10.Location = new Point(0, 765);
            panel10.Name = "panel10";
            panel10.Size = new Size(399, 82);
            panel10.TabIndex = 7;
            // 
            // pictureBox5
            // 
            pictureBox5.Enabled = false;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(12, 8);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(379, 69);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 5;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Transparent;
            panel5.BackgroundImage = (Image)resources.GetObject("panel5.BackgroundImage");
            panel5.BackgroundImageLayout = ImageLayout.Stretch;
            panel5.Controls.Add(label14);
            panel5.Controls.Add(label12);
            panel5.Controls.Add(label11);
            panel5.Controls.Add(label10);
            panel5.Controls.Add(label9);
            panel5.Controls.Add(label8);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(label7);
            panel5.Location = new Point(7, 432);
            panel5.Name = "panel5";
            panel5.Size = new Size(385, 193);
            panel5.TabIndex = 8;
            panel5.Visible = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(157, 143);
            label14.Name = "label14";
            label14.Size = new Size(40, 20);
            label14.TabIndex = 7;
            label14.Text = "VND";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(91, 141);
            label12.Name = "label12";
            label12.Size = new Size(62, 23);
            label12.TabIndex = 6;
            label12.Text = "label12";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(76, 97);
            label11.Name = "label11";
            label11.Size = new Size(60, 23);
            label11.TabIndex = 5;
            label11.Text = "label11";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(129, 55);
            label10.Name = "label10";
            label10.Size = new Size(62, 23);
            label10.TabIndex = 4;
            label10.Text = "label10";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(11, 143);
            label9.Name = "label9";
            label9.Size = new Size(75, 20);
            label9.TabIndex = 3;
            label9.Text = "Tổng tiền:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 99);
            label8.Name = "label8";
            label8.Size = new Size(58, 20);
            label8.TabIndex = 2;
            label8.Text = "Địa chỉ:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 56);
            label6.Name = "label6";
            label6.Size = new Size(114, 20);
            label6.TabIndex = 1;
            label6.Text = "Tên khách hàng:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(12, 10);
            label7.Name = "label7";
            label7.Size = new Size(189, 28);
            label7.TabIndex = 0;
            label7.Text = "Thông tin hoá đơn";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(33, 152);
            label15.Name = "label15";
            label15.Size = new Size(76, 20);
            label15.TabIndex = 7;
            label15.Text = "Mã ưu đãi";
            // 
            // panel6
            // 
            panel6.BackgroundImage = (Image)resources.GetObject("panel6.BackgroundImage");
            panel6.BackgroundImageLayout = ImageLayout.Stretch;
            panel6.Controls.Add(textBox2);
            panel6.Location = new Point(9, 163);
            panel6.Name = "panel6";
            panel6.Size = new Size(367, 61);
            panel6.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(13, 14);
            textBox2.MaxLength = 12;
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Nhập mã ưu đãi";
            textBox2.Size = new Size(337, 34);
            textBox2.TabIndex = 0;
            // 
            // PayBillDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(399, 847);
            Controls.Add(panel5);
            Controls.Add(panel10);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PayBillDetail";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PayBillDetail";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private FontAwesome.Sharp.IconButton iconButton2;
        private Label label1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Panel panel1;
        private Label label5;
        private Panel panel4;
        private TextBox textBox1;
        private Label label2;
        private Panel panel3;
        private Label label4;
        private Label label3;
        private PictureBox pictureBox1;
        private Panel panel10;
        private PictureBox pictureBox5;
        private Panel panel5;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label6;
        private Label label7;
        private Label label11;
        private Label label13;
        private Label label12;
        private Label label14;
        private Label label15;
        private Panel panel6;
        private TextBox textBox2;
    }
}