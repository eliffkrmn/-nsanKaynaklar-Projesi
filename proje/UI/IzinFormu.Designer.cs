namespace proje.UI
{
    partial class IzinFormu
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
            dtpBaslangic = new DateTimePicker();
            dtpBitis = new DateTimePicker();
            txtAciklama = new TextBox();
            btnTalepEt = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            gridIzinler = new DataGridView();
            grpTalepOlustur = new GroupBox();
            btnReddet = new Button();
            btnOnayla = new Button();
            ((System.ComponentModel.ISupportInitialize)gridIzinler).BeginInit();
            grpTalepOlustur.SuspendLayout();
            SuspendLayout();
            // 
            // dtpBaslangic
            // 
            dtpBaslangic.Location = new Point(241, 33);
            dtpBaslangic.Name = "dtpBaslangic";
            dtpBaslangic.Size = new Size(250, 27);
            dtpBaslangic.TabIndex = 0;
            // 
            // dtpBitis
            // 
            dtpBitis.Location = new Point(241, 85);
            dtpBitis.Name = "dtpBitis";
            dtpBitis.Size = new Size(250, 27);
            dtpBitis.TabIndex = 1;
            // 
            // txtAciklama
            // 
            txtAciklama.Location = new Point(241, 127);
            txtAciklama.Multiline = true;
            txtAciklama.Name = "txtAciklama";
            txtAciklama.Size = new Size(250, 34);
            txtAciklama.TabIndex = 2;
            // 
            // btnTalepEt
            // 
            btnTalepEt.Location = new Point(574, 53);
            btnTalepEt.Name = "btnTalepEt";
            btnTalepEt.Size = new Size(106, 85);
            btnTalepEt.TabIndex = 4;
            btnTalepEt.Text = "İzin Talebi Kaydet";
            btnTalepEt.UseVisualStyleBackColor = true;
            btnTalepEt.Click += btnTalepEt_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 33);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 5;
            label1.Text = "Başlangıç";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(76, 85);
            label2.Name = "label2";
            label2.Size = new Size(37, 20);
            label2.TabIndex = 6;
            label2.Text = "Bitiş";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(76, 130);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 7;
            label3.Text = "Açıklama";
            // 
            // gridIzinler
            // 
            gridIzinler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridIzinler.Location = new Point(42, 194);
            gridIzinler.MultiSelect = false;
            gridIzinler.Name = "gridIzinler";
            gridIzinler.RowHeadersWidth = 51;
            gridIzinler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridIzinler.Size = new Size(499, 244);
            gridIzinler.TabIndex = 8;
            gridIzinler.CellContentClick += gridIzinler_CellContentClick;
            // 
            // grpTalepOlustur
            // 
            grpTalepOlustur.Controls.Add(btnReddet);
            grpTalepOlustur.Controls.Add(label1);
            grpTalepOlustur.Controls.Add(btnOnayla);
            grpTalepOlustur.Controls.Add(dtpBaslangic);
            grpTalepOlustur.Controls.Add(gridIzinler);
            grpTalepOlustur.Controls.Add(btnTalepEt);
            grpTalepOlustur.Controls.Add(label3);
            grpTalepOlustur.Controls.Add(txtAciklama);
            grpTalepOlustur.Controls.Add(label2);
            grpTalepOlustur.Controls.Add(dtpBitis);
            grpTalepOlustur.Location = new Point(-3, 0);
            grpTalepOlustur.Name = "grpTalepOlustur";
            grpTalepOlustur.Size = new Size(807, 452);
            grpTalepOlustur.TabIndex = 9;
            grpTalepOlustur.TabStop = false;
            grpTalepOlustur.Text = "İzin Talep Formu";
            // 
            // btnReddet
            // 
            btnReddet.BackColor = Color.Red;
            btnReddet.Location = new Point(574, 343);
            btnReddet.Name = "btnReddet";
            btnReddet.Size = new Size(94, 58);
            btnReddet.TabIndex = 10;
            btnReddet.Text = "REDDET";
            btnReddet.UseVisualStyleBackColor = false;
            btnReddet.Click += btnReddet_Click;
            // 
            // btnOnayla
            // 
            btnOnayla.BackColor = Color.Lime;
            btnOnayla.Location = new Point(574, 238);
            btnOnayla.Name = "btnOnayla";
            btnOnayla.Size = new Size(94, 58);
            btnOnayla.TabIndex = 9;
            btnOnayla.Text = "ONAYLA";
            btnOnayla.UseVisualStyleBackColor = false;
            btnOnayla.Click += btnOnayla_Click;
            // 
            // IzinFormu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grpTalepOlustur);
            Name = "IzinFormu";
            Text = "IzinFormu";
            Load += IzinFormu_Load;
            ((System.ComponentModel.ISupportInitialize)gridIzinler).EndInit();
            grpTalepOlustur.ResumeLayout(false);
            grpTalepOlustur.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker dtpBaslangic;
        private DateTimePicker dtpBitis;
        private TextBox txtAciklama;
        private Button btnTalepEt;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView gridIzinler;
        private GroupBox grpTalepOlustur;
        private Button btnReddet;
        private Button btnOnayla;
    }
}