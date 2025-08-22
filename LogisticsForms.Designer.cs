namespace ProjeDeneme
{
    partial class LogisticsForms
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
            dgvLogistics = new DataGridView();
            lblPending = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvLogistics).BeginInit();
            SuspendLayout();
            // 
            // dgvLogistics
            // 
            dgvLogistics.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLogistics.Location = new Point(52, 260);
            dgvLogistics.Name = "dgvLogistics";
            dgvLogistics.RowHeadersWidth = 51;
            dgvLogistics.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLogistics.Size = new Size(662, 397);
            dgvLogistics.TabIndex = 2;
            // 
            // lblPending
            // 
            lblPending.BackColor = SystemColors.GradientInactiveCaption;
            lblPending.Font = new Font("Segoe UI", 40.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblPending.ForeColor = Color.Red;
            lblPending.Location = new Point(0, 43);
            lblPending.Name = "lblPending";
            lblPending.Size = new Size(785, 146);
            lblPending.TabIndex = 3;
            lblPending.Text = "Onay Beklenen Kayıtlar";
            lblPending.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LogisticsForms
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(785, 803);
            Controls.Add(lblPending);
            Controls.Add(dgvLogistics);
            Cursor = Cursors.Hand;
            ForeColor = SystemColors.MenuText;
            Name = "LogisticsForms";
            Text = "LogisticsForms";
            ((System.ComponentModel.ISupportInitialize)dgvLogistics).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvLogistics;
        private Label lblPending;
    }
}