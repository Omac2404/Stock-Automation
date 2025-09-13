using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketSistem
{
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        int baslangic = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            baslangic += 2;
            CircleProgressBar.Value = baslangic;
            if (CircleProgressBar.Value == 100)
            {
                CircleProgressBar.Value = 0;
                timer1.Stop();
                LoginForm loginForm = new LoginForm();
                this.Hide();
                loginForm.Show();
            }
        }

        private void LoadingForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
