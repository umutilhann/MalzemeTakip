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
    
    public partial class LogisticsForms : Form
    {
        string productionCon = "SERVER(ProductionDB);";
        string mainCon = "SERVER(MaindDB);";

        DataTable dt = new DataTable();

        public LogisticsForms()
        {
            InitializeComponent();

            // Bağlantı string'lerini ConfigurationManager'dan al
           // productionCon = ConfigurationManager.ConnectionStrings["ProductionDB"].ConnectionString;
           // mainCon = ConfigurationManager.ConnectionStrings["MainDB"].ConnectionString;

            LoadPendingRecords();
            ConfigureDataGridView();
        }

        private void ConfigureDataGridView()
        {
            // DataGridView'i yapılandır
            dgvLogistics.AutoGenerateColumns = false;

            // Sütunları temizle
            dgvLogistics.Columns.Clear();

            // Sütunları ekle
            dgvLogistics.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "ProductionID",
                HeaderText = "ID",
                Name = "ProductionID", // Add this line
                Visible = false
            });

            dgvLogistics.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "MaterialName",
                HeaderText = "Malzeme Adı",
                Width = 150
            });

            dgvLogistics.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Quantity",
                HeaderText = "Miktar",
                Width = 80
            });

            dgvLogistics.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "ProductionDate",
                HeaderText = "Üretim Tarihi",
                Width = 120,
                DefaultCellStyle = new DataGridViewCellStyle()
                {
                    Format = "dd.MM.yyyy HH:mm"
                }
            });

            // Onayla buton sütunu
            DataGridViewButtonColumn approveColumn = new DataGridViewButtonColumn();
            approveColumn.Name = "Approve";
            approveColumn.HeaderText = "Onayla";
            approveColumn.Text = "Onayla";
            approveColumn.UseColumnTextForButtonValue = true;
            dgvLogistics.Columns.Add(approveColumn);

            // Reddet buton sütunu
            DataGridViewButtonColumn rejectColumn = new DataGridViewButtonColumn();
            rejectColumn.Name = "Reject";
            rejectColumn.HeaderText = "Reddet";
            rejectColumn.Text = "Reddet";
            rejectColumn.UseColumnTextForButtonValue = true;
            dgvLogistics.Columns.Add(rejectColumn);

            // CellClick olayını bağla
            dgvLogistics.CellClick += new DataGridViewCellEventHandler(dgvLogistics_CellClick);
        }

        private void LoadPendingRecords()
        {
            try
            {
                using (var con = new SqlConnection(productionCon))
                {
                    con.Open();
                    string query = "SELECT * FROM ProductionRecords WHERE Status = 'Beklemede'";
                    var da = new SqlDataAdapter(query, con);
                    dt.Clear();
                    da.Fill(dt);
                    dgvLogistics.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri Yüklenirken Hata Oluştu:" + ex.Message);
            }
        }

        // CellClick olayı için metod
        private void dgvLogistics_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int id = Convert.ToInt32(dgvLogistics.Rows[e.RowIndex].Cells["ProductionID"].Value);

            if (e.ColumnIndex == dgvLogistics.Columns["Approve"].Index)
            {
                ApproveRecord(id, e.RowIndex);
            }
            else if (e.ColumnIndex == dgvLogistics.Columns["Reject"].Index)
            {
                RejectRecord(id, e.RowIndex);
            }
        }

        private void ApproveRecord(int id, int rowIndex)
        {
            try
            {
                // ProductionDB'den veriyi al
                DataRow row = dt.Rows[rowIndex];

                // MainDB'ye kaydet
                using (SqlConnection con = new SqlConnection(mainCon))
                {
                    con.Open();
                    string query = @"INSERT INTO ApprovedRecords 
                                (MaterialName, Quantity, ProductionDate, ApprovalDate) 
                                VALUES (@name, @qty, @date, GETDATE())";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@name", row["MaterialName"]);
                    cmd.Parameters.AddWithValue("@qty", row["Quantity"]);
                    cmd.Parameters.AddWithValue("@date", row["ProductionDate"]);
                    cmd.ExecuteNonQuery();
                }

                // ProductionDB'de durumu güncelle
                using (SqlConnection con = new SqlConnection(productionCon))
                {
                    con.Open();
                    string query = "UPDATE ProductionRecords SET Status = 'Onaylandı' WHERE ProductionID = @id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Kayıt başarıyla onaylandı ve ana veritabanına eklendi!");
                LoadPendingRecords();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Onaylama işlemi sırasında hata oluştu: " + ex.Message);
            }
        }

        private void RejectRecord(int id, int rowIndex)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(productionCon))
                {
                    con.Open();
                    string query = "UPDATE ProductionRecords SET Status = 'Reddedildi' WHERE ProductionID = @id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Kayıt reddedildi!");
                LoadPendingRecords();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Reddetme işlemi sırasında hata oluştu: " + ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadPendingRecords();
        }
    }
}
