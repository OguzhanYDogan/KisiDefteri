namespace KisiDefteri
{
    partial class DuzenleForm
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
            label1 = new Label();
            label2 = new Label();
            btnKaydet = new Button();
            btnIptal = new Button();
            SuspendLayout();
            // 
            // txtAd
            // 
            txtAd.Location = new Point(45, 119);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(300, 31);
            txtAd.TabIndex = 0;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(45, 209);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(300, 31);
            txtSoyad.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 82);
            label1.Name = "label1";
            label1.Size = new Size(35, 25);
            label1.TabIndex = 2;
            label1.Text = "Ad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 167);
            label2.Name = "label2";
            label2.Size = new Size(62, 25);
            label2.TabIndex = 3;
            label2.Text = "Soyad";
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(45, 277);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(133, 49);
            btnKaydet.TabIndex = 4;
            btnKaydet.Text = "KAYDET";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnIptal
            // 
            btnIptal.Location = new Point(212, 277);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(133, 49);
            btnIptal.TabIndex = 5;
            btnIptal.Text = "İPTAL";
            btnIptal.UseVisualStyleBackColor = true;
            btnIptal.Click += btnIptal_Click;
            // 
            // DuzenleForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 386);
            Controls.Add(btnIptal);
            Controls.Add(btnKaydet);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Name = "DuzenleForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Düzenle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAd;
        private TextBox txtSoyad;
        private Label label1;
        private Label label2;
        private Button btnKaydet;
        private Button btnIptal;
    }
}