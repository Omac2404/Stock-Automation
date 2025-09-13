namespace MarketSistem
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label_exit = new Label();
            TextBox_username = new Guna.UI2.WinForms.Guna2TextBox();
            TextBox_password = new Guna.UI2.WinForms.Guna2TextBox();
            Button_login = new Guna.UI2.WinForms.Guna2Button();
            comboBox_role = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(228, 249, 245);
            label1.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(48, 227, 202);
            label1.Location = new Point(13, 88);
            label1.Name = "label1";
            label1.Size = new Size(185, 31);
            label1.TabIndex = 0;
            label1.Text = "KULLANICI ADI";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(228, 249, 245);
            label2.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(48, 227, 202);
            label2.Location = new Point(13, 135);
            label2.Name = "label2";
            label2.Size = new Size(76, 31);
            label2.TabIndex = 0;
            label2.Text = "ŞİFRE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(228, 249, 245);
            label3.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(48, 227, 202);
            label3.Location = new Point(200, 9);
            label3.Name = "label3";
            label3.Size = new Size(251, 31);
            label3.TabIndex = 0;
            label3.Text = "Market İdare Sistemi";
            // 
            // label_exit
            // 
            label_exit.AutoSize = true;
            label_exit.BackColor = Color.FromArgb(228, 249, 245);
            label_exit.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label_exit.ForeColor = Color.FromArgb(48, 227, 202);
            label_exit.Location = new Point(591, 9);
            label_exit.Name = "label_exit";
            label_exit.Size = new Size(29, 31);
            label_exit.TabIndex = 0;
            label_exit.Text = "X";
            label_exit.Click += label_exit_Click;
            label_exit.MouseEnter += label_exit_MouseEnter;
            label_exit.MouseLeave += label_exit_MouseLeave;
            // 
            // TextBox_username
            // 
            TextBox_username.BorderRadius = 18;
            TextBox_username.CustomizableEdges = customizableEdges1;
            TextBox_username.DefaultText = "";
            TextBox_username.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            TextBox_username.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            TextBox_username.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            TextBox_username.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            TextBox_username.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            TextBox_username.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TextBox_username.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            TextBox_username.Location = new Point(201, 88);
            TextBox_username.Name = "TextBox_username";
            TextBox_username.PasswordChar = '\0';
            TextBox_username.PlaceholderText = "";
            TextBox_username.SelectedText = "";
            TextBox_username.ShadowDecoration.CustomizableEdges = customizableEdges2;
            TextBox_username.Size = new Size(250, 45);
            TextBox_username.TabIndex = 1;
            // 
            // TextBox_password
            // 
            TextBox_password.BorderRadius = 18;
            TextBox_password.CustomizableEdges = customizableEdges3;
            TextBox_password.DefaultText = "";
            TextBox_password.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            TextBox_password.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            TextBox_password.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            TextBox_password.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            TextBox_password.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            TextBox_password.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TextBox_password.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            TextBox_password.Location = new Point(201, 139);
            TextBox_password.Name = "TextBox_password";
            TextBox_password.PasswordChar = '●';
            TextBox_password.PlaceholderText = "";
            TextBox_password.SelectedText = "";
            TextBox_password.ShadowDecoration.CustomizableEdges = customizableEdges4;
            TextBox_password.Size = new Size(250, 45);
            TextBox_password.TabIndex = 1;
            TextBox_password.UseSystemPasswordChar = true;
            // 
            // Button_login
            // 
            Button_login.BorderRadius = 18;
            Button_login.CustomizableEdges = customizableEdges5;
            Button_login.DisabledState.BorderColor = Color.DarkGray;
            Button_login.DisabledState.CustomBorderColor = Color.DarkGray;
            Button_login.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Button_login.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Button_login.FillColor = Color.FromArgb(48, 227, 202);
            Button_login.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Button_login.ForeColor = Color.White;
            Button_login.Location = new Point(255, 202);
            Button_login.Name = "Button_login";
            Button_login.ShadowDecoration.CustomizableEdges = customizableEdges6;
            Button_login.Size = new Size(142, 56);
            Button_login.TabIndex = 2;
            Button_login.Text = "Giriş";
            // 
            // comboBox_role
            // 
            comboBox_role.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox_role.ForeColor = Color.FromArgb(48, 227, 202);
            comboBox_role.FormattingEnabled = true;
            comboBox_role.Items.AddRange(new object[] { "Admin", "Satıcı" });
            comboBox_role.Location = new Point(201, 46);
            comboBox_role.Name = "comboBox_role";
            comboBox_role.Size = new Size(250, 39);
            comboBox_role.TabIndex = 3;
            comboBox_role.Text = "Rol Seç";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(228, 249, 245);
            ClientSize = new Size(632, 353);
            Controls.Add(comboBox_role);
            Controls.Add(Button_login);
            Controls.Add(TextBox_password);
            Controls.Add(TextBox_username);
            Controls.Add(label_exit);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label_exit;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_username;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_password;
        private Guna.UI2.WinForms.Guna2Button Button_login;
        private ComboBox comboBox_role;
    }
}