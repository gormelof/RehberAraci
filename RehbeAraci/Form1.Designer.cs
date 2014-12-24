namespace RehbeAraci
{
    partial class FormReberAraci
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
            this.tbDosyaYolu = new System.Windows.Forms.TextBox();
            this.btnGozat = new System.Windows.Forms.Button();
            this.lbRehber = new System.Windows.Forms.ListBox();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.ofdVCFoku = new System.Windows.Forms.OpenFileDialog();
            this.tbAd = new System.Windows.Forms.TextBox();
            this.tbIkıncıAd = new System.Windows.Forms.TextBox();
            this.tbSoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCepNo = new System.Windows.Forms.TextBox();
            this.btnTekeIndır = new System.Windows.Forms.Button();
            this.btnDısaAktar = new System.Windows.Forms.Button();
            this.btnGozat2 = new System.Windows.Forms.Button();
            this.tbDisYol = new System.Windows.Forms.TextBox();
            this.fbdVCFdisaAktar = new System.Windows.Forms.FolderBrowserDialog();
            this.btnEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbDosyaYolu
            // 
            this.tbDosyaYolu.Location = new System.Drawing.Point(13, 13);
            this.tbDosyaYolu.Name = "tbDosyaYolu";
            this.tbDosyaYolu.Size = new System.Drawing.Size(393, 20);
            this.tbDosyaYolu.TabIndex = 1;
            // 
            // btnGozat
            // 
            this.btnGozat.Location = new System.Drawing.Point(412, 11);
            this.btnGozat.Name = "btnGozat";
            this.btnGozat.Size = new System.Drawing.Size(223, 23);
            this.btnGozat.TabIndex = 2;
            this.btnGozat.Text = "Gözat";
            this.btnGozat.UseVisualStyleBackColor = true;
            this.btnGozat.Click += new System.EventHandler(this.btnGozat_Click);
            // 
            // lbRehber
            // 
            this.lbRehber.FormattingEnabled = true;
            this.lbRehber.Location = new System.Drawing.Point(13, 40);
            this.lbRehber.Name = "lbRehber";
            this.lbRehber.Size = new System.Drawing.Size(393, 407);
            this.lbRehber.TabIndex = 3;
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Location = new System.Drawing.Point(412, 147);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(223, 23);
            this.btnDuzenle.TabIndex = 4;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(412, 205);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(223, 23);
            this.btnSil.TabIndex = 5;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // ofdVCFoku
            // 
            this.ofdVCFoku.FileName = "openFileDialog1";
            // 
            // tbAd
            // 
            this.tbAd.Location = new System.Drawing.Point(493, 40);
            this.tbAd.Name = "tbAd";
            this.tbAd.Size = new System.Drawing.Size(142, 20);
            this.tbAd.TabIndex = 6;
            // 
            // tbIkıncıAd
            // 
            this.tbIkıncıAd.Location = new System.Drawing.Point(493, 67);
            this.tbIkıncıAd.Name = "tbIkıncıAd";
            this.tbIkıncıAd.Size = new System.Drawing.Size(142, 20);
            this.tbIkıncıAd.TabIndex = 7;
            // 
            // tbSoyad
            // 
            this.tbSoyad.Location = new System.Drawing.Point(493, 94);
            this.tbSoyad.Name = "tbSoyad";
            this.tbSoyad.Size = new System.Drawing.Size(142, 20);
            this.tbSoyad.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(416, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(416, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "İkinci Ad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(416, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Soyad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(416, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Cep No:";
            // 
            // tbCepNo
            // 
            this.tbCepNo.Location = new System.Drawing.Point(493, 121);
            this.tbCepNo.Name = "tbCepNo";
            this.tbCepNo.Size = new System.Drawing.Size(142, 20);
            this.tbCepNo.TabIndex = 13;
            // 
            // btnTekeIndır
            // 
            this.btnTekeIndır.Location = new System.Drawing.Point(412, 234);
            this.btnTekeIndır.Name = "btnTekeIndır";
            this.btnTekeIndır.Size = new System.Drawing.Size(223, 23);
            this.btnTekeIndır.TabIndex = 14;
            this.btnTekeIndır.Text = "Kayıtları Teke İndir";
            this.btnTekeIndır.UseVisualStyleBackColor = true;
            this.btnTekeIndır.Click += new System.EventHandler(this.btnTekeIndır_Click);
            // 
            // btnDısaAktar
            // 
            this.btnDısaAktar.Location = new System.Drawing.Point(412, 424);
            this.btnDısaAktar.Name = "btnDısaAktar";
            this.btnDısaAktar.Size = new System.Drawing.Size(223, 23);
            this.btnDısaAktar.TabIndex = 15;
            this.btnDısaAktar.Text = "Rehberi Dışa Aktar";
            this.btnDısaAktar.UseVisualStyleBackColor = true;
            this.btnDısaAktar.Click += new System.EventHandler(this.btnDısaAktar_Click);
            // 
            // btnGozat2
            // 
            this.btnGozat2.Location = new System.Drawing.Point(559, 396);
            this.btnGozat2.Name = "btnGozat2";
            this.btnGozat2.Size = new System.Drawing.Size(75, 23);
            this.btnGozat2.TabIndex = 16;
            this.btnGozat2.Text = "Gözat";
            this.btnGozat2.UseVisualStyleBackColor = true;
            this.btnGozat2.Click += new System.EventHandler(this.btnGozat2_Click);
            // 
            // tbDisYol
            // 
            this.tbDisYol.Location = new System.Drawing.Point(412, 398);
            this.tbDisYol.Name = "tbDisYol";
            this.tbDisYol.Size = new System.Drawing.Size(141, 20);
            this.tbDisYol.TabIndex = 17;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(412, 176);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(221, 23);
            this.btnEkle.TabIndex = 18;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // FormReberAraci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 455);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.tbDisYol);
            this.Controls.Add(this.btnGozat2);
            this.Controls.Add(this.btnDısaAktar);
            this.Controls.Add(this.btnTekeIndır);
            this.Controls.Add(this.tbCepNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSoyad);
            this.Controls.Add(this.tbIkıncıAd);
            this.Controls.Add(this.tbAd);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.lbRehber);
            this.Controls.Add(this.btnGozat);
            this.Controls.Add(this.tbDosyaYolu);
            this.Name = "FormReberAraci";
            this.Text = "Rehber Aracı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDosyaYolu;
        private System.Windows.Forms.Button btnGozat;
        private System.Windows.Forms.ListBox lbRehber;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.OpenFileDialog ofdVCFoku;
        private System.Windows.Forms.TextBox tbAd;
        private System.Windows.Forms.TextBox tbIkıncıAd;
        private System.Windows.Forms.TextBox tbSoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCepNo;
        private System.Windows.Forms.Button btnTekeIndır;
        private System.Windows.Forms.Button btnDısaAktar;
        private System.Windows.Forms.Button btnGozat2;
        private System.Windows.Forms.TextBox tbDisYol;
        private System.Windows.Forms.FolderBrowserDialog fbdVCFdisaAktar;
        private System.Windows.Forms.Button btnEkle;
    }
}

