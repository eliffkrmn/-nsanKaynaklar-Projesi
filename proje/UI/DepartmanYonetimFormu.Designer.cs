namespace proje.UI
{
    partial class DepartmanYonetimFormu
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
            txtAciklama = new TextBox();
            btnKaydet = new Button();
            label1 = new Label();
            label2 = new Label();
            gridDepartmanlar = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gridDepartmanlar).BeginInit();
            SuspendLayout();
            // 
            // txtAd
            // 
            txtAd.Location = new Point(168, 37);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(195, 27);
            txtAd.TabIndex = 1;
            // 
            // txtAciklama
            // 
            txtAciklama.Location = new Point(168, 99);
            txtAciklama.Name = "txtAciklama";
            txtAciklama.Size = new Size(195, 27);
            txtAciklama.TabIndex = 2;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(74, 170);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(188, 47);
            btnKaydet.TabIndex = 3;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 37);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 4;
            label1.Text = "Departman Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 99);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 5;
            label2.Text = "Açıklama";
            // 
            // gridDepartmanlar
            // 
            gridDepartmanlar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridDepartmanlar.Location = new Point(405, 21);
            gridDepartmanlar.Name = "gridDepartmanlar";
            gridDepartmanlar.RowHeadersWidth = 51;
            gridDepartmanlar.Size = new Size(383, 339);
            gridDepartmanlar.TabIndex = 6;
            // 
            // DepartmanYonetimFormu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gridDepartmanlar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnKaydet);
            Controls.Add(txtAciklama);
            Controls.Add(txtAd);
            Name = "DepartmanYonetimFormu";
            Text = "DepartmanYonetimFormu";
            Load += DepartmanYonetimFormu_Load;
            ((System.ComponentModel.ISupportInitialize)gridDepartmanlar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtAd;
        private TextBox txtAciklama;
        private Button btnKaydet;
        private Label label1;
        private Label label2;
        private DataGridView gridDepartmanlar;
    }
}