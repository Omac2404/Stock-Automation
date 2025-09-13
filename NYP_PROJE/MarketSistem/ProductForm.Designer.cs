namespace MarketSistem
{
    partial class ProductForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            dataGridView_category = new DataGridView();
            button_delete = new Button();
            button_update = new Button();
            button_add = new Button();
            TextBox_description = new Guna.UI2.WinForms.Guna2TextBox();
            label4 = new Label();
            TextBox_name = new Guna.UI2.WinForms.Guna2TextBox();
            label2 = new Label();
            TextBox_id = new Guna.UI2.WinForms.Guna2TextBox();
            label6 = new Label();
            label1 = new Label();
            label_exit = new Label();
            button_seller = new Button();
            button_product = new Button();
            button_selling = new Button();
            button_logout = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_category).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(48, 227, 202);
            panel1.Controls.Add(dataGridView_category);
            panel1.Controls.Add(button_delete);
            panel1.Controls.Add(button_update);
            panel1.Controls.Add(button_add);
            panel1.Controls.Add(TextBox_description);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(TextBox_name);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(TextBox_id);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(137, 34);
            panel1.Name = "panel1";
            panel1.Size = new Size(974, 621);
            panel1.TabIndex = 0;
            // 
            // dataGridView_category
            // 
            dataGridView_category.BackgroundColor = Color.White;
            dataGridView_category.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_category.Location = new Point(464, 105);
            dataGridView_category.Name = "dataGridView_category";
            dataGridView_category.RowHeadersWidth = 51;
            dataGridView_category.RowTemplate.Height = 29;
            dataGridView_category.Size = new Size(476, 486);
            dataGridView_category.TabIndex = 4;
            // 
            // button_delete
            // 
            button_delete.FlatAppearance.BorderSize = 0;
            button_delete.FlatStyle = FlatStyle.Flat;
            button_delete.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button_delete.Location = new Point(336, 265);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(94, 45);
            button_delete.TabIndex = 3;
            button_delete.Text = "Sil";
            button_delete.UseVisualStyleBackColor = true;
            button_delete.Click += button3_Click;
            // 
            // button_update
            // 
            button_update.FlatAppearance.BorderSize = 0;
            button_update.FlatStyle = FlatStyle.Flat;
            button_update.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button_update.Location = new Point(167, 265);
            button_update.Name = "button_update";
            button_update.Size = new Size(128, 45);
            button_update.TabIndex = 3;
            button_update.Text = "Güncelle";
            button_update.UseVisualStyleBackColor = true;
            // 
            // button_add
            // 
            button_add.FlatAppearance.BorderSize = 0;
            button_add.FlatStyle = FlatStyle.Flat;
            button_add.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button_add.Location = new Point(25, 265);
            button_add.Name = "button_add";
            button_add.Size = new Size(94, 45);
            button_add.TabIndex = 3;
            button_add.Text = "Ekle";
            button_add.UseVisualStyleBackColor = true;
            button_add.Click += button_add_Click;
            // 
            // TextBox_description
            // 
            TextBox_description.BorderRadius = 18;
            TextBox_description.CustomizableEdges = customizableEdges7;
            TextBox_description.DefaultText = "";
            TextBox_description.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            TextBox_description.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            TextBox_description.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            TextBox_description.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            TextBox_description.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            TextBox_description.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TextBox_description.ForeColor = Color.Black;
            TextBox_description.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            TextBox_description.Location = new Point(121, 187);
            TextBox_description.Name = "TextBox_description";
            TextBox_description.PasswordChar = '\0';
            TextBox_description.PlaceholderText = "";
            TextBox_description.SelectedText = "";
            TextBox_description.ShadowDecoration.CustomizableEdges = customizableEdges8;
            TextBox_description.Size = new Size(296, 45);
            TextBox_description.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(48, 227, 202);
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(3, 187);
            label4.Name = "label4";
            label4.Size = new Size(113, 31);
            label4.TabIndex = 0;
            label4.Text = "Açıklama";
            // 
            // TextBox_name
            // 
            TextBox_name.BorderRadius = 18;
            TextBox_name.CustomizableEdges = customizableEdges9;
            TextBox_name.DefaultText = "";
            TextBox_name.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            TextBox_name.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            TextBox_name.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            TextBox_name.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            TextBox_name.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            TextBox_name.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TextBox_name.ForeColor = Color.Black;
            TextBox_name.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            TextBox_name.Location = new Point(121, 122);
            TextBox_name.Name = "TextBox_name";
            TextBox_name.PasswordChar = '\0';
            TextBox_name.PlaceholderText = "";
            TextBox_name.SelectedText = "";
            TextBox_name.ShadowDecoration.CustomizableEdges = customizableEdges10;
            TextBox_name.Size = new Size(296, 45);
            TextBox_name.TabIndex = 1;
            TextBox_name.TextChanged += guna2TextBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(48, 227, 202);
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(3, 122);
            label2.Name = "label2";
            label2.Size = new Size(59, 31);
            label2.TabIndex = 0;
            label2.Text = "İsim";
            // 
            // TextBox_id
            // 
            TextBox_id.BorderRadius = 18;
            TextBox_id.CustomizableEdges = customizableEdges11;
            TextBox_id.DefaultText = "";
            TextBox_id.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            TextBox_id.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            TextBox_id.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            TextBox_id.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            TextBox_id.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            TextBox_id.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TextBox_id.ForeColor = Color.Black;
            TextBox_id.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            TextBox_id.Location = new Point(121, 55);
            TextBox_id.Name = "TextBox_id";
            TextBox_id.PasswordChar = '\0';
            TextBox_id.PlaceholderText = "";
            TextBox_id.SelectedText = "";
            TextBox_id.ShadowDecoration.CustomizableEdges = customizableEdges12;
            TextBox_id.Size = new Size(296, 45);
            TextBox_id.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(48, 227, 202);
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(464, 16);
            label6.Name = "label6";
            label6.Size = new Size(206, 31);
            label6.TabIndex = 0;
            label6.Text = "Kategori Yönetme";
            label6.Click += label6_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(48, 227, 202);
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(3, 55);
            label1.Name = "label1";
            label1.Size = new Size(84, 31);
            label1.TabIndex = 0;
            label1.Text = "Kimlik";
            // 
            // label_exit
            // 
            label_exit.AutoSize = true;
            label_exit.BackColor = Color.FromArgb(228, 249, 245);
            label_exit.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label_exit.ForeColor = Color.FromArgb(48, 227, 202);
            label_exit.Location = new Point(1069, 0);
            label_exit.Name = "label_exit";
            label_exit.Size = new Size(29, 31);
            label_exit.TabIndex = 1;
            label_exit.Text = "X";
            // 
            // button_seller
            // 
            button_seller.FlatAppearance.BorderSize = 0;
            button_seller.FlatStyle = FlatStyle.Flat;
            button_seller.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button_seller.Location = new Point(12, 36);
            button_seller.Name = "button_seller";
            button_seller.Size = new Size(94, 45);
            button_seller.TabIndex = 3;
            button_seller.Text = "Satıcı";
            button_seller.UseVisualStyleBackColor = true;
            button_seller.Click += button_add_Click;
            // 
            // button_product
            // 
            button_product.FlatAppearance.BorderSize = 0;
            button_product.FlatStyle = FlatStyle.Flat;
            button_product.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button_product.Location = new Point(12, 101);
            button_product.Name = "button_product";
            button_product.Size = new Size(101, 45);
            button_product.TabIndex = 3;
            button_product.Text = "Ürün";
            button_product.UseVisualStyleBackColor = true;
            button_product.Click += button_add_Click;
            // 
            // button_selling
            // 
            button_selling.FlatAppearance.BorderSize = 0;
            button_selling.FlatStyle = FlatStyle.Flat;
            button_selling.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button_selling.Location = new Point(12, 170);
            button_selling.Name = "button_selling";
            button_selling.Size = new Size(94, 45);
            button_selling.TabIndex = 3;
            button_selling.Text = "Satış";
            button_selling.UseVisualStyleBackColor = true;
            button_selling.Click += button_add_Click;
            // 
            // button_logout
            // 
            button_logout.FlatAppearance.BorderSize = 0;
            button_logout.FlatStyle = FlatStyle.Flat;
            button_logout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button_logout.Location = new Point(19, 580);
            button_logout.Name = "button_logout";
            button_logout.Size = new Size(94, 45);
            button_logout.TabIndex = 4;
            button_logout.Text = "Çıkış";
            button_logout.UseVisualStyleBackColor = true;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(228, 249, 245);
            ClientSize = new Size(1100, 650);
            Controls.Add(button_logout);
            Controls.Add(label_exit);
            Controls.Add(panel1);
            Controls.Add(button_selling);
            Controls.Add(button_product);
            Controls.Add(button_seller);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "ProductForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProductForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_category).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label_exit;
        private Label label1;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_description;
        private Label label4;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_name;
        private Label label2;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_id;
        private Button button_add;
        private Button button_delete;
        private Button button_update;
        private Label label6;
        private Button button_seller;
        private Button button_product;
        private Button button_selling;
        private Button button_logout;
        private DataGridView dataGridView_category;
    }
}