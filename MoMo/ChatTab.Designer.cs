namespace MoMo
{
    partial class ChatTab
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
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            richTextBox1 = new RichTextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 255, 192);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(396, 123);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(3, 98);
            label4.Name = "label4";
            label4.Size = new Size(162, 17);
            label4.TabIndex = 3;
            label4.Text = "Email: pvcorp@gmail.com";
            // 
            // label3
            // 
            label3.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(3, 72);
            label3.Name = "label3";
            label3.Size = new Size(390, 26);
            label3.TabIndex = 2;
            label3.Text = "Địa chỉ liên hệ: Tòa nhà V3, Đường Trần Khải P5 Q10 Tp.HCM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(3, 45);
            label2.Name = "label2";
            label2.Size = new Size(274, 17);
            label2.TabIndex = 1;
            label2.Text = "Trụ sở chính: 123 Trần Phú P10 Q5 TP.HCM";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(255, 22);
            label1.TabIndex = 0;
            label1.Text = "CÔNG TY TNHH PHÚ VINH";
            // 
            // iconButton1
            // 
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.CircleArrowRight;
            iconButton1.IconColor = Color.DodgerBlue;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 40;
            iconButton1.Location = new Point(334, 3);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(47, 46);
            iconButton1.TabIndex = 2;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.Location = new Point(9, 3);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(319, 46);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 123);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(396, 379);
            flowLayoutPanel1.TabIndex = 4;
            flowLayoutPanel1.WrapContents = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(richTextBox1);
            panel2.Controls.Add(iconButton1);
            panel2.Location = new Point(3, 508);
            panel2.Name = "panel2";
            panel2.Size = new Size(390, 54);
            panel2.TabIndex = 0;
            // 
            // ChatTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 248, 248);
            ClientSize = new Size(396, 566);
            Controls.Add(panel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ChatTab";
            Text = "ChatTab";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private RichTextBox richTextBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel2;
    }
}