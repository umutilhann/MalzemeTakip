namespace ProjeDeneme
{
    partial class ProductionForm
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
            btnSave = new Button();
            txtMaterial = new TextBox();
            nudQuantity = new NumericUpDown();
            dtpProductionDate = new DateTimePicker();
            dataGridView1 = new DataGridView();
            lblMaterial = new Label();
            lblQuantity = new Label();
            lblDate = new Label();
            label1 = new Label();
            buttonDel = new Button();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Lime;
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSave.Location = new Point(456, 489);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(218, 68);
            btnSave.TabIndex = 0;
            btnSave.Text = "KAYDET";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtMaterial
            // 
            txtMaterial.Location = new Point(456, 268);
            txtMaterial.Name = "txtMaterial";
            txtMaterial.PlaceholderText = "Malzeme Adı";
            txtMaterial.Size = new Size(218, 27);
            txtMaterial.TabIndex = 1;
            // 
            // nudQuantity
            // 
            nudQuantity.Location = new Point(456, 348);
            nudQuantity.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(218, 27);
            nudQuantity.TabIndex = 2;
            nudQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // dtpProductionDate
            // 
            dtpProductionDate.Format = DateTimePickerFormat.Short;
            dtpProductionDate.Location = new Point(456, 414);
            dtpProductionDate.Name = "dtpProductionDate";
            dtpProductionDate.Size = new Size(218, 27);
            dtpProductionDate.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 644);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(880, 164);
            dataGridView1.TabIndex = 4;
            dataGridView1.Visible = false;
            // 
            // lblMaterial
            // 
            lblMaterial.AutoSize = true;
            lblMaterial.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblMaterial.Location = new Point(222, 264);
            lblMaterial.Name = "lblMaterial";
            lblMaterial.Size = new Size(103, 28);
            lblMaterial.TabIndex = 5;
            lblMaterial.Text = "Malzeme:";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblQuantity.Location = new Point(222, 346);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(81, 28);
            lblQuantity.TabIndex = 6;
            lblQuantity.Text = "Miktar:";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblDate.Location = new Point(222, 415);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(141, 28);
            lblDate.TabIndex = 7;
            lblDate.Text = "Üretim Tarihi:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.GradientInactiveCaption;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.DarkCyan;
            label1.Location = new Point(130, 44);
            label1.Name = "label1";
            label1.Size = new Size(661, 108);
            label1.TabIndex = 8;
            label1.Text = "ÜRETİCİ EKRANI";
            // 
            // buttonDel
            // 
            buttonDel.BackColor = Color.LightCoral;
            buttonDel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            buttonDel.Location = new Point(222, 489);
            buttonDel.Name = "buttonDel";
            buttonDel.Size = new Size(227, 68);
            buttonDel.TabIndex = 9;
            buttonDel.Text = "SİL";
            buttonDel.UseVisualStyleBackColor = false;
            buttonDel.Click += buttonDel_Click;
            // 
            // ProductionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(916, 805);
            Controls.Add(buttonDel);
            Controls.Add(label1);
            Controls.Add(lblDate);
            Controls.Add(lblQuantity);
            Controls.Add(lblMaterial);
            Controls.Add(dataGridView1);
            Controls.Add(dtpProductionDate);
            Controls.Add(nudQuantity);
            Controls.Add(txtMaterial);
            Controls.Add(btnSave);
            Cursor = Cursors.Hand;
            Name = "ProductionForm";
            Text = "ProductionForm";
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private TextBox txtMaterial;
        private NumericUpDown nudQuantity;
        private DateTimePicker dtpProductionDate;
        private DataGridView dataGridView1;
        private Label lblMaterial;
        private Label lblQuantity;
        private Label lblDate;
        private Label label1;
        private Button buttonDel;
    }
}