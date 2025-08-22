using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace ProjeDeneme
{
    public partial class ManagementForm : Form
    {
        string conString = "Data Source=UMT---TMU\\SQLEXPRESS;Initial Catalog=MaindDB;Integrated Security=True;Trust Server Certificate=True;";
        public ManagementForm()
        {
            InitializeComponent();
            LoadApprovedRecords();
        }

        private void LoadApprovedRecords()
        {
            try
            {
                //string mainCon = ConfigurationManager.ConnectionStrings["MainDB"].ConnectionString;

                using (SqlConnection con = new SqlConnection(conString))
                {
                    con.Open();
                    string query = "SELECT * FROM ApprovedRecords";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvManagement.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri yüklenirken hata oluştu: " + ex.Message);
            }
        }
    }
}
