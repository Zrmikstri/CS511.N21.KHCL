namespace MoMo.MyUserControl
{
    partial class ResetPassword
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetPassword));
            panel4 = new Panel();
            textBox1 = new TextBox();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panel4.BackgroundImageLayout = ImageLayout.Stretch;
            panel4.Controls.Add(textBox1);
            panel4.Location = new Point(15, 37);
            panel4.Name = "panel4";
            panel4.Size = new Size(402, 61);
            panel4.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(13, 14);
            textBox1.MaxLength = 12;
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Nhập SĐT";
            textBox1.Size = new Size(375, 34);
            textBox1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 28);
            label5.Name = "label5";
            label5.Size = new Size(154, 20);
            label5.TabIndex = 4;
            label5.Text = "SĐT tài khoản đăng kí";
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(247, 113);
            button1.Name = "button1";
            button1.Size = new Size(170, 42);
            button1.TabIndex = 5;
            button1.Text = "Reset mật khẩu";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(15, 113);
            button2.Name = "button2";
            button2.Size = new Size(167, 42);
            button2.TabIndex = 6;
            button2.Text = "Quay lại";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // ResetPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(panel4);
            Name = "ResetPassword";
            Size = new Size(434, 173);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel4;
        private TextBox textBox1;
        private Label label5;
        private Button button1;
        private Button button2;
    }
}
