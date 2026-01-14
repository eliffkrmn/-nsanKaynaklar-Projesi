namespace proje.UI
{
    partial class RaporFormu
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
            lstRapor = new ListBox();
            btnPersonelRapor = new Button();
            btnIzinRapor = new Button();
            btnDepartmanRapor = new Button();
            btnTemizle = new Button();
            SuspendLayout();
            // 
            // lstRapor
            // 
            lstRapor.FormattingEnabled = true;
            lstRapor.Location = new Point(44, 12);
            lstRapor.Name = "lstRapor";
            lstRapor.Size = new Size(689, 284);
            lstRapor.TabIndex = 0;
            lstRapor.SelectedIndexChanged += lstRapor_SelectedIndexChanged;
            // 
            // btnPersonelRapor
            // 
            btnPersonelRapor.Location = new Point(44, 319);
            btnPersonelRapor.Name = "btnPersonelRapor";
            btnPersonelRapor.Size = new Size(156, 61);
            btnPersonelRapor.TabIndex = 1;
            btnPersonelRapor.Text = "Personel Raporu";
            btnPersonelRapor.UseVisualStyleBackColor = true;
            btnPersonelRapor.Click += btnPersonelRapor_Click;
            // 
            // btnIzinRapor
            // 
            btnIzinRapor.Location = new Point(577, 319);
            btnIzinRapor.Name = "btnIzinRapor";
            btnIzinRapor.Size = new Size(156, 61);
            btnIzinRapor.TabIndex = 2;
            btnIzinRapor.Text = "İzin Raporu";
            btnIzinRapor.UseVisualStyleBackColor = true;
            btnIzinRapor.Click += btnIzinRapor_Click;
            // 
            // btnDepartmanRapor
            // 
            btnDepartmanRapor.Location = new Point(306, 319);
            btnDepartmanRapor.Name = "btnDepartmanRapor";
            btnDepartmanRapor.Size = new Size(156, 61);
            btnDepartmanRapor.TabIndex = 3;
            btnDepartmanRapor.Text = "Departman Raporu";
            btnDepartmanRapor.UseVisualStyleBackColor = true;
            btnDepartmanRapor.Click += btnDepartmanRapor_Click;
            // 
            // btnTemizle
            // 
            btnTemizle.Location = new Point(250, 406);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(285, 41);
            btnTemizle.TabIndex = 4;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = true;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // RaporFormu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnTemizle);
            Controls.Add(btnDepartmanRapor);
            Controls.Add(btnIzinRapor);
            Controls.Add(btnPersonelRapor);
            Controls.Add(lstRapor);
            Name = "RaporFormu";
            Text = "RaporFormu";
            Load += RaporFormu_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstRapor;
        private Button btnPersonelRapor;
        private Button btnIzinRapor;
        private Button btnDepartmanRapor;
        private Button btnTemizle;
    }
}