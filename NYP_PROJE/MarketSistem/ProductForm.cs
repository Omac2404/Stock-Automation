using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.Management;

namespace MarketSistem
{
    public partial class ProductForm : Form
    {
        DBConnect dBCon = new DBConnect();
        public ProductForm()
        {
            InitializeComponent();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button_add_Click(object sender, EventArgs e)
        {
            try
            {
                string insertQuery = $"INSERT INTO Category VALUES('{TextBox_id.Text}','{TextBox_name.Text}','{TextBox_description.Text}')";
                SqlCommand command = new SqlCommand(insertQuery,dBCon.Getcon());
                dBCon.OpenCon();
                command.ExecuteNonQuery();
                MessageBox.Show("Kategori eklendi");
                dBCon.CloseCon();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
