namespace KisiDefteri
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
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            btnEkle = new Button();
            label1 = new Label();
            label2 = new Label();
            lstKisiler = new ListBox();
            btnDuzenle = new Button();
            btnSil = new Button();
            btnYukari = new Button();
            btnAsagi = new Button();
            SuspendLayout();
            // 
            // txtAd
            // 
            txtAd.Location = new Point(27, 64);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(219, 31);
            txtAd.TabIndex = 0;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(266, 64);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(221, 31);
            txtSoyad.TabIndex = 1;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(506, 48);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(146, 47);
            btnEkle.TabIndex = 2;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 26);
            label1.Name = "label1";
            label1.Size = new Size(35, 25);
            label1.TabIndex = 3;
            label1.Text = "Ad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(266, 26);
            label2.Name = "label2";
            label2.Size = new Size(62, 25);
            label2.TabIndex = 3;
            label2.Text = "Soyad";
            // 
            // lstKisiler
            // 
            lstKisiler.DisplayMember = "TamAd";
            lstKisiler.FormattingEnabled = true;
            lstKisiler.ItemHeight = 25;
            lstKisiler.Location = new Point(27, 122);
            lstKisiler.Name = "lstKisiler";
            lstKisiler.Size = new Size(625, 604);
            lstKisiler.TabIndex = 3;
            lstKisiler.KeyDown += lstKisiler_KeyDown;
            // 
            // btnDuzenle
            // 
            btnDuzenle.Location = new Point(27, 744);
            btnDuzenle.Name = "btnDuzenle";
            btnDuzenle.Size = new Size(184, 47);
            btnDuzenle.TabIndex = 4;
            btnDuzenle.Text = "DÜZENLE";
            btnDuzenle.UseVisualStyleBackColor = true;
            btnDuzenle.Click += btnDuzenle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(243, 744);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(184, 47);
            btnSil.TabIndex = 5;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnYukari
            // 
            btnYukari.BackgroundImage = Properties.Resources.up;
            btnYukari.BackgroundImageLayout = ImageLayout.Zoom;
            btnYukari.Location = new Point(669, 302);
            btnYukari.Name = "btnYukari";
            btnYukari.Size = new Size(50, 50);
            btnYukari.TabIndex = 6;
            btnYukari.UseVisualStyleBackColor = true;
            btnYukari.Click += btnYukari_Click;
            // 
            // btnAsagi
            // 
            btnAsagi.BackgroundImage = Properties.Resources.down;
            btnAsagi.BackgroundImageLayout = ImageLayout.Zoom;
            btnAsagi.Location = new Point(669, 370);
            btnAsagi.Name = "btnAsagi";
            btnAsagi.Size = new Size(50, 50);
            btnAsagi.TabIndex = 7;
            btnAsagi.UseVisualStyleBackColor = true;
            btnAsagi.Click += btnAsagi_Click;
            // 
            // Form1
            // 
            AcceptButton = btnEkle;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(740, 803);
            Controls.Add(btnAsagi);
            Controls.Add(btnYukari);
            Controls.Add(btnSil);
            Controls.Add(btnDuzenle);
            Controls.Add(lstKisiler);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnEkle);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Name = "Form1";
            Text = "3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAd;
        private TextBox txtSoyad;
        private Button btnEkle;
        private Label label1;
        private Label label2;
        private ListBox lstKisiler;
        private Button btnDuzenle;
        private Button btnSil;
        private Button btnYukari;
        private Button btnAsagi;
    }
}