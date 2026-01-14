namespace proje.UI
{
    partial class AnaMenuForm
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
            lblKarsilama = new Label();
            btnPersonelYonetimi = new Button();
            btnDepartmanYonetimi = new Button();
            btnIzinIslemleri = new Button();
            btnMaas = new Button();
            btnRaporlar = new Button();
            btnPerformans = new Button();
            btnOturumuKapat = new Button();
            SuspendLayout();
            // 
            // lblKarsilama
            // 
            lblKarsilama.AutoSize = true;
            lblKarsilama.Font = new Font("Britannic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblKarsilama.Location = new Point(12, 23);
            lblKarsilama.Name = "lblKarsilama";
            lblKarsilama.Size = new Size(79, 16);
            lblKarsilama.TabIndex = 0;
            lblKarsilama.Text = "Hoşgeldiniz";
            // 
            // btnPersonelYonetimi
            // 
            btnPersonelYonetimi.Location = new Point(320, 97);
            btnPersonelYonetimi.Name = "btnPersonelYonetimi";
            btnPersonelYonetimi.Size = new Size(160, 62);
            btnPersonelYonetimi.TabIndex = 1;
            btnPersonelYonetimi.Text = "Personel Yönetimi";
            btnPersonelYonetimi.UseVisualStyleBackColor = true;
            btnPersonelYonetimi.Click += btnPersonelYonetimi_Click;
            // 
            // btnDepartmanYonetimi
            // 
            btnDepartmanYonetimi.Location = new Point(506, 190);
            btnDepartmanYonetimi.Name = "btnDepartmanYonetimi";
            btnDepartmanYonetimi.Size = new Size(160, 62);
            btnDepartmanYonetimi.TabIndex = 2;
            btnDepartmanYonetimi.Text = "Departman Yönetimi";
            btnDepartmanYonetimi.UseVisualStyleBackColor = true;
            btnDepartmanYonetimi.Click += btnDepartmanYonetimi_Click;
            // 
            // btnIzinIslemleri
            // 
            btnIzinIslemleri.Location = new Point(320, 190);
            btnIzinIslemleri.Name = "btnIzinIslemleri";
            btnIzinIslemleri.Size = new Size(160, 62);
            btnIzinIslemleri.TabIndex = 3;
            btnIzinIslemleri.Text = "İzin İşlemleri";
            btnIzinIslemleri.UseVisualStyleBackColor = true;
            btnIzinIslemleri.Click += btnIzinIslemleri_Click;
            // 
            // btnMaas
            // 
            btnMaas.Location = new Point(139, 286);
            btnMaas.Name = "btnMaas";
            btnMaas.Size = new Size(160, 62);
            btnMaas.TabIndex = 4;
            btnMaas.Text = "Maaş Bilgileri";
            btnMaas.UseVisualStyleBackColor = true;
            btnMaas.Click += btnMaas_Click;
            // 
            // btnRaporlar
            // 
            btnRaporlar.Location = new Point(506, 286);
            btnRaporlar.Name = "btnRaporlar";
            btnRaporlar.Size = new Size(160, 62);
            btnRaporlar.TabIndex = 5;
            btnRaporlar.Text = "Raporlar";
            btnRaporlar.UseVisualStyleBackColor = true;
            btnRaporlar.Click += btnRaporlar_Click;
            // 
            // btnPerformans
            // 
            btnPerformans.Location = new Point(139, 190);
            btnPerformans.Name = "btnPerformans";
            btnPerformans.Size = new Size(160, 62);
            btnPerformans.TabIndex = 7;
            btnPerformans.Text = "Performans Yönetimi";
            btnPerformans.UseVisualStyleBackColor = true;
            btnPerformans.Click += btnPerformans_Click;
            // 
            // btnOturumuKapat
            // 
            btnOturumuKapat.Location = new Point(320, 286);
            btnOturumuKapat.Name = "btnOturumuKapat";
            btnOturumuKapat.Size = new Size(160, 62);
            btnOturumuKapat.TabIndex = 8;
            btnOturumuKapat.Text = "Oturumu Kapat";
            btnOturumuKapat.UseVisualStyleBackColor = true;
            btnOturumuKapat.Click += btnOturumuKapat_Click;
            // 
            // AnaMenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnOturumuKapat);
            Controls.Add(btnPerformans);
            Controls.Add(btnRaporlar);
            Controls.Add(btnMaas);
            Controls.Add(btnIzinIslemleri);
            Controls.Add(btnDepartmanYonetimi);
            Controls.Add(btnPersonelYonetimi);
            Controls.Add(lblKarsilama);
            Name = "AnaMenuForm";
            Text = "AnaMenuForm";
            Load += AnaMenuForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblKarsilama;
        private Button btnPersonelYonetimi;
        private Button btnDepartmanYonetimi;
        private Button btnIzinIslemleri;
        private Button btnMaas;
        private Button btnRaporlar;
        private Button btnPerformans;
        private Button btnOturumuKapat;
    }
}