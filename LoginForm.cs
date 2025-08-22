namespace ProjeDeneme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProduction_Click(object sender, EventArgs e)
        {
            ProductionForm frm = new ProductionForm();
            if (textBoxProduction.Text == "Umut" && textBoxPp.Text == "1234")
            {
                frm.Show();
            }
            else
            {
                MessageBox.Show("Kullanýcý adý ve ya þifre hatalý!!!");
            }
        }

        private void btnLogistics_Click(object sender, EventArgs e)
        {
            LogisticsForms frm = new LogisticsForms();
            if (textBoxLogistics.Text == "Faruk" && textBoxLp.Text == "1234")
            {
                frm.Show();
            }
            else
            {
                MessageBox.Show("Kullanýcý adý ve ya þifre hatalý!!!");
            }
        }

        private void btnManagement_Click(object sender, EventArgs e)
        {
            ManagementForm frm = new ManagementForm();
            if (textBoxManagement.Text == "Muhammed" && textBoxMp.Text == "1234")
            {
                frm.Show();
            }
            else
            {
                MessageBox.Show("Kullanýcý adý ve ya þifre hatalý!!!");
            }
        }

        private void btnDel1_Click(object sender, EventArgs e)
        {
            textBoxProduction.Clear();
            textBoxPp.Clear();
        }

        private void btnDel2_Click(object sender, EventArgs e)
        {
            textBoxLogistics.Clear();
            textBoxLp.Clear();
        }

        private void btnDel3_Click(object sender, EventArgs e)
        {
            textBoxManagement.Clear();
            textBoxMp.Clear();
        }

        //private void textBoxPp_TextChanged(object sender, EventArgs e)
        //{

        //}
    }
}
