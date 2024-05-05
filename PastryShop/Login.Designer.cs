namespace PastryShop
{
    partial class Login
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
            LoginBtn = new Button();
            PasswordTb = new TextBox();
            UsernameTb = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.IndianRed;
            panel1.Controls.Add(LoginBtn);
            panel1.Controls.Add(PasswordTb);
            panel1.Controls.Add(UsernameTb);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-6, -6);
            panel1.Name = "panel1";
            panel1.Size = new Size(646, 345);
            panel1.TabIndex = 0;
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.Transparent;
            LoginBtn.Font = new Font("Roboto Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LoginBtn.ForeColor = Color.IndianRed;
            LoginBtn.Location = new Point(263, 235);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(129, 42);
            LoginBtn.TabIndex = 8;
            LoginBtn.Text = "Log In";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // PasswordTb
            // 
            PasswordTb.Font = new Font("Roboto", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordTb.ForeColor = SystemColors.ControlText;
            PasswordTb.Location = new Point(219, 181);
            PasswordTb.Name = "PasswordTb";
            PasswordTb.PlaceholderText = "Password";
            PasswordTb.ScrollBars = ScrollBars.Horizontal;
            PasswordTb.Size = new Size(213, 28);
            PasswordTb.TabIndex = 4;
            // 
            // UsernameTb
            // 
            UsernameTb.Font = new Font("Roboto", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            UsernameTb.ForeColor = SystemColors.ControlText;
            UsernameTb.Location = new Point(219, 137);
            UsernameTb.Name = "UsernameTb";
            UsernameTb.PlaceholderText = "Username";
            UsernameTb.Size = new Size(213, 28);
            UsernameTb.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.MistyRose;
            label2.Location = new Point(289, 89);
            label2.Name = "label2";
            label2.Size = new Size(64, 24);
            label2.TabIndex = 2;
            label2.Text = "Log In";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.MistyRose;
            label1.Location = new Point(139, 35);
            label1.Name = "label1";
            label1.Size = new Size(369, 37);
            label1.TabIndex = 1;
            label1.Text = "Vanille Pastry And Sweets";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(633, 326);
            Controls.Add(panel1);
            Name = "Login";
            Text = "Log In";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private TextBox PasswordTb;
        private TextBox UsernameTb;
        private Button LoginBtn;
    }
}