namespace MoMo
{
    partial class Screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Screen));
            tableLayoutPanel1 = new TableLayoutPanel();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            iconButton5 = new FontAwesome.Sharp.IconButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 23F));
            tableLayoutPanel1.Controls.Add(iconButton1, 0, 0);
            tableLayoutPanel1.Controls.Add(iconButton4, 2, 0);
            tableLayoutPanel1.Controls.Add(iconButton5, 3, 0);
            tableLayoutPanel1.Controls.Add(iconButton3, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 905);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(453, 83);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.FromArgb(243, 233, 237);
            iconButton1.Dock = DockStyle.Fill;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.House;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 32;
            iconButton1.ImageAlign = ContentAlignment.TopCenter;
            iconButton1.Location = new Point(3, 4);
            iconButton1.Margin = new Padding(3, 4, 3, 4);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(107, 75);
            iconButton1.TabIndex = 0;
            iconButton1.Text = "Trang chủ";
            iconButton1.TextAlign = ContentAlignment.BottomCenter;
            iconButton1.TextImageRelation = TextImageRelation.ImageAboveText;
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
            // 
            // iconButton4
            // 
            iconButton4.BackColor = Color.FromArgb(243, 233, 237);
            iconButton4.Dock = DockStyle.Fill;
            iconButton4.FlatAppearance.BorderSize = 0;
            iconButton4.FlatStyle = FlatStyle.Flat;
            iconButton4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.Comments;
            iconButton4.IconColor = Color.Black;
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButton4.IconSize = 32;
            iconButton4.ImageAlign = ContentAlignment.TopCenter;
            iconButton4.Location = new Point(229, 4);
            iconButton4.Margin = new Padding(3, 4, 3, 4);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(107, 75);
            iconButton4.TabIndex = 3;
            iconButton4.Text = "Trao đổi";
            iconButton4.TextAlign = ContentAlignment.BottomCenter;
            iconButton4.TextImageRelation = TextImageRelation.ImageAboveText;
            iconButton4.UseVisualStyleBackColor = false;
            iconButton4.Click += iconButton4_Click;
            // 
            // iconButton5
            // 
            iconButton5.BackColor = Color.FromArgb(243, 233, 237);
            iconButton5.Dock = DockStyle.Fill;
            iconButton5.FlatAppearance.BorderSize = 0;
            iconButton5.FlatStyle = FlatStyle.Flat;
            iconButton5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton5.IconChar = FontAwesome.Sharp.IconChar.User;
            iconButton5.IconColor = Color.Black;
            iconButton5.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButton5.IconSize = 32;
            iconButton5.ImageAlign = ContentAlignment.TopCenter;
            iconButton5.Location = new Point(342, 4);
            iconButton5.Margin = new Padding(3, 4, 3, 4);
            iconButton5.Name = "iconButton5";
            iconButton5.Size = new Size(108, 75);
            iconButton5.TabIndex = 4;
            iconButton5.Text = "Tài khoản";
            iconButton5.TextAlign = ContentAlignment.BottomCenter;
            iconButton5.TextImageRelation = TextImageRelation.ImageAboveText;
            iconButton5.UseVisualStyleBackColor = false;
            iconButton5.Click += iconButton5_Click;
            // 
            // iconButton3
            // 
            iconButton3.BackColor = Color.FromArgb(243, 233, 237);
            iconButton3.Dock = DockStyle.Fill;
            iconButton3.FlatAppearance.BorderSize = 0;
            iconButton3.FlatStyle = FlatStyle.Flat;
            iconButton3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.ClockRotateLeft;
            iconButton3.IconColor = Color.Black;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.IconSize = 32;
            iconButton3.ImageAlign = ContentAlignment.TopCenter;
            iconButton3.Location = new Point(116, 4);
            iconButton3.Margin = new Padding(3, 4, 3, 4);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(107, 75);
            iconButton3.TabIndex = 2;
            iconButton3.Text = "Lịch sử GD";
            iconButton3.TextAlign = ContentAlignment.BottomCenter;
            iconButton3.TextImageRelation = TextImageRelation.ImageAboveText;
            iconButton3.UseVisualStyleBackColor = false;
            iconButton3.Click += iconButton3_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(453, 901);
            panel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(224, 224, 224);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(402, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 45);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Screen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(453, 988);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Screen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Screen";
            FormClosed += Screen_FormClosed;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton3;
        private Panel panel2;
        private PictureBox pictureBox1;
    }
}