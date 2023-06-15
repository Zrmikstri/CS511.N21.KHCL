namespace MoMo
{
    partial class ReadQRcode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReadQRcode));
            panel2 = new Panel();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            label7 = new Label();
            pictureBox3 = new PictureBox();
            label5 = new Label();
            label4 = new Label();
            panel3 = new Panel();
            textBox2 = new TextBox();
            panel4 = new Panel();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            label6 = new Label();
            pictureBox2 = new PictureBox();
            panel5 = new Panel();
            panel10 = new Panel();
            pictureBox5 = new PictureBox();
            label15 = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel5.SuspendLayout();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Fuchsia;
            panel2.Controls.Add(iconButton2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(iconButton1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(417, 75);
            panel2.TabIndex = 9;
            // 
            // iconButton2
            // 
            iconButton2.BackColor = Color.Fuchsia;
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            iconButton2.IconColor = Color.White;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.Location = new Point(358, 8);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(65, 62);
            iconButton2.TabIndex = 2;
            iconButton2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(137, 13);
            label1.Name = "label1";
            label1.Size = new Size(150, 46);
            label1.TabIndex = 1;
            label1.Text = "Quét QR";
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.Fuchsia;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(6, 6);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(65, 62);
            iconButton1.TabIndex = 0;
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 129);
            panel1.Name = "panel1";
            panel1.Size = new Size(395, 578);
            panel1.TabIndex = 10;
            panel1.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(141, 528);
            label7.Name = "label7";
            label7.Size = new Size(159, 31);
            label7.TabIndex = 9;
            label7.Text = "Chọn QR khác";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(72, 513);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(59, 63);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(37, 433);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 6;
            label5.Text = "Lời nhắn";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 342);
            label4.Name = "label4";
            label4.Size = new Size(91, 20);
            label4.TabIndex = 5;
            label4.Text = "Số tiền nhận";
            // 
            // panel3
            // 
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Controls.Add(textBox2);
            panel3.Location = new Point(13, 445);
            panel3.Name = "panel3";
            panel3.Size = new Size(367, 61);
            panel3.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(6, 13);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Chuyển tiền cho mình nhé";
            textBox2.Size = new Size(339, 27);
            textBox2.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panel4.BackgroundImageLayout = ImageLayout.Stretch;
            panel4.Controls.Add(label15);
            panel4.Controls.Add(textBox1);
            panel4.Location = new Point(13, 354);
            panel4.Name = "panel4";
            panel4.Size = new Size(367, 61);
            panel4.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(6, 13);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "0đ";
            textBox1.Size = new Size(309, 27);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(81, 98);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(232, 232);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(141, 56);
            label3.Name = "label3";
            label3.Size = new Size(112, 25);
            label3.TabIndex = 1;
            label3.Text = "0373488359";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(92, 16);
            label2.Name = "label2";
            label2.Size = new Size(210, 31);
            label2.TabIndex = 0;
            label2.Text = "Đào Trần Anh Tuấn";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(119, 29);
            label6.Name = "label6";
            label6.Size = new Size(223, 31);
            label6.TabIndex = 8;
            label6.Text = "Chọn QR từ thư viện";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(33, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(80, 77);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Transparent;
            panel5.BackgroundImage = (Image)resources.GetObject("panel5.BackgroundImage");
            panel5.BackgroundImageLayout = ImageLayout.Stretch;
            panel5.Controls.Add(pictureBox2);
            panel5.Controls.Add(label6);
            panel5.Location = new Point(12, 450);
            panel5.Name = "panel5";
            panel5.Size = new Size(393, 83);
            panel5.TabIndex = 11;
            // 
            // panel10
            // 
            panel10.BackColor = Color.White;
            panel10.Controls.Add(pictureBox5);
            panel10.Dock = DockStyle.Bottom;
            panel10.Location = new Point(0, 812);
            panel10.Name = "panel10";
            panel10.Size = new Size(417, 82);
            panel10.TabIndex = 12;
            // 
            // pictureBox5
            // 
            pictureBox5.Enabled = false;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(8, 8);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(403, 69);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 5;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(311, 13);
            label15.Name = "label15";
            label15.Size = new Size(56, 28);
            label15.TabIndex = 3;
            label15.Text = "VND";
            // 
            // ReadQRcode
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(417, 894);
            Controls.Add(panel5);
            Controls.Add(panel10);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ReadQRcode";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ReadQRcode";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private FontAwesome.Sharp.IconButton iconButton2;
        private Label label1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Panel panel1;
        private Label label5;
        private Label label4;
        private Panel panel3;
        private TextBox textBox2;
        private Panel panel4;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label2;
        private Label label6;
        private PictureBox pictureBox2;
        private Panel panel5;
        private Panel panel10;
        private PictureBox pictureBox5;
        private Label label7;
        private PictureBox pictureBox3;
        private Label label15;
    }
}