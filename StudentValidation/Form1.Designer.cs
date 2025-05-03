namespace StudentValidation
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
            lblAd = new Label();
            lblSoyad = new Label();
            lblBolum = new Label();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtBolum = new TextBox();
            btnBilgileriDogrula = new Button();
            lblSonuc = new Label();
            SuspendLayout();
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Location = new Point(54, 48);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(139, 25);
            lblAd.TabIndex = 0;
            lblAd.Text = "Öğrencinin Adı :";
            lblAd.Click += lblAd_Click;
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.Location = new Point(54, 112);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(166, 25);
            lblSoyad.TabIndex = 1;
            lblSoyad.Text = "Öğrencinin Soyadı :";
            // 
            // lblBolum
            // 
            lblBolum.AutoSize = true;
            lblBolum.Location = new Point(47, 190);
            lblBolum.Name = "lblBolum";
            lblBolum.Size = new Size(173, 25);
            lblBolum.TabIndex = 2;
            lblBolum.Text = "Öğrencinin Bölümü :";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(275, 45);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(177, 31);
            txtAd.TabIndex = 3;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(273, 112);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(179, 31);
            txtSoyad.TabIndex = 4;
            // 
            // txtBolum
            // 
            txtBolum.Location = new Point(273, 190);
            txtBolum.Name = "txtBolum";
            txtBolum.Size = new Size(179, 31);
            txtBolum.TabIndex = 5;
            // 
            // btnBilgileriDogrula
            // 
            btnBilgileriDogrula.Location = new Point(532, 367);
            btnBilgileriDogrula.Name = "btnBilgileriDogrula";
            btnBilgileriDogrula.Size = new Size(234, 58);
            btnBilgileriDogrula.TabIndex = 6;
            btnBilgileriDogrula.Text = "BİLGİLERİ DOĞRULA";
            btnBilgileriDogrula.UseVisualStyleBackColor = true;
            btnBilgileriDogrula.Click += btnDogrula_Click;
            // 
            // lblSonuc
            // 
            lblSonuc.Location = new Point(26, 249);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new Size(284, 176);
            lblSonuc.TabIndex = 7;
            lblSonuc.Text = "SONUÇ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblSonuc);
            Controls.Add(btnBilgileriDogrula);
            Controls.Add(txtBolum);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(lblBolum);
            Controls.Add(lblSoyad);
            Controls.Add(lblAd);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAd;
        private Label lblSoyad;
        private Label lblBolum;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private TextBox txtBolum;
        private Button btnBilgileriDogrula;
        private Label lblSonuc;
    }
}
