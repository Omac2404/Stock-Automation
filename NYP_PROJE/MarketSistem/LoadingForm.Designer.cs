namespace MarketSistem
{
    partial class LoadingForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            guna2CircleButton2 = new Guna.UI2.WinForms.Guna2CircleButton();
            CircleProgressBar = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            label2 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(48, 227, 202);
            label1.Location = new Point(165, 28);
            label1.Name = "label1";
            label1.Size = new Size(312, 41);
            label1.TabIndex = 0;
            label1.Text = "Market İdare Sistemi";
            label1.Click += label1_Click;
            // 
            // guna2CircleButton1
            // 
            guna2CircleButton1.DisabledState.BorderColor = Color.DarkGray;
            guna2CircleButton1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2CircleButton1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2CircleButton1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2CircleButton1.FillColor = Color.FromArgb(48, 227, 202);
            guna2CircleButton1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            guna2CircleButton1.ForeColor = Color.White;
            guna2CircleButton1.Location = new Point(-31, 309);
            guna2CircleButton1.Name = "guna2CircleButton1";
            guna2CircleButton1.ShadowDecoration.CustomizableEdges = customizableEdges1;
            guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CircleButton1.Size = new Size(352, 289);
            guna2CircleButton1.TabIndex = 1;
            guna2CircleButton1.Text = "guna2CircleButton1";
            // 
            // guna2CircleButton2
            // 
            guna2CircleButton2.DisabledState.BorderColor = Color.DarkGray;
            guna2CircleButton2.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2CircleButton2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2CircleButton2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2CircleButton2.FillColor = Color.FromArgb(48, 227, 202);
            guna2CircleButton2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            guna2CircleButton2.ForeColor = Color.White;
            guna2CircleButton2.Location = new Point(307, 309);
            guna2CircleButton2.Name = "guna2CircleButton2";
            guna2CircleButton2.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2CircleButton2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CircleButton2.Size = new Size(352, 289);
            guna2CircleButton2.TabIndex = 1;
            guna2CircleButton2.Text = "guna2CircleButton1";
            // 
            // CircleProgressBar
            // 
            CircleProgressBar.BackColor = Color.Transparent;
            CircleProgressBar.FillColor = Color.FromArgb(200, 213, 218, 223);
            CircleProgressBar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CircleProgressBar.ForeColor = Color.White;
            CircleProgressBar.Location = new Point(240, 83);
            CircleProgressBar.Minimum = 0;
            CircleProgressBar.Name = "CircleProgressBar";
            CircleProgressBar.ShadowDecoration.CustomizableEdges = customizableEdges3;
            CircleProgressBar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            CircleProgressBar.Size = new Size(162, 162);
            CircleProgressBar.TabIndex = 2;
            CircleProgressBar.Text = "guna2CircleProgressBar1";
            CircleProgressBar.UseTransparentBackground = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(48, 227, 202);
            label2.Location = new Point(215, 263);
            label2.Name = "label2";
            label2.Size = new Size(213, 31);
            label2.TabIndex = 0;
            label2.Text = "Toprak Tahir Omaç";
            label2.Click += label1_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // LoadingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(228, 249, 245);
            ClientSize = new Size(650, 400);
            Controls.Add(CircleProgressBar);
            Controls.Add(guna2CircleButton2);
            Controls.Add(guna2CircleButton1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoadingForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoadingForm";
            Load += LoadingForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton2;
        private Guna.UI2.WinForms.Guna2CircleProgressBar CircleProgressBar;
        private Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}