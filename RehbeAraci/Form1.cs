/*  Ömer Faruk Görmel, @gormelof
 *  gormelomerfaruk@gmail.com
 *  
 *  Kullanıcı, telefonun rehberini dışa aktarır (Eğer farklı bir program kullanılmıyorsa sistem .vcf uzantılı bir dosya verir).
 *  Telefon USB kablo ile bilgisayara bağlanır.
 *  Bu program ile .vcf uzantılı dosyanın yolu seçilir ve rehber görüntülenir.
 *  Bu program ile görüntülen kişiler üzerinde silme, ekleme, değişiklik ve aynı kayıtları tek indirme işlemleri yapılabilir.
 *  Yapılan değişikliklerden sonra rehber dışa aktarılarak telefona geri yüklenebilir.
 *  
 *  Aşağıda .vcf uzantılı bir dosyada tek bir kişinin nasıl görüntülendiği gösterilmiştir (http://en.wikipedia.org/wiki/VCard).
 *  
 *  Ben bu programda isim (N:) ve telefon (TEL;HOME) özelliklerini kullanıp değişiklikler yapacağım.
 * 
    BEGIN:VCARD
    VERSION:2.1
    N:Gump;Forrest
    FN:Forrest Gump
    ORG:Bubba Gump Shrimp Co.
    TITLE:Shrimp Man
    PHOTO;GIF:http://www.example.com/dir_photos/my_photo.gif
    TEL;WORK;VOICE:(111) 555-1212
    TEL;HOME;VOICE:(404) 555-1212
    ADR;WORK:;;100 Waters Edge;Baytown;LA;30314;United States of America
    LABEL;WORK;ENCODING=QUOTED-PRINTABLE:100 Waters Edge=0D=0ABaytown, LA 30314=0D=0AUnited States of America
    ADR;HOME:;;42 Plantation St.;Baytown;LA;30314;United States of America
    LABEL;HOME;ENCODING=QUOTED-PRINTABLE:42 Plantation St.=0D=0ABaytown, LA 30314=0D=0AUnited States of America
    EMAIL;PREF;INTERNET:forrestgump@example.com
    REV:20080424T195243Z
    END:VCARD
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RehbeAraci
{
    public partial class FormReberAraci : Form
    {
        // Program boyunca kullanılacak değişkenler.
        static string ad = "";
        static string ikinciAd = "";
        static string soyad = "";
        static string cepNo = "";

        // Kisi sınıfını baz alarak oluşturulan liste, rehber bu listede tutulacaktır.
        static List<Kisi> liste_kisi = new List<Kisi>();

        public FormReberAraci()
        {
            InitializeComponent();
        }

        // Gözat butonu
        private void btnGozat_Click(object sender, EventArgs e)
        {
            // Dosya yolunu penceresi açılır. TextBox' a dosya yolu yazılır.
            ofdVCFoku.ShowDialog();
            tbDosyaYolu.Text = ofdVCFoku.FileName.ToString();

            // Belirtilen yolda ki dosta satır satır dosya okunur.
            StreamReader dosyaOku = File.OpenText(tbDosyaYolu.Text);
            string okunanSatir;
            
            okunanSatir = dosyaOku.ReadLine();

            // Dosya sonuna gelene kardar satır satır dosya okunur ve istenilen kısımlar çekilir.
            while (okunanSatir != null)
            {
                // Okunan satırlar ':' karakterine göre parçalanır (Satırın hangi string başladığını öğrenmek için).
                string[] satir = okunanSatir.Split(':'); 
                if (satir[0] == "N") Nparcala(satir[1]); // Satir N ile başlıyorsa istediğimizi alabiliriz -> NParcala()

                if (satir[0] == "TEL;HOME") TELParcala(satir[1]); // Satir TEL;HOME ile başlıyorsa istediğimizi alabiliriz -> TELParcala()

                okunanSatir = dosyaOku.ReadLine();
            }

            dosyaOku.Close(); // Okuma işlemi biter ve dosya kapatılır.

            listeGuncelle(); // Okunan veriler ListBox' a dökülür.
        }

        // Düzenle butonu
        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            // TextBox da ki veriler rehberde (listboxda) seçili olan indeksde ki veri için düzenlenir.
            liste_kisi[lbRehber.SelectedIndex].Ad = tbAd.Text;
            liste_kisi[lbRehber.SelectedIndex].IkıncıAd = tbIkıncıAd.Text;
            liste_kisi[lbRehber.SelectedIndex].Soyad = tbSoyad.Text;
            liste_kisi[lbRehber.SelectedIndex].CepNo = tbCepNo.Text;

            // Düzenleme işleminden sonra rehber (listbox) güncellenir. 
            listeGuncelle();
        }

        // Ekle butonu
        private void btnEkle_Click(object sender, EventArgs e)
        {
            // Textbox da ki veriler okunarak yeni bir kişi oluşturulur.
            Kisi kisi = new Kisi(tbAd.Text, tbIkıncıAd.Text, tbSoyad.Text, tbCepNo.Text);

            // Oluşturulan kişi listeye eklenir.
            liste_kisi.Add(kisi);

            // Ekleme işleminden sonra Listbox (Reber) güncellenir
            listeGuncelle();
        }

        // Sil butonu
        private void btnSil_Click(object sender, EventArgs e)
        {   
            // Rehberden (Listboxdan) seçilen kişinin indeksi alınarak listeden silinir. 
            liste_kisi.RemoveAt(lbRehber.SelectedIndex);

            // Silme işleminden sonra Rehber (Listbox) güncellenir. 
            listeGuncelle();
        }

        // Kayıtları teke indir butonu
        private void btnTekeIndır_Click(object sender, EventArgs e)
        {
            // Aynı olan kayıtlar teke indirilir.
            kayitlariTekIndir();

            // Güncelleme işlemi...
            listeGuncelle();
        }

        // 2. Gözat butonu
        private void btnGozat2_Click(object sender, EventArgs e)
        {
            // Dosya yolunu penceresi açılır. TextBox' a dosya yolu yazılır.
            fbdVCFdisaAktar.ShowDialog();
            tbDisYol.Text = fbdVCFdisaAktar.SelectedPath;
        }

        // Dışa aktar butonu
        private void btnDısaAktar_Click(object sender, EventArgs e)
        {
            // Rehberi dışa aktarmak için yeni bir dosya oluşturulur.
            StreamWriter disaYaz = File.CreateText(@fbdVCFdisaAktar.SelectedPath + "\\guncel_rehber.vcf");
            disaYaz.Close();

            // Yazılacak dosyanın yolu belirtilir.
            disaYaz = new StreamWriter(@fbdVCFdisaAktar.SelectedPath + "\\guncel_rehber.vcf");

            // .vcf formatına uygun şekilde yazma
            for (int i = 0; i < liste_kisi.Count; i++)
            {
                disaYaz.WriteLine("BEGIN:VCARD");
                disaYaz.WriteLine("VERSION: 2.1");
                disaYaz.WriteLine("N:" + liste_kisi[i].Soyad + ";" + liste_kisi[i].Ad + ";" + liste_kisi[i].IkıncıAd + ";");
                disaYaz.WriteLine("FN:" + liste_kisi[i].Ad + " " + liste_kisi[i].IkıncıAd + " " + liste_kisi[i].Soyad);
                disaYaz.WriteLine("TEL;HOME:" + liste_kisi[i].CepNo);
                disaYaz.WriteLine("END:VCARD");
            }
            disaYaz.Close();
        }

        // N ile başlayan satırı parçalar
        static void Nparcala(string Nbaslayan)
        {
            string[] satirN = Nbaslayan.Split(';');
            soyad = satirN[0]; ad = satirN[1]; ikinciAd = satirN[2];

            // NOT: ';' göre parçalı bölmenin bir sırası vardır.
            // VCARD yapısı gereği "N: soyad; ad; ikinciAd; unvan; bisey" şeklindedir.
        }

        // TEL ile başlayan satırı parçalar ve Yeni bir kişi oluşturup listeye atar.
        static void TELParcala(string TELbaslayan)
        {
            cepNo = TELbaslayan;
            liste_kisi.Add(new Kisi(ad, ikinciAd, soyad, cepNo));

            // NOT: VCARD yapısı gereği N ile başlayan satır TEL satırlarından önce gelir.
        }

        // Kayıtları teke indirir.
        void kayitlariTekIndir()
        {
            for ( int i = 0; i < liste_kisi.Count; i++ )
            {
                for( int j = i+1; j < liste_kisi.Count; j++ )
                {
                    if (liste_kisi[i].Ad == liste_kisi[j].Ad && liste_kisi[i].IkıncıAd == liste_kisi[j].IkıncıAd &&
                        liste_kisi[i].Soyad == liste_kisi[j].Soyad && liste_kisi[i].CepNo == liste_kisi[j].CepNo)
                    {
                        liste_kisi.RemoveAt(j);
                    }
                }
            }
        }

        // Rehberi (Listboxu) günceller.
        void listeGuncelle() 
        {
            lbRehber.Items.Clear();

            for (int i = 0; i < liste_kisi.Count; i++)
            {
                lbRehber.Items.Add(liste_kisi[i].Ad + " " + liste_kisi[i].IkıncıAd + " " + liste_kisi[i].Soyad + " " + liste_kisi[i].CepNo);
            }
        }
    }
}