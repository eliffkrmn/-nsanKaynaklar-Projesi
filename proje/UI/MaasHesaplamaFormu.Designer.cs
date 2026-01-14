namespace proje.UI
{
    partial class MaasHesaplamaFormu
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
            cmbPersonel = new ComboBox();
            lblTemelMaas = new Label();
            numMaas = new NumericUpDown();
            btnKaydet = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtDonem = new TextBox();
            gridMaaslar = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)numMaas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridMaaslar).BeginInit();
            SuspendLayout();
            // 
            // cmbPersonel
            // 
            cmbPersonel.FormattingEnabled = true;
            cmbPersonel.Location = new Point(600, 34);
            cmbPersonel.Name = "cmbPersonel";
            cmbPersonel.Size = new Size(151, 28);
            cmbPersonel.TabIndex = 0;
            // 
            // lblTemelMaas
            // 
            lblTemelMaas.AutoSize = true;
            lblTemelMaas.Location = new Point(442, 86);
            lblTemelMaas.Name = "lblTemelMaas";
            lblTemelMaas.Size = new Size(130, 20);
            lblTemelMaas.TabIndex = 1;
            lblTemelMaas.Text = "Mevcut Maaş: 0 TL";
            // 
            // numMaas
            // 
            numMaas.Location = new Point(601, 231);
            numMaas.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numMaas.Minimum = new decimal(new int[] { 26005, 0, 0, 0 });
            numMaas.Name = "numMaas";
            numMaas.Size = new Size(150, 27);
            numMaas.TabIndex = 2;
            numMaas.Value = new decimal(new int[] { 33030, 0, 0, 0 });
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(467, 314);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(208, 48);
            btnKaydet.TabIndex = 4;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(442, 34);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 6;
            label1.Text = "Personel Seç";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(442, 148);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 7;
            label2.Text = "Dönem(Ay/Yıl)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(447, 233);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 8;
            label3.Text = "Maaş Tutarı";
            // 
            // txtDonem
            // 
            txtDonem.Location = new Point(600, 141);
            txtDonem.Name = "txtDonem";
            txtDonem.Size = new Size(151, 27);
            txtDonem.TabIndex = 9;
            // 
            // gridMaaslar
            // 
            gridMaaslar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridMaaslar.Location = new Point(12, 34);
            gridMaaslar.Name = "gridMaaslar";
            gridMaaslar.RowHeadersWidth = 51;
            gridMaaslar.Size = new Size(349, 339);
            gridMaaslar.TabIndex = 10;
            // 
            // MaasHesaplamaFormu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gridMaaslar);
            Controls.Add(txtDonem);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnKaydet);
            Controls.Add(numMaas);
            Controls.Add(lblTemelMaas);
            Controls.Add(cmbPersonel);
            Name = "MaasHesaplamaFormu";
            Text = "MaasHesaplamaFormu";
            Load += MaasHesaplamaFormu_Load;
            ((System.ComponentModel.ISupportInitialize)numMaas).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridMaaslar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbPersonel;
        private Label lblTemelMaas;
        private NumericUpDown numMaas;
        private Button btnKaydet;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtDonem;
        private DataGridView gridMaaslar;
    }
}