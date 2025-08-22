using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeDeneme
{
    public partial class ProductionForm : Form
    {

        public ProductionForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ProductionDB"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                if (String.IsNullOrEmpty(txtMaterial.Text) == false)
                {
                    con.Open();
                    string query = @"INSERT INTO ProductionRecords 
                            (MaterialName, Quantity, ProductionDate) 
                            VALUES (@name, @qty, @date)";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@name", txtMaterial.Text);
                    cmd.Parameters.AddWithValue("@qty", (int)nudQuantity.Value);
                    cmd.Parameters.AddWithValue("@date", dtpProductionDate.Value);

                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Üretim kaydı eklendi!");
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Text Alanı boş bırakılamaz!!!");
                }
            }
        }
        private void ClearForm()
        {
            txtMaterial.Clear();
            nudQuantity.Value = 1;
            dtpProductionDate.Value = DateTime.Now;
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            txtMaterial.Clear();
            nudQuantity.Value = 1;
        }
    }
}
