namespace MoMo
{
    partial class PayPhoneMoney
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PayPhoneMoney));
            panel2 = new Panel();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            label111 = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            panel3 = new Panel();
            label2 = new Label();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            panel4 = new Panel();
            label4 = new Label();
            panel5 = new Panel();
            label5 = new Label();
            panel6 = new Panel();
            label6 = new Label();
            panel7 = new Panel();
            label7 = new Label();
            panel8 = new Panel();
            label8 = new Label();
            panel9 = new Panel();
            label9 = new Label();
            panel10 = new Panel();
            label10 = new Label();
            panel11 = new Panel();
            label11 = new Label();
            panel12 = new Panel();
            pictureBox5 = new PictureBox();
            panels1 = new Panel();
            label14 = new Label();
            labels1 = new Label();
            panel14 = new Panel();
            panels5 = new Panel();
            label21 = new Label();
            labels5 = new Label();
            panels4 = new Panel();
            labels4 = new Label();
            label20 = new Label();
            panels3 = new Panel();
            label17 = new Label();
            labels3 = new Label();
            panels2 = new Panel();
            label15 = new Label();
            labels2 = new Label();
            label13 = new Label();
            label23 = new Label();
            label12 = new Label();
            label16 = new Label();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            panel11.SuspendLayout();
            panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panels1.SuspendLayout();
            panel14.SuspendLayout();
            panels5.SuspendLayout();
            panels4.SuspendLayout();
            panels3.SuspendLayout();
            panels2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(219, 45, 139);
            panel2.Controls.Add(iconButton2);
            panel2.Controls.Add(label111);
            panel2.Controls.Add(iconButton1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(417, 75);
            panel2.TabIndex = 2;
            // 
            // iconButton2
            // 
            iconButton2.BackColor = Color.FromArgb(219, 45, 139);
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
            // label111
            // 
            label111.AutoSize = true;
            label111.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label111.ForeColor = Color.White;
            label111.Location = new Point(88, 15);
            label111.Name = "label111";
            label111.Size = new Size(255, 38);
            label111.TabIndex = 1;
            label111.Text = "Nạp tiền điện thoại";
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
            iconButton1.Size = new Size(65, 62);
            iconButton1.TabIndex = 0;
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Controls.Add(label2);
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(12, 101);
            panel3.Name = "panel3";
            panel3.Size = new Size(393, 69);
            panel3.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Red;
            label2.Location = new Point(116, 10);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 3;
            label2.Text = "không hợp lệ!";
            label2.Visible = false;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(79, 33);
            textBox1.MaxLength = 10;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Nhập SĐT";
            textBox1.Size = new Size(208, 24);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(7, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(61, 58);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(79, 10);
            label3.Name = "label3";
            label3.Size = new Size(36, 20);
            label3.TabIndex = 0;
            label3.Text = "SĐT";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(5, 403);
            panel1.Name = "panel1";
            panel1.Size = new Size(130, 100);
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.MediumVioletRed;
            label1.Location = new Point(21, 31);
            label1.Name = "label1";
            label1.Size = new Size(81, 28);
            label1.TabIndex = 0;
            label1.Text = "10.000đ";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panel4.BackgroundImageLayout = ImageLayout.Stretch;
            panel4.Controls.Add(label4);
            panel4.Location = new Point(142, 403);
            panel4.Name = "panel4";
            panel4.Size = new Size(130, 100);
            panel4.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(22, 31);
            label4.Name = "label4";
            label4.Size = new Size(84, 28);
            label4.TabIndex = 0;
            label4.Text = "20.000đ";
            // 
            // panel5
            // 
            panel5.BackColor = Color.Transparent;
            panel5.BackgroundImage = (Image)resources.GetObject("panel5.BackgroundImage");
            panel5.BackgroundImageLayout = ImageLayout.Stretch;
            panel5.Controls.Add(label5);
            panel5.Location = new Point(279, 403);
            panel5.Name = "panel5";
            panel5.Size = new Size(130, 100);
            panel5.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(22, 31);
            label5.Name = "label5";
            label5.Size = new Size(84, 28);
            label5.TabIndex = 0;
            label5.Text = "30.000đ";
            // 
            // panel6
            // 
            panel6.BackColor = Color.Transparent;
            panel6.BackgroundImage = (Image)resources.GetObject("panel6.BackgroundImage");
            panel6.BackgroundImageLayout = ImageLayout.Stretch;
            panel6.Controls.Add(label6);
            panel6.Location = new Point(5, 506);
            panel6.Name = "panel6";
            panel6.Size = new Size(130, 100);
            panel6.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(21, 32);
            label6.Name = "label6";
            label6.Size = new Size(84, 28);
            label6.TabIndex = 0;
            label6.Text = "50.000đ";
            // 
            // panel7
            // 
            panel7.BackColor = Color.Transparent;
            panel7.BackgroundImage = (Image)resources.GetObject("panel7.BackgroundImage");
            panel7.BackgroundImageLayout = ImageLayout.Stretch;
            panel7.Controls.Add(label7);
            panel7.Location = new Point(142, 506);
            panel7.Name = "panel7";
            panel7.Size = new Size(130, 100);
            panel7.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(17, 32);
            label7.Name = "label7";
            label7.Size = new Size(92, 28);
            label7.TabIndex = 0;
            label7.Text = "100.000đ";
            // 
            // panel8
            // 
            panel8.BackColor = Color.Transparent;
            panel8.BackgroundImage = (Image)resources.GetObject("panel8.BackgroundImage");
            panel8.BackgroundImageLayout = ImageLayout.Stretch;
            panel8.Controls.Add(label8);
            panel8.Location = new Point(279, 506);
            panel8.Name = "panel8";
            panel8.Size = new Size(130, 100);
            panel8.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(17, 31);
            label8.Name = "label8";
            label8.Size = new Size(95, 28);
            label8.TabIndex = 0;
            label8.Text = "200.000đ";
            // 
            // panel9
            // 
            panel9.BackColor = Color.Transparent;
            panel9.BackgroundImage = (Image)resources.GetObject("panel9.BackgroundImage");
            panel9.BackgroundImageLayout = ImageLayout.Stretch;
            panel9.Controls.Add(label9);
            panel9.Location = new Point(5, 611);
            panel9.Name = "panel9";
            panel9.Size = new Size(130, 100);
            panel9.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(17, 30);
            label9.Name = "label9";
            label9.Size = new Size(95, 28);
            label9.TabIndex = 0;
            label9.Text = "300.000đ";
            // 
            // panel10
            // 
            panel10.BackColor = Color.Transparent;
            panel10.BackgroundImage = (Image)resources.GetObject("panel10.BackgroundImage");
            panel10.BackgroundImageLayout = ImageLayout.Stretch;
            panel10.Controls.Add(label10);
            panel10.Location = new Point(142, 611);
            panel10.Name = "panel10";
            panel10.Size = new Size(130, 100);
            panel10.TabIndex = 11;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(13, 31);
            label10.Name = "label10";
            label10.Size = new Size(95, 28);
            label10.TabIndex = 0;
            label10.Text = "500.000đ";
            // 
            // panel11
            // 
            panel11.BackColor = Color.Transparent;
            panel11.BackgroundImage = (Image)resources.GetObject("panel11.BackgroundImage");
            panel11.BackgroundImageLayout = ImageLayout.Stretch;
            panel11.Controls.Add(label11);
            panel11.Location = new Point(279, 611);
            panel11.Name = "panel11";
            panel11.Size = new Size(130, 100);
            panel11.TabIndex = 12;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(17, 32);
            label11.Name = "label11";
            label11.Size = new Size(95, 28);
            label11.TabIndex = 0;
            label11.Text = "800.000đ";
            // 
            // panel12
            // 
            panel12.BackColor = Color.White;
            panel12.Controls.Add(pictureBox5);
            panel12.Dock = DockStyle.Bottom;
            panel12.Location = new Point(0, 812);
            panel12.Name = "panel12";
            panel12.Size = new Size(417, 82);
            panel12.TabIndex = 13;
            // 
            // pictureBox5
            // 
            pictureBox5.Enabled = false;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(12, 8);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(397, 69);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 5;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // panels1
            // 
            panels1.BackColor = Color.Transparent;
            panels1.BackgroundImage = (Image)resources.GetObject("panels1.BackgroundImage");
            panels1.BackgroundImageLayout = ImageLayout.Stretch;
            panels1.Controls.Add(label14);
            panels1.Controls.Add(labels1);
            panels1.Location = new Point(6, 13);
            panels1.Name = "panels1";
            panels1.Size = new Size(123, 79);
            panels1.TabIndex = 14;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(21, 49);
            label14.Name = "label14";
            label14.Size = new Size(79, 20);
            label14.TabIndex = 1;
            label14.Text = "hoàn 500đ";
            // 
            // labels1
            // 
            labels1.AutoSize = true;
            labels1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labels1.Location = new Point(19, 19);
            labels1.Name = "labels1";
            labels1.Size = new Size(84, 28);
            labels1.TabIndex = 0;
            labels1.Text = "20.000đ";
            // 
            // panel14
            // 
            panel14.BackColor = Color.MistyRose;
            panel14.Controls.Add(panels5);
            panel14.Controls.Add(panels4);
            panel14.Controls.Add(panels3);
            panel14.Controls.Add(panels2);
            panel14.Controls.Add(panels1);
            panel14.Location = new Point(6, 243);
            panel14.Name = "panel14";
            panel14.Size = new Size(405, 107);
            panel14.TabIndex = 16;
            // 
            // panels5
            // 
            panels5.BackColor = Color.Transparent;
            panels5.BackgroundImage = (Image)resources.GetObject("panels5.BackgroundImage");
            panels5.BackgroundImageLayout = ImageLayout.Stretch;
            panels5.Controls.Add(label21);
            panels5.Controls.Add(labels5);
            panels5.Location = new Point(547, 14);
            panels5.Name = "panels5";
            panels5.Size = new Size(123, 79);
            panels5.TabIndex = 18;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label21.Location = new Point(21, 49);
            label21.Name = "label21";
            label21.Size = new Size(87, 20);
            label21.TabIndex = 1;
            label21.Text = "hoàn 8000đ";
            // 
            // labels5
            // 
            labels5.AutoSize = true;
            labels5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labels5.Location = new Point(19, 19);
            labels5.Name = "labels5";
            labels5.Size = new Size(95, 28);
            labels5.TabIndex = 0;
            labels5.Text = "500.000đ";
            // 
            // panels4
            // 
            panels4.BackColor = Color.Transparent;
            panels4.BackgroundImage = (Image)resources.GetObject("panels4.BackgroundImage");
            panels4.BackgroundImageLayout = ImageLayout.Stretch;
            panels4.Controls.Add(labels4);
            panels4.Controls.Add(label20);
            panels4.Location = new Point(412, 14);
            panels4.Name = "panels4";
            panels4.Size = new Size(123, 79);
            panels4.TabIndex = 17;
            // 
            // labels4
            // 
            labels4.AutoSize = true;
            labels4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labels4.Location = new Point(21, 49);
            labels4.Name = "labels4";
            labels4.Size = new Size(87, 20);
            labels4.TabIndex = 1;
            labels4.Text = "hoàn 5000đ";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label20.Location = new Point(19, 19);
            label20.Name = "label20";
            label20.Size = new Size(95, 28);
            label20.TabIndex = 0;
            label20.Text = "200.000đ";
            // 
            // panels3
            // 
            panels3.BackColor = Color.Transparent;
            panels3.BackgroundImage = (Image)resources.GetObject("panels3.BackgroundImage");
            panels3.BackgroundImageLayout = ImageLayout.Stretch;
            panels3.Controls.Add(label17);
            panels3.Controls.Add(labels3);
            panels3.Location = new Point(278, 14);
            panels3.Name = "panels3";
            panels3.Size = new Size(123, 79);
            panels3.TabIndex = 16;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(21, 49);
            label17.Name = "label17";
            label17.Size = new Size(87, 20);
            label17.TabIndex = 1;
            label17.Text = "hoàn 1500đ";
            // 
            // labels3
            // 
            labels3.AutoSize = true;
            labels3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labels3.Location = new Point(19, 19);
            labels3.Name = "labels3";
            labels3.Size = new Size(92, 28);
            labels3.TabIndex = 0;
            labels3.Text = "100.000đ";
            // 
            // panels2
            // 
            panels2.BackColor = Color.Transparent;
            panels2.BackgroundImage = (Image)resources.GetObject("panels2.BackgroundImage");
            panels2.BackgroundImageLayout = ImageLayout.Stretch;
            panels2.Controls.Add(label15);
            panels2.Controls.Add(labels2);
            panels2.Location = new Point(142, 14);
            panels2.Name = "panels2";
            panels2.Size = new Size(123, 79);
            panels2.TabIndex = 15;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(18, 47);
            label15.Name = "label15";
            label15.Size = new Size(87, 20);
            label15.TabIndex = 1;
            label15.Text = "hoàn 1000đ";
            // 
            // labels2
            // 
            labels2.AutoSize = true;
            labels2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labels2.Location = new Point(16, 17);
            labels2.Name = "labels2";
            labels2.Size = new Size(84, 28);
            labels2.TabIndex = 0;
            labels2.Text = "50.000đ";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(9, 202);
            label13.Name = "label13";
            label13.Size = new Size(123, 28);
            label13.TabIndex = 17;
            label13.Text = "Gói giới hạn";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.BackColor = Color.Transparent;
            label23.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label23.ForeColor = Color.Black;
            label23.Location = new Point(8, 370);
            label23.Name = "label23";
            label23.Size = new Size(146, 28);
            label23.TabIndex = 18;
            label23.Text = "Gói phổ thông";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(9, 768);
            label12.Name = "label12";
            label12.Size = new Size(105, 28);
            label12.TabIndex = 19;
            label12.Text = "Tổng tiền:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.Transparent;
            label16.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label16.ForeColor = Color.Red;
            label16.Location = new Point(283, 768);
            label16.Name = "label16";
            label16.RightToLeft = RightToLeft.No;
            label16.Size = new Size(23, 28);
            label16.TabIndex = 20;
            label16.Text = "0";
            label16.TextAlign = ContentAlignment.MiddleRight;
            label16.Click += label16_Click;
            // 
            // PayPhoneMoney
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(417, 894);
            Controls.Add(label16);
            Controls.Add(label12);
            Controls.Add(label23);
            Controls.Add(label13);
            Controls.Add(panel14);
            Controls.Add(panel12);
            Controls.Add(panel11);
            Controls.Add(panel10);
            Controls.Add(panel9);
            Controls.Add(panel8);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PayPhoneMoney";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PayPhoneMoney";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panels1.ResumeLayout(false);
            panels1.PerformLayout();
            panel14.ResumeLayout(false);
            panels5.ResumeLayout(false);
            panels5.PerformLayout();
            panels4.ResumeLayout(false);
            panels4.PerformLayout();
            panels3.ResumeLayout(false);
            panels3.PerformLayout();
            panels2.ResumeLayout(false);
            panels2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private FontAwesome.Sharp.IconButton iconButton2;
        private Label label111;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Panel panel3;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private Label label3;
        private Panel panel1;
        private Label label1;
        private Panel panel4;
        private Label label4;
        private Panel panel5;
        private Label label5;
        private Panel panel6;
        private Label label6;
        private Panel panel7;
        private Label label7;
        private Panel panel8;
        private Label label8;
        private Panel panel9;
        private Label label9;
        private Panel panel10;
        private Label label10;
        private Panel panel11;
        private Label label11;
        private Panel panel12;
        private PictureBox pictureBox5;
        private Label label2;
        private Panel panels1;
        private Label labels1;
        private Panel panel14;
        private Label label14;
        private Panel panels5;
        private Label label21;
        private Label labels5;
        private Panel panels4;
        private Label labels4;
        private Label label20;
        private Panel panels3;
        private Label label17;
        private Label labels3;
        private Panel panels2;
        private Label label15;
        private Label labels2;
        private Label label13;
        private Label label23;
        private Label label12;
        private Label label16;
    }
}