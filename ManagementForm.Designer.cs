namespace ProjeDeneme
{
    partial class ManagementForm
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
            dgvManagement = new DataGridView();
            lblTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvManagement).BeginInit();
            SuspendLayout();
            // 
            // dgvManagement
            // 
            dgvManagement.AllowUserToAddRows = false;
            dgvManagement.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvManagement.Location = new Point(55, 255);
            dgvManagement.Name = "dgvManagement";
            dgvManagement.ReadOnly = true;
            dgvManagement.RowHeadersWidth = 51;
            dgvManagement.Size = new Size(755, 406);
            dgvManagement.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.BackColor = SystemColors.GradientInactiveCaption;
            lblTitle.Font = new Font("Segoe UI", 40.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblTitle.ForeColor = Color.DarkCyan;
            lblTitle.Location = new Point(55, 23);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(755, 108);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "YÖNETİM SİSTEMİ";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(887, 804);
            Controls.Add(lblTitle);
            Controls.Add(dgvManagement);
            Cursor = Cursors.Hand;
            ForeColor = SystemColors.ControlText;
            Name = "ManagementForm";
            Text = "ManagementForm";
            ((System.ComponentModel.ISupportInitialize)dgvManagement).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvManagement;
        private Label lblTitle;
    }
}