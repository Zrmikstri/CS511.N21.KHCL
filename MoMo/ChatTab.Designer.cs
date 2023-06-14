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
            components = new System.ComponentModel.Container();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            richTextBox1 = new RichTextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel2 = new Panel();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            timer1 = new System.Windows.Forms.Timer(components);
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // iconButton1
            // 
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatAppearance.CheckedBackColor = Color.Transparent;
            iconButton1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            iconButton1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.CircleArrowRight;
            iconButton1.IconColor = Color.DodgerBlue;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 40;
            iconButton1.Location = new Point(355, 3);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(32, 46);
            iconButton1.TabIndex = 2;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.Location = new Point(41, 3);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(308, 46);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            richTextBox1.KeyDown += richTextBox1_KeyDown;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(396, 502);
            flowLayoutPanel1.TabIndex = 4;
            flowLayoutPanel1.WrapContents = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(iconButton2);
            panel2.Controls.Add(richTextBox1);
            panel2.Controls.Add(iconButton1);
            panel2.Location = new Point(3, 508);
            panel2.Name = "panel2";
            panel2.Size = new Size(390, 54);
            panel2.TabIndex = 0;
            // 
            // iconButton2
            // 
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatAppearance.CheckedBackColor = Color.Transparent;
            iconButton2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            iconButton2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.Image;
            iconButton2.IconColor = Color.DodgerBlue;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 40;
            iconButton2.Location = new Point(3, 5);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(32, 46);
            iconButton2.TabIndex = 4;
            iconButton2.UseVisualStyleBackColor = true;
            iconButton2.Click += iconButton2_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // ChatTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 248, 248);
            ClientSize = new Size(396, 566);
            Controls.Add(panel2);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ChatTab";
            Text = "ChatTab";
            FormClosing += ChatTab_FormClosing;
            Load += ChatTab_Load;
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private FontAwesome.Sharp.IconButton iconButton1;
        private RichTextBox richTextBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Timer timer1;
    }
}