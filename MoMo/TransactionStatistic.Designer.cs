namespace MoMo
{
    partial class TransactionStatistic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionStatistic));
            panel1 = new Panel();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            panel3 = new Panel();
            label8 = new Label();
            label9 = new Label();
            label6 = new Label();
            label7 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(219, 45, 139);
            panel1.Controls.Add(iconButton2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(iconButton1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(453, 75);
            panel1.TabIndex = 6;
            // 
            // iconButton2
            // 
            iconButton2.BackColor = Color.FromArgb(219, 45, 139);
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            iconButton2.IconColor = Color.White;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 35;
            iconButton2.Location = new Point(448, 24);
            iconButton2.Margin = new Padding(3, 4, 3, 4);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(39, 53);
            iconButton2.TabIndex = 2;
            iconButton2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(102, 17);
            label1.Name = "label1";
            label1.Size = new Size(248, 38);
            label1.TabIndex = 1;
            label1.Text = "Tổng quan thu chi";
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.FromArgb(219, 45, 139);
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.ChevronLeft;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 35;
            iconButton1.Location = new Point(5, 17);
            iconButton1.Margin = new Padding(3, 4, 3, 4);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(37, 40);
            iconButton1.TabIndex = 0;
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Location = new Point(5, 193);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(441, 424);
            panel2.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(25, 121);
            label2.Name = "label2";
            label2.Size = new Size(168, 28);
            label2.TabIndex = 8;
            label2.Text = "Thống kê thu chi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(255, 121);
            label3.Name = "label3";
            label3.Size = new Size(138, 28);
            label3.TabIndex = 9;
            label3.Text = "Tháng 6/2023";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(282, 21);
            label4.Name = "label4";
            label4.Size = new Size(117, 25);
            label4.TabIndex = 11;
            label4.Text = "150.000 VND";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(28, 21);
            label5.Name = "label5";
            label5.Size = new Size(125, 25);
            label5.TabIndex = 10;
            label5.Text = "Tổng chi tiêu:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(7, 646);
            panel3.Name = "panel3";
            panel3.Size = new Size(439, 160);
            panel3.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(26, 113);
            label8.Name = "label8";
            label8.Size = new Size(153, 25);
            label8.TabIndex = 14;
            label8.Text = "Biến động số dư:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(283, 113);
            label9.Name = "label9";
            label9.Size = new Size(110, 25);
            label9.TabIndex = 15;
            label9.Text = "30.000 VND";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(27, 67);
            label6.Name = "label6";
            label6.Size = new Size(160, 25);
            label6.TabIndex = 12;
            label6.Text = "Chi tiêu mỗi tuần:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(283, 68);
            label7.Name = "label7";
            label7.Size = new Size(110, 25);
            label7.TabIndex = 13;
            label7.Text = "30.000 VND";
            // 
            // TransactionStatistic
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 1040);
            Controls.Add(panel3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "TransactionStatistic";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TransactionStatistic";
            Load += TransactionStatistic_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private Label label1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Panel panel2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Panel panel3;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}