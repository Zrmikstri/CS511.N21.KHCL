namespace MoMo
{
    partial class TransferMoney
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransferMoney));
            panel2 = new Panel();
            panel5 = new Panel();
            textBox3 = new TextBox();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Fuchsia;
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(iconButton1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(396, 56);
            panel2.TabIndex = 3;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Transparent;
            panel5.BackgroundImage = (Image)resources.GetObject("panel5.BackgroundImage");
            panel5.BackgroundImageLayout = ImageLayout.Stretch;
            panel5.Controls.Add(textBox3);
            panel5.Controls.Add(iconButton2);
            panel5.Location = new Point(49, 9);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(335, 39);
            panel5.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            textBox3.Location = new Point(46, 9);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Nhập tên, SĐT người nhận";
            textBox3.Size = new Size(254, 20);
            textBox3.TabIndex = 2;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // iconButton2
            // 
            iconButton2.BackColor = Color.Transparent;
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            iconButton2.IconColor = Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 30;
            iconButton2.Location = new Point(10, 4);
            iconButton2.Margin = new Padding(3, 2, 3, 2);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(30, 30);
            iconButton2.TabIndex = 1;
            iconButton2.UseVisualStyleBackColor = false;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.Fuchsia;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.ChevronLeft;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 30;
            iconButton1.Location = new Point(3, 8);
            iconButton1.Margin = new Padding(3, 2, 3, 2);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(40, 40);
            iconButton1.TabIndex = 0;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(396, 684);
            panel1.TabIndex = 4;
            // 
            // TransferMoney
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 741);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Margin = new Padding(3, 2, 3, 2);
            Name = "TransferMoney";
            Text = "TransferMoney";
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Panel panel5;
        private TextBox textBox3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Panel panel1;
    }
}