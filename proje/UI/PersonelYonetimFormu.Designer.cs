namespace proje.UI
{
    partial class PersonelYonetimFormu
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
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtKullaniciAdi = new TextBox();
            txtSifre = new TextBox();
            cmbDepartman = new ComboBox();
            cmbRol = new ComboBox();
            btnKaydet = new Button();
            numMaas = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            gridPersoneller = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)numMaas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridPersoneller).BeginInit();
            SuspendLayout();
            // 
            // txtAd
            // 
            txtAd.Location = new Point(203, 237);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(151, 27);
            txtAd.TabIndex = 1;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(204, 292);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(151, 27);
            txtSoyad.TabIndex = 2;
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(204, 347);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(151, 27);
            txtKullaniciAdi.TabIndex = 3;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(204, 410);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(150, 27);
            txtSifre.TabIndex = 4;
            // 
            // cmbDepartman
            // 
            cmbDepartman.FormattingEnabled = true;
            cmbDepartman.Items.AddRange(new object[] { "İşletme", "İnsan Kaynakları ", "IT", "Pazarlama" });
            cmbDepartman.Location = new Point(540, 237);
            cmbDepartman.Name = "cmbDepartman";
            cmbDepartman.Size = new Size(151, 28);
            cmbDepartman.TabIndex = 5;
            // 
            // cmbRol
            // 
            cmbRol.FormattingEnabled = true;
            cmbRol.Items.AddRange(new object[] { "Yönetici", "İK Personeli", "Normal Kullanıcı" });
            cmbRol.Location = new Point(540, 292);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(151, 28);
            cmbRol.TabIndex = 6;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(446, 432);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(230, 49);
            btnKaydet.TabIndex = 7;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // numMaas
            // 
            numMaas.Location = new Point(540, 361);
            numMaas.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numMaas.Minimum = new decimal(new int[] { 26005, 0, 0, 0 });
            numMaas.Name = "numMaas";
            numMaas.Size = new Size(150, 27);
            numMaas.TabIndex = 8;
            numMaas.Value = new decimal(new int[] { 33030, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(90, 237);
            label1.Name = "label1";
            label1.Size = new Size(28, 20);
            label1.TabIndex = 9;
            label1.Text = "Ad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(90, 292);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 10;
            label2.Text = "Soyad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(90, 347);
            label3.Name = "label3";
            label3.Size = new Size(92, 20);
            label3.TabIndex = 11;
            label3.Text = "Kullanıcı Adı";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(90, 410);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 12;
            label4.Text = "Parola";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(421, 240);
            label5.Name = "label5";
            label5.Size = new Size(84, 20);
            label5.TabIndex = 13;
            label5.Text = "Departman";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(421, 299);
            label6.Name = "label6";
            label6.Size = new Size(31, 20);
            label6.TabIndex = 14;
            label6.Text = "Rol";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(421, 363);
            label7.Name = "label7";
            label7.Size = new Size(69, 20);
            label7.TabIndex = 15;
            label7.Text = "Maaş(TL)";
            // 
            // gridPersoneller
            // 
            gridPersoneller.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridPersoneller.Location = new Point(163, 2);
            gridPersoneller.Name = "gridPersoneller";
            gridPersoneller.RowHeadersWidth = 51;
            gridPersoneller.Size = new Size(501, 216);
            gridPersoneller.TabIndex = 16;
            // 
            // PersonelYonetimFormu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 486);
            Controls.Add(gridPersoneller);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numMaas);
            Controls.Add(btnKaydet);
            Controls.Add(cmbRol);
            Controls.Add(cmbDepartman);
            Controls.Add(txtSifre);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Name = "PersonelYonetimFormu";
            Text = "PersonelYonetimFormu";
            ((System.ComponentModel.ISupportInitialize)numMaas).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridPersoneller).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtAd;
        private TextBox txtSoyad;
        private TextBox txtKullaniciAdi;
        private TextBox txtSifre;
        private ComboBox cmbDepartman;
        private ComboBox cmbRol;
        private Button btnKaydet;
        private NumericUpDown numMaas;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private DataGridView gridPersoneller;
    }
}