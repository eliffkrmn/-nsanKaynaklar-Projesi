namespace proje.UI
{
    partial class PerformansFormu
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
            numPuan = new NumericUpDown();
            btnKaydet = new Button();
            lstPerformanslar = new ListBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)numPuan).BeginInit();
            SuspendLayout();
            // 
            // cmbPersonel
            // 
            cmbPersonel.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPersonel.FormattingEnabled = true;
            cmbPersonel.Location = new Point(238, 255);
            cmbPersonel.Name = "cmbPersonel";
            cmbPersonel.Size = new Size(151, 28);
            cmbPersonel.TabIndex = 0;
            // 
            // numPuan
            // 
            numPuan.Location = new Point(239, 301);
            numPuan.Name = "numPuan";
            numPuan.Size = new Size(150, 27);
            numPuan.TabIndex = 1;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(124, 361);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(201, 42);
            btnKaydet.TabIndex = 3;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // lstPerformanslar
            // 
            lstPerformanslar.FormattingEnabled = true;
            lstPerformanslar.Location = new Point(60, 12);
            lstPerformanslar.Name = "lstPerformanslar";
            lstPerformanslar.Size = new Size(661, 224);
            lstPerformanslar.TabIndex = 4;
            lstPerformanslar.SelectedIndexChanged += lstPerformanslar_SelectedIndexChanged_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 258);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 5;
            label1.Text = "Personel Seç";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(94, 303);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 6;
            label2.Text = "Puan ";
            // 
            // PerformansFormu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstPerformanslar);
            Controls.Add(btnKaydet);
            Controls.Add(numPuan);
            Controls.Add(cmbPersonel);
            Name = "PerformansFormu";
            Text = "PerformansFormu";
            Load += PerformansFormu_Load;
            ((System.ComponentModel.ISupportInitialize)numPuan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbPersonel;
        private NumericUpDown numPuan;
        private Button btnKaydet;
        private ListBox lstPerformanslar;
        private Label label1;
        private Label label2;
    }
}