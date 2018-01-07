namespace Sinema_Otomasyonu
{
    partial class Form1
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
            this.btnBiletAl = new System.Windows.Forms.Button();
            this.txtKoltukNo = new System.Windows.Forms.TextBox();
            this.lblKoltukNo = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtListele = new System.Windows.Forms.TextBox();
            this.btnArama = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.lblAramaAd = new System.Windows.Forms.Label();
            this.lblAramaSoyad = new System.Windows.Forms.Label();
            this.txtAramaAd = new System.Windows.Forms.TextBox();
            this.txtAramaSoyad = new System.Windows.Forms.TextBox();
            this.lblSilKoltukNo = new System.Windows.Forms.Label();
            this.lblSilAd = new System.Windows.Forms.Label();
            this.lblSilSoyad = new System.Windows.Forms.Label();
            this.txtSilKoltukNo = new System.Windows.Forms.TextBox();
            this.txtSilAd = new System.Windows.Forms.TextBox();
            this.txtSilSoyad = new System.Windows.Forms.TextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnBosKoltukListele = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBiletAl
            // 
            this.btnBiletAl.Location = new System.Drawing.Point(109, 92);
            this.btnBiletAl.Name = "btnBiletAl";
            this.btnBiletAl.Size = new System.Drawing.Size(75, 23);
            this.btnBiletAl.TabIndex = 0;
            this.btnBiletAl.Text = "Bilet Al";
            this.btnBiletAl.UseVisualStyleBackColor = true;
            this.btnBiletAl.Click += new System.EventHandler(this.btnBiletAl_Click);
            // 
            // txtKoltukNo
            // 
            this.txtKoltukNo.Location = new System.Drawing.Point(98, 12);
            this.txtKoltukNo.Name = "txtKoltukNo";
            this.txtKoltukNo.Size = new System.Drawing.Size(100, 20);
            this.txtKoltukNo.TabIndex = 1;
            // 
            // lblKoltukNo
            // 
            this.lblKoltukNo.AutoSize = true;
            this.lblKoltukNo.Location = new System.Drawing.Point(27, 15);
            this.lblKoltukNo.Name = "lblKoltukNo";
            this.lblKoltukNo.Size = new System.Drawing.Size(57, 13);
            this.lblKoltukNo.TabIndex = 2;
            this.lblKoltukNo.Text = "Koltuk No:";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(61, 40);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(23, 13);
            this.lblAd.TabIndex = 3;
            this.lblAd.Text = "Ad:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(98, 40);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 20);
            this.txtAd.TabIndex = 4;
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(49, 69);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(40, 13);
            this.lblSoyad.TabIndex = 5;
            this.lblSoyad.Text = "Soyad:";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(98, 66);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtSoyad.TabIndex = 6;
            // 
            // txtListele
            // 
            this.txtListele.Location = new System.Drawing.Point(303, 15);
            this.txtListele.Multiline = true;
            this.txtListele.Name = "txtListele";
            this.txtListele.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtListele.Size = new System.Drawing.Size(439, 387);
            this.txtListele.TabIndex = 7;
            // 
            // btnArama
            // 
            this.btnArama.Location = new System.Drawing.Point(109, 210);
            this.btnArama.Name = "btnArama";
            this.btnArama.Size = new System.Drawing.Size(75, 23);
            this.btnArama.TabIndex = 8;
            this.btnArama.Text = "Ara";
            this.btnArama.UseVisualStyleBackColor = true;
            this.btnArama.Click += new System.EventHandler(this.btnArama_Click);
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(319, 408);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(173, 23);
            this.btnListele.TabIndex = 9;
            this.btnListele.Text = "Dolu Koltukları Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // lblAramaAd
            // 
            this.lblAramaAd.AutoSize = true;
            this.lblAramaAd.Location = new System.Drawing.Point(49, 150);
            this.lblAramaAd.Name = "lblAramaAd";
            this.lblAramaAd.Size = new System.Drawing.Size(20, 13);
            this.lblAramaAd.TabIndex = 10;
            this.lblAramaAd.Text = "Ad";
            // 
            // lblAramaSoyad
            // 
            this.lblAramaSoyad.AutoSize = true;
            this.lblAramaSoyad.Location = new System.Drawing.Point(49, 184);
            this.lblAramaSoyad.Name = "lblAramaSoyad";
            this.lblAramaSoyad.Size = new System.Drawing.Size(37, 13);
            this.lblAramaSoyad.TabIndex = 11;
            this.lblAramaSoyad.Text = "Soyad";
            // 
            // txtAramaAd
            // 
            this.txtAramaAd.Location = new System.Drawing.Point(98, 147);
            this.txtAramaAd.Name = "txtAramaAd";
            this.txtAramaAd.Size = new System.Drawing.Size(100, 20);
            this.txtAramaAd.TabIndex = 12;
            // 
            // txtAramaSoyad
            // 
            this.txtAramaSoyad.Location = new System.Drawing.Point(98, 184);
            this.txtAramaSoyad.Name = "txtAramaSoyad";
            this.txtAramaSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtAramaSoyad.TabIndex = 13;
            // 
            // lblSilKoltukNo
            // 
            this.lblSilKoltukNo.AutoSize = true;
            this.lblSilKoltukNo.Location = new System.Drawing.Point(27, 284);
            this.lblSilKoltukNo.Name = "lblSilKoltukNo";
            this.lblSilKoltukNo.Size = new System.Drawing.Size(57, 13);
            this.lblSilKoltukNo.TabIndex = 14;
            this.lblSilKoltukNo.Text = "Koltuk No:";
            // 
            // lblSilAd
            // 
            this.lblSilAd.AutoSize = true;
            this.lblSilAd.Location = new System.Drawing.Point(61, 310);
            this.lblSilAd.Name = "lblSilAd";
            this.lblSilAd.Size = new System.Drawing.Size(23, 13);
            this.lblSilAd.TabIndex = 15;
            this.lblSilAd.Text = "Ad:";
            // 
            // lblSilSoyad
            // 
            this.lblSilSoyad.AutoSize = true;
            this.lblSilSoyad.Location = new System.Drawing.Point(44, 336);
            this.lblSilSoyad.Name = "lblSilSoyad";
            this.lblSilSoyad.Size = new System.Drawing.Size(40, 13);
            this.lblSilSoyad.TabIndex = 16;
            this.lblSilSoyad.Text = "Soyad:";
            // 
            // txtSilKoltukNo
            // 
            this.txtSilKoltukNo.Location = new System.Drawing.Point(98, 281);
            this.txtSilKoltukNo.Name = "txtSilKoltukNo";
            this.txtSilKoltukNo.Size = new System.Drawing.Size(100, 20);
            this.txtSilKoltukNo.TabIndex = 17;
            // 
            // txtSilAd
            // 
            this.txtSilAd.Location = new System.Drawing.Point(98, 307);
            this.txtSilAd.Name = "txtSilAd";
            this.txtSilAd.Size = new System.Drawing.Size(100, 20);
            this.txtSilAd.TabIndex = 18;
            // 
            // txtSilSoyad
            // 
            this.txtSilSoyad.Location = new System.Drawing.Point(98, 333);
            this.txtSilSoyad.Name = "txtSilSoyad";
            this.txtSilSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtSilSoyad.TabIndex = 19;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(109, 360);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 20;
            this.btnSil.Text = "İade Et";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnBosKoltukListele
            // 
            this.btnBosKoltukListele.Location = new System.Drawing.Point(509, 408);
            this.btnBosKoltukListele.Name = "btnBosKoltukListele";
            this.btnBosKoltukListele.Size = new System.Drawing.Size(213, 23);
            this.btnBosKoltukListele.TabIndex = 21;
            this.btnBosKoltukListele.Text = "Boş Koltuklar Listele";
            this.btnBosKoltukListele.UseVisualStyleBackColor = true;
            this.btnBosKoltukListele.Click += new System.EventHandler(this.btnBosKoltukListele_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 460);
            this.Controls.Add(this.btnBosKoltukListele);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.txtSilSoyad);
            this.Controls.Add(this.txtSilAd);
            this.Controls.Add(this.txtSilKoltukNo);
            this.Controls.Add(this.lblSilSoyad);
            this.Controls.Add(this.lblSilAd);
            this.Controls.Add(this.lblSilKoltukNo);
            this.Controls.Add(this.txtAramaSoyad);
            this.Controls.Add(this.txtAramaAd);
            this.Controls.Add(this.lblAramaSoyad);
            this.Controls.Add(this.lblAramaAd);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.btnArama);
            this.Controls.Add(this.txtListele);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.lblKoltukNo);
            this.Controls.Add(this.txtKoltukNo);
            this.Controls.Add(this.btnBiletAl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBiletAl;
        private System.Windows.Forms.TextBox txtKoltukNo;
        private System.Windows.Forms.Label lblKoltukNo;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtListele;
        private System.Windows.Forms.Button btnArama;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Label lblAramaAd;
        private System.Windows.Forms.Label lblAramaSoyad;
        private System.Windows.Forms.TextBox txtAramaAd;
        private System.Windows.Forms.TextBox txtAramaSoyad;
        private System.Windows.Forms.Label lblSilKoltukNo;
        private System.Windows.Forms.Label lblSilAd;
        private System.Windows.Forms.Label lblSilSoyad;
        private System.Windows.Forms.TextBox txtSilKoltukNo;
        private System.Windows.Forms.TextBox txtSilAd;
        private System.Windows.Forms.TextBox txtSilSoyad;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnBosKoltukListele;
    }
}

