namespace ProjeDeneme
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnProduction = new Button();
            btnLogistics = new Button();
            btnManagement = new Button();
            lblTitle = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBoxProduction = new TextBox();
            textBoxPp = new TextBox();
            textBoxLp = new TextBox();
            textBoxLogistics = new TextBox();
            textBoxManagement = new TextBox();
            textBoxMp = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnDel1 = new Button();
            btnDel2 = new Button();
            btnDel3 = new Button();
            SuspendLayout();
            // 
            // btnProduction
            // 
            btnProduction.BackColor = Color.BurlyWood;
            btnProduction.Location = new Point(351, 320);
            btnProduction.Name = "btnProduction";
            btnProduction.Size = new Size(175, 44);
            btnProduction.TabIndex = 0;
            btnProduction.Text = "GİRİŞ";
            btnProduction.UseVisualStyleBackColor = false;
            btnProduction.Click += btnProduction_Click;
            // 
            // btnLogistics
            // 
            btnLogistics.BackColor = SystemColors.MenuHighlight;
            btnLogistics.Location = new Point(351, 530);
            btnLogistics.Name = "btnLogistics";
            btnLogistics.Size = new Size(175, 42);
            btnLogistics.TabIndex = 1;
            btnLogistics.Text = "GİRİŞ";
            btnLogistics.UseVisualStyleBackColor = false;
            btnLogistics.Click += btnLogistics_Click;
            // 
            // btnManagement
            // 
            btnManagement.BackColor = Color.Khaki;
            btnManagement.Location = new Point(357, 728);
            btnManagement.Name = "btnManagement";
            btnManagement.Size = new Size(169, 40);
            btnManagement.TabIndex = 2;
            btnManagement.Text = "GİRİŞ";
            btnManagement.UseVisualStyleBackColor = false;
            btnManagement.Click += btnManagement_Click;
            // 
            // lblTitle
            // 
            lblTitle.BackColor = SystemColors.GradientInactiveCaption;
            lblTitle.Enabled = false;
            lblTitle.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblTitle.ForeColor = Color.DarkCyan;
            lblTitle.Location = new Point(46, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(657, 109);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "GİRİŞ EKRANI";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.BurlyWood;
            textBox1.Location = new Point(46, 169);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(657, 27);
            textBox1.TabIndex = 4;
            textBox1.Text = "Üretim Modülü";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Khaki;
            textBox2.Location = new Point(46, 578);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(663, 27);
            textBox2.TabIndex = 5;
            textBox2.Text = "Yönetim Sistemi";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.MenuHighlight;
            textBox3.Location = new Point(46, 378);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(659, 27);
            textBox3.TabIndex = 5;
            textBox3.Text = "Lojistik Modülü";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxProduction
            // 
            textBoxProduction.Location = new Point(221, 214);
            textBoxProduction.Name = "textBoxProduction";
            textBoxProduction.Size = new Size(299, 27);
            textBoxProduction.TabIndex = 6;
            // 
            // textBoxPp
            // 
            textBoxPp.Location = new Point(221, 261);
            textBoxPp.Name = "textBoxPp";
            textBoxPp.PasswordChar = '*';
            textBoxPp.Size = new Size(299, 27);
            textBoxPp.TabIndex = 7;
            // 
            // textBoxLp
            // 
            textBoxLp.Location = new Point(227, 477);
            textBoxLp.Name = "textBoxLp";
            textBoxLp.PasswordChar = '*';
            textBoxLp.Size = new Size(299, 27);
            textBoxLp.TabIndex = 8;
            // 
            // textBoxLogistics
            // 
            textBoxLogistics.Location = new Point(227, 432);
            textBoxLogistics.Name = "textBoxLogistics";
            textBoxLogistics.Size = new Size(299, 27);
            textBoxLogistics.TabIndex = 9;
            // 
            // textBoxManagement
            // 
            textBoxManagement.Location = new Point(227, 627);
            textBoxManagement.Name = "textBoxManagement";
            textBoxManagement.Size = new Size(299, 27);
            textBoxManagement.TabIndex = 10;
            // 
            // textBoxMp
            // 
            textBoxMp.Location = new Point(227, 676);
            textBoxMp.Name = "textBoxMp";
            textBoxMp.PasswordChar = '*';
            textBoxMp.Size = new Size(299, 27);
            textBoxMp.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(90, 214);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 12;
            label1.Text = "USER NAME";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(90, 435);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 13;
            label2.Text = "USER NAME";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(93, 630);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 14;
            label3.Text = "USER NAME";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(90, 264);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 15;
            label4.Text = "PASSWORD";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(93, 480);
            label5.Name = "label5";
            label5.Size = new Size(87, 20);
            label5.TabIndex = 16;
            label5.Text = "PASSWORD";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(96, 679);
            label6.Name = "label6";
            label6.Size = new Size(87, 20);
            label6.TabIndex = 17;
            label6.Text = "PASSWORD";
            // 
            // btnDel1
            // 
            btnDel1.BackColor = Color.LightCoral;
            btnDel1.Location = new Point(221, 320);
            btnDel1.Name = "btnDel1";
            btnDel1.Size = new Size(124, 44);
            btnDel1.TabIndex = 18;
            btnDel1.Text = "TEMİZLE";
            btnDel1.UseVisualStyleBackColor = false;
            btnDel1.Click += btnDel1_Click;
            // 
            // btnDel2
            // 
            btnDel2.BackColor = Color.LightCoral;
            btnDel2.Location = new Point(221, 530);
            btnDel2.Name = "btnDel2";
            btnDel2.Size = new Size(124, 42);
            btnDel2.TabIndex = 19;
            btnDel2.Text = "TEMİZLE";
            btnDel2.UseVisualStyleBackColor = false;
            btnDel2.Click += btnDel2_Click;
            // 
            // btnDel3
            // 
            btnDel3.BackColor = Color.LightCoral;
            btnDel3.Location = new Point(227, 728);
            btnDel3.Name = "btnDel3";
            btnDel3.Size = new Size(124, 40);
            btnDel3.TabIndex = 20;
            btnDel3.Text = "TEMİZLE";
            btnDel3.UseVisualStyleBackColor = false;
            btnDel3.Click += btnDel3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(751, 867);
            Controls.Add(btnDel3);
            Controls.Add(btnDel2);
            Controls.Add(btnDel1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxMp);
            Controls.Add(textBoxManagement);
            Controls.Add(textBoxLogistics);
            Controls.Add(textBoxLp);
            Controls.Add(textBoxPp);
            Controls.Add(textBoxProduction);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblTitle);
            Controls.Add(btnManagement);
            Controls.Add(btnLogistics);
            Controls.Add(btnProduction);
            Cursor = Cursors.Hand;
            Name = "Form1";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnProduction;
        private Button btnLogistics;
        private Button btnManagement;
        private Label lblTitle;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBoxProduction;
        private TextBox textBoxPp;
        private TextBox textBoxLp;
        private TextBox textBoxLogistics;
        private TextBox textBoxManagement;
        private TextBox textBoxMp;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnDel1;
        private Button btnDel2;
        private Button btnDel3;
    }
}
