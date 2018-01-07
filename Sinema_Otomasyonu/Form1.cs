using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema_Otomasyonu
{
    public partial class Form1 : Form
    {
        LinkedList koltuk = new LinkedList();
        public Form1()
        {
            InitializeComponent();
           
            for (int i = 0; i < 60; i++)
            {
                Musteri m = new Musteri();
                m.Ad="";
                m.Soyad="";
                m.KoltukNo=i+1;
                koltuk.Insert(m);
            }
        }

        private void btnBiletAl_Click(object sender, EventArgs e)
        {
            Musteri m= new Musteri();
            m.Soyad=txtSoyad.Text;
            m.Ad = txtAd.Text;
            m.KoltukNo= Convert.ToInt32(txtKoltukNo.Text);
            int sayac = 0;

            sayac=koltuk.InsertPos(m.KoltukNo, m);

            if (sayac == 0)
            {
                MessageBox.Show("Bilet alınamadı");
            }
            else
            {
                MessageBox.Show("Bilet başarıyla satıldı");
            }
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtKoltukNo.Text = "";
        }

        private void btnArama_Click(object sender, EventArgs e)
        {
            int koltukNo;
            Musteri m = new Musteri();
            m.Soyad = txtAramaSoyad.Text;
            m.Ad = txtAramaAd.Text;
            if (txtAramaAd.Text == "" && txtAramaSoyad.Text == "")
            {
                MessageBox.Show("Lütfen İsim ve Soyisim Giriniz!!!");

            }
            else
            {
                koltukNo = koltuk.GetElement(m);
                if (koltukNo == 61)
                    txtListele.Text = "Aradıgınız İsim Bulunamadı";
                else
                    txtListele.Text = "Koltuk No:" + koltukNo + Environment.NewLine + "Ad:" + m.Ad + Environment.NewLine + "Soyad:" + m.Soyad;
                txtAramaAd.Text = "";
                txtAramaSoyad.Text = "";
            }
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            string listele = "";
            listele = koltuk.DisplayEmpty();
            if (listele == "")
            {
                listele = "Hiç Bilet Satılmamıştır...";
            }
            txtListele.Text = listele;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int koltukNo;
            koltukNo =Convert.ToInt32(txtSilKoltukNo.Text);
            
            koltuk.DeletePos(koltukNo);
            txtSilAd.Text = "";
            txtSilKoltukNo.Text = "";
            txtSilSoyad.Text = "";
        }

        private void btnBosKoltukListele_Click(object sender, EventArgs e)
        {
            string listele = "";
            listele = koltuk.DisplayElements();
            if (listele == "")
            {
                listele = "Bütün Koltuklar Satılmıştır...";
            }
            txtListele.Text = listele;
        }
    }
}
